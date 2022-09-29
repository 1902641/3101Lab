using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.StepDefinitions;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private double _result;

        private CalculatorContext _calculatorContext;

        public UsingCalculatorFactorialSteps(CalculatorContext _calculatorContext) // use it as ctor parameter
        {
            this._calculatorContext = _calculatorContext;
        }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = _calculatorContext._calculator.Factorial(p0);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
