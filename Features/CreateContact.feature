Feature: CreateContact

Logged user can create a new contact and open it to verify its data

Scenario: Add new contact and verify the data
	Given User is logged in
	When User navigates to Contacts
		And User adds new Contact
	Then User opens created Contact
		And User verifies if its data matches the entered ones