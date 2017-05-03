using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fraction : MonoBehaviour {

	public int numerator1;
	public InputField Numerator1;
	public int denominator1;
	public InputField Denominator1;
	public int numerator2;
	public InputField Numerator2;
	public int denominator2;
	public InputField Denominator2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Called when the Equals button is clicked
	public void OnEqualsClick()
	{
		SetValues();


		//Check if zero
		if (numerator1 == 0)
		{
			throw new System.ArgumentException("Parameter cannot be Zero!", "numerator1");
		}

	}

	// Sets the values of the numerators and denominators
	public void SetValues()
	{
		numerator1 = int.Parse(Numerator1.text);
		Debug.Log("numerator1 =" + numerator1);
		denominator1 = int.Parse(Denominator1.text);
		Debug.Log("denominator1 =" + denominator1);

		numerator2 = int.Parse(Numerator2.text);
		Debug.Log("numerator2 =" + numerator2);
		denominator2 = int.Parse(Denominator2.text);
		Debug.Log("denominator2 =" + denominator2);

	}

	// Calculate the first number
	public float CalculateFraction1()
	{
		return numerator1/denominator1;
	}

	// Calculate the second number
	public float CalculateFraction2()
	{
		return numerator2/denominator2;
	}
}
