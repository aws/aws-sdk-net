# JavaScript S3 Presigned POST Test

This project demonstrates how the AWS SDK for JavaScript (v3) handles S3 presigned POST URLs, using the same test cases as the Python and C# implementations while accounting for JavaScript SDK's unique behavior.

## Key Feature: Adapter Pattern

The JavaScript SDK behaves differently from Python and C# SDKs when it comes to presigned POST URLs:

- **JavaScript SDK**: Automatically converts fields to exact match conditions in the policy document
- **Python/C# SDKs**: Requires explicit conditions for each field

To maintain consistent test cases across all implementations while accounting for this difference, this project uses an **adapter pattern**:

1. Test cases are loaded from the same `s3-presigned-post-test-cases.json` file used by Python and C#
2. The adapter transforms these test cases at runtime to be compatible with JavaScript SDK's behavior
3. No changes are needed to the original test cases or other language implementations

## Implementation Details

### Adapter Pattern Implementation

```javascript
function adaptTestCaseForJavaScriptSDK(testCase) {
  const adapted = JSON.parse(JSON.stringify(testCase)); // Deep copy
  const fieldsToRemove = [];
  
  // Find fields that have non-exact-match conditions
  if (adapted.conditions) {
    for (const condition of adapted.conditions) {
      if (condition.type === 'startsWith' && adapted.fields[condition.field]) {
        // Remove from fields to prevent auto exact-match condition
        fieldsToRemove.push(condition.field);
      }
    }
  }
  
  // Remove identified fields
  for (const field of fieldsToRemove) {
    delete adapted.fields[field];
  }
  
  return adapted;
}
```

### How the Adapter Works

1. **Identify Fields with Special Conditions**: For any field that should have a "starts-with" condition (not an exact match), the adapter identifies it
2. **Prevent Automatic Conversion**: The adapter removes these fields from the `Fields` object to prevent the SDK from automatically creating exact match conditions
3. **Preserve Original Conditions**: The original "starts-with" conditions are kept and properly formatted for the JavaScript SDK

## Test Cases

This project uses the same test cases as the Python and C# implementations:

1. **End-to-End Demo**: Basic presigned POST functionality with text file upload
2. **Text Upload Test**: Form-based text file upload with starts-with Content-Type validation
3. **JSON Upload Test**: Form-based JSON file upload with exact Content-Type validation
4. **Binary Upload Test**: Form-based binary file upload with exact Content-Type validation

## Prerequisites

- Node.js 14+ installed
- AWS credentials configured in your environment (via AWS CLI, environment variables, or IAM role)
- An S3 bucket for testing

## Installation

1. Clone the repository or copy the project files
2. Install dependencies:

```bash
cd js-s3-presigned-post-test
npm install
```

## Usage

Run the tests:

```bash
node index.js
```

You can optionally set the AWS region if needed:

```bash
AWS_REGION=us-west-2 node index.js
```

The script uses the hardcoded bucket name "s3-presigned-post-demo-comparison" to match the Python and .NET implementations for consistent results.

## Output

The test generates JSON comparison files that match the Python and C# implementations:

- `javascript_end_to_end_demo_response.json`
- `javascript_text_upload_test_response.json`
- `javascript_json_upload_test_response.json`
- `javascript_binary_upload_test_response.json`

These files can be compared with the Python and C# counterparts to verify consistent behavior.

## Comparing with Other AWS SDKs

This project demonstrates the key differences between AWS SDKs for S3 presigned POST:

| SDK | Field-to-Condition Behavior |
|-----|----------------------------|
| JavaScript | Automatically converts fields to exact match conditions |
| Python (boto3) | Does not automatically convert fields to conditions |
| .NET | Does not automatically convert fields to conditions |

Understanding these differences is crucial when working with S3 presigned POST URLs across different programming languages.
