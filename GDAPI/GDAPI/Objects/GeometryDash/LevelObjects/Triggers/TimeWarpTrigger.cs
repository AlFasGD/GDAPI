using GDAPI.Attributes;
using GDAPI.Enumerations.GeometryDash;

namespace GDAPI.Objects.GeometryDash.LevelObjects.Triggers
{
    /// <summary>Represents a TimeWarp trigger.</summary>
    [FutureProofing("2.2")]
    [ObjectID(TriggerType.TimeWarp)]
    public class TimeWarpTrigger : Trigger
    {
        /// <summary>The Object ID of the trigger.</summary>
        [ObjectStringMappable(ObjectProperty.ObjectID)]
        public override int ObjectID => (int)TriggerType.TimeWarp;

        /// <summary>Initializes a new instance of the <seealso cref="TimeWarpTrigger"/> class.</summary>
        public TimeWarpTrigger() : base() { }

        /// <summary>Returns a clone of this <seealso cref="TimeWarpTrigger"/>.</summary>
        public override GeneralObject Clone() => AddClonedInstanceInformation(new TimeWarpTrigger());
    }
}
