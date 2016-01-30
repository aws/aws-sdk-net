Feature: Test feature
  Run tests.

  Scenario: Tests are going to be run
    Then I touch the "TestButton" button
	Then I wait to see "ALL TESTS PASSED"
	Then I should not see "SOME TESTS FAILED"
	And take picture
