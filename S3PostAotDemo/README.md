# S3 Presigned POST Demo (Native AOT)

This demo application demonstrates the AWS SDK for .NET's S3 Presigned POST functionality with full end-to-end testing capabilities.

## Features

### End-to-End Testing
- ✅ **Real AWS Integration**: Uses actual AWS credentials and creates real S3 buckets
- ✅ **Bucket Creation**: Automatically creates test buckets with unique names
- ✅ **File Upload**: Performs actual file uploads using presigned POST URLs
- ✅ **Upload Verification**: Retrieves and verifies uploaded files from S3
- ✅ **Resource Cleanup**: Optional automatic cleanup of test resources

### Native AOT Compatibility
- ✅ **PublishAot**: Configured for ahead-of-time compilation
- ✅ **Trimming Support**: Compatible with assembly trimming
- ✅ **Cross-Platform**: Runs on Windows, macOS, and Linux

## Prerequisites

### AWS Credentials
You need valid AWS credentials configured through one of these methods:

1. **Environment Variables**:
   ```bash
   export AWS_ACCESS_KEY_ID=your_access_key
   export AWS_SECRET_ACCESS_KEY=your_secret_key
   export AWS_DEFAULT_REGION=us-west-2  # optional
   ```

2. **AWS CLI Profile**:
   ```bash
   aws configure --profile your-profile
   ```

3. **IAM Role** (when running on EC2/ECS/Lambda)

### Required Permissions
Your AWS credentials need the following S3 permissions:
- `s3:CreateBucket`
- `s3:PutObject`
- `s3:GetObject`
- `s3:DeleteObject`
- `s3:DeleteBucket`
- `s3:ListBucket`

## Usage

### Basic Usage
```bash
dotnet run
```
This will:
- Create a bucket with auto-generated name
- Upload a test file using presigned POST
- Verify the upload
- Leave resources in AWS (manual cleanup required)

### With Automatic Cleanup
```bash
dotnet run --cleanup
```
Automatically deletes all created resources after the demo.

### Custom Region
```bash
dotnet run --region us-east-1 --cleanup
```

### Custom Bucket Name
```bash
dotnet run --bucket my-test-bucket --cleanup
```

### Help
```bash
dotnet run --help
```

## Command Line Options

| Option | Description | Default |
|--------|-------------|---------|
| `-r, --region <region>` | AWS region to use | `us-west-2` |
| `-b, --bucket <name>` | Custom bucket name | Auto-generated |
| `-c, --cleanup` | Delete resources after demo | `false` |
| `-h, --help` | Show help message | - |

## Demo Flow

### 1. End-to-End Demo
The main demo performs these steps:
1. **Credential Verification**: Verifies AWS credentials work
2. **Bucket Creation**: Creates a test S3 bucket
3. **Presigned POST Generation**: Creates a presigned POST URL
4. **File Creation**: Generates test file content
5. **Upload**: Uploads file using HTTP POST to the presigned URL
6. **Verification**: Downloads and verifies the uploaded file

### 2. API Demonstrations
Additional demos show:
- **Basic Presigned POST**: Simple conditions and form generation
- **Advanced Presigned POST**: Complex conditions, metadata, and encryption
- **HTML Form Examples**: Ready-to-use HTML forms for browser uploads
- **JavaScript Examples**: Fetch API integration code

## Example Output

```
AWS SDK S3 Presigned POST Demo (Native AOT)
===========================================
End-to-End Testing with Real S3 Operations

Setting up AWS credentials...
Verifying AWS credentials...
✓ AWS credentials verified successfully

Using bucket: s3-presigned-post-demo-20250103-143052-a1b2c3d4
Region: us-west-2

Creating S3 bucket: s3-presigned-post-demo-20250103-143052-a1b2c3d4
✓ Bucket created successfully

=== END-TO-END PRESIGNED POST DEMO ===
1. Generate presigned POST URL
2. Create test file
3. Upload file using presigned POST
4. Verify upload success

Generating presigned POST URL...
✓ Presigned POST URL generated
  Upload URL: https://s3-presigned-post-demo-20250103-143052-a1b2c3d4.s3.us-west-2.amazonaws.com/
  Object key: test-uploads/demo-20250103-143052.txt

Test file content:
----------------------------------------
Hello from S3 Presigned POST Demo!
Generated at: 2025-01-03 19:30:52 UTC
Bucket: s3-presigned-post-demo-20250103-143052-a1b2c3d4
Key: test-uploads/demo-20250103-143052.txt
This file was uploaded using AWS SDK for .NET presigned POST functionality.
----------------------------------------

Uploading file using presigned POST...
  HTTP Status: NoContent
✓ File uploaded successfully!

Verifying uploaded file...
✓ File retrieved from S3
  Size: 271 bytes
  Content-Type: text/plain
  Last Modified: 1/3/2025 7:30:53 PM +00:00
✓ File content matches expected content
```

## Building for Native AOT

### Standard Build
```bash
dotnet build
```

### AOT Publish
```bash
dotnet publish -c Release
```

### Self-Contained AOT
```bash
dotnet publish -c Release -r win-x64 --self-contained
dotnet publish -c Release -r linux-x64 --self-contained
dotnet publish -c Release -r osx-x64 --self-contained
```

## Project Structure

```
S3PostAotDemo/
├── Program.cs              # Main demo application
├── S3PostAotDemo.csproj   # Project configuration with AOT settings
└── README.md              # This file
```

## Key Implementation Details

### HTTP Upload
The demo uses `HttpClient` with `MultipartFormDataContent` to perform the actual file upload:

```csharp
using var httpClient = new HttpClient();
using var form = new MultipartFormDataContent();

// Add presigned POST form fields
foreach (var field in response.Fields)
{
    form.Add(new StringContent(field.Value), field.Key);
}

// Add file content
var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
fileContent.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
form.Add(fileContent, "file", "test-file.txt");

// Upload
var uploadResponse = await httpClient.PostAsync(response.Url, form);
```

### Error Handling
Comprehensive error handling for:
- Invalid AWS credentials
- Bucket creation failures
- Upload failures with detailed error messages
- File verification issues

### Resource Management
- Automatic unique bucket naming to avoid conflicts
- Optional cleanup of all created resources
- Proper disposal of HTTP clients and streams

## Troubleshooting

### Common Issues

1. **Credential Errors**:
   - Ensure AWS credentials are properly configured
   - Verify credentials have required S3 permissions

2. **Region Issues**:
   - Some regions require explicit bucket configuration
   - Use `--region` parameter to specify your preferred region

3. **Bucket Name Conflicts**:
   - Auto-generated names include timestamps and GUIDs to avoid conflicts
   - Use `--bucket` with a unique name if needed

4. **Upload Failures**:
   - Check AWS account limits and quotas
   - Verify network connectivity to AWS S3
   - Review error messages in console output

### Debug Information
Run with detailed error information:
```bash
dotnet run 2>&1 | tee debug.log
```

The demo provides comprehensive error messages and full exception details for troubleshooting.
