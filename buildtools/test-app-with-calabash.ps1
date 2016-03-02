# Script parameters
Param(
    [string]
    $ApkLocation = $(Throw "Please provide a location for the signed APK"),
    [string]
    $CalabashZipLocation = $(Throw "Please provide a location for the Calabash zip archive"),
	[string]
	$ArtifactDownloadLocation = $(Throw "Please provide a location for downloading the artifactList"),
    [string]
    $TestProjectName = "TestDotNetUnity",
    [string]
    $DevicePoolName = "Top Devices",
    [int]
    $TestTimeoutMinutes = 70 
)


# Script functions

function presignedPut
{
    param(
        [string] $PresignedUrl = $(Throw "Please provide a presigned url"),
        [string] $FilePath = $(Throw "Please provide a file path"),
        [string] $ContentType = $(Throw "Please provide a content type")
    )

	Write-Host "$PresignedUrl"
	#unity apk's are huge > 90 MB in size, so we have a big timeout
    $response = Invoke-RestMethod `
        -Uri $PresignedUrl `
        -Method Put `
        -ContentType $ContentType `
        -TimeoutSec 180 `
        -InFile $FilePath
    Write-Host $response
}

function presignedGet
{
	param(
        [string] $PresignedUrl = $(Throw "Please provide a presigned url"),
        [string] $FilePath = $(Throw "Please provide a file path")
    )

	Write-Host "$PresignedUrl"
	Write-Host "$FilePath"
	
    $response = Invoke-RestMethod $PresignedUrl -OutFile $FilePath
	Write-Host $response
}

function getProjectArn
{
    param(
        [string] $ProjectName = $(Throw "Please provide a project name")
    )

    # get projects, see if one already exists
    $projects = Get-DFProjectList
    $project = $projects | where { $_.Name -eq $ProjectName } | select -First 1

    # if project doesn't exist, create a new one
    if ($project -eq $null)
    {
        $project = New-DFProject -Name $ProjectName
    }

    # return
    $project.Arn
}

function getDevicePoolArn
{
    param(
        [string] $ProjectArn = $(Throw "Please provide a project arn"),
        [string] $PoolName = $(Throw "Please provide a pool name")
    )

    $pools = Get-DFDevicePoolList -Type "CURATED" -Arn $ProjectArn
    $pool = $pools | where { $_.Name -eq $PoolName } | select -First 1

    if ($pool -eq $null)
    {
        throw "Unable to find device pool"
    }

    # return
    $pool.Arn
}

function waitUntilSucceeds
{
    param(
        [ScriptBlock] $test = $(Throw "Please provide a script block"),
        [string] $testName = $(Throw "Please provide a test name"),
        [int] $timeoutMinutes = 30,
        [int] $sleepSeconds = 30
    )

    Write-Host "Starting test $testName"
    $result = $null
    $testTimeout = New-TimeSpan -Minutes $timeoutMinutes
    $finished = $false
    $startTime = Get-Date
    do
    {
	    try
        {
            $result = $test.Invoke()
            if ($result)
            {
                Write-Host "Test succeeded with result = $result"
                $finished = $true
            }
            else
            {
                Write-Host "Attempt of $testName failed with result = $result"
            }
        }
        catch
        {
            Write-Host "Attempt of $testName failed with an exception: $_"
        }

        if (!($finished))
        {
            Write-Host "Test $testName has not yet succeeded, sleeping for $sleepSeconds seconds"
    	    Start-Sleep -Seconds $sleepSeconds
        }
	    $elapsedTime = (Get-Date).Subtract($startTime)
    } while (!($finished) -and $elapsedTime -lt $testTimeout)

    if (!($finished))
    {
	    throw "Test $testName did not complete in the allotted time"
    }

    return $result
}


# stop on errors
$ErrorActionPreference = "Stop"

# define test properties
$ContentType = "application/octet-stream"
$TestTimeout = New-TimeSpan -Minutes $TestTimeoutMinutes
$RunName = "Unity Run " + ([System.DateTime]::Now.ToFileTime())
$ApkName = Split-Path $ApkLocation -Leaf
$CalabashArchiveName = Split-Path $CalabashZipLocation -Leaf

Add-AWSLoggingListener -Name MyAWSLogs -LogFilePath c:\logs\aws.txt
Set-AWSResponseLogging Always

# AWS Device Farm is only in us-west-2
Set-DefaultAWSRegion -Region us-west-2


# get project arn (either retrieve existing or create new project)
$projectArn = getProjectArn -ProjectName $TestProjectName
# get arn for the device pool that will be used
$poolArn = getDevicePoolArn -ProjectArn $projectArn -PoolName $DevicePoolName

# upload signed APK
$apkUpload = New-DFUpload `
	-Type "ANDROID_APP" `
	-ContentType $ContentType `
	-Name $ApkName `
	-ProjectArn $projectArn
presignedPut -PresignedUrl $apkUpload.Url -FilePath $ApkLocation -ContentType $ContentType

# upload Calabash zip archive
$calabashUpload = New-DFUpload `
	-Type "CALABASH_TEST_PACKAGE" `
	-ContentType $ContentType `
	-Name $CalabashArchiveName `
	-ProjectArn $projectArn
presignedPut -PresignedUrl $calabashUpload.Url -FilePath $CalabashZipLocation -ContentType $ContentType

# wait until both uploads have been processed
waitUntilSucceeds -testName "Confirm packages are processed" -timeoutMinutes 5 -sleepSeconds 10 -test {
	$upload1 = Get-DFUpload -Arn $apkUpload.Arn
	Write-Host $upload1.Status
    $apkUploaded = $upload1.Status -eq "SUCCEEDED"
	$upload2 = Get-DFUpload -Arn $calabashUpload.Arn
	Write-Host $upload2.Status
    $calabashUploaded = $upload2.Status -eq "SUCCEEDED"
	
	if(($upload1.Status -eq "FAILED") -or $upload2.Status -eq "FAILED")
	{
		throw "Upload of apk and calabash tests failed"
	}
	
    return ($apkUploaded -and $calabashUploaded)
}


# start test run
$testRun = Submit-DFTestRun `
	-ProjectArn $projectArn `
	-Name $RunName `
	-AppArn $apkUpload.Arn `
	-DevicePoolArn $poolArn `
	-Test_Type "CALABASH" `
	-Test_TestPackageArn $calabashUpload.Arn

Write-Host "Test run ARN:" $testRun.Arn
Write-Host "Test run details:"
$testRun

# wait for test to complete
$testResults = waitUntilSucceeds -testName "Wait until tests finish"  -timeoutMinutes 70 -sleepSeconds 60 -test {
    $run = Get-DFRun -Arn $testRun.Arn
    $finished = ($run.Status -eq "COMPLETED")
    if (!($finished))
    {
        return $null
    }
    else
    {
        return $run
    }
}

$testFailed = true

if($testResults.Result -eq "PASSED")
{
	$testFailed = false;
}
else
{
	Write-Host "$testResults"
	$testFailed = true;
}

New-Item -ItemType Directory -Force -Path "$ArtifactDownloadLocation\File\"
New-Item -ItemType Directory -Force -Path "$ArtifactDownloadLocation\Log\"
New-Item -ItemType Directory -Force -Path "$ArtifactDownloadLocation\ScreenShot\"

Get-DFArtifactList -Arn $testRun.Arn -Type "FILE" | ForEach{ 
    $subPath = $_.Arn.substring($_.Arn.length-23,23).replace("/","");
	$artifactPath  = "$ArtifactDownloadLocation\File\" + $subPath
    New-Item -ItemType Directory -Force -Path $artifactPath
	$artifactDownload = $artifactPath +"\" + $_.Name +"." +$_.Extension
	presignedGet -PresignedUrl $_.Url -FilePath $artifactDownload 
}

Get-DFArtifactList -Arn $testRun.Arn -Type "LOG" | ForEach{
	$subPath = $_.Arn.substring($_.Arn.length-23,23).replace("/","");
	$artifactPath  = "$ArtifactDownloadLocation\Log\" + $subPath
    New-Item -ItemType Directory -Force -Path "$ArtifactDownloadLocation\Log\" + $_.Arn
	$artifactDownload = $artifactPath +"\"+ $_.Name +"." +$_.Extension
	presignedGet -PresignedUrl $_.Url -FilePath $artifactDownload
}

Get-DFArtifactList -Arn $testRun.Arn -Type "SCREENSHOT" | ForEach{
	$subPath = $_.Arn.substring($_.Arn.length-23,23).replace("/","");
	$artifactPath  = "$ArtifactDownloadLocation\ScreenShot\" + $subPath
	$artifactDownload = $artifactPath +"\"+ $_.Name +"." +$_.Extension
	presignedGet -PresignedUrl $_.Url -FilePath $artifactDownload
}

if($testFailed)
{
	Write-Host "Tests Failed, please check $ArtifactDownloadLocation for logs"
	exit 1
}	
