Feature: Resgister Student

@mytag
Scenario: Register valid student
	Given name "Agustina"
	And lastname "Disiot"
	And  number 221025
	When create button in pressed
	Then the user should be created