using ICT3101_Calculator;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    public class CalculatorContext
    {
        public Calculator _calculator;
    }

    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        private readonly CalculatorContext _calculatorContext;

        public UsingCalculatorStepDefinitions(CalculatorContext _calculatorContext) // use it as ctor parameter
        {
            this._calculatorContext = _calculatorContext;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
            _calculatorContext._calculator = _calculator;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}