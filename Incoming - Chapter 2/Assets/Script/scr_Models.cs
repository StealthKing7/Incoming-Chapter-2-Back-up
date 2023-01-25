using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class scr_Models
{
    #region - Player -

    public enum PlayerStance
    {
        Stand,
        Crouch,
        Prone
    }
     
    [Serializable]
    public class PlayerSettingModel
    {
        [Header("View Settings")]
        public  float ViewXSencitivity;
        public float ViewYSencitivity;
        public float AimSensitivityEffector;
        public bool ViewXInverted;
        public bool ViewYInverted;
        [Header("Movement - Running")]
        public float RunningForwardSpeed; 
        public float RunningStrafeSpeed; 
        [Header("Movement - Settings")]
        public bool SprintHold;
        public float MovementSmoothing;
        [Header("Movement - Walking")]
        public float WalkingForwardSpeed;
        public float WalkingBackwardSpeed;
        public float WalkingStrafeSpeed;

        [Header("Jump Settings")]
        public float JumpingHeight;
        public float JumpingFallof;
        public float FallingSmoothing;
        [Header("Speed Effectors")]
        public float SpeedEffector = 1f;
        public float CrouchSpeedEffector;
        public float ProneSpeedEffector;
        public float FallingSpeedEffector;
        public float AimSpeedEffector;
        [Header("Is Grounded/Falling")]
        public float IsGroundedRadius;
        public float IsFallingSpeed;

    }
    [Serializable]
    public class CharacterStance
    {
        public float CameraHeight;
        public CapsuleCollider StanceCollider;
    }

    #endregion


    #region - Weapon -

    public enum WeaponFireType
    {
        SemiAuto,
        FullyAuto
    }

    [Serializable]
    public class WeaponSettingsModel
    {
        [Header("Weapon Sway")]
        public float SwayAmount;
        public bool SwayYInverted; 
        public bool SwayXInverted; 
        public float SwaySmoothing;
        public float SwayResetSmoothing;
        public float SwayClampX;
        public float SwayClampY;
        [Header("Weapon Movement Sway")]
        public float MovementSwayX;
        public float MovementSwayY;
        public bool MovementSwayYInverted;
        public bool MovementSwayXInverted;
        public float MovementSwaySmoothing;
    }

    #endregion

    #region - Enemy -
    public enum EState
    {
        Idle,
        Patrol,
        AlertAudio,
        AlertVisual
    }
    [Serializable]
    public class EnemySettings
    {
        public float IldeMinTime = 5f;
        public float IldeMaxTime = 10f;
        public float PatrollingReachedThreshHold = 0.5f;
        public float Speed;
    }
    #endregion
}


