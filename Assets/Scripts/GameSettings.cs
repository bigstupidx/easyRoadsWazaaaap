﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameSettings{

	public static Complexity currentComplexity = Complexity.Hard;

	public enum Complexity
	{
		Low,
		Middle,
		Hard
	}

	public static int countLevels = 20;

	public static int startLives = 3;

	public static float penaltyTime = 5f;

	static float[] lowParameters = {4f,4f,1f};
	static float[] middleParameters = {3f,3f,1f};
	static float[] hardParameters = {2f,2f,2f};
	static float[][] parameters = {lowParameters,middleParameters,hardParameters};

	static float[] KMparametersChange = {1.25f,1.5f,1.75f};

	static float[] Ntimes = {120f,90f,60f};

	static int[] correctlyPoints = {100,200,300};
	static float[] factorPoints = {1f,1.25f,1.5f};
	static float[] stepForFactors = {0.25f,0.5f,1.5f};

	// set time for each level
	public static float deltaGoodTime = 10f;

	static float[] listTime_3 = {90,  90,  160, 120, 140, 150, 115, 120, 140, 140, 90,  90,  160, 120, 140, 150, 115, 120, 140, 140};
	static float[] listTime_2 = {105, 105, 180, 135, 160, 160, 130, 135, 150, 150, 105, 105, 180, 135, 160, 160, 130, 135, 150, 150};
	static float[] listTime_1 = {120, 120, 200, 150, 180, 180, 145, 150, 165, 165, 120, 120, 200, 150, 180, 180, 145, 150, 165, 165};
	// set level for unlocking next bike
	static int[] listUnlockingBike = {1,2,3,3}; // {1,2,4,12};

	// speed, acceleration, lean, handling
	static BikeStatics[] bikeStatisticsArray = {new BikeStatics(0.45f, 0.7f, 0.7f, 0.75f), 
												new BikeStatics(0.6f, 0.5f, 0.5f, 0.4f), 
												new BikeStatics(0.65f, 0.9f, 0.7f, 0.55f),
												new BikeStatics(0.7f, 0.8f, 0.85f, 0.8f)};
//	static BikeStatics[] bikeStatisticsArray = {new BikeStatics(0.7f, 0.8f, 0.85f, 0.8f), 
//												new BikeStatics(0.6f, 0.5f, 0.5f, 0.4f), 
//												new BikeStatics(0.45f, 0.7f, 0.7f, 0.75f),
//												new BikeStatics(0.65f, 0.9f, 0.7f, 0.55f)};

	public static BikeStatics getCurrentBikeStatistics(int currentBike){
		return bikeStatisticsArray[currentBike];
	}

	public static int getLevelForUnlockBike(int currentBike){
		return listUnlockingBike[currentBike];
	}

	public static int[] getListUnlockingBike(){
		return listUnlockingBike;
	}

	public static float getTime_3(int currentLevel){
		return listTime_3[currentLevel];
	}

	public static float getTime_2(int currentLevel){
		return listTime_2[currentLevel];
	}

	public static float getTime_1(int currentLevel){
		return listTime_1[currentLevel];
	}

	public static float[] GetParameters()
	{
		return parameters [(int)currentComplexity];
	}

	public static float GetKMParameter()
	{
		return KMparametersChange [(int)currentComplexity];
	}

	public static float GetNtime()
	{
		return Ntimes [(int)currentComplexity];
	}
	public static int GetPoints()
	{
		return correctlyPoints [(int)currentComplexity];
	}
	public static float GetFactor()
	{
		return factorPoints [(int)currentComplexity];
	}
	public static float GetStep()
	{
		return stepForFactors [(int)currentComplexity];
	}
}

public class BikeStatics{
	public float topSpeed;
	public float acceleration;
	public float lean;
	public float grip;

	public BikeStatics(float topSpeed, float acceleration, float lean, float grip){
		this.topSpeed = topSpeed;
		this.acceleration = acceleration;
		this.lean = lean;
		this.grip = grip;
	}
}
