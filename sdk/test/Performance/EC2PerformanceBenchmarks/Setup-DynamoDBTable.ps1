<#
.SYNOPSIS
    Creates a DynamoDB table for benchmark testing.
.DESCRIPTION
    Creates a provisioned DynamoDB table for the DynamoDB latency benchmarks.
    The benchmarks measure PutItem and GetItem operations with 1KiB items.

    Requirements:
      - Partition key: pk (String)
      - Billing mode: PROVISIONED (5000 RCU / 5000 WCU) for consistent performance
      - Region: us-east-1

    After benchmarks are complete, use Cleanup-DynamoDBTable.ps1 to delete the table.
.PARAMETER TableName
    The name of the DynamoDB table to create. Default: dotnet-sdk-benchmark
.PARAMETER Region
    The AWS region. Default: us-east-1
.PARAMETER ReadCapacity
    Read capacity units. Default: 5000
.PARAMETER WriteCapacity
    Write capacity units. Default: 5000
#>
param(
    [string]$TableName = "dotnet-sdk-benchmark",
    [string]$Region = "us-east-1",
    [int]$ReadCapacity = 5000,
    [int]$WriteCapacity = 5000
)

Write-Host "Creating DynamoDB table '$TableName' in $Region..."
Write-Host "  Partition key: pk (String)"
Write-Host "  Provisioned: $ReadCapacity RCU / $WriteCapacity WCU"

aws dynamodb create-table `
    --table-name $TableName `
    --attribute-definitions "AttributeName=pk,AttributeType=S" `
    --key-schema "AttributeName=pk,KeyType=HASH" `
    --provisioned-throughput "ReadCapacityUnits=$ReadCapacity,WriteCapacityUnits=$WriteCapacity" `
    --region $Region

if ($LASTEXITCODE -ne 0) {
    Write-Error "Failed to create table '$TableName'"
    exit 1
}

Write-Host "Waiting for table to become active..."
aws dynamodb wait table-exists --table-name $TableName --region $Region

Write-Host "Table '$TableName' is now active."
Write-Host ""
Write-Host "Set the environment variable before running benchmarks:"
Write-Host "  `$env:DYNAMODB_BENCHMARK_TABLE = '$TableName'"
