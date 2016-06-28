Feature: TestFeature
	Integration Test for the Quote Controller


@mytag
Scenario: Get Quote 
	Given I select AAPL
	When I press search button
	Then the result should be 120 on the screen

Scenario: Get List of Symbols
	Given The Page Starts 
	When It Finished Loaded
	Then The Count of Symbols should be N 
