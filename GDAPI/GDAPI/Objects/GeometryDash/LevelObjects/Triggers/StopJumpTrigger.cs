using GDAPI.Attributes;
using GDAPI.Enumerations.GeometryDash;

namespace GDAPI.Objects.GeometryDash.LevelObjects.Triggers
{
    /// <summary>Represents a Stop Jump trigger.</summary>
    [FutureProofing("2.2")]
    [ObjectID(TriggerType.StopJump)]
    public class StopJumpTrigger : Trigger
    {
        /// <summary>The Object ID of the trigger.</summary>
        [ObjectStringMappable(ObjectProperty.ObjectID)]
        public override int ObjectID => (int)TriggerType.StopJump;

        /// <summary>Initializes a new instance of the <seealso cref="StopJumpTrigger"/> class.</summary>
        public StopJumpTrigger() : base() { }

        /// <summary>Returns a clone of this <seealso cref="StopJumpTrigger"/>.</summary>
        public override GeneralObject Clone() => AddClonedInstanceInformation(new StopJumpTrigger());
    }
}
