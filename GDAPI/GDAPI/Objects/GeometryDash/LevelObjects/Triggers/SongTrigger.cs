using GDAPI.Attributes;
using GDAPI.Enumerations.GeometryDash;

namespace GDAPI.Objects.GeometryDash.LevelObjects.Triggers
{
    /// <summary>Represents a Song trigger.</summary>
    [FutureProofing("2.2")]
    [ObjectID(TriggerType.Song)]
    public class SongTrigger : Trigger
    {
        /// <summary>The Object ID of the trigger.</summary>
        [ObjectStringMappable(ObjectProperty.ObjectID)]
        public override int ObjectID => (int)TriggerType.Song;

        /// <summary>Initializes a new instance of the <seealso cref="SongTrigger"/> class.</summary>
        public SongTrigger() : base() { }

        /// <summary>Returns a clone of this <seealso cref="SongTrigger"/>.</summary>
        public override GeneralObject Clone() => AddClonedInstanceInformation(new SongTrigger());
    }
}
