﻿using System.Collections.Generic;
using System.ComponentModel;
using VRageMath;
using static Scripts.Structure;
using static Scripts.Structure.PartDefinition.AmmoDef;
using static Scripts.Structure.PartDefinition.AnimationDef.RelMove;
using static Scripts.Structure.PartDefinition.AnimationDef.PartAnimationSetDef;
using static Scripts.Structure.PartDefinition.AnimationDef;
using static Scripts.Structure.PartDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static Scripts.Structure.ArmorDefinition.ArmorType;

namespace Scripts
{
    partial class Parts
    {
        internal ContainerDefinition Container = new ContainerDefinition();
        internal void PartFiles(params PartDefinition[] defs)
        {
            Container.PartDefs = defs;
        }

        internal void ArmorFiles(params ArmorDefinition[] defs)
        {
            Container.ArmorDefs = defs;
        }

        internal static void GetBaseDefinitions(out ContainerDefinition baseDefs)
        {
            baseDefs = new Parts().Container;
        }


        internal Randomize Random(float start, float end)
        {
            return new Randomize { Start = start, End = end };
        }

        internal Vector4 Color(float red, float green, float blue, float alpha)
        {
            return new Vector4(red, green, blue, alpha);
        }

        internal Vector3D Vector(double x, double y, double z)
        {
            return new Vector3D(x, y, z);
        }

        internal XYZ Transformation(double X, double Y, double Z)
        {
            return new XYZ { x = X, y = Y, z = Z };
        }

        internal Dictionary<EventTriggers, uint> Delays(uint firingDelay = 0, uint reloadingDelay = 0, uint overheatedDelay = 0, uint trackingDelay = 0, uint lockedDelay = 0, uint onDelay = 0, uint offDelay = 0, uint burstReloadDelay = 0, uint outOfAmmoDelay = 0, uint preFireDelay = 0, uint stopFiringDelay = 0, uint stopTrackingDelay = 0)
        {
            return new Dictionary<EventTriggers, uint>
            {
                [Firing] = firingDelay,
                [Reloading] = reloadingDelay,
                [Overheated] = overheatedDelay,
                [Tracking] = trackingDelay,
                [TurnOn] = onDelay,
                [TurnOff] = offDelay,
                [BurstReload] = burstReloadDelay,
                [NoMagsToLoad] = outOfAmmoDelay,
                [PreFire] = preFireDelay,
                [EmptyOnGameLoad] = 0,
                [StopFiring] = stopFiringDelay,
                [StopTracking] = stopTrackingDelay,
                [LockDelay] = lockedDelay,
            };
        }

        internal PartEmissive Emissive(string emissiveName, bool cycleEmissiveParts, bool leavePreviousOn, Vector4[] colors, float intensityFrom, float intensityTo, string[] emissivePartNames)
        {
            return new PartEmissive
            {
                EmissiveName = emissiveName,
                Colors = colors,
                CycleEmissivesParts = cycleEmissiveParts,
                LeavePreviousOn = leavePreviousOn,
                EmissivePartNames = emissivePartNames,
                IntensityRange = new[]{ intensityFrom, intensityTo }
            };
        }

        internal EventTriggers[] Events(params EventTriggers[] events)
        {
            return events;
        }

        internal string[] Names(params string[] names)
        {
            return names;
        }

        internal string[] AmmoRounds(params string[] names)
        {
            return names;
        }
    }
}
