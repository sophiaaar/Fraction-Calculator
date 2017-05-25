using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayModeTests {
	public Fraction _Fraction;

	[Test]
	public void PlayModeTestsSimplePasses() {
		// Use the Assert class to test conditions.
	}

	// [Test]
	// public void GameObject_CreatedWithGiven_WillHaveTheName()
	// {
	// 	var go = new GameObject(“MyGameObject”);
	// 	Assert.AreEqual(“MyGameObject”, go.name);
	// }

	[Test]
	public void TestAddition()
	{
		Fraction testFractionOne = new Fraction(1, 2);
		Fraction testFractionTwo = new Fraction(1, 4);

		Fraction expectedResults = new Fraction (3, 4);

		Fraction actualResults = _Fraction.Add(testFractionOne, testFractionTwo);
		Assert.AreSame(expectedResults, actualResults);

	}


	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator PlayModeTestsWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
