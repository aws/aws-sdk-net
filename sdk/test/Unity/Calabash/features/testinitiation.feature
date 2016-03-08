Feature: Test Feature
  Run Tests.

  Scenario: Tests are going to be run
  	Then I wait for 5 seconds
    Given I press the "TestButton" button
    Then I wait to see "ALL TESTS PASSED" on textview with id "status"
    And take picture
