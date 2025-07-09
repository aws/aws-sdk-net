import { S3Client } from '@aws-sdk/client-s3';
import { createPresignedPost } from '@aws-sdk/s3-presigned-post';
import fetch from 'node-fetch';
import FormData from 'form-data';
import fs from 'fs/promises';
import path from 'path';

// Configuration
const BUCKET_NAME = 's3-presigned-post-demo-comparison'; // Default bucket name
const REGION = 'us-west-2';

// Create S3 client
const s3Client = new S3Client({ region: REGION });

async function main() {
  try {
    // Read test cases from the JSON file
    console.log('Reading test cases from s3-presigned-post-test-cases.json...');
    const testCasesJson = await fs.readFile(
      path.resolve('../s3-presigned-post-test-cases.json'), 
      'utf-8'
    );
    const { testCases } = JSON.parse(testCasesJson);
    
    console.log(`Found ${testCases.length} test cases`);
    
    // Process each test case
    for (const testCase of testCases) {
      console.log(`\n== Processing test case: ${testCase.name} ==`);
      await processTestCase(testCase);
    }
    
    console.log('\nAll test cases processed successfully!');
  } catch (error) {
    console.error('Error processing test cases:', error);
  }
}

async function processTestCase(testCase) {
  // Use fixed timestamp "consistent" to match .NET implementation for comparison
  const timestamp = "consistent";
  
  // Replace placeholders
  const bucketName = testCase.bucketName.replace('{BUCKET_NAME}', BUCKET_NAME);
  const key = testCase.key.replace('{TIMESTAMP}', timestamp);
  
  // Create request configuration
  const request = {
    Bucket: bucketName,
    Key: key,
    Fields: {},
    Conditions: [],
    Expires: testCase.expiresIn
  };
  
  // Process fields and replace placeholders
  for (const [fieldName, fieldValue] of Object.entries(testCase.fields)) {
    request.Fields[fieldName] = fieldValue.replace('{TIMESTAMP}', timestamp).replace('{BUCKET_NAME}', BUCKET_NAME);
  }
  
  // Add additional conditions
  if (testCase.additionalConditions) {
    for (const condition of testCase.additionalConditions) {
      if (condition.type === 'contentLengthRange') {
        request.Conditions.push(['content-length-range', condition.min, condition.max]);
      } else if (condition.type === 'startsWith') {
        request.Conditions.push(['starts-with', `$${condition.field}`, condition.value]);
      }
    }
  }
  
  console.log('Generating presigned POST URL...');
  console.log('Request:', JSON.stringify(request, null, 2));
  
  // Generate presigned POST
  const { url, fields } = await createPresignedPost(s3Client, request);
  
  // Create normalized test name for filenames
  const normalizedTestName = testCase.name.toLowerCase().replace(/\s+/g, '_');
  
  // Save response to file
  await saveResponseToFile(normalizedTestName, url, fields, testCase);
  
  // Perform upload if specified
  if (testCase.performUpload) {
    await performUpload(testCase, url, fields, normalizedTestName, timestamp, key);
  }
}

async function saveResponseToFile(testName, url, fields, testCase) {
  // Decode the policy for comparison
  const decodedPolicy = JSON.parse(Buffer.from(fields.Policy, 'base64').toString('utf-8'));
  
  // Create a standardized response object
  const responseData = {
    testname: testCase.name,
    url: url,
    fields: fields,
    decodedPolicy: decodedPolicy
  };
  
  // Save to file with js_ prefix for our comparison script
  const filename = `js_${testName}_response.json`;
  await fs.writeFile(filename, JSON.stringify(responseData, null, 2));
  console.log(`Response saved to ${filename}`);
  
  return filename;
}

async function performUpload(testCase, url, fields, normalizedTestName, timestamp, key) {
  console.log(`Performing upload for test case: ${testCase.name}`);
  
  // Create form data
  const form = new FormData();
  
  // Add all fields from the presigned POST response
  Object.entries(fields).forEach(([key, value]) => {
    form.append(key, value);
  });
  
  // Prepare content with placeholders replaced
  let content = testCase.testContent;
  if (typeof content === 'string') {
    content = content
      .replace('{TIMESTAMP}', timestamp) // Use the consistent timestamp directly
      .replace('{BUCKET_NAME}', fields.bucket || BUCKET_NAME)
      .replace('{KEY}', key);
  } else if (typeof content === 'object' && content !== null) {
    content = JSON.stringify(content).replace('{TIMESTAMP}', timestamp);
  }
  
  // Handle different content types
  const contentType = testCase.fields['Content-Type'];
  
  if (content === 'BINARY_PNG_DATA') {
    // For demo purposes, use a simple 1x1 transparent PNG
    const pngBuffer = Buffer.from('iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mNkYAAAAAYAAjCB0C8AAAAASUVORK5CYII=', 'base64');
    form.append('file', pngBuffer, {
      filename: `${normalizedTestName}.png`,
      contentType: contentType
    });
  } else if (contentType === 'application/json') {
    form.append('file', Buffer.from(content), {
      filename: `${normalizedTestName}.json`,
      contentType: contentType
    });
  } else {
    // Default to text
    form.append('file', Buffer.from(content), {
      filename: `${normalizedTestName}.txt`,
      contentType: contentType
    });
  }
  
  // Perform the upload
  console.log('Uploading file...');
  const response = await fetch(url, {
    method: 'POST',
    body: form
  });
  
  if (response.ok) {
    console.log('✅ Upload successful!');
    console.log(`Status: ${response.status}`);
  } else {
    console.log('❌ Upload failed');
    console.log(`Status: ${response.status}`);
    console.log('Error:', await response.text());
  }
}

// Run the main function
main().catch(console.error);
