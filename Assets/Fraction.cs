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

		if (_Numerator == 0)
		{
			throw new System.ArgumentException("Parameter cannot be Zero!", "numerator");
		}
		else if (_Denominator == 0)
		{
			throw new System.ArgumentException("Parameter cannot be Zero!", "denominator");
		}
		else
		{
			Reduce(_Numerator, _Denominator);
		}
	}

	public int Numerator//read only property for numerator
	{
		get
		{
			return _Numerator;
		}
	}
	public int Denominator//read only property for denominator
	{
		get
		{
			return _Denominator;
		}
	}
		
	
	// allows the user to create an "empty" fraction by initializing a fraction of 1/1
	public Fraction() : this(1, 1) { }

	// method that takes in two numbers and finds the 
	// Greatest Common Factor (GCF)
	private int GCF(int left, int right)
	{
		int GCF;
		int remainder;
		int a = left;
		int b = right;
		
		while (b != 0)
		{
			remainder = left % right;
			a = b;
			b = remainder;
		}//end while
		GCF = a;
		return GCF;
	}

	private void Reduce(int numerator, int denominator)
	{
		if (numerator < 0 && denominator < 0)//if numerator and denominator are both negative, 
		{                                    // convert both to a positive
			numerator *= -1;
			denominator *= -1;

		}
		else if (numerator > 0 && denominator < 0)//if numerator is positive, but the denominator is negative
			//convert the numerator to a negative and the denominator to a positive
		{
			numerator *= -1;
			denominator *= -1;
		}
		

		int a = GCF(numerator, denominator);
		
		numerator = numerator / a;//reduce the numerator
		denominator = denominator / a;//reduce the denominator

		
	}
	public Fraction Add(Fraction fraction1, Fraction fraction2)
	{
		Fraction result = new Fraction((fraction1.Numerator * fraction2.Denominator) + (fraction1.Numerator * fraction2.Denominator),
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
		int newNum = fraction1.Numerator * fraction2.Denominator;
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
