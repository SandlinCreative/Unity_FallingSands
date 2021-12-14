using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace Assets.Scripts.Cellular.Elements
{
    public abstract class Element
    {
        private static readonly int REACTION_FRAME = 3;
        public static readonly int EFFECTS_FRAME = 1;
        public int pixelX;
        public int pixelY;

        private int matrixX;
        private int matrixY;
        public Vector3 vel;

        public List<Vector2> secondaryMatrixCoords = new List<Vector2>();

        public float frictionFactor;
        public bool isFreeFalling = true;
        public float inertialResistance;
        public int stoppedMovingCount = 0;
        public int stoppedMovingThreshold = 1;
        public int mass;
        public int health = 500;
        public int flammabilityResistance = 100;
        public int resetFlammabilityResistance => flammabilityResistance / 2;
        public bool isIgnited;
        public int heatFactor = 10;
        public int fireDamage = 3;
        public bool heated = false;
        public int temperature = 0;
        public int coolingFactor = 5;
        public int lifeSpan = 0;
        public ElementType elementType;
        //public PhysicsElementActor owningBody = null;
        public Vector2 owningBodyCoords = Vector2.zero;
        public int explosionResistance = 1;
        public int explosionRadius = 0;
        public bool discolored = false;

        public float xThreshold = 0;
        public float yThreshold = 0;

        public bool isDead = false;

        public Color color;

        public BitArray stepped = new BitArray(1);
    }
}
