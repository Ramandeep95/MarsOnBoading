Feature: LanguagePage
In order to manage Languages Record
As a Mars Logo admin
I would like to create, edit ad delete Languages records
@mytag
Scenario: Add Language
	Given I have log in profile page
	And I navigate to Language Page
	Then I should be able to create Languages record with valid details

	Scenario: Edit Language
	Given I have log in profile page
	And I navigate to Language Page
	Then I should be able to edit Languages record with valid details

	Scenario: Delete Language
	Given I have log in profile page
	And I navigate to Language Page
	Then I should be able to delete Languages record with valid details