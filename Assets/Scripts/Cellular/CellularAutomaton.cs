using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace Assets.Scripts.Cellular
{
	public class CellularAutomaton
	{
		public static int screenWidth = 1280; // 480;
		public static int screenHeight = 800; //800;
		public static int pixelSizeModifier = 6;
		public static int box2dSizeModifier = 10;
		public static Vector3 gravity = new Vector3(0f, -5f, 0f);
		public static BitArray stepped = new BitArray(1);

		//private ShapeRenderer shapeRenderer;
		public CellularMatrix matrix;
		//private OrthographicCamera camera;

		private int numThreads = 12;
		private bool useMultiThreading = true;

		//private InputManager inputManager;

		//private FPSLogger fpsLogger;
		public static int frameCount = 0;
		public bool useChunks = true;
		//public World b2dWorld;
		//public Box2DDebugRenderer debugRenderer;
		//public InputProcessors inputProcessors;
		//public Stage matrixStage;
		//public GameManager gameManager;

		public void create() {}

		public void render() {}

		public void resize(int width, int height) {}

		private void incrementFrameCount() {}

		private void setUpBasicBodies() {}

		private void startAndWaitOnEvenThreads(List<Thread> threads) {}

		private void startAndWaitOnOddThreads(List<Thread> threads) {}

		public void dispose() {}

	}
}
