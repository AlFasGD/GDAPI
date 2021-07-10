using GDAPI.Enumerations.GeometryDash;
using GDAPI.Information.GeometryDash;
using GDAPI.Objects.GeometryDash.LevelObjects;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Orbs;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Pads;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Portals;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Portals.GamemodePortals;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Portals.SpeedPortals;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.SpecialBlocks;
using GDAPI.Objects.GeometryDash.LevelObjects.Triggers;
using GDAPI.Objects.GeometryDash.LevelObjects.Triggers.ColorTriggers;
using NUnit.Framework;

namespace GDAPI.Tests.Objects.GeometryDash.LevelObjects
{
    public class GeneralObjectTests
    {
        [Test]
        public void NewObjectInstances()
        {
            GeneralObject instance;

            AnalyzeInstance<GeneralObject>(1);

            #region Color Triggers
            AnalyzeInstance<BGColorTrigger>((int)TriggerType.BG);
            AnalyzeInstance<GRNDColorTrigger>((int)TriggerType.GRND);
            AnalyzeInstance<GRND2ColorTrigger>((int)TriggerType.GRND2);
            AnalyzeInstance<LineColorTrigger>((int)TriggerType.Line);
            AnalyzeInstance<LineColorTrigger>((int)TriggerType.Line2);
            AnalyzeInstance<ThreeDLColorTrigger>((int)TriggerType.ThreeDL);
            AnalyzeInstance<ObjColorTrigger>((int)TriggerType.Obj);
            AnalyzeInstance<Color1ColorTrigger>((int)TriggerType.Color1);
            AnalyzeInstance<Color2ColorTrigger>((int)TriggerType.Color2);
            AnalyzeInstance<Color3ColorTrigger>((int)TriggerType.Color3);
            AnalyzeInstance<Color4ColorTrigger>((int)TriggerType.Color4);
            #endregion

            #region Triggers
            AnalyzeInstance<MoveTrigger>((int)TriggerType.Move);
            AnalyzeInstance<PulseTrigger>((int)TriggerType.Pulse);
            AnalyzeInstance<AlphaTrigger>((int)TriggerType.Alpha);
            AnalyzeInstance<ToggleTrigger>((int)TriggerType.Toggle);
            AnalyzeInstance<SpawnTrigger>((int)TriggerType.Spawn);
            AnalyzeInstance<RotateTrigger>((int)TriggerType.Rotate);
            AnalyzeInstance<FollowTrigger>((int)TriggerType.Follow);
            AnalyzeInstance<ShakeTrigger>((int)TriggerType.Shake);
            AnalyzeInstance<AnimateTrigger>((int)TriggerType.Animate);
            AnalyzeInstance<TouchTrigger>((int)TriggerType.Touch);
            AnalyzeInstance<CountTrigger>((int)TriggerType.Count);
            AnalyzeInstance<StopTrigger>((int)TriggerType.Stop);
            AnalyzeInstance<InstantCountTrigger>((int)TriggerType.InstantCount);
            AnalyzeInstance<OnDeathTrigger>((int)TriggerType.OnDeath);
            AnalyzeInstance<FollowPlayerYTrigger>((int)TriggerType.FollowPlayerY);
            AnalyzeInstance<CollisionTrigger>((int)TriggerType.Collision);
            AnalyzeInstance<PickupTrigger>((int)TriggerType.Pickup);
            AnalyzeInstance<RandomTrigger>((int)TriggerType.Random);
            AnalyzeInstance<ZoomTrigger>((int)TriggerType.Zoom);
            AnalyzeInstance<StaticCameraTrigger>((int)TriggerType.StaticCamera);
            AnalyzeInstance<CameraOffsetTrigger>((int)TriggerType.CameraOffset);
            AnalyzeInstance<ReverseTrigger>((int)TriggerType.Reverse);
            AnalyzeInstance<EndTrigger>((int)TriggerType.End);
            AnalyzeInstance<StopJumpTrigger>((int)TriggerType.StopJump);
            AnalyzeInstance<ScaleTrigger>((int)TriggerType.Scale);
            AnalyzeInstance<SongTrigger>((int)TriggerType.Song);
            AnalyzeInstance<TimeWarpTrigger>((int)TriggerType.TimeWarp);
            #endregion

            #region Speed Portals
            AnalyzeInstance<SlowSpeedPortal>((int)PortalType.SlowSpeed);
            AnalyzeInstance<NormalSpeedPortal>((int)PortalType.NormalSpeed);
            AnalyzeInstance<FastSpeedPortal>((int)PortalType.FastSpeed);
            AnalyzeInstance<FasterSpeedPortal>((int)PortalType.FasterSpeed);
            AnalyzeInstance<FastestSpeedPortal>((int)PortalType.FastestSpeed);
            #endregion

            #region Gamemode Portals
            AnalyzeInstance<CubePortal>((int)PortalType.Cube);
            AnalyzeInstance<ShipPortal>((int)PortalType.Ship);
            AnalyzeInstance<BallPortal>((int)PortalType.Ball);
            AnalyzeInstance<UFOPortal>((int)PortalType.UFO);
            AnalyzeInstance<WavePortal>((int)PortalType.Wave);
            AnalyzeInstance<RobotPortal>((int)PortalType.Robot);
            AnalyzeInstance<SpiderPortal>((int)PortalType.Spider);
            #endregion

            #region Other Portals
            AnalyzeInstance<GreenSizePortal>((int)PortalType.GreenSize);
            AnalyzeInstance<MagentaSizePortal>((int)PortalType.MagentaSize);
            AnalyzeInstance<BlueMirrorPortal>((int)PortalType.BlueMirror);
            AnalyzeInstance<YellowMirrorPortal>((int)PortalType.YellowMirror);
            AnalyzeInstance<BlueTeleportationPortal>((int)PortalType.BlueTeleportation);
            // Yellow teleportation portal is not meant to be initialized standalone, therefore instantiation must not be tested
            AnalyzeInstance<BlueGravityPortal>((int)PortalType.BlueGravity);
            AnalyzeInstance<YellowGravityPortal>((int)PortalType.YellowGravity);
            AnalyzeInstance<BlueDualPortal>((int)PortalType.BlueDual);
            AnalyzeInstance<YellowDualPortal>((int)PortalType.YellowDual);
            #endregion

            #region Orbs
            AnalyzeInstance<YellowOrb>((int)OrbType.YellowOrb);
            AnalyzeInstance<MagentaOrb>((int)OrbType.MagentaOrb);
            AnalyzeInstance<BlueOrb>((int)OrbType.BlueOrb);
            AnalyzeInstance<GreenOrb>((int)OrbType.GreenOrb);
            AnalyzeInstance<BlackOrb>((int)OrbType.BlackOrb);
            AnalyzeInstance<RedOrb>((int)OrbType.RedOrb);
            AnalyzeInstance<GreenDashOrb>((int)OrbType.GreenDashOrb);
            AnalyzeInstance<MagentaDashOrb>((int)OrbType.MagentaDashOrb);
            AnalyzeInstance<TriggerOrb>((int)OrbType.TriggerOrb);
            #endregion

            #region Pads
            AnalyzeInstance<YellowPad>((int)PadType.YellowPad);
            AnalyzeInstance<MagentaPad>((int)PadType.MagentaPad);
            AnalyzeInstance<BluePad>((int)PadType.BluePad);
            AnalyzeInstance<RedPad>((int)PadType.RedPad);
            #endregion

            #region Special Blocks
            AnalyzeInstance<DSpecialBlock>((int)SpecialBlockType.D);
            AnalyzeInstance<JSpecialBlock>((int)SpecialBlockType.J);
            AnalyzeInstance<SSpecialBlock>((int)SpecialBlockType.S);
            AnalyzeInstance<HSpecialBlock>((int)SpecialBlockType.H);
            #endregion

            #region Other Special Objects
            AnalyzeInstance<CollisionBlock>((int)SpecialObjectType.CollisionBlock);
            AnalyzeInstance<CountTextObject>((int)SpecialObjectType.CountTextObject);
            AnalyzeInstance<CustomParticleObject>((int)SpecialObjectType.CustomParticleObject);
            AnalyzeInstance<TextObject>((int)SpecialObjectType.TextObject);

            AnalyzeInstances<AnimatedObject>(ObjectLists.AnimatedObjectList);
            AnalyzeInstances<PulsatingObject>(ObjectLists.PulsatingObjectList);
            AnalyzeInstances<RotatingObject>(ObjectLists.RotatingObjectList);
            AnalyzeInstances<PickupItem>(ObjectLists.PickupItemList);
            #endregion

            void AnalyzeInstance<T>(int ID)
            {
                instance = LevelObjectFactory.GetNewObjectInstance(ID);
                Assert.AreEqual(typeof(T), instance.GetType());
            }
            void AnalyzeInstances<T>(int[] objectList)
            {
                foreach (var ID in objectList)
                {
                    instance = LevelObjectFactory.GetNewObjectInstance(ID);
                    Assert.AreEqual(typeof(T), instance.GetType());
                }
            }
        }
    }
}