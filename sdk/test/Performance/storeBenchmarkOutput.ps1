if (Get-Module -ListAvailable -Name AWS.Tools.CloudWatch) {
  Import-Module AWS.Tools.CloudWatch
} 
else {
  Install-Module AWS.Tools.CloudWatch -Force -AllowClobber
  Import-Module AWS.Tools.CloudWatch
}

Function SaveToCloudWatch {
  [CmdletBinding()]
  Param
  (
    # The root folder containing the core runtime or a service
    [Parameter(Mandatory = $true)]
    [string]
    $ResultsCSV,
    [Parameter(Mandatory = $false)]
    [string]
    $ExecutionEnvironment
  )

  Process {
    if ($null -eq $ExecutionEnvironment) {
      $ExecutionEnvironment = [Environment]::GetEnvironmentVariable("AWS_EXECUTION_ENV")
    }

    $namespace = switch ($ExecutionEnvironment) {
      { [string]::IsNullOrEmpty($_) } { "EC2PerformanceBenchmarks" }
      "AWS_ECS_EC2" { "ECS EC2 Performance Benchmarks" }
      "AWS_ECS_FARGATE" { "ECS Fargate Performance Benchmarks" }
      { $_ -like "AWS_Lambda" } { "Lambda Performance Benchmarks" }
      default { throw "Unhandled execution environment: $_" }
    }

    $results = Import-CSV $ResultsCSV

    ForEach ($result in $results) {
      $method = $($result.Method)
      $platform = $($result.Platform)
      $runtime = $($result.Runtime)
      $meanWithUnits = $($result.Mean)
      $p50WithUnits = $($result.P50)
      $p90WithUnits = $($result.P90)
      $p95WithUnits = $($result.P95)
      $stdDevWithUnits = $($result.StdDev)
      $lambdaRuntime = $($result.LambdaRuntime)
      $lambdaArchitecture = $($result.Architecture)
      $lambdaMemorySize = $($result.MemorySize)
      $dynamoDBModelType = $($result.DynamoDBModelType)

      Write-Host $method took $meanWithUnits mean on $platform on $runtime


      $methodDimension = [Amazon.CloudWatch.Model.Dimension]::new()
      $methodDimension.Name = 'Method'
      $methodDimension.Value = $method
      
      $platformDimension = [Amazon.CloudWatch.Model.Dimension]::new()
      $platformDimension.Name = 'Platform'
      $platformDimension.Value = $platform

      $runtimeDimension = [Amazon.CloudWatch.Model.Dimension]::new()
      $runtimeDimension.Name = 'Runtime'
      $runtimeDimension.Value = $runtime

      $Dimensions = @($methodDimension, $platformDimension, $runtimeDimension)
          
      if ($null -ne $lambdaRuntime) {
        $lambdaRuntimeDimension = [Amazon.CloudWatch.Model.Dimension]::new()
        $lambdaRuntimeDimension.Name = 'Lambda Runtime'
        $lambdaRuntimeDimension.Value = $lambdaRuntime
        $Dimensions += $lambdaRuntimeDimension
      }

      if ($null -ne $lambdaMemorySize) {
        $lambdaMemorySizeDimension = [Amazon.CloudWatch.Model.Dimension]::new()
        $lambdaMemorySizeDimension.Name = 'Lambda MemorySize'
        $lambdaMemorySizeDimension.Value = $lambdaMemorySize
        $Dimensions += $lambdaMemorySizeDimension
      }

      if ($null -ne $lambdaArchitecture) {
        $lambdaArchitectureDimension = [Amazon.CloudWatch.Model.Dimension]::new()
        $lambdaArchitectureDimension.Name = 'Lambda Architecture'
        $lambdaArchitectureDimension.Value = $lambdaArchitecture
        $Dimensions += $lambdaArchitectureDimension
      }

      if ($null -ne $dynamoDBModelType) {
        $dynamoDBModelTypeDimension = [Amazon.CloudWatch.Model.Dimension]::new()
        $dynamoDBModelTypeDimension.Name = 'DynamoDB Model Type'
        $dynamoDBModelTypeDimension.Value = $dynamoDBModelType
        $Dimensions += $dynamoDBModelTypeDimension
      }

      Write-Host About to push $meanWithUnits for $method to namespace $namespace
      
      $Metrics = @()
      $Metrics += (GetMetricDatum 'Mean' $meanWithUnits $Dimensions)
      $Metrics += (GetMetricDatum 'P50' $p50WithUnits $Dimensions)
      $Metrics += (GetMetricDatum 'P90' $p90WithUnits $Dimensions)
      $Metrics += (GetMetricDatum 'P95' $p95WithUnits $Dimensions)
      $Metrics += (GetMetricDatum 'StdDev' $stdDevWithUnits $Dimensions)

      Write-CWMetricData -Namespace $namespace -MetricData $Metrics
    }
  }
}

Function GetMetricDatum {
  Param
  (
    [Parameter(Mandatory = $true)]
    $MetricName,
    [Parameter(Mandatory = $true)]
    $MetricWithUnit,
    [Parameter(Mandatory = $true)]
    $Dimensions

  )
  Process {
    $units = $MetricWithUnit.substring($MetricWithUnit.length - 2)
    $rawValue = [int]$MetricWithUnit.substring(0, $MetricWithUnit.length - 3)
        
    $Metric = New-Object -TypeName Amazon.CloudWatch.Model.MetricDatum
    #convert all values in terms of milliseconds
    if ($units -eq "ms") {
      $Metric.Value = $rawValue
      $Metric.Unit = "Milliseconds"
    }
    
    $Metric.Timestamp = [DateTime]::UtcNow
    $Metric.MetricName = $MetricName
    
    $Metric.Dimensions = $Dimensions

    return $Metric
  }
}

SaveToCloudWatch $args[0] $args[1]