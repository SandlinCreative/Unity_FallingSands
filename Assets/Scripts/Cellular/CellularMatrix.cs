using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assets.Scripts.Cellular.Elements;
using Assets.Scripts.Cellular.Util;
using Assets.Scripts.Cellular.Spouts;

namespace Assets.Scripts.Cellular
{
    public class CellularMatrix
    {
        public int innerArraySize;
        public int outerArraySize;
        public int pixelSizeModifier;
        private readonly List<int> shuffledXIndexes;
        public bool useChunks = true;
        public int drawThreadCount = 6;
        private List<List<int>> shuffledXIndexesForThreads;
        private List<List<int>> shuffledYIndexesForThreads;
        private int threadedIndexOffset = 0;

        private Element[,] matrix;

        private readonly Chunk[,] chunks;

        public Spout[] spoutArray;

        //public Array<PhysicsElementActor> physicsElementActors = new Array<>();
        //public World world;
        //public Array<Explosion> explosionArray = new Array<>();
        //public Array<Boid> boids = new Array<>();

    }
}
