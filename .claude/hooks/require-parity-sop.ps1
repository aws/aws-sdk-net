# Runs when generator/ServiceModels/_smithy-migrated-services.json is edited. Injects the parity
# requirement into the session, but only when a service was ADDED — removing a name reverts that
# service to C2J, which needs no parity report.
#
# Baseline is main, which always holds the currently-migrated list, so an addition stays detected
# for the whole life of a migration branch regardless of what has been committed on it.
#
# Wired from .claude/settings.json as a PostToolUse hook filtered with `if`, so it does not run on
# unrelated work. Test standalone with: pwsh -NoProfile -File .claude/hooks/require-parity-sop.ps1

$ErrorActionPreference = 'Stop'

$file = 'generator/ServiceModels/_smithy-migrated-services.json'

if (-not (Test-Path $file)) { exit 0 }

# Stay silent on a malformed file rather than erroring: the edit may be mid-flight.
try {
    $current = @((Get-Content $file -Raw | ConvertFrom-Json).services)
} catch {
    exit 0
}

# Compare against main. If it does not resolve there is no baseline, so stay silent rather than
# flagging every already-migrated service.
$baseline = $null
foreach ($ref in @('origin/main', 'main')) {
    try {
        $show = git show "${ref}:$file" 2>$null
        if ($LASTEXITCODE -eq 0 -and $show) {
            $baseline = @(($show | ConvertFrom-Json).services)
            break
        }
    } catch { }
}

if ($null -eq $baseline) { exit 0 }

$added = @($current | Where-Object { $_ -notin $baseline })
if ($added.Count -eq 0) { exit 0 }

$names = $added -join ', '

$response = @{
    hookSpecificOutput = @{
        hookEventName     = 'PostToolUse'
        additionalContext = @"
Added to the Smithy migration list: $names

Before reporting this migration as done, invoke the verify-smithy-service-parity skill and follow it.
Its verdict defaults to NOT VERIFIED and only becomes VERIFIED once every step has pasted output.

Do not state that the service is API-compatible, clean, or unblocked without that evidence.
AssemblyComparer passing is not sufficient on its own: it does not compare custom-attribute
argument values, so a dropped attribute argument passes it while still breaking the public API.
"@
    }
} | ConvertTo-Json -Depth 4 -Compress

Write-Output $response
