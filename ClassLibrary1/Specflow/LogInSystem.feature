Feature: SpecFlowFeature1
	In order to check log in function
	As a registered user
	I want to log into my user account


@CorrectLoginInfo
Scenario: Log in using the correct username and correct password
	Given I am on Edu Website
	And I click the login button
	And I login with user
	| username | password | remember |
	| test002  | Test1234 | false    |

	When I press login
	Then the user icon should be shown on the top right corner of the screen

@WrongLoginInfo
Scenario: Log in using the incorrect username and incorrect password
    Given I am on Edu Website
	And I click the login button
	And I login with user
	| username | password | remember |
	| test112  | Test1111 | false    |
	When I press login
	Then the alert bar should be shown on the login page

@CorrectLoginInfor_ClickRemember
Scenario: Log in using the correct username and correct password and click remember password
	Given I am on Edu Website
	And I click the login button
	And I login with user
	| username | password | remember |
	| test002  | Test1234 | true     |	
	When I press login
	Then the user icon should be shown on the top right corner of the screen
