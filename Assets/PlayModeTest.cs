using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayModeTest {
	//public Fraction _Fraction;

	[Test]
	public void NewPlayModeTestSimplePasses() {
		// Use the Assert class to test conditions.
	}

	[Test]
	public void TestAddition()
	{
		Fraction testFractionOne = new Fraction(1, 2);
		Fraction testFractionTwo = new Fraction(1, 4);

		//Fraction expectedResults = new Fraction (3, 4);

		Fraction actualResults = new Fraction();
		
		//This adds the fractions but doesn't reduce them
		Fraction actualResult = actualResults.Add(testFractionOne, testFractionTwo);

		float actualNumerator = actualResult.Numerator;

		float actualDenominator = actualResult.Denominator;


		// int expectedNumerator = 3;
		// int expectedDenominator = 4;

		//Check the actual maths (but not the reducing) works

		double expectedAnswer = 0.75;
		double actualAnswer = actualNumerator/actualDenominator;

		//Assert.AreSame(expectedResults, actualResults);
		// Assert.AreEqual(expectedNumerator, actualNumerator);
		// Assert.AreEqual(expectedDenominator, actualDenominator);
		
		Assert.AreEqual(expectedAnswer, actualAnswer);

	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator NewPlayModeTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
