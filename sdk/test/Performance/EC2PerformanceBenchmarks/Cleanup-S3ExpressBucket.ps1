<#
.SYNOPSIS
    Deletes an S3 Express One Zone directory bucket and all its objects.
.DESCRIPTION
    Cleanup script for the S3 throughput benchmarks.
    Run this after completing benchmarks to avoid ongoing costs.
    The bucket was created by Setup-S3ExpressBucket.ps1.
.PARAMETER BucketName
    The bucket name to delete.
.PARAMETER Region
    The AWS region. Default: us-east-1
.EXAMPLE
    .\Cleanup-S3ExpressBucket.ps1 -BucketName "my-team-benchmark--use1-az4--x-s3"
#>
param(
    [Parameter(Mandatory=$true)]
    [string]$BucketName,
    [string]$Region = "us-east-1"
)

Write-Host "Deleting all objects in bucket '$BucketName'..."

# List and delete objects in batches
$hasMore = $true
while ($hasMore) {
    $objects = aws s3api list-objects-v2 --bucket $BucketName --max-keys 1000 --region $Region 2>$null | ConvertFrom-Json
    if ($null -eq $objects -or $null -eq $objects.Contents -or $objects.Contents.Count -eq 0) {
        $hasMore = $false
        break
    }

    $deleteObjects = @{
        Objects = $objects.Contents | ForEach-Object { @{ Key = $_.Key } }
    } | ConvertTo-Json -Depth 3 -Compress

    aws s3api delete-objects --bucket $BucketName --delete $deleteObjects --region $Region | Out-Null

    if (-not $objects.IsTruncated) {
        $hasMore = $false
    }
}

Write-Host "Deleting bucket '$BucketName'..."
aws s3api delete-bucket --bucket $BucketName --region $Region

if ($LASTEXITCODE -ne 0) {
    Write-Warning "Failed to delete bucket '$BucketName'"
} else {
    Write-Host "Bucket '$BucketName' deleted successfully."
}
