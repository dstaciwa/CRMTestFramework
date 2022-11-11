Feature: RemoveEventsFromActivityLog

Logged user can remove events from Activity Log

Scenario: Check and remove events
	Given User is logged in
	When User navigates to Activity Log
		And User selects first 3 items in the table
		And User deletes selected items
	Then User verifies if selected items were deleted