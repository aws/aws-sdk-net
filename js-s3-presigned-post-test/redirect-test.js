import { 
  S3Client, 
  CreateBucketCommand, 
  ListObjectsV2Command, 
  DeleteObjectsCommand,
  DeleteBucketCommand,
  HeadBucketCommand,
  waitUntilBucketExists
} from '@aws-sdk/client-s3';
import { createPresignedPost } from '@aws-sdk/s3-presigned-post';
import fetch from 'node-fetch';
import FormData from 'form-data';

// Configuration
const REGION = 'us-west-2';
const BUCKET_NAME = `s3-filename-variable-test-${Date.now()}`;
const s3Client = new S3Client({ region: REGION });

async function setupBucket() {
  try {
    console.log(`Setting up test bucket: ${BUCKET_NAME}`);
    
    // Check if bucket already exists
    try {
      await s3Client.send(new HeadBucketCommand({ Bucket: BUCKET_NAME }));
      console.log(`Bucket ${BUCKET_NAME} already exists, using it for tests`);
    } catch (err) {
      // Create bucket if it doesn't exist
      console.log(`Creating bucket ${BUCKET_NAME}...`);
      await s3Client.send(new CreateBucketCommand({ 
        Bucket: BUCKET_NAME,
        CreateBucketConfiguration: {
          LocationConstraint: REGION !== 'us-east-1' ? REGION : undefined
        }
      }));
      
      // Wait for bucket to be available
      await waitUntilBucketExists(
        { client: s3Client, maxWaitTime: 60 },
        { Bucket: BUCKET_NAME }
      );
      console.log(`Bucket ${BUCKET_NAME} created successfully`);
    }
    
    return true;
  } catch (err) {
    console.error('Error setting up bucket:', err);
    return false;
  }
}

async function cleanupBucket() {
  try {
    console.log(`\nCleaning up bucket: ${BUCKET_NAME}`);
    
    // List all objects in the bucket
    const listResult = await s3Client.send(new ListObjectsV2Command({
      Bucket: BUCKET_NAME
    }));
    
    if (listResult.Contents && listResult.Contents.length > 0) {
      console.log(`Found ${listResult.Contents.length} objects to delete`);
      
      // Delete all objects
      await s3Client.send(new DeleteObjectsCommand({
        Bucket: BUCKET_NAME,
        Delete: {
          Objects: listResult.Contents.map(obj => ({ Key: obj.Key }))
        }
      }));
      console.log('All objects deleted');
    } else {
      console.log('No objects to delete');
    }
    
    // Delete the bucket
    await s3Client.send(new DeleteBucketCommand({
      Bucket: BUCKET_NAME
    }));
    console.log(`Bucket ${BUCKET_NAME} deleted successfully`);
    
    return true;
  } catch (err) {
    console.error('Error during cleanup:', err);
    return false;
  }
}

async function testRedirect(redirectUrl) {
  try {
    console.log(`\nTesting with redirect URL: "${redirectUrl}"`);
    
    // Create presigned POST with success_action_redirect
    const { url, fields } = await createPresignedPost(s3Client, {
      Bucket: BUCKET_NAME,
      Key: `test-${Date.now()}.txt`,
      Fields: {
        'Content-Type': 'text/plain',
        'success_action_redirect': redirectUrl
      },
      Conditions: [
        ['content-length-range', 1, 1048576]
      ],
      Expires: 600
    });
    
    // Decode policy to see conditions
    const policyBase64 = fields.Policy;
    const policyJson = Buffer.from(policyBase64, 'base64').toString('utf-8');
    const policy = JSON.parse(policyJson);
    
    console.log('\nGenerated policy conditions:');
    policy.conditions.forEach(condition => {
      console.log(JSON.stringify(condition));
    });
    
    // Find the success_action_redirect condition
    const redirectCondition = policy.conditions.find(
      c => typeof c === 'object' && c['success_action_redirect'] !== undefined
    );
    
    console.log('\nSuccess_action_redirect condition:', 
      redirectCondition ? JSON.stringify(redirectCondition) : 'None found');
    
    // Try uploading
    console.log('\nAttempting upload...');
    const form = new FormData();
    
    // Add all fields from the presigned POST response
    Object.entries(fields).forEach(([key, value]) => {
      form.append(key, value);
    });
    
    // Add file content
    const testContent = 'Test content for filename variable bug reproduction';
    form.append('file', Buffer.from(testContent), {
      filename: 'test.txt',
      contentType: 'text/plain'
    });
    
    // Perform the upload
    const response = await fetch(url, {
      method: 'POST',
      body: form
    });
    
    console.log(`Upload status: ${response.status}`);
    if (!response.ok) {
      const text = await response.text();
      console.log(`Error response: ${text}`);
      return false;
    } else {
      console.log('Upload successful!');
      return true;
    }
  } catch (err) {
    console.error('Error during test:', err);
    return false;
  }
}

async function main() {
  try {
    console.log('S3 ${filename} Variable Bug Reproduction');
    console.log('======================================\n');
    
    // Setup the test bucket
    const setupSuccess = await setupBucket();
    if (!setupSuccess) {
      console.error('Failed to set up test bucket, aborting tests');
      return;
    }
    
    // Test 1: With ${filename} in success_action_redirect (will fail)
    console.log('\n== TEST 1: With ${filename} in success_action_redirect ==');
    const test1Result = await testRedirect('https://example.com/success?file=${filename}');
    console.log(`\nTEST 1 RESULT: ${test1Result ? 'PASSED' : 'FAILED'}`);
    if (test1Result) {
      console.log('Note: This test was expected to fail but passed. The issue may have been fixed.');
    } else {
      console.log('Note: This test failed as expected, confirming the issue exists.');
    }
    
    // Test 2: Without ${filename} (control test - should work)
    console.log('\n== TEST 2: Without ${filename} (control test) ==');
    const test2Result = await testRedirect('https://example.com/success');
    console.log(`\nTEST 2 RESULT: ${test2Result ? 'PASSED' : 'FAILED'}`);
    if (!test2Result) {
      console.log('Warning: Control test failed. There may be other issues with your setup.');
    }
    
    // Clean up resources
    await cleanupBucket();
    
    console.log('\nTest completed. If Test 1 failed and Test 2 passed, the issue is reproduced.');
  } catch (err) {
    console.error('Unexpected error:', err);
  }
}

// Run the test
main().catch(console.error);
