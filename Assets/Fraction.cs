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
	public override string ToString()
	{
		return Numerator + "/" + Denominator;
	}
	public string ToFloatString(int digits)
	{
		if (digits < 1)
		{
			//throw new ArgumentOutOfRangeException("Digits must be a non negative integer!");
		}
		
		double fractionAsNum = Numerator / Denominator;
		return fractionAsNum.ToString("f" + digits);
	}
}
