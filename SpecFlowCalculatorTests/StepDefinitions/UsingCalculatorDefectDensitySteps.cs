using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using SpecFlowCalculatorTests.StepDefinitions;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDefectDensitySteps
    {
        private double _result;

        private CalculatorContext _calculatorContext;

        public UsingCalculatorDefectDensitySteps(CalculatorContext _calculatorContext) // use it as ctor parameter
        {
            this._calculatorContext = _calculatorContext;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into calculator the and press Defect Density")]
        public void WhenIHaveEnteredAndIntoCalculatorTheAndPressDefectDensity(double p0, double p1)
        {
            _result = _calculatorContext._calculator.DefectDensity(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSI(double p0, double p1, double p2)
        {
            _result = _calculatorContext._calculator.SSISecondRelease(p0, p1, p2);
        }
        
        [Then(@"the defect density result should be ""(.*)""")]
        public void ThenTheDefectDensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the defect density result should be positive infinity")]
        public void ThenTheDefectDensityResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
        
        [Then(@"the SSI result for second release should be ""(.*)""")]
        public void ThenTheSSIResultForSecondReleaseShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
