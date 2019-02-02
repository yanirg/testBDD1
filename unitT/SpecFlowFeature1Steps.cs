using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitT
{
    [Binding]
    public sealed class SpecFlowFeature1Steps
    {
        private MathLib1.MathLibOps1 mlo = new MathLib1.MathLibOps1();
        private double res;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //ScenarioContext.Current.Pending();
            mlo.num1 = p0;
        }
        
        [Given(@"first num (.*)")]
        public void GivenFirstNum(int p0)
        {
            mlo.num1 = p0;
        }
        
        [Given(@"second num (.*)")]
        public void GivenSecondNum(int p0)
        {
            mlo.num2 = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           res= mlo.Add();
        }
        
        [When(@"the tow num are added")]
        public void WhenTheTowNumAreAdded()
        {
            //ScenarioContext.Current.Pending();
            res = mlo.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, res);
        }
        
        [Then(@"the resualt should be (.*)")]
        public void ThenTheResualtShouldBe(int p0)
        {
            Assert.AreEqual(p0,res);
        }
    }
}
