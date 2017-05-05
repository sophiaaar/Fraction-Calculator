using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fraction : MonoBehaviour
{
	private int _Numerator;
	private int _Denominator;

	public Fraction(int theNumerator, int theDenominator)
	{
		_Numerator = theNumerator;
		_Denominator = theDenominator;
	}

	// read only property for numerator
	public int Numerator
	{
		get
		{
			return _Numerator;
		}
	}

	// read only property for denominator
	public int Denominator
	{
		get
		{
			return _Denominator;
		}
	}
	
	// allows the user to create an "empty" fraction by initializing a fraction of 1/1
	public Fraction() : this(1, 1) { }

	// Method that takes in two numbers and finds the Greatest Common Divisor (GCD)
	private int GCD(int a, int b)
	{
		while (a != 0 && b != 0)
		{
			if (a > b)
				a %= b;
			else
				b %= a;
		}

		if (a == 0)
			return b;
		else
			return a;
	}

	public Fraction Reduce(int numerator, int denominator)
	{
		// if numerator and denominator are both negative, convert both to a positive
		if (numerator < 0 && denominator < 0)
		{
			numerator *= -1;
			denominator *= -1;

		}
		// if numerator is positive, but the denominator is negative convert the numerator to a negative and the denominator to a positive
		else if (numerator > 0 && denominator < 0)
		{
			numerator *= -1;
			denominator *= -1;
		}	

		int a = GCD(numerator, denominator);
		
		// reduce the numerator
		numerator = numerator / a;
		// reduce the denominator
		denominator = denominator / a;

		return new Fraction(numerator, denominator);
	}

	public Fraction Add(Fraction fraction1, Fraction fraction2)
	{
		Fraction result = new Fraction((fraction1.Numerator * fraction2.Denominator) + (fraction2.Numerator * fraction1.Denominator),
								fraction1.Denominator * fraction2.Denominator);
		
		return result;
	}

	public Fraction Subtract(Fraction fraction1, Fraction fraction2)
	{
		return new Fraction(((fraction1.Numerator * fraction2.Denominator) - (fraction2.Numerator * fraction1.Denominator)),
			(fraction1.Denominator * fraction2.Denominator));
	}

	public Fraction Multiply(Fraction fraction1, Fraction fraction2)
	{
		int newNum = fraction1.Numerator * fraction2.Numerator;
		int newDen = fraction1.Denominator * fraction2.Denominator;
		return new Fraction(newNum, newDen);
	}

	public Fraction Divide(Fraction fraction1, Fraction fraction2)
	{
		return new Fraction((fraction1.Numerator * fraction2.Denominator), (fraction2.Numerator * fraction1.Denominator));

	}
}
