Feature: UsingCalculatorLogarithmicReliability
	In order to calculate the Musa Logarithmic model's failures/intensities
	As a system quality engineer
	I want to use my calculator to do this

@CurrentLogFailureIntensity
Scenario: Calculating logarithmic model failure intensity normally
	Given I have a calculator
	When I have entered "10", "0.02" and "50" into the calculator and press logarithmic failure intensity
	Then the log failure intensity result should be "3.68"

@CurrentLogExpectedFailureIntensity
Scenario: Calculating logarithmic model number of expected failures normally
	Given I have a calculator
	When I have entered "10", "0.02" and "10" into the calculator and press logarithmic expected failure
	Then the log expected failure result should be "54"