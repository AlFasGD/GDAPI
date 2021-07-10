using GDAPI.Attributes;

namespace GDAPI.Enumerations.GeometryDash
{
    /// <summary>This enumeration provides the Object ID values for the triggers.</summary>
    public enum TriggerType : short
    {
        /// <summary>Represents the Object ID value of the BG Color trigger.</summary>
        BG = 29,
        /// <summary>Represents the Object ID value of the GRND Color trigger.</summary>
        GRND = 30,
        /// <summary>Represents the Object ID value of the Start Pos trigger.</summary>
        StartPos = 31,
        /// <summary>Represents the Object ID value of the Enable Trail trigger.</summary>
        EnableTrail = 32,
        /// <summary>Represents the Object ID value of the DisableTrail trigger.</summary>
        DisableTrail = 33,
        /// <summary>Represents the Object ID value of the Line Color trigger.</summary>
        Line = 104,
        /// <summary>Represents the Object ID value of the Obj Color trigger.</summary>
        Obj = 105,
        /// <summary>Represents the Object ID value of the Color 1 trigger.</summary>
        Color1 = 221,
        /// <summary>Represents the Object ID value of the Color 2 trigger.</summary>
        Color2 = 717,
        /// <summary>Represents the Object ID value of the Color 3 trigger.</summary>
        Color3 = 718,
        /// <summary>Represents the Object ID value of the Color 4 trigger.</summary>
        Color4 = 743,
        /// <summary>Represents the Object ID value of the 3DL Color trigger.</summary>
        ThreeDL = 744,
        /// <summary>Represents the Object ID value of the Color trigger.</summary>
        Color = 899,
        /// <summary>Represents the Object ID value of the GRND Color trigger.</summary>
        GRND2 = 900,
        /// <summary>Represents the Object ID value of the Move trigger.</summary>
        Move = 901,
        /// <summary>Represents the Object ID value of the Line Color trigger (again, but this time with ID 915).</summary>
        Line2 = 915,
        /// <summary>Represents the Object ID value of the Pulse trigger.</summary>
        Pulse = 1006,
        /// <summary>Represents the Object ID value of the Alpha trigger.</summary>
        Alpha = 1007,
        /// <summary>Represents the Object ID value of the Toggle trigger.</summary>
        Toggle = 1049,
        /// <summary>Represents the Object ID value of the Spawn trigger.</summary>
        Spawn = 1268,
        /// <summary>Represents the Object ID value of the Rotate trigger.</summary>
        Rotate = 1346,
        /// <summary>Represents the Object ID value of the Follow trigger.</summary>
        Follow = 1347,
        /// <summary>Represents the Object ID value of the Shake trigger.</summary>
        Shake = 1520,
        /// <summary>Represents the Object ID value of the Animate trigger.</summary>
        Animate = 1585,
        /// <summary>Represents the Object ID value of the Touch trigger.</summary>
        Touch = 1595,
        /// <summary>Represents the Object ID value of the Count trigger.</summary>
        Count = 1611,
        /// <summary>Represents the Object ID value of the Hide Player trigger.</summary>
        HidePlayer = 1612,
        /// <summary>Represents the Object ID value of the Show Player trigger.</summary>
        ShowPlayer = 1613,
        /// <summary>Represents the Object ID value of the Stop trigger.</summary>
        Stop = 1616,
        /// <summary>Represents the Object ID value of the Instant Count trigger.</summary>
        InstantCount = 1811,
        /// <summary>Represents the Object ID value of the On Death trigger.</summary>
        OnDeath = 1812,
        /// <summary>Represents the Object ID value of the Follow Player Y trigger.</summary>
        FollowPlayerY = 1814,
        /// <summary>Represents the Object ID value of the Collision trigger.</summary>
        Collision = 1815,
        /// <summary>Represents the Object ID value of the Pickup trigger.</summary>
        Pickup = 1817,
        /// <summary>Represents the Object ID value of the BG Effect On trigger.</summary>
        BGEffectOn = 1818,
        /// <summary>Represents the Object ID value of the BG Effect Off trigger.</summary>
        BGEffectOff = 1819,

        /// <summary>Represents the Object ID value of the Random trigger (as found in Subzero; considering the latest sneak peeks the ID might have changed since it has been probably replaced with the new advanced Random trigger).</summary>
        [FutureProofing("2.2")]
        Random = 1912,
        /// <summary>Represents the Object ID value of the Zoom trigger.</summary>
        [FutureProofing("2.2")]
        Zoom = 1913,
        /// <summary>Represents the Object ID value of the Static Camera trigger.</summary>
        [FutureProofing("2.2")]
        StaticCamera = 1914,
        /// <summary>Represents the Object ID value of the Camera Offset trigger.</summary>
        [FutureProofing("2.2")]
        CameraOffset = 1916,
        /// <summary>Represents the Object ID value of the Reverse trigger.</summary>
        [FutureProofing("2.2")]
        Reverse = 1917,
        /// <summary>Represents the Object ID value of the End trigger.</summary>
        [FutureProofing("2.2")]
        End = 1931,
        /// <summary>Represents the Object ID value of the Stop Jump trigger.</summary>
        [FutureProofing("2.2")]
        StopJump = 1932,
        /// <summary>Represents the Object ID value of the Scale trigger. (Reserved for future use)</summary>
        [FutureProofing("2.2")]
        Scale = -11,
        /// <summary>Represents the Object ID value of the Song trigger. (Reserved for future use)</summary>
        [FutureProofing("2.2")]
        Song = -12,
        /// <summary>Represents the Object ID value of the TimeWarp trigger. (Reserved for future use)</summary>
        [FutureProofing("2.2")]
        TimeWarp = -13,
    }
}
