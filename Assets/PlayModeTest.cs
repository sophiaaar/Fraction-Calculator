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

	[Test]
	public void TestSubtraction()
	{
		Fraction testFractionOne = new Fraction(1, 2);
		Fraction testFractionTwo = new Fraction(1, 4);
		//Fraction expectedResults = new Fraction (1, 4);

		Fraction actualResults = new Fraction();
		
		//This subtracts the fractions but doesn't reduce them
		Fraction actualResult = actualResults.Subtract(testFractionOne, testFractionTwo);
		float actualNumerator = actualResult.Numerator;
		float actualDenominator = actualResult.Denominator;

		//Check the actual maths (but not the reducing) works
		double expectedAnswer = 0.25;
		double actualAnswer = actualNumerator/actualDenominator;
		
		Assert.AreEqual(expectedAnswer, actualAnswer);
	}

	[Test]
	public void TestMultiplication()
	{
		Fraction testFractionOne = new Fraction(1, 2);
		Fraction testFractionTwo = new Fraction(1, 4);
		//Fraction expectedResults = new Fraction (1, 8);

		Fraction actualResults = new Fraction();
		
		//This multiplies the fractions but doesn't reduce them
		Fraction actualResult = actualResults.Multiply(testFractionOne, testFractionTwo);
		float actualNumerator = actualResult.Numerator;
		float actualDenominator = actualResult.Denominator;

		//Check the actual maths (but not the reducing) works
		double expectedAnswer = 0.125;
		double actualAnswer = actualNumerator/actualDenominator;
		
		Assert.AreEqual(expectedAnswer, actualAnswer);
	}

	[Test]
	public void TestDivision()
	{
		Fraction testFractionOne = new Fraction(1, 2);
		Fraction testFractionTwo = new Fraction(1, 4);
		//Fraction expectedResults = new Fraction (2, 1);

		Fraction actualResults = new Fraction();
		
		//This divides the fractions but doesn't reduce them
		Fraction actualResult = actualResults.Divide(testFractionOne, testFractionTwo);
		float actualNumerator = actualResult.Numerator;
		float actualDenominator = actualResult.Denominator;

		//Check the actual maths (but not the reducing) works
		double expectedAnswer = 2.0;
		double actualAnswer = actualNumerator/actualDenominator;
		
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
