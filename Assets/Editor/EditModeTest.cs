using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class EditModeTest {

	[Test]
	public void EditModeTestSimplePasses() {
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

	[Test]
	public void TestReducing()
	{
		//A test to check that the reduction method works
		//It takes in two ints (a fraction) and reduces them to their lowest terms

		int inputNumerator = 3;
		int inputDenominator = 6;

		//Reducing 3/6 should be 1/2

		Fraction actualResult = new Fraction();
		Fraction reduction = actualResult.Reduce(inputNumerator, inputDenominator);

		int expectedNumerator = 1;
		int expectedDenominator = 2;

		Assert.AreEqual(expectedNumerator, reduction.Numerator);
		Assert.AreEqual(expectedDenominator, reduction.Denominator);
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator EditModeTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
