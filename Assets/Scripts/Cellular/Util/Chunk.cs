using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assets.Scripts.Cellular.Boids;
using UnityEngine;

namespace Assets.Scripts.Cellular.Util
{
    public class Chunk
    {
        public static int size = 32;

        private bool shouldStep = true;
        private bool shouldStepNextFrame = true;
        private Vector3 topLeft;
        private Vector3 bottomRight;
        private ConcurrentDictionary<Boid, String> boidMap = new ConcurrentDictionary<Boid, String>();

        public Chunk(Vector3 topLeft, Vector3 bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }
    }
}
