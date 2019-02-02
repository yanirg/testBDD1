Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	

@MithLib @Add
Scenario: Add two numbers77
	Given first num 3
	And second num 4
	When the tow num are added
	Then the resualt should be 7