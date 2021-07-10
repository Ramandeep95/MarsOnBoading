Feature: Skills
In order to manage Skills Record
As a Mars Logo admin
I would like to create, edit ad delete Skills record
@mytag
Scenario: Add Records in Skills
	Given I'd  log in profile page
	And I navigate to Skills Page
	Then I should be able to create Skills record with valid details

@mytag
Scenario: Edit Record in Skills
	Given I'd  log in profile page
	And I navigate to Skills Page
	Then I should be able to edit Skills record 

	@mytag
Scenario: Delete Record in Skills
	Given I'd  log in profile page
	And I navigate to Skills Page
	Then I should be able to Delete Skills record 