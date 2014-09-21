using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using TechTalk.SpecFlow;

namespace JenkinsTest_ExampleTests.Models
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private int[] numbers = new int[2];
        private int index = 0;
        private int expect, actual;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            numbers[index] = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var target = new Calculator();
            actual = target.Add(numbers[0], numbers[1]);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            expect = p0;
            Assert.AreEqual(expect, actual);
        }
    }
}
