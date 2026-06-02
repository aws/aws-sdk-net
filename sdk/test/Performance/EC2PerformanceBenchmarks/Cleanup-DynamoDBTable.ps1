<#
.SYNOPSIS
    Deletes a DynamoDB table used for benchmark testing.
.DESCRIPTION
    Cleanup script for the DynamoDB latency benchmarks.
    Run this after completing benchmarks to avoid ongoing costs.
    The table was created by Setup-DynamoDBTable.ps1.
.PARAMETER TableName
    The name of the DynamoDB table to delete. Default: dotnet-sdk-benchmark
.PARAMETER Region
    The AWS region. Default: us-east-1
#>
param(
    [string]$TableName = "dotnet-sdk-benchmark",
    [string]$Region = "us-east-1"
)

Write-Host "Deleting DynamoDB table '$TableName' in $Region..."

aws dynamodb delete-table --table-name $TableName --region $Region

if ($LASTEXITCODE -ne 0) {
    Write-Warning "Failed to delete table '$TableName' (it may not exist)"
} else {
    Write-Host "Table '$TableName' deletion initiated."
}
