Feature: SpecFlowFeature3
	In order to check uploadingphoto function
	As a user
	I want to uplaod my profile photo

@UploadMyProfilePhoto
Scenario: Uplaod profile photo in personal setting
	Given I have logged in my account
	| username | password | rmb   |
	| test002  | Test1234 | false |
	When  I click uploadingProfileButton
	Then The new photo is uploaded
