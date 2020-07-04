Feature: BackgroundSystem
	In order to search orders
	As a admin
	I would like to search orders with different filters

@Search  orders
Scenario: Search course orders
	Given I logged in as an admin
	|username | password       | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the course order option
	When I click the sreach button
	Then I can see the expected orders 


	

Scenario: Search class orders
	Given I logged in as an admin
	|username | password       | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the class order option
	When I click the sreach button
	Then I can see the expected orders 
	

Scenario Outline: Search course orders with filters
	Given I logged in as an admin
	|username | password       | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the course order option
	And I chose a <filter> and inserted a <value>
	When I click the sreach button
	Then I see <results> orders 
	Examples:
	| filter           | value            | results |
	| startDateTime    | 2017-12-14 22:51 | 20      |
	| status           | 已付款            | 20      |
	| payment          | 支付宝            | 0       |
	| keywordType      | 课程名称          |20       |

	 

Scenario Outline: Search class orders with filters
	Given I logged in as an admin
	| username | password      | rmb   |
	| admin   | 5EstafeyEtre   | false |
	And I opened the order page	in the background managing system
	And I chose the class order option
	And I chose a <filter> and inserted a <value>
	When I click the sreach button
	Then I see <results> orders 
    Examples:
	| filter            | value              | results |
	| startDateTime     | 2017-12-14 22:51   | 5       |
	| status            | 已付款             | 5       |
	| payment           | 支付宝             | 0       |
	| keywordType       | 班级编号           | 5       |
	
