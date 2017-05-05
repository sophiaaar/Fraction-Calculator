using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Maths : MonoBehaviour {

	public int numerator1 = 0;
	public InputField Numerator1;
	public int denominator1 = 0;
	public InputField Denominator1;
	public int numerator2 = 0;
	public InputField Numerator2;
	public int denominator2 = 0;
	public InputField Denominator2;
	public Text currentOperatorText;
	Fraction answer;
	public InputField AnswerNum;
	public InputField AnswerDen;
	public Text TextBox;
	Fraction fraction1;
	Fraction fraction2;
	public Fraction _Fraction;

	// Called when the Equals button is clicked
	public void OnEqualsClick()
	{
		SetValues();
		//Set denominators to zero if empty - TODO

		//Do the calculation

		if (currentOperatorText.text.ToString().Contains("+"))
		{
			answer = _Fraction.Add(fraction1, fraction2);
		}
		else if (currentOperatorText.text.ToString() == "-")
		{
			answer = _Fraction.Subtract(fraction1, fraction2);
		}
		else if (currentOperatorText.text.ToString() == "*")
		{
			answer = _Fraction.Multiply(fraction1, fraction2);
		}
		else if (currentOperatorText.text.ToString() == "/")
		{
			answer = _Fraction.Divide(fraction1, fraction2);
		}
		else
		{
			//Please enter some values
			TextBox.text = "Please enter some values. Press C to restart";
		}

		answer = _Fraction.Reduce(answer.Numerator, answer.Denominator);
		AnswerNum.text = answer.Numerator.ToString();
		AnswerDen.text = answer.Denominator.ToString();
	}

	// Sets the values of the numerators and denominators based on what has been inputted by the user
	public void SetValues()
	{
		numerator1 = int.Parse(Numerator1.text);
		denominator1 = int.Parse(Denominator1.text);
		fraction1 = new Fraction(numerator1, denominator1);

		numerator2 = int.Parse(Numerator2.text);
		denominator2 = int.Parse(Denominator2.text);
		fraction2 = new Fraction(numerator2, denominator2);
	}

	// Calculate the first number
	public float CalculateFraction1()
	{
		// Dividing by zero with integers will always equal 0
		return numerator1/denominator1;
	}

	// Calculate the second number
	public float CalculateFraction2()
	{
		return numerator2/denominator2;
	}

	public bool IsZero(float one, float two)
	{
		if (one == 0)
		{
			//check if division is being done first?
			TextBox.text = "Fraction1 cannot be zero. Press C to restart";
			return true;
		}
		else if (two == 0)
		{
			TextBox.text = "Fraction2 cannot be zero. Press C to restart";
			return true;
		}
		else
		{
			//this is fine
			return false;
		}

	}

	// Places the chosen operator in a hidden text box so that it an be used for the operation (v sneaky and a bit hacky)
	public void DecideOperator()
	{
		// Gets the value of the clicked button (+, -, *, /)
		string currentOperator = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().GetComponentInChildren<Text>().text;
		Debug.Log(currentOperator);
		// Puts the value in the hidden text box
		currentOperatorText.text = currentOperator.ToString();
	}

	public void ConvertAnswerToFraction(float answerDec)
	{
		float answer100 = answerDec * 100;

	}

	// Clears all values
	public void Reset()
	{
		Numerator1.text = null;
		numerator1 = 0;
		Denominator1.text = null;
		denominator1 = 0;
		Numerator2.text = null;
		numerator2 = 0;
		Denominator2.text = null;
		denominator2 = 0;
		currentOperatorText = null;
		AnswerNum.text = null;
		AnswerDen.text = null;
		//answer = 0;
		currentOperatorText.text = "";
		TextBox.text = null;
		TextBox.text = "Sophia's Fraction Calculator:";
	}
}
