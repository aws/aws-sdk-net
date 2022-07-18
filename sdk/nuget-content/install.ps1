param($installPath, $toolsPath, $package, $project)
# This install script is based on the Newtonsoft.Json NuGet install script and is licensed under the MIT License.

# The MIT License (MIT)
#
# Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
# and associated documentation files (the "Software"), to deal in the Software without restriction, 
# including without limitation the rights to use, copy, modify, merge, publish, distribute, 
# sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
# furnished to do so, subject to the following conditions:
#
# The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
#
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING 
# BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
# IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER 
# IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


# open AWSSDK splash page on package install
# don't open if AWSSDK is installed as a dependency

try
{
  $url = "http://aws-nuget-landingpages.s3-website-us-east-1.amazonaws.com/awssdk.version.3.html?package=" + $package
  $dte2 = Get-Interface $dte ([EnvDTE80.DTE2])

  if ($dte2.ActiveWindow.Caption -eq "Package Manager Console")
  {
    # user is installing from VS NuGet console
    # get reference to the window, the console host and the input history
    # show webpage if "install-package AWSSDK" was last input

    $consoleWindow = $(Get-VSComponentModel).GetService([NuGetConsole.IPowerConsoleWindow])

    $props = $consoleWindow.GetType().GetProperties([System.Reflection.BindingFlags]::Instance -bor `
      [System.Reflection.BindingFlags]::NonPublic)

    $prop = $props | ? { $_.Name -eq "ActiveHostInfo" } | select -first 1
    if ($prop -eq $null) { return }
  
    $hostInfo = $prop.GetValue($consoleWindow)
    if ($hostInfo -eq $null) { return }

    $history = $hostInfo.WpfConsole.InputHistory.History

    $lastCommand = $history | select -last 1

    if ($lastCommand)
    {
      $lastCommand = $lastCommand.Trim().ToLower()
      if ($lastCommand.StartsWith("install-package") -and $lastCommand.Contains("awssdk"))
      {
        $dte2.ItemOperations.Navigate($url) | Out-Null
      }
    }
  }
  else
  {
    # user is installing from VS NuGet dialog
    # get reference to the window, then smart output console provider
    # show webpage if messages in buffered console contains "installing...AWSSDK" in last operation

    $instanceField = [NuGet.Dialog.PackageManagerWindow].GetField("CurrentInstance", [System.Reflection.BindingFlags]::Static -bor `
      [System.Reflection.BindingFlags]::NonPublic)

    $consoleField = [NuGet.Dialog.PackageManagerWindow].GetField("_smartOutputConsoleProvider", [System.Reflection.BindingFlags]::Instance -bor `
      [System.Reflection.BindingFlags]::NonPublic)

    if ($instanceField -eq $null -or $consoleField -eq $null) { return }

    $instance = $instanceField.GetValue($null)

    if ($instance -eq $null) { return }

    $consoleProvider = $consoleField.GetValue($instance)
    if ($consoleProvider -eq $null) { return }

    $console = $consoleProvider.CreateOutputConsole($false)

    $messagesField = $console.GetType().GetField("_messages", [System.Reflection.BindingFlags]::Instance -bor `
      [System.Reflection.BindingFlags]::NonPublic)
    if ($messagesField -eq $null) { return }

    $messages = $messagesField.GetValue($console)
    if ($messages -eq $null) { return }

    $operations = $messages -split "=============================="

    $lastOperation = $operations | select -last 1

    if ($lastOperation)
    {
      $lastOperation = $lastOperation.ToLower()

      $lines = $lastOperation -split "`r`n"

      $installMatch = $lines | ? { $_.StartsWith("------- installing...awssdk") } | select -first 1

      if ($installMatch)
      {
        $dte2.ItemOperations.Navigate($url) | Out-Null
      }
    }
  }
}
catch
{
  try
  {
    $pmPane = $dte2.ToolWindows.OutputWindow.OutputWindowPanes.Item("Package Manager")

    $selection = $pmPane.TextDocument.Selection
    $selection.StartOfDocument($false)
    $selection.EndOfDocument($true)

    if ($selection.Text.StartsWith("Installing 'awssdk"))
    {
      $dte2.ItemOperations.Navigate($url) | Out-Null
    }
  }
  catch
  {
    # stop potential errors from bubbling up
    # worst case the splash page won't open  
  }
}

function UpdateCurrentProjectsConfigFile([string]$name)
{
    $config = $project.ProjectItems | where {$_.Name -eq "Web.config"}
    if ($config -eq $null)
    {
        $config = $project.ProjectItems | where {$_.Name -eq "App.config"}
        if ($config -eq $null)
        {
            return
        }
    }
    $localPath = $config.Properties | where {$_.Name -eq "LocalPath"}
    UpdateConfigFile($localPath.Value, $name)
}

function UpdateConfigFile([string]$configFilePath, [string]$name)
{
	$references = (Select-String $configFilePath -pattern "AWSProfileName").Matches.Count

	If( $references -ne 0)
	{
		Write-Host "AWSProfileName already exists in config file"
		return
	}

	$xml = New-Object xml
    $xml.Load($configFilePath)

	$appSettingNode = $xml.SelectSingleNode("configuration/appSettings/add[@key = 'AWSProfileName']")

	
	Write-Host "Adding AWSProfileName appSetting to " $configFilePath

    $appSettingsNode = $xml.SelectSingleNode("configuration/appSettings")
    if ($appSettingsNode -eq $null)
    {
        $appSettingsNode = $xml.CreateElement("appSettings")
        $xml.DocumentElement.AppendChild($appSettingsNode)
    }

    if ($name -eq "")
    {    
        $comment = $xml.CreateComment("AWSProfileName is used to reference an account that has been registered with the SDK.`r`nIf using AWS Toolkit for Visual Studio then this value is the same value shown in the AWS Explorer.`r`nIt is also possible to register an account using the <solution-dir>/packages/AWSSDK-X.X.X.X/tools/account-management.ps1 PowerShell script`r`nthat is bundled with the nuget package under the tools folder.`r`n`r`n`t`t<add key=""AWSProfileName"" value="""" />`r`n")
        $appSettingsNode.AppendChild($comment)
    }
    
    $xml.Save($configFilePath)
}


UpdateCurrentProjectsConfigFile ""
# SIG # Begin signature block
# MIIsmgYJKoZIhvcNAQcCoIIsizCCLIcCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCD5YDSJCqst/cbt
# sDsenRhb8aFQrp5wSSSmT4bMyjoNO6CCFB0wggXAMIIEqKADAgECAhAP0bvKeWvX
# +N1MguEKmpYxMA0GCSqGSIb3DQEBCwUAMGwxCzAJBgNVBAYTAlVTMRUwEwYDVQQK
# EwxEaWdpQ2VydCBJbmMxGTAXBgNVBAsTEHd3dy5kaWdpY2VydC5jb20xKzApBgNV
# BAMTIkRpZ2lDZXJ0IEhpZ2ggQXNzdXJhbmNlIEVWIFJvb3QgQ0EwHhcNMjIwMTEz
# MDAwMDAwWhcNMzExMTA5MjM1OTU5WjBiMQswCQYDVQQGEwJVUzEVMBMGA1UEChMM
# RGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3d3cuZGlnaWNlcnQuY29tMSEwHwYDVQQD
# ExhEaWdpQ2VydCBUcnVzdGVkIFJvb3QgRzQwggIiMA0GCSqGSIb3DQEBAQUAA4IC
# DwAwggIKAoICAQC/5pBzaN675F1KPDAiMGkz7MKnJS7JIT3yithZwuEppz1Yq3aa
# za57G4QNxDAf8xukOBbrVsaXbR2rsnnyyhHS5F/WBTxSD1Ifxp4VpX6+n6lXFllV
# cq9ok3DCsrp1mWpzMpTREEQQLt+C8weE5nQ7bXHiLQwb7iDVySAdYyktzuxeTsiT
# +CFhmzTrBcZe7FsavOvJz82sNEBfsXpm7nfISKhmV1efVFiODCu3T6cw2Vbuyntd
# 463JT17lNecxy9qTXtyOj4DatpGYQJB5w3jHtrHEtWoYOAMQjdjUN6QuBX2I9YI+
# EJFwq1WCQTLX2wRzKm6RAXwhTNS8rhsDdV14Ztk6MUSaM0C/CNdaSaTC5qmgZ92k
# J7yhTzm1EVgX9yRcRo9k98FpiHaYdj1ZXUJ2h4mXaXpI8OCiEhtmmnTK3kse5w5j
# rubU75KSOp493ADkRSWJtppEGSt+wJS00mFt6zPZxd9LBADMfRyVw4/3IbKyEbe7
# f/LVjHAsQWCqsWMYRJUadmJ+9oCw++hkpjPRiQfhvbfmQ6QYuKZ3AeEPlAwhHbJU
# KSWJbOUOUlFHdL4mrLZBdd56rF+NP8m800ERElvlEFDrMcXKchYiCd98THU/Y+wh
# X8QgUWtvsauGi0/C1kVfnSD8oR7FwI+isX4KJpn15GkvmB0t9dmpsh3lGwIDAQAB
# o4IBZjCCAWIwDwYDVR0TAQH/BAUwAwEB/zAdBgNVHQ4EFgQU7NfjgtJxXWRM3y5n
# P+e6mK4cD08wHwYDVR0jBBgwFoAUsT7DaQP4v0cB1JgmGggC72NkK8MwDgYDVR0P
# AQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUFBwMDMH8GCCsGAQUFBwEBBHMwcTAk
# BggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29tMEkGCCsGAQUFBzAC
# hj1odHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNlcnRIaWdoQXNzdXJh
# bmNlRVZSb290Q0EuY3J0MEsGA1UdHwREMEIwQKA+oDyGOmh0dHA6Ly9jcmwzLmRp
# Z2ljZXJ0LmNvbS9EaWdpQ2VydEhpZ2hBc3N1cmFuY2VFVlJvb3RDQS5jcmwwHAYD
# VR0gBBUwEzAHBgVngQwBAzAIBgZngQwBBAEwDQYJKoZIhvcNAQELBQADggEBAEHx
# qRH0DxNHecllao3A7pgEpMbjDPKisedfYk/ak1k2zfIe4R7sD+EbP5HU5A/C5pg0
# /xkPZigfT2IxpCrhKhO61z7H0ZL+q93fqpgzRh9Onr3g7QdG64AupP2uU7SkwaT1
# IY1rzAGt9Rnu15ClMlIr28xzDxj4+87eg3Gn77tRWwR2L62t0+od/P1Tk+WMieNg
# GbngLyOOLFxJy34riDkruQZhiPOuAnZ2dMFkkbiJUZflhX0901emWG4f7vtpYeJa
# 3Cgh6GO6Ps9W7Zrk9wXqyvPsEt84zdp7PiuTUy9cUQBY3pBIowrHC/Q7bVUx8ALM
# R3eWUaNetbxcyEMRoacwggawMIIEmKADAgECAhAIrUCyYNKcTJ9ezam9k67ZMA0G
# CSqGSIb3DQEBDAUAMGIxCzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxEaWdpQ2VydCBJ
# bmMxGTAXBgNVBAsTEHd3dy5kaWdpY2VydC5jb20xITAfBgNVBAMTGERpZ2lDZXJ0
# IFRydXN0ZWQgUm9vdCBHNDAeFw0yMTA0MjkwMDAwMDBaFw0zNjA0MjgyMzU5NTla
# MGkxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwgSW5jLjFBMD8GA1UE
# AxM4RGlnaUNlcnQgVHJ1c3RlZCBHNCBDb2RlIFNpZ25pbmcgUlNBNDA5NiBTSEEz
# ODQgMjAyMSBDQTEwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoICAQDVtC9C
# 0CiteLdd1TlZG7GIQvUzjOs9gZdwxbvEhSYwn6SOaNhc9es0JAfhS0/TeEP0F9ce
# 2vnS1WcaUk8OoVf8iJnBkcyBAz5NcCRks43iCH00fUyAVxJrQ5qZ8sU7H/Lvy0da
# E6ZMswEgJfMQ04uy+wjwiuCdCcBlp/qYgEk1hz1RGeiQIXhFLqGfLOEYwhrMxe6T
# SXBCMo/7xuoc82VokaJNTIIRSFJo3hC9FFdd6BgTZcV/sk+FLEikVoQ11vkunKoA
# FdE3/hoGlMJ8yOobMubKwvSnowMOdKWvObarYBLj6Na59zHh3K3kGKDYwSNHR7Oh
# D26jq22YBoMbt2pnLdK9RBqSEIGPsDsJ18ebMlrC/2pgVItJwZPt4bRc4G/rJvmM
# 1bL5OBDm6s6R9b7T+2+TYTRcvJNFKIM2KmYoX7BzzosmJQayg9Rc9hUZTO1i4F4z
# 8ujo7AqnsAMrkbI2eb73rQgedaZlzLvjSFDzd5Ea/ttQokbIYViY9XwCFjyDKK05
# huzUtw1T0PhH5nUwjewwk3YUpltLXXRhTT8SkXbev1jLchApQfDVxW0mdmgRQRNY
# mtwmKwH0iU1Z23jPgUo+QEdfyYFQc4UQIyFZYIpkVMHMIRroOBl8ZhzNeDhFMJlP
# /2NPTLuqDQhTQXxYPUez+rbsjDIJAsxsPAxWEQIDAQABo4IBWTCCAVUwEgYDVR0T
# AQH/BAgwBgEB/wIBADAdBgNVHQ4EFgQUaDfg67Y7+F8Rhvv+YXsIiGX0TkIwHwYD
# VR0jBBgwFoAU7NfjgtJxXWRM3y5nP+e6mK4cD08wDgYDVR0PAQH/BAQDAgGGMBMG
# A1UdJQQMMAoGCCsGAQUFBwMDMHcGCCsGAQUFBwEBBGswaTAkBggrBgEFBQcwAYYY
# aHR0cDovL29jc3AuZGlnaWNlcnQuY29tMEEGCCsGAQUFBzAChjVodHRwOi8vY2Fj
# ZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkUm9vdEc0LmNydDBDBgNV
# HR8EPDA6MDigNqA0hjJodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vRGlnaUNlcnRU
# cnVzdGVkUm9vdEc0LmNybDAcBgNVHSAEFTATMAcGBWeBDAEDMAgGBmeBDAEEATAN
# BgkqhkiG9w0BAQwFAAOCAgEAOiNEPY0Idu6PvDqZ01bgAhql+Eg08yy25nRm95Ry
# sQDKr2wwJxMSnpBEn0v9nqN8JtU3vDpdSG2V1T9J9Ce7FoFFUP2cvbaF4HZ+N3HL
# IvdaqpDP9ZNq4+sg0dVQeYiaiorBtr2hSBh+3NiAGhEZGM1hmYFW9snjdufE5Btf
# Q/g+lP92OT2e1JnPSt0o618moZVYSNUa/tcnP/2Q0XaG3RywYFzzDaju4ImhvTnh
# OE7abrs2nfvlIVNaw8rpavGiPttDuDPITzgUkpn13c5UbdldAhQfQDN8A+KVssIh
# dXNSy0bYxDQcoqVLjc1vdjcshT8azibpGL6QB7BDf5WIIIJw8MzK7/0pNVwfiThV
# 9zeKiwmhywvpMRr/LhlcOXHhvpynCgbWJme3kuZOX956rEnPLqR0kq3bPKSchh/j
# wVYbKyP/j7XqiHtwa+aguv06P0WmxOgWkVKLQcBIhEuWTatEQOON8BUozu3xGFYH
# Ki8QxAwIZDwzj64ojDzLj4gLDb879M4ee47vtevLt/B3E+bnKD+sEq6lLyJsQfmC
# XBVmzGwOysWGw/YmMwwHS6DTBwJqakAwSEs0qFEgu60bhQjiWQ1tygVQK+pKHJ6l
# /aCnHwZ05/LWUpD9r4VIIflXO7ScA+2GRfS0YW6/aOImYIbqyK+p/pQd52MbOoZW
# eE4wggehMIIFiaADAgECAhALyko14sGCglkXWPsT8gmbMA0GCSqGSIb3DQEBCwUA
# MGkxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwgSW5jLjFBMD8GA1UE
# AxM4RGlnaUNlcnQgVHJ1c3RlZCBHNCBDb2RlIFNpZ25pbmcgUlNBNDA5NiBTSEEz
# ODQgMjAyMSBDQTEwHhcNMjExMjI4MDAwMDAwWhcNMjMwMTAzMjM1OTU5WjCB9jEd
# MBsGA1UEDwwUUHJpdmF0ZSBPcmdhbml6YXRpb24xEzARBgsrBgEEAYI3PAIBAxMC
# VVMxGTAXBgsrBgEEAYI3PAIBAhMIRGVsYXdhcmUxEDAOBgNVBAUTBzQxNTI5NTQx
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdTZWF0
# dGxlMSIwIAYDVQQKExlBbWF6b24gV2ViIFNlcnZpY2VzLCBJbmMuMRcwFQYDVQQL
# Ew5TREtzIGFuZCBUb29sczEiMCAGA1UEAxMZQW1hem9uIFdlYiBTZXJ2aWNlcywg
# SW5jLjCCAaIwDQYJKoZIhvcNAQEBBQADggGPADCCAYoCggGBAKHRLdQSyJ6AfhQ8
# U7Gi6le7gshUhu34xQ7jaTCfpKaKQRGu+oNfAYDRSSfh498eK+jFnGHU/TMzVHEg
# Bb4TUrc1e2f5LHhXAtYTJK0uis9OJ5n3MjHwOJt/uGSSMUAIIIselvbSF2mOE0lI
# z0CNMIlUiXI9O+y9+FJP7Vsg/NU/zAVsQ4Ok0GLd+Yp566nRuj9aNU+L+TxRhSHA
# 7KKjJ9oE0mVblUGQaeNrOd1Ql9djJy0pg6oT2s9Peh8lqB3tUsMaoQ/FMV0P/e1S
# 6V3yFg/I1OvQdtm29ryJTdg9ZvIV/FGnIYdW5s5T8t//nf+7LToQVhpML/ZWEhFR
# Aa6We80Y8zs9glIPDZyYmi6OPbpY7kVHa4dr8S49tPwrVMjC3hk9v9S6poDx/hR9
# kytwVt1Lo4LjAlpmKLeHVmOnn5uenpXqFOJMbTMYmciwHz8yWJwZYMKKLJPCGa79
# xaAkZj9HCop5yPUPccqjyz2i0v/Pt8yFH77s8q86e99O2a+/oQIDAQABo4ICNTCC
# AjEwHwYDVR0jBBgwFoAUaDfg67Y7+F8Rhvv+YXsIiGX0TkIwHQYDVR0OBBYEFGml
# Ip+0bnVEmnOvWcJjnCup9DbsMC4GA1UdEQQnMCWgIwYIKwYBBQUHCAOgFzAVDBNV
# Uy1ERUxBV0FSRS00MTUyOTU0MA4GA1UdDwEB/wQEAwIHgDATBgNVHSUEDDAKBggr
# BgEFBQcDAzCBtQYDVR0fBIGtMIGqMFOgUaBPhk1odHRwOi8vY3JsMy5kaWdpY2Vy
# dC5jb20vRGlnaUNlcnRUcnVzdGVkRzRDb2RlU2lnbmluZ1JTQTQwOTZTSEEzODQy
# MDIxQ0ExLmNybDBToFGgT4ZNaHR0cDovL2NybDQuZGlnaWNlcnQuY29tL0RpZ2lD
# ZXJ0VHJ1c3RlZEc0Q29kZVNpZ25pbmdSU0E0MDk2U0hBMzg0MjAyMUNBMS5jcmww
# PQYDVR0gBDYwNDAyBgVngQwBAzApMCcGCCsGAQUFBwIBFhtodHRwOi8vd3d3LmRp
# Z2ljZXJ0LmNvbS9DUFMwgZQGCCsGAQUFBwEBBIGHMIGEMCQGCCsGAQUFBzABhhho
# dHRwOi8vb2NzcC5kaWdpY2VydC5jb20wXAYIKwYBBQUHMAKGUGh0dHA6Ly9jYWNl
# cnRzLmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydFRydXN0ZWRHNENvZGVTaWduaW5nUlNB
# NDA5NlNIQTM4NDIwMjFDQTEuY3J0MAwGA1UdEwEB/wQCMAAwDQYJKoZIhvcNAQEL
# BQADggIBALlYa6PSDPPulVJbqEi7XGz23lFZwYa1PiXk+PkJO2HDXv2zep26LZri
# wBHT2yA/KbDvbwZpf4VOBKn5lQC9R+DsgwW/xZbNq7y3cWf9Ad1AQ9Do/FXfBqVO
# 1if+GpqFbqUme5wOjn8/8dc4nFR4erbDgkM4ICn/astBigYnfM5wTO+J8ex+7fE2
# D1kFAwfZAuiRNdDreVMDlYXpJMQ4CtTKVLHYentLR747zzRjO4PqgL1exvbvpOMZ
# lSDLWhaDjtKwUDb645ziHDA3DXe8K51+hIFuadKTinJa8Pfsbgg2W7aTfBdi2gTy
# XkeVJ836631Ks4KD3cXui9Jx2PWRAVxKIEvXuebZ09Mph2jiBH75urqS57i1mpS7
# OA5lIj7a7NIYsVl26PVpJUEr3LRKV8GO3tRC7KP0zE7sB7k2VQKwBXbsifq/vpcm
# eyy4OeQbZ1i8GwZLPHuygP9exTWK2o2wWByJs62Wdk6JmSREvr9Wr59BVNbQfRSR
# aF9q058bBK68hGZtDBpJ9gJX4V12DI2UpSbcGf10+afL1J4zFDv98GIGkgmfLQJU
# pJeC/FnNrEXJbINndCsOb6gdLvLX1grMdUPmPkpRZyvG3HEyEMCV5ODMItTx7K6T
# DyeZDIXXP5oBnBMK9EjtRD3XkEb9dDfuzCrdlTpEoTElt2mGuEE7MYIX0zCCF88C
# AQEwfTBpMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNlcnQsIEluYy4xQTA/
# BgNVBAMTOERpZ2lDZXJ0IFRydXN0ZWQgRzQgQ29kZSBTaWduaW5nIFJTQTQwOTYg
# U0hBMzg0IDIwMjEgQ0ExAhALyko14sGCglkXWPsT8gmbMA0GCWCGSAFlAwQCAQUA
# oHwwEAYKKwYBBAGCNwIBDDECMAAwGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQw
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIK61
# EKI3E83uBQw2QlFhFvOqB2zYRU+jUG2AWNwCS1w5MA0GCSqGSIb3DQEBAQUABIIB
# gFmxk+5K2ZDC/aFp8E1saXKAauRBXbDoshdIIZ6BwuZlpp6vGb32Y3fVkCYqc/lZ
# +yEiBTbN8tXfxYDH3pl24zX1UOL0WjkxHel46R2rbN7DiRgdzgBfwOL2jbHTBSar
# OK/riuG5nzCFiF9goM4T804l2oSIONBPYuNpG17y0Fr72CHTIV/z0+eGCf1j5HEi
# 9lM9CrusjM1zCPp/Hi1CsZbUvgRxuXjlo2rLfVcamMlppGZmIsxANr7T967KNEOR
# mdaXNISswg4NBfvnXXvi2JffPfd52MHalEajEY0IWoArmnBQrq5bxNkDN53AEYju
# 6TcqGvgCOr4FmdOibnwrLPLOg7pmhpdqJZLznhYqM+4lbBusCbb6ipnwuCRrE/gx
# 6QblODDaR6/8kEfb1US0uSDrQqZk97YNYZ7GBFs/LCK4dw4KTG4ZtmqcqKwM++bw
# laDuDH/AmElHm6qtL776SIhc1n0LqjHA0/McuWvVJQ67LOs8K1uA0+HzQezW2q92
# +aGCFSkwghUlBgorBgEEAYI3AwMBMYIVFTCCFREGCSqGSIb3DQEHAqCCFQIwghT+
# AgEDMQ0wCwYJYIZIAWUDBAIBMIHyBgsqhkiG9w0BCRABBKCB4gSB3zCB3AIBAQYK
# YIZIAYb6bAoDBTAxMA0GCWCGSAFlAwQCAQUABCCa0NNlprWUZZ5oDMcpZuM4BqYT
# LMezce4VH1Fuc8ogoQIHXaVR7cUzkBgPMjAyMjA3MTgxODQ5NDhaMAMCAQGgeaR3
# MHUxCzAJBgNVBAYTAkNBMRAwDgYDVQQIEwdPbnRhcmlvMQ8wDQYDVQQHEwZPdHRh
# d2ExFjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xKzApBgNVBAMTIkVudHJ1c3QgVGlt
# ZXN0YW1wIEF1dGhvcml0eSAtIFRTQTGggg9VMIIEKjCCAxKgAwIBAgIEOGPe+DAN
# BgkqhkiG9w0BAQUFADCBtDEUMBIGA1UEChMLRW50cnVzdC5uZXQxQDA+BgNVBAsU
# N3d3dy5lbnRydXN0Lm5ldC9DUFNfMjA0OCBpbmNvcnAuIGJ5IHJlZi4gKGxpbWl0
# cyBsaWFiLikxJTAjBgNVBAsTHChjKSAxOTk5IEVudHJ1c3QubmV0IExpbWl0ZWQx
# MzAxBgNVBAMTKkVudHJ1c3QubmV0IENlcnRpZmljYXRpb24gQXV0aG9yaXR5ICgy
# MDQ4KTAeFw05OTEyMjQxNzUwNTFaFw0yOTA3MjQxNDE1MTJaMIG0MRQwEgYDVQQK
# EwtFbnRydXN0Lm5ldDFAMD4GA1UECxQ3d3d3LmVudHJ1c3QubmV0L0NQU18yMDQ4
# IGluY29ycC4gYnkgcmVmLiAobGltaXRzIGxpYWIuKTElMCMGA1UECxMcKGMpIDE5
# OTkgRW50cnVzdC5uZXQgTGltaXRlZDEzMDEGA1UEAxMqRW50cnVzdC5uZXQgQ2Vy
# dGlmaWNhdGlvbiBBdXRob3JpdHkgKDIwNDgpMIIBIjANBgkqhkiG9w0BAQEFAAOC
# AQ8AMIIBCgKCAQEArU1LqRKGsuqjIAcVFmQqK0vRvwtKTY7tgHalZ7d4QMBzQsho
# wNtTK91euHaYNZOLGp18EzoOH1u3Hs/lJBQesYGpjX24zGtLA/ECDNyrpUAkAH90
# lKGdCCmziAv1h3edVc3kw37XamSrhRSGlVuXMlBvPci6Zgzj/L24ScF2iUkZ/cCo
# vYmjZy/Gn7xxGWC4LeksyZB2ZnuU4q941mVTXTzWnLLPKQP5L6RQstRIzgUyVYr9
# smRMDuSYB3Xbf9+5CFVghTAp+XtIpGmG4zU/HoZdenoVve8AjhUiVBcAkCaTvA5J
# aJG/+EfTnZVCwQ5N328mz8MYIWJmQ3DW1cAH4QIDAQABo0IwQDAOBgNVHQ8BAf8E
# BAMCAQYwDwYDVR0TAQH/BAUwAwEB/zAdBgNVHQ4EFgQUVeSB0RGAvtiJuQijMfmh
# JAkWuXAwDQYJKoZIhvcNAQEFBQADggEBADubj1abMOdTmXx6eadNl9cZlZD7Bh/K
# M3xGY4+WZiT6QBshJ8rmcnPyT/4xmf3IDExoU8aAghOY+rat2l098c5u9hURlIIM
# 7j+VrxGrD9cv3h8Dj1csHsm7mhpElesYT6YfzX1XEC+bBAlahLVu2B064dae0Wx5
# XnkcFMXj0EyTO2U87d89vqbllRrDtRnDvV5bu/8j72gZyxKTJ1wDLW8w0B62Gqze
# WvfRqqgnpv55gcR5mTNXuhKwqeBCbJPKVt7+bYQLCIt+jerXmCHG8+c8eS9enNFM
# FY3h7CI3zJpDC5fcgJCNs2ebb0gIFVbPv/ErfF6adulZkMV8gzURZVEwggUTMIID
# +6ADAgECAgxY2hP/AAAAAFHODfcwDQYJKoZIhvcNAQELBQAwgbQxFDASBgNVBAoT
# C0VudHJ1c3QubmV0MUAwPgYDVQQLFDd3d3cuZW50cnVzdC5uZXQvQ1BTXzIwNDgg
# aW5jb3JwLiBieSByZWYuIChsaW1pdHMgbGlhYi4pMSUwIwYDVQQLExwoYykgMTk5
# OSBFbnRydXN0Lm5ldCBMaW1pdGVkMTMwMQYDVQQDEypFbnRydXN0Lm5ldCBDZXJ0
# aWZpY2F0aW9uIEF1dGhvcml0eSAoMjA0OCkwHhcNMTUwNzIyMTkwMjU0WhcNMjkw
# NjIyMTkzMjU0WjCBsjELMAkGA1UEBhMCVVMxFjAUBgNVBAoTDUVudHJ1c3QsIElu
# Yy4xKDAmBgNVBAsTH1NlZSB3d3cuZW50cnVzdC5uZXQvbGVnYWwtdGVybXMxOTA3
# BgNVBAsTMChjKSAyMDE1IEVudHJ1c3QsIEluYy4gLSBmb3IgYXV0aG9yaXplZCB1
# c2Ugb25seTEmMCQGA1UEAxMdRW50cnVzdCBUaW1lc3RhbXBpbmcgQ0EgLSBUUzEw
# ggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDZI+YUpOh8S4VxWPv4geZy
# i11Gw4gAHzjQiuHWblYw5a/aZFB9whM5+71mtNqE+4PQKB/LduhgUGmb885PE+LB
# PsHfEssyo/heRCIOzDrpjUm5YHTI3lQ9QV5DXyhGqaa3yhArIrxbTVuMF2UShv0s
# d9XFoIzKwoPgR1d853CuYkUnMRgK1MCkGFVS92DGBEuz3WgybhAfNBG4Enhk8e6p
# 4PfjsSKPNFply4r04UVQdN+Tl6Y05tBMO583SVKnU06fLmdc7Zb8pb90UYjjqo69
# 2bEvX1AwFvRRYCJrmcv/4VQ7uftEOKUIOSObaUf6PMTQ56rfRrLs8ooZrCmyOJV1
# AgMBAAGjggEjMIIBHzASBgNVHRMBAf8ECDAGAQH/AgEAMA4GA1UdDwEB/wQEAwIB
# BjA7BgNVHSAENDAyMDAGBFUdIAAwKDAmBggrBgEFBQcCARYaaHR0cDovL3d3dy5l
# bnRydXN0Lm5ldC9ycGEwMwYIKwYBBQUHAQEEJzAlMCMGCCsGAQUFBzABhhdodHRw
# Oi8vb2NzcC5lbnRydXN0Lm5ldDAyBgNVHR8EKzApMCegJaAjhiFodHRwOi8vY3Js
# LmVudHJ1c3QubmV0LzIwNDhjYS5jcmwwEwYDVR0lBAwwCgYIKwYBBQUHAwgwHQYD
# VR0OBBYEFMPCcdJ712gFrjs5mzQlDGIDx1doMB8GA1UdIwQYMBaAFFXkgdERgL7Y
# ibkIozH5oSQJFrlwMA0GCSqGSIb3DQEBCwUAA4IBAQAdJOeadFuqcPyxDjFF1ywA
# f2Y6K6CaNKqsY22J+Z/fDXf9JCP8T5y3b4/z9B+2wf3WHMSMiGbBY426V3fTuBoe
# yFGtzGA2GodqKOoRZd7MPCyMdLfoUEPTzCjoFWwRKp8UlSnJBVe1ZzboPKmD70HB
# IRbTfvctEUdmdmCCEmmMdlVzD98vS13pbCP4B/a1fdZpRZxYfWEu/HhLQ06JkUZE
# LKBTqEWh9hZYu5ET8kvF3wvA564per1Fs+dwMOc0jut69tO10d5rE5lGs4vSTZN1
# tfFvv9wAKMIlv7zno2U07D8NHZeM+qqIIqQYNdsFjnbjEMgpj2PQrqwY2drEn1ES
# MIIGDDCCBPSgAwIBAgIRAI3OFfOnlMWHAAAAAFWSM/QwDQYJKoZIhvcNAQELBQAw
# gbIxCzAJBgNVBAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSgwJgYDVQQL
# Ex9TZWUgd3d3LmVudHJ1c3QubmV0L2xlZ2FsLXRlcm1zMTkwNwYDVQQLEzAoYykg
# MjAxNSBFbnRydXN0LCBJbmMuIC0gZm9yIGF1dGhvcml6ZWQgdXNlIG9ubHkxJjAk
# BgNVBAMTHUVudHJ1c3QgVGltZXN0YW1waW5nIENBIC0gVFMxMB4XDTIwMDcyMjE1
# MzMyOVoXDTMwMTIyOTE2MjkyM1owdTELMAkGA1UEBhMCQ0ExEDAOBgNVBAgTB09u
# dGFyaW8xDzANBgNVBAcTBk90dGF3YTEWMBQGA1UEChMNRW50cnVzdCwgSW5jLjEr
# MCkGA1UEAxMiRW50cnVzdCBUaW1lc3RhbXAgQXV0aG9yaXR5IC0gVFNBMTCCAiIw
# DQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAMo+7CRi4ff+39E2qTdm1nkXFJRC
# AKSGl7gnjOtPqffTruKrMAQIKF+bU6aHii3dAlJftbjltlDwnKsSwe4aVniKbkQ/
# qYqP19tT2cZHyAzcRlcAZwYXGoW3QKqvdgfnkF+UktWu1tfNeaHFNStEhF9JHNVz
# uIGNcpQCaqnPVpKqNpTDUMlWl4hc4X9f/fvfFI49qyQN9nuPavpuHvqVvX2Q+ORC
# FL9VXgRUkzFD98PnwgURaKxAaccjN+xaTCnJ3zWzfklOxnrbzsIllJ43P4jsJE05
# j3/vFWtUTHHxDSF8WnXQh1OJoFvgHfucB8CoobQi0GKkxxd/N07OLTpY4+XwJoZN
# QgefvqPiGaJrcqVGv8tkWyXIRfTe6Dy2/ZzzoO+DQXw2cJDDUmKwx389e+WWh6VW
# /w7qSQXftN0Tb0XTm8gjeSowmZ2Z3MzNpS6BU1Ii8tA9ojdSkZFGcNbFSwX/TvTc
# ZAaX/nyQhievnzRVSImrIsB1B4wh2QTTHKfqbaTJUivixAKJMF7nmzHmOWWtca3v
# Z1vcoyTtDebiqXo6GFXe8EYuNE0aTZiADU7RbIV1uAPCANUiSibRjt3ttdQn1jp8
# Z2mG11Q/l89kvpGrbradGRB5tZcO9NGFyeSux8C0qgfEH8E6V5/NDqZ65RWGsqr0
# opMsz4z3UfrdjNBJAgMBAAGjggFXMIIBUzAOBgNVHQ8BAf8EBAMCB4AwFgYDVR0l
# AQH/BAwwCgYIKwYBBQUHAwgwQQYDVR0gBDowODA2BgpghkgBhvpsCgMFMCgwJgYI
# KwYBBQUHAgEWGmh0dHA6Ly93d3cuZW50cnVzdC5uZXQvcnBhMAkGA1UdEwQCMAAw
# aAYIKwYBBQUHAQEEXDBaMCMGCCsGAQUFBzABhhdodHRwOi8vb2NzcC5lbnRydXN0
# Lm5ldDAzBggrBgEFBQcwAoYnaHR0cDovL2FpYS5lbnRydXN0Lm5ldC90czEtY2hh
# aW4yNTYuY2VyMDEGA1UdHwQqMCgwJqAkoCKGIGh0dHA6Ly9jcmwuZW50cnVzdC5u
# ZXQvdHMxY2EuY3JsMB8GA1UdIwQYMBaAFMPCcdJ712gFrjs5mzQlDGIDx1doMB0G
# A1UdDgQWBBQtVoDvjvdKQxxDobXe2deoqmsmKDANBgkqhkiG9w0BAQsFAAOCAQEA
# WEvO2P6B11HYx1yNktJOlR6FhkPt4BrmmiFCM13jkb74UHx2jCWpQdSEmejooraZ
# l2iiIL0yqKopfAp2Gp/IVY6r03vU435ZfpJwOQ/t9i/zT/90XPPnMDRAoxGja3Kk
# MhEFfP2Ri0eoVzZSx/q1RYTRsj5C5RZe3QPTqf09cGd62hPghIJnOGBWw62wiOEK
# N35igQa7IwTvWKAjqNEJYzDN2Rk49Otad1i+X7/rlC3/LwQwZBCPPllWLjo2Tw48
# lg+Pyep+f0kyH6Nfbtoin9fZFzlZ3kgXegJLWHH/twwtofBnoxHc98m82R7LbAwV
# J3hIFmss8a2XuHVsu5XDjjGCBJowggSWAgEBMIHIMIGyMQswCQYDVQQGEwJVUzEW
# MBQGA1UEChMNRW50cnVzdCwgSW5jLjEoMCYGA1UECxMfU2VlIHd3dy5lbnRydXN0
# Lm5ldC9sZWdhbC10ZXJtczE5MDcGA1UECxMwKGMpIDIwMTUgRW50cnVzdCwgSW5j
# LiAtIGZvciBhdXRob3JpemVkIHVzZSBvbmx5MSYwJAYDVQQDEx1FbnRydXN0IFRp
# bWVzdGFtcGluZyBDQSAtIFRTMQIRAI3OFfOnlMWHAAAAAFWSM/QwCwYJYIZIAWUD
# BAIBoIIBpjAaBgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQwHAYJKoZIhvcNAQkF
# MQ8XDTIyMDcxODE4NDk0OFowKQYJKoZIhvcNAQk0MRwwGjALBglghkgBZQMEAgGh
# CwYJKoZIhvcNAQELMC8GCSqGSIb3DQEJBDEiBCAC7OFFgMx/KZGYMe8xeO+ANuS+
# czaEvW2AeBbx+tFCljCCAQwGCyqGSIb3DQEJEAIvMYH8MIH5MIH2MIHzBCCVCib9
# x8AgGOn3kalcOPJu7z2kMmfKsM0VpVWvYxByyTCBzjCBuKSBtTCBsjELMAkGA1UE
# BhMCVVMxFjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xKDAmBgNVBAsTH1NlZSB3d3cu
# ZW50cnVzdC5uZXQvbGVnYWwtdGVybXMxOTA3BgNVBAsTMChjKSAyMDE1IEVudHJ1
# c3QsIEluYy4gLSBmb3IgYXV0aG9yaXplZCB1c2Ugb25seTEmMCQGA1UEAxMdRW50
# cnVzdCBUaW1lc3RhbXBpbmcgQ0EgLSBUUzECEQCNzhXzp5TFhwAAAABVkjP0MAsG
# CSqGSIb3DQEBCwSCAgBl9CbuwgM5qS8/vW3GYmVqEmkIRJmRV8y0+ddJ9WQ/Es+m
# 32rd9T1jL4YsIkeDfKMLGv2uCLHMvLzeLIFBh0ns2tSMgHGJ0hgXq4GRS1AxFnXL
# feFxIicJTr/LCDFiK7jVozOfHztlpITiujauWvMFPC7cCsDuR+2LdLNUbE3jvuex
# EWiTCNVKxFuaoAnO12MUJQwluhDIk6/k3eWoUgfOxEOVrG4awF84FkTM2Hd0jv7s
# 13lDrQyUx3XRL6rGyb6Sp+4dDwa0S3oh3T5qA8HCmJ21Wuab8M1ybt+yQBWVu1Ab
# 2aQuBwCYAjlK4zOxZbyYJjfb5+4ko8tANmHjArS0x0aazdEAmARaA3Diu66bE7r0
# MY8nvXS8MK+rxeOejDwb7p60rQDKc2eqev3Y5nkSER7uoXPuo22TU2B0kvYlXwQF
# cvGZShtNrXfNT4QKF3/C2TknGgkEWpa0YIGhRrg7S5tpQAT3Qg/EBgPkSWUQDDwX
# uJ+Y97rB47a0AIHcLyN6CB8qDfWtiXsozDb4FP1v47B7/gEKDeSMlIknyC2a2EOc
# ynU1bLmIiJQ/l/e/P7ADTrV+x90DYY6FdX8ZPi2XJcXczk5O9NHf38SKa+j3UyOI
# YFXGeM1qWmNRUlNh2O9GgXGskqN12Xl3I74Tmm5upC4QTAf8NN7btCW/xBQF6A==
# SIG # End signature block
