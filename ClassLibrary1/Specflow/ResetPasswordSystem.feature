Feature: SpecFlowFeature5
    In order to check email alert function on the reset password page
	As user
	I want to type in invalid  emails

@unauthorizedEmail
Scenario Outline: Type in unauthorized email
	Given I have opened reset password page
	When  I typed in <unauthorized email> and I pressed reset password  
    Then  The <email error> should shows up
    Examples:
	| unauthorized email  | email error        |
	| aa@gmail.com        | 该邮箱地址没有注册过帐号   |
	| aa                  | 请输入有效的电子邮件地址 |