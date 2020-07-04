Feature: SpecFlowFeature4
	In order to check alert message in signIn page
	As a user
	I want to sign in an user account using invalid information

@invalidSignInInfo
Scenario Outline: Sign in using invalid 
	Given I have opened sign in page
	And I register with <name> and <password> and <email> ,typing in <verificationCode>
	When I press signin button
	Then the <error> error alert should shows up
	Examples:
	| name                              | password | email           | verificationCode | error                   |
	| test003                           | test003  | test003         | aa               | 请输入有效的电子邮件地址            |
	| test003test003                    | test003  | test@test.co.nz | aa               | 验证码错误                   |
	| test003                           | test     | test@003        | aa               | 最少需要输入 5 个字符            |
	| ddddddddddddddddddddddddddddddddd | 11111111 | test003@qq.com  | aa               | 字符长度必须小于等于18，一个中文字算2个字符 |


