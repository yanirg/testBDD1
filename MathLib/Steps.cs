using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using MathLib;

namespace MathLibTest
{
    [Binding]
    public sealed class Steps
    {
        private MathLibOps mlo = new MathLibOps();
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Add("p0", p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"first num (.*)")]
        public void GivenFirstNum(int num1)
        {
           // ScenarioContext.Current.Add("num1", num1);
            mlo._first = num1;
        }

        [Given(@"second num (.*)")]
        public void GivenSecondNum(int num2)
        {
            //ScenarioContext.Current.Add("num2", num2);
            mlo._second = num2;
        }

        [When(@"the tow num are added")]
        public void WhenTheTowNumAreAdded()
        {
            int num1 = (int)ScenarioContext.Current["num1"];
            int num2 = (int)ScenarioContext.Current["num2"];
            
            var addResult = mlo.Add(num1, num2);

            ScenarioContext.Current.Add("AddResult", addResult);
        }

        [Then(@"the resualt should be (.*)")]
        public void ThenTheResualtShouldBe(int expectedRes)
        {
            var addResult = (int)ScenarioContext.Current["AddResult"];
            Assert.AreEqual(expectedRes, addResult);
          
        }

    }
}
