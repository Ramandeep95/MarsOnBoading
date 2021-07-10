Feature: EducationPage
In order to manage Education Record
As a Mars Logo admin
I would like to create, edit and delete Education Record
@mytag
	Scenario: I'd like add valid details in Education
	Given I'd like to logged in profile page
	And I navigate to Education Page
	Then I should be able to create Education record with valid details

	@mytag
	Scenario: I like to edit records in Education
	Given I'd like to logged in profile page
	And I navigate to Education Page
	Then I should be able to edit Education record 

	@mytag
	Scenario: I like delete record inEducation
	Given I'd like to logged in profile page
	And I navigate to Education Page
	Then I should be able to Delete Education record 