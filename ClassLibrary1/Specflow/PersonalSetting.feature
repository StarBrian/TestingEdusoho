Feature: PersonalSetting
	In order to update my personal info
	As a user
	I want to insert user information

@UserInfomration
Scenario: Insert user information - Validation
	Given I have logged in my account
	| username | password | rmb   |
	| test002  | Test1234 | false |
	And I opened personal setting 
	And I updated my personal information
	| Name                                   | ID   | Phone | Company | Job    | Title                                              | Signature | Site | Weibo | QQ      |
	| aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa   | aaaa | qq    | abc     | Tester | aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa | Hello     | sss  | ss    | aaaaa   |
	When I pressed save button
    Then The error messages should show up on the page
	| error                                  |
	| 最多只能输入 18 个字符                   |
	| 请正确输入您的身份证号码                  |
	| 请输入正确的手机号                       |
	| 最多只能输入 24 个字符                   |
	| 地址不正确，须以http://或者https://开头。 |
	| 地址不正确，须以http://或者https://开头。 |
	| 请输入正确的QQ号                         |


Scenario: Insert user information - Happy path 
	Given I have logged in my account
	| username | password | rmb   |
	| test002  | Test1234 | false |
	And I opened personal setting
	And I updated my personal information
	| Name              | ID                 | Phone         | Company     | Job    | Title  | Signature | Site                     | Weibo                      | QQ      |
	| Test001           | 512554199901230233 | 13588765420    | fonefix     | Tester | aa     | BZ        | https://www.google.com/  | https://www.google.com/    | 1234567 |
	When I pressed save button
	Then The 基础信息保存成功 message should show upon the page