using System.Runtime.InteropServices;
using VehicleGarage.DBCStores;

namespace VehicleGarage.DBCStructures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VehicleEntry
    {
        public uint ID;
        public uint Flags;
        public float UnkName;
        public float TurnSpeed;
        public float PitchSpeed;
        public float PitchMin;
        public float PitchMax;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Constants.MaxVehicleSeats)]
        public uint[] SeatId;
        public float MouseLookOffsetPitch;
        public float CameraFadeDistScalarMin;
        public float CameraFadeDistScalarMax;
        public float CameraPitchOffset;
        public float FacingLimitRight;
        public float FacingLimitLeft;
        public float MissileTargetTurnLingering;
        public float MissileTargetPitchLingering;
        public float MissileTargetMouseLingering;
        public float MissileTargetEndOpacity;
        public float MissileTargetArcSpeed;
        public float MissileTargetArcRepeat;
        public float MissileTargetArcWidth;
        public float MissileTargetImpactRadius_1;
        public float MissileTargetImpactRadius_2;
        private readonly uint MissileTargetArcTexture;
        private readonly uint MissileTargetImpactTexture;
        private readonly uint MissileTargetImpactModel_1;
        private readonly uint MissileTargetImpactModel_2;
        public float CameraYawOffset;
        public int UILocomotionType;
        public float MissileTargetImpactTexRadius;
        public int UISeatIndicatorType;
        public int PowerType;
        public int Unk1;        // New in 3.1 - Either -1 or 0 (most common) - PowerType[1]?
        public int Unk2;        // New in 3.1 - Always 0 - PowerType[2]?

        public string MissleTargetArcTexture
        {
            get { return DBC.VehicleStrings[MissileTargetArcTexture]; }
        }

        public string MissleTargetImpactTexture
        {
            get { return DBC.VehicleStrings[MissileTargetArcTexture]; }
        }

        public string MissleTargetImpactModel1
        {
            get { return DBC.VehicleStrings[MissileTargetImpactModel_1]; }
        }

        public string MissleTargetImpactModel2
        {
            get { return DBC.VehicleStrings[MissileTargetImpactModel_2]; }
        }

    }
}
