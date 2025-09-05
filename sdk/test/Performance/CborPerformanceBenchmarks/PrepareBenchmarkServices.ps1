function Update-JsonProperty {
    param (
        [Parameter(Mandatory = $true)]
        [string]$JsonFilePath,

        [Parameter(Mandatory = $true)]
        [string]$PropertyPath,

        [Parameter(Mandatory = $true)]
        [object]$Value
    )

    if (-Not (Test-Path $JsonFilePath)) {
        Write-Error "File not found: $JsonFilePath"
        return
    }

    # Read and parse the JSON file
    $json = Get-Content -Raw -Path $JsonFilePath | ConvertFrom-Json

    # Split property path
    $parts = $PropertyPath -split '\.'

    # Navigate to the target property
    $target = $json
    for ($i = 0; $i -lt $parts.Length - 1; $i++) {
        $key = $parts[$i]
        if (-Not $target.PSObject.Properties[$key]) {
            # Create the property if it doesn't exist
            $target | Add-Member -MemberType NoteProperty -Name $key -Value @{}
        }
        $target = $target.$key
    }

    # Set the final property
    $finalKey = $parts[-1]
    if ($target.PSObject.Properties[$finalKey]) {
        $target.$finalKey = $Value
    } else {
        $target | Add-Member -MemberType NoteProperty -Name $finalKey -Value $Value
    }

    # Convert back to JSON and save
    $json | ConvertTo-Json -Depth 100 | Set-Content -Path $JsonFilePath
}

Write-Host "Updating current models to use CBOR..."

Set-Location "../../../../generator"
Update-JsonProperty -JsonFilePath "./ServiceModels/monitoring/monitoring-2010-08-01.normal.json" -PropertyPath "metadata.targetPrefix" -Value "GraniteServiceVersion20100801"
Update-JsonProperty -JsonFilePath "./ServiceModels/monitoring/monitoring-2010-08-01.normal.json" -PropertyPath "metadata.protocols" -Value @("smithy-rpc-v2-cbor")
Update-JsonProperty -JsonFilePath "./ServiceModels/secretsmanager/secretsmanager-2017-10-17.normal.json" -PropertyPath "metadata.protocols" -Value @("smithy-rpc-v2-cbor")
Update-JsonProperty -JsonFilePath "./TestServiceModels/echo-service-tests-client/echo-service-2020-07-02.normal.json" -PropertyPath "metadata.protocols" -Value @("smithy-rpc-v2-cbor")


dotnet build --configuration Release
Set-Location "./ServiceClientGenerator/bin/Release"
dotnet run --project ../../../ServiceClientGenerator/ServiceClientGenerator.csproj -- /sro /sm "echo-service-tests-client;monitoring;secretsmanager"

Write-Host "Updating aws-sdk-net-old-protocols models to use old protocols..."

Set-Location "./../../../../../aws-sdk-net-old-protocols/generator"

Update-JsonProperty -JsonFilePath "./ServiceModels/monitoring/monitoring-2010-08-01.normal.json" -PropertyPath "metadata.protocols" -Value @("query")
Update-JsonProperty -JsonFilePath "./ServiceModels/secretsmanager/secretsmanager-2017-10-17.normal.json" -PropertyPath "metadata.protocols" -Value @("json")
Update-JsonProperty -JsonFilePath "./TestServiceModels/echo-service-tests-client/echo-service-2020-07-02.normal.json" -PropertyPath "metadata.protocols" -Value @("json")

dotnet build --configuration Release
Set-Location "./ServiceClientGenerator/bin/Release"
dotnet run --project ../../../ServiceClientGenerator/ServiceClientGenerator.csproj -- /sro /sm "echo-service-tests-client;monitoring;secretsmanager"

