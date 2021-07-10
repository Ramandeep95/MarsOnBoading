Feature: CertificationsPage
In order to manage Certifications Record
As a Mars Logo admin
I would like to create, edit ad delete Certifications record
@mytag
	Scenario: I'd like add valid details in Certifications
	Given I logged in profile page
	And I navigate to Certification Page
	Then I should be able to create Certification record with valid details