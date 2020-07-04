Feature: SpecFlowFeature2
	In order to check logout function
	As a user
	I want to log out of my account

@Logoutofmyaccount
Scenario: Log out of user account
	Given I have logged in my accout
	| username | password | rmb   |
	| test002  | Test1234 | false |
	When I click logout
	Then The page returns to homepage
	