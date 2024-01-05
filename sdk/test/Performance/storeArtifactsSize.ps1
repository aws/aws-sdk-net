if (Get-Module -ListAvailable -Name AWS.Tools.CloudWatch) {
  Import-Module AWS.Tools.CloudWatch
} 
else {
  Install-Module AWS.Tools.CloudWatch -Force -AllowClobber
  Import-Module AWS.Tools.CloudWatch
}

Function SaveArtifactsSizeToCloudWatch {
  [CmdletBinding()]
  Param
  (
    [Parameter(Mandatory = $true)]
    [string]
    $BuildPath
  )
  Process {
    $AssembliesPath = $BuildPath + "/assemblies";

    if (Test-Path -Path $AssembliesPath) {
      # Use Deployment folder structure
      $BuildFolders = Get-ChildItem $AssembliesPath
      ForEach ($BuildFolder in $BuildFolders) {
        SaveBuildFolderToCloudWatch $BuildFolder
      }
      SaveBuildFolderToCloudWatch (Get-Item ($BuildPath + "/nuget"))
    }
    else {
      # Use sdk\src folder structure
      $ServicesFolders = (Get-ChildItem ($BuildPath + "/Services")) + (Get-Item ($BuildPath + "/Core"))
      ForEach ($ServiceFolder in $ServicesFolders) {
        $BuildFolders = Get-ChildItem ($ServiceFolder.FullName + "/bin/Release")
  
        ForEach ($BuildFolder in $BuildFolders) {
          SaveBuildFolderToCloudWatch $BuildFolder
        }
      }
    }
  }
}

Function SaveBuildFolderToCloudWatch {
  Param
  (
    [Parameter(Mandatory = $true)]
    $BuildFolder
  )
  Process {
    $BuildFilesExtensions = "dll|pdb|xml|json|nupkg"
    $BuildFiles = (Get-ChildItem $BuildFolder.FullName).where{ $_ -match $BuildFilesExtensions }
    
    ForEach ($File in $BuildFiles) {
      If (-Not $File.Name.StartsWith('AWS', 'CurrentCultureIgnoreCase') ) { continue }

      $Metric = New-Object -TypeName Amazon.CloudWatch.Model.MetricDatum
          
      $Metric.Timestamp = [DateTime]::UtcNow
      $Metric.MetricName = "Size"
          
      $Metric.Value = $File.Length
      $Metric.Unit = "Bytes"

      $fileNameDimension = [Amazon.CloudWatch.Model.Dimension]::new()
      $fileNameDimension.Name = "File Name"
      $fileNameDimension.Value = $File.Name

      $FileNameParts = $File.Name.Split(".")
      $serviceDimension = [Amazon.CloudWatch.Model.Dimension]::new()
      $serviceDimension.Name = "Service Name"
      $serviceDimension.Value = If ($FileNameParts[0] -eq "AWSSDK") { $FileNameParts[1] } Else { $FileNameParts[0] }
          
      $targetFramework = [Amazon.CloudWatch.Model.Dimension]::new()
      $targetFramework.Name = "Target Framework"
      $targetFramework.Value = $BuildFolder.Name

      $Metric.Dimensions = $fileNameDimension, $serviceDimension, $targetFramework

      Write-Host About to push $Metric.Value $targetFramework.Value for $File.Name
      Write-CWMetricData -Namespace "SDK Artifacts Size" -MetricData $Metric
    }
  }
}

SaveArtifactsSizeToCloudWatch $args[0]
