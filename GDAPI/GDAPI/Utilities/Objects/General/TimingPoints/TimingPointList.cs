﻿using GDAPI.Utilities.Functions.Extensions;
using GDAPI.Utilities.Objects.General.DataStructures;
using GDAPI.Utilities.Objects.General.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDAPI.Utilities.Objects.General.TimingPoints
{
    /// <summary>Contains a list of <seealso cref="TimingPoint"/>s.</summary>
    public class TimingPointList
    {
        private SortedList<TimingPoint> timingPoints;

        /// <summary>Creates a new empty instance of the <seealso cref="TimingPointList"/> class.</summary>
        public TimingPointList() { }
        /// <summary>Creates a new instance of the <seealso cref="TimingPointList"/> class.</summary>
        /// <param name="presetTimingPoints">The list of timing points that are contained.</param>
        public TimingPointList(List<TimingPoint> presetTimingPoints)
        {
            timingPoints = ConvertToSortedList(presetTimingPoints);
        }
        /// <summary>Creates a new instance of the <seealso cref="TimingPointList"/> class.</summary>
        /// <param name="presetTimingPoints">The list of timing points that are contained.</param>
        public TimingPointList(SortedList<TimingPoint> presetTimingPoints)
        {
            timingPoints = new SortedList<TimingPoint>(presetTimingPoints);
        }

        /// <summary>Adds a <seealso cref="TimingPoint"/> to the list.</summary>
        /// <param name="timingPoint">The <seealso cref="TimingPoint"/> to add to the list.</param>
        public void Add(TimingPoint timingPoint) => RecalculateTimePositions(timingPoints.Insert(timingPoint) + 1);
        /// <summary>Adds a collection of <seealso cref="TimingPoint"/>s to the list.</summary>
        /// <param name="points">The <seealso cref="TimingPoint"/>s to add to the list.</param>
        public void AddRange(IEnumerable<TimingPoint> points)
        {
            if (!points.Any())
                return;

            int minIndex = int.MaxValue;
            foreach (var p in points)
            {
                int index = timingPoints.Insert(p) + 1;
                if (index < minIndex)
                    minIndex = index;
            }
            RecalculateTimePositions(minIndex);
        }
        /// <summary>Removes a <seealso cref="TimingPoint"/> from the list.</summary>
        /// <param name="timingPoint">The <seealso cref="TimingPoint"/> to remove from the list.</param>
        public void Remove(TimingPoint timingPoint)
        {
            if (timingPoints.RemoveIfNotAtIndex(timingPoint, 0, out int index))
                RecalculateTimePositions(index);
        }

        /// <summary>Clones this instance and returns the new instance.</summary>
        public TimingPointList Clone() => new TimingPointList(timingPoints);

        private void RecalculateTimePositions(int firstIndex)
        {
            for (int i = firstIndex; i < timingPoints.Count; i++)
                timingPoints[i].CalculateTimePosition(timingPoints[i - 1]);
        }

        /// <summary>Gets the string representation of this <seealso cref="TimingPointList"/>.</summary>
        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var p in timingPoints)
                result.AppendLine(p.ToString()).AppendLine();

            return result.RemoveLastIfEndsWith('\n').ToString();
        }

        private static SortedList<TimingPoint> ConvertToSortedList(List<TimingPoint> presetTimingPoints)
        {
            var timingPoints = new SortedList<TimingPoint>(presetTimingPoints.Count, CompareTimingPoints);

            var absoluteTimingPoints = Convert<TimingPoint, AbsoluteTimingPoint>(presetTimingPoints);

            if (absoluteTimingPoints.Count == 0)
                throw new InvalidOperationException("No absolute timing points were used");
            absoluteTimingPoints[0].SetAsInitialTimingPoint();

            var relativeTimingPoints = Convert<TimingPoint, RelativeTimingPoint>(presetTimingPoints);
            relativeTimingPoints.Sort((a, b) => MeasuredTimePosition.CompareByAbsolutePosition(a.TimePosition, b.TimePosition));

            // Add absolute timing points and calculate their relative time positions
            AbsoluteTimingPoint previousAbsolute = null;
            foreach (var a in absoluteTimingPoints)
            {
                if (previousAbsolute != null)
                    a.CalculateRelativeTimePosition(previousAbsolute);
                timingPoints.Add(previousAbsolute = a);
            }

            // Add relative timing points, calculate their absolute time positions and adjust the absolute timing points' relative time positions
            foreach (var r in relativeTimingPoints)
            {
                int index = timingPoints.IndexBefore(r);
                r.CalculateAbsoluteTimePosition(timingPoints[index]);
                if (index + 1 < timingPoints.Count)
                {
                    // The next timing point is certainly an absolute timing point since no relative timing points have been added beyond that one yet
                    var nextAbsolute = timingPoints[index + 1] as AbsoluteTimingPoint;

                    // Calculate the measure adjustment for the first absolute timing point to apply it to all the rest
                    int currentMeasure = nextAbsolute.RelativeTimePosition.Measure;
                    nextAbsolute.CalculateRelativeTimePosition(r);
                    int newMeasure = nextAbsolute.RelativeTimePosition.Measure;
                    int measureAdjustment = newMeasure - currentMeasure;

                    if (measureAdjustment != 0)
                        for (int i = index + 2; i < timingPoints.Count; i++)
                            (timingPoints[i] as AbsoluteTimingPoint).AdjustMeasure(measureAdjustment);
                }
                timingPoints.Add(r);
            }

            return timingPoints;
        }

        private static List<TConverted> Convert<TBase, TConverted>(List<TBase> list)
            where TConverted : class
        {
            var result = list.ConvertAll(p => p as TConverted);
            result.RemoveAll(p => p is null);
            return result;
        }

        private static int CompareTimingPoints(TimingPoint left, TimingPoint right) => left.GetRelativeTimePosition().CompareTo(right.GetRelativeTimePosition());
    }
}
