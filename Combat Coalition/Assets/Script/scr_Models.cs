using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class scr_Models
{
    public static Vector3 GravityVec = new Vector3(0, -9.81f, 0);
    #region - Player -

    public static float ArmourHeath = 50f;

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
        [Header("Head Bob")]
        public float WalkBobSpeed = 14;
        public float WalkBobAmount = 0.5f;
        public float SprintBobSpeed = 18;
        public float SprintBobAmount = 1f;
        public float CrouchBobSpeed = 8;
        public float CrouchBobAmount = 0.25f;
        public float ProneBobSpeed = 6;
        public float ProneBobAmount = 0.125f;
    }
    [Serializable]
    public class CharacterStance
    {
        public float CameraHeight;
        public float ForwardPos;
        public CapsuleCollider StanceCollider;
    }
    #endregion

    #region - Weapon -

    public enum WeaponFireType
    {
        SemiAuto,
        FullyAuto
    }
    public enum WeaponType
    {
        Gun,
        Melee
    }
    [Serializable]
    public class WeaponSettingsModel
    {
        public float WeaponSearchRaduis;
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
        [Header("Weapon Retract")]
        public Vector3 RetractAngle;
        public float RetractSmoothing;
    }

    #endregion

    #region - Gun - 
    [Serializable]
    public class AttachmentsPoints
    {
        public AttachmentTypes AttachmentType;
        public Transform Point;
    }
    public class AttachedWeaponPart
    {
        public AttachmentsPoints AttachmentTypePoint;
        public scr_Attachment_SO weaponPartSO;
        public Transform spawnedTransform;
    }
    public enum AttachmentTypes
    {
        Barrel,
        Grip,
        Magzine,
        Muzzle,
        Sight,
        Stock,
        UnderBarrel,
    }
    #endregion
    #region - Bullet -
    public struct BulletWithTarget
    {
        public scr_Bullet scr_Bullet;
        public Vector3 BulletTarget;
    }
    //Integration method 3
    //upVec is a vector perpendicular (in the upwards direction) to the direction the bullet is travelling in
    //is only needed if we calculate the lift force
    public static void Heuns(float timeStep, Vector3 currentPos, Vector3 currentVel, Vector3 upVec, scr_GunSO bulletData, out Vector3 newPos, out Vector3 newVel)
    {
        //Add all factors that affects the acceleration
        //Gravity
        Vector3 accFactorEuler = GravityVec;
        //Drag
        accFactorEuler += CalculateBulletDragAcc(currentVel, bulletData);
        //Lift  
        accFactorEuler += CalculateBulletLiftAcc(currentVel, bulletData, upVec);


        //Calculate the new velocity and position
        //y_k+1 = y_k + timeStep * 0.5 * (f(t_k, y_k) + f(t_k+1, y_k+1))
        //Where f(t_k+1, y_k+1) is calculated with Forward Euler: y_k+1 = y_k + timeStep * f(t_k, y_k)

        //Step 1. Find new pos and new vel with Forward Euler
        Vector3 newVelEuler = currentVel + timeStep * accFactorEuler;

        //New position with Forward Euler (is not needed here)
        //Vector3 newPosEuler = currentPos + timeStep * currentVel;


        //Step 2. Heuns method's final step
        //If we take drag into account, then acceleration is not constant - it also depends on the velocity
        //So we have to calculate another acceleration factor
        //Gravity
        Vector3 accFactorHeuns = GravityVec;
        //Drag
        //This assumes that windspeed is constant between the steps, which it should be because wind doesnt change that often
        accFactorHeuns += CalculateBulletDragAcc(newVelEuler, bulletData);
        //Lift 
        accFactorHeuns += CalculateBulletLiftAcc(newVelEuler, bulletData, upVec);

        newVel = currentVel + timeStep * 0.5f * (accFactorEuler + accFactorHeuns);

        newPos = currentPos + timeStep * 0.5f * (currentVel + newVelEuler);
    }

    //Calculate the bullet's drag acceleration
    public static Vector3 CalculateBulletDragAcc(Vector3 bulletVel, scr_GunSO bulletData)
    { 
        //If you have a wind speed in your game, you can take that into account here:
        //https://www.youtube.com/watch?v=lGg7wNf1w-k
        Vector3 bulletVelRelativeToWindVel = bulletVel - bulletData.windSpeedVector;

        //Step 1. Calculate the bullet's drag force [N]
        //https://en.wikipedia.org/wiki/Drag_equation
        //F_drag = 0.5 * rho * v^2 * C_d * A 

        //The velocity of the bullet [m/s]
        float v = bulletVelRelativeToWindVel.magnitude;
        //The bullet's cross section area [m^2]
        float A = Mathf.PI * bulletData.r * bulletData.r;

        float dragForce = 0.5f * bulletData.rho * v * v * bulletData.DragCoefficient * A;


        //Step 2. We need to add an acceleration, not a force, in the integration method [m/s^2]
        //Drag acceleration F = m * a -> a = F / m
        float dragAcc = dragForce / bulletData.m;

        //SHould be in a direction opposite of the bullet's velocity vector
        Vector3 dragVec = dragAcc * bulletVelRelativeToWindVel.normalized * -1f;


        return dragVec;
    }
    //Calculate the bullet's lift acceleration
    public static Vector3 CalculateBulletLiftAcc(Vector3 bulletVel, scr_GunSO bulletData, Vector3 bulletUpDir)
    {
        //If you have a wind speed in your game, you can take that into account here:
        //https://www.youtube.com/watch?v=lGg7wNf1w-k
        Vector3 bulletVelRelativeToWindVel = bulletVel - bulletData.windSpeedVector;

        //Step 1. Calculate the bullet's lift force [N]
        //https://en.wikipedia.org/wiki/Lift_(force)
        //F_lift = 0.5 * rho * v^2 * S * C_l 

        //The velocity of the bullet [m/s]
        float v = bulletVelRelativeToWindVel.magnitude;
        //Planform (projected) wing area, which is assumed to be the same as the cross section area [m^2]
        float S = Mathf.PI * bulletData.r * bulletData.r;

        float liftForce = 0.5f * bulletData.rho * v * v * S * bulletData.LiftCoefficient;

        //Step 2. We need to add an acceleration, not a force, in the integration method [m/s^2]
        //Drag acceleration F = m * a -> a = F / m
        float liftAcc = liftForce / bulletData.m;

        //The lift force acts in the up-direction = perpendicular to the velocity direction it travels in
        Vector3 liftVec = liftAcc * bulletUpDir;


        return liftVec;
    }
    #endregion
}


