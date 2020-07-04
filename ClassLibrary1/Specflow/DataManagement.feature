Feature: DataManagement
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario Outline: Search info with filters
	Given I logged in as an admin
	|username | password       | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the operation option
	And I selected a <filter> and entered a <value>
	When I clicked the sreach button
	Then I saw the articles contained a <word>
	Examples:
	| filter    | value   | word    |
	| category  | EduSoho | EduSoho |
	| keywords   | 世界     | 世界    |
	| property | 头条    | 头    |
	| status    | 已发布  | 已发布   |


	
Scenario: Update publish status
	Given I logged in as an admin
	|username | password       | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the operation option
	When I change the publish status on a info
	Then I saw the updated publish status was popping up
	

Scenario: Add a category on infor management page
	Given I logged in as an admin
	|username | password       | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the operation option
	And I clicked AddInfor button
	And I filled out the article form
	| title        | value   | tag   | content  |
	| TestAddInfor | EduSoho | 课程  | test1234 |
	When I clicked save button
	Then the new article TestAddInfor should pop up on information management page
	
	

	
Scenario:Change the category name
	Given I logged in as an admin
	|username | password       | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the operation option
	And I clicked edit button of the top article
	And I changed category name to TestingEditFunction
	When I clicked save button
	Then the article should show the new name TestingEditFunction
	
