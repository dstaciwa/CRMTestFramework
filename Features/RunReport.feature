Feature: RunReport

Logged user can find and run reports

Scenario: Find and run report
	Given User is logged in
	When User navigates to Reports
		And User finds "Project Profitability" report
	Then User runs report
		And User verifies if some results were returned