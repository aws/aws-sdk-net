<#
.SYNOPSIS
    Creates an S3 Express One Zone directory bucket for benchmark testing.
.DESCRIPTION
    Creates an S3 Express One Zone directory bucket for the S3 throughput benchmarks.
    The benchmarks measure PutObject and GetObject with 256KiB objects, 10,000 operations
    per batch under high concurrency.

    Requirements:
      - Bucket type: Directory bucket (S3 Express One Zone)
      - Availability zone: use1-az4
      - Bucket name format: <name>--use1-az4--x-s3
      - Lifecycle rules: Objects expire after 1 day
      - Region: us-east-1

    After benchmarks are complete, use Cleanup-S3ExpressBucket.ps1 to delete the bucket.
.PARAMETER BucketName
    The bucket name. Must end with --<az>--x-s3 for S3 Express.
.PARAMETER Region
    The AWS region. Default: us-east-1
.EXAMPLE
    .\Setup-S3ExpressBucket.ps1 -BucketName "my-team-benchmark--use1-az4--x-s3"
#>
param(
    [Parameter(Mandatory=$true)]
    [string]$BucketName,
    [string]$Region = "us-east-1"
)

Write-Host "Creating S3 Express One Zone directory bucket '$BucketName' in $Region..."

$config = @{
    Location = @{
        Type = "AvailabilityZone"
        Name = "use1-az4"
    }
    Bucket = @{
        Type = "Directory"
        DataRedundancy = "SingleAvailabilityZone"
    }
} | ConvertTo-Json -Depth 3 -Compress

aws s3api create-bucket `
    --bucket $BucketName `
    --region $Region `
    --create-bucket-configuration $config

if ($LASTEXITCODE -ne 0) {
    Write-Error "Failed to create bucket '$BucketName'"
    exit 1
}

Write-Host "Bucket '$BucketName' created successfully."

# Add lifecycle rule to expire objects after 1 day
$lifecycle = @{
    Rules = @(
        @{
            ID = "ExpireAfter1Day"
            Status = "Enabled"
            Expiration = @{
                Days = 1
            }
            Filter = @{
                Prefix = ""
            }
        }
    )
} | ConvertTo-Json -Depth 4 -Compress

Write-Host "Adding lifecycle rule to expire objects after 1 day..."
aws s3api put-bucket-lifecycle-configuration `
    --bucket $BucketName `
    --lifecycle-configuration $lifecycle `
    --region $Region

if ($LASTEXITCODE -eq 0) {
    Write-Host "Lifecycle rule added successfully."
} else {
    Write-Warning "Failed to add lifecycle rule (S3 Express may not support lifecycle rules)."
}

Write-Host ""
Write-Host "Set the environment variable before running benchmarks:"
Write-Host "  `$env:S3_BENCHMARK_BUCKET = '$BucketName'"
