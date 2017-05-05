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
	public Fraction fraction1;
	public Fraction fraction2;
	public Fraction _Fraction;

	// Called when the Equals button is clicked
	public void OnEqualsClick()
	{
		SetValues();

		//Do the calculation
		if (IsFractionZero(fraction1, fraction2) == false)
		{
			if (currentOperatorText.text.ToString() == ("+"))
			{
				answer = _Fraction.Add(fraction1, fraction2);
				answer = _Fraction.Reduce(answer.Numerator, answer.Denominator);
				AnswerNum.text = answer.Numerator.ToString();
				AnswerDen.text = answer.Denominator.ToString();
			}
			else if (currentOperatorText.text.ToString() == "-")
			{
				answer = _Fraction.Subtract(fraction1, fraction2);
				answer = _Fraction.Reduce(answer.Numerator, answer.Denominator);
				AnswerNum.text = answer.Numerator.ToString();
				AnswerDen.text = answer.Denominator.ToString();
			}
			else if (currentOperatorText.text.ToString() == "*")
			{
				answer = _Fraction.Multiply(fraction1, fraction2);
				answer = _Fraction.Reduce(answer.Numerator, answer.Denominator);
				AnswerNum.text = answer.Numerator.ToString();
				AnswerDen.text = answer.Denominator.ToString();
			}
			else if (currentOperatorText.text.ToString() == "/")
			{
				answer = _Fraction.Divide(fraction1, fraction2);
				answer = _Fraction.Reduce(answer.Numerator, answer.Denominator);
				AnswerNum.text = answer.Numerator.ToString();
				AnswerDen.text = answer.Denominator.ToString();
			}
			else
			{
				TextBox.text = "Please select an operator or press C to restart.";
			}
		}
		else
		{
			TextBox.text = "Values cannot be zero. Press C to restart";
		}
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

	// Places the chosen operator in a hidden text box so that it an be used for the operation (v sneaky and a bit hacky)
	public void DecideOperator()
	{
		// Gets the value of the clicked button (+, -, *, /)
		string currentOperator = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().GetComponentInChildren<Text>().text;
		Debug.Log(currentOperator);
		// Puts the value in the hidden text box
		currentOperatorText.text = currentOperator;
	}

	// Checks if either of the fractions are zero
	private bool IsFractionZero(Fraction fraction1, Fraction fraction2)
	{
		if (fraction1.Numerator == 0)
		{
			return true;
		}
		else if (fraction1.Denominator == 0)
		{
			return true;
		}
		if (fraction2.Numerator == 0)
		{
			return true;
		}
		else if (fraction2.Denominator == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
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
		//currentOperatorText = null;
		AnswerNum.text = null;
		AnswerDen.text = null;
		fraction1 = new Fraction(0,0);
		fraction2 = new Fraction(0,0);
		//answer = 0;
		currentOperatorText.text = "";
		//TextBox = null;
		TextBox.text = "Sophia's Fraction Calculator:";
	}
}
