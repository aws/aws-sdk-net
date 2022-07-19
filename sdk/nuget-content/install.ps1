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
# MIIsmwYJKoZIhvcNAQcCoIIsjDCCLIgCAQExDzANBglghkgBZQMEAgEFADB5Bgor
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
# DyeZDIXXP5oBnBMK9EjtRD3XkEb9dDfuzCrdlTpEoTElt2mGuEE7MYIX1DCCF9AC
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
# +aGCFSowghUmBgorBgEEAYI3AwMBMYIVFjCCFRIGCSqGSIb3DQEHAqCCFQMwghT/
# AgEDMQ0wCwYJYIZIAWUDBAIBMIHzBgsqhkiG9w0BCRABBKCB4wSB4DCB3QIBAQYK
# YIZIAYb6bAoDBTAxMA0GCWCGSAFlAwQCAQUABCCa0NNlprWUZZ5oDMcpZuM4BqYT
# LMezce4VH1Fuc8ogoQIITHlyBzV89QgYDzIwMjIwNzE5MTQ1NTMyWjADAgEBoHmk
# dzB1MQswCQYDVQQGEwJDQTEQMA4GA1UECBMHT250YXJpbzEPMA0GA1UEBxMGT3R0
# YXdhMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSswKQYDVQQDEyJFbnRydXN0IFRp
# bWVzdGFtcCBBdXRob3JpdHkgLSBUU0ExoIIPVTCCBCowggMSoAMCAQICBDhj3vgw
# DQYJKoZIhvcNAQEFBQAwgbQxFDASBgNVBAoTC0VudHJ1c3QubmV0MUAwPgYDVQQL
# FDd3d3cuZW50cnVzdC5uZXQvQ1BTXzIwNDggaW5jb3JwLiBieSByZWYuIChsaW1p
# dHMgbGlhYi4pMSUwIwYDVQQLExwoYykgMTk5OSBFbnRydXN0Lm5ldCBMaW1pdGVk
# MTMwMQYDVQQDEypFbnRydXN0Lm5ldCBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eSAo
# MjA0OCkwHhcNOTkxMjI0MTc1MDUxWhcNMjkwNzI0MTQxNTEyWjCBtDEUMBIGA1UE
# ChMLRW50cnVzdC5uZXQxQDA+BgNVBAsUN3d3dy5lbnRydXN0Lm5ldC9DUFNfMjA0
# OCBpbmNvcnAuIGJ5IHJlZi4gKGxpbWl0cyBsaWFiLikxJTAjBgNVBAsTHChjKSAx
# OTk5IEVudHJ1c3QubmV0IExpbWl0ZWQxMzAxBgNVBAMTKkVudHJ1c3QubmV0IENl
# cnRpZmljYXRpb24gQXV0aG9yaXR5ICgyMDQ4KTCCASIwDQYJKoZIhvcNAQEBBQAD
# ggEPADCCAQoCggEBAK1NS6kShrLqoyAHFRZkKitL0b8LSk2O7YB2pWe3eEDAc0LI
# aMDbUyvdXrh2mDWTixqdfBM6Dh9btx7P5SQUHrGBqY19uMxrSwPxAgzcq6VAJAB/
# dJShnQgps4gL9Yd3nVXN5MN+12pkq4UUhpVblzJQbz3IumYM4/y9uEnBdolJGf3A
# qL2Jo2cvxp+8cRlguC3pLMmQdmZ7lOKveNZlU1081pyyzykD+S+kULLUSM4FMlWK
# /bJkTA7kmAd123/fuQhVYIUwKfl7SKRphuM1Px6GXXp6Fb3vAI4VIlQXAJAmk7wO
# SWiRv/hH052VQsEOTd9vJs/DGCFiZkNw1tXAB+ECAwEAAaNCMEAwDgYDVR0PAQH/
# BAQDAgEGMA8GA1UdEwEB/wQFMAMBAf8wHQYDVR0OBBYEFFXkgdERgL7YibkIozH5
# oSQJFrlwMA0GCSqGSIb3DQEBBQUAA4IBAQA7m49WmzDnU5l8enmnTZfXGZWQ+wYf
# yjN8RmOPlmYk+kAbISfK5nJz8k/+MZn9yAxMaFPGgIITmPq2rdpdPfHObvYVEZSC
# DO4/la8Rqw/XL94fA49XLB7Ju5oaRJXrGE+mH819VxAvmwQJWoS1btgdOuHWntFs
# eV55HBTF49BMkztlPO3fPb6m5ZUaw7UZw71eW7v/I+9oGcsSkydcAy1vMNAethqs
# 3lr30aqoJ6b+eYHEeZkzV7oSsKngQmyTylbe/m2ECwiLfo3q15ghxvPnPHkvXpzR
# TBWN4ewiN8yaQwuX3ICQjbNnm29ICBVWz7/xK3xemnbpWZDFfIM1EWVRMIIFEzCC
# A/ugAwIBAgIMWNoT/wAAAABRzg33MA0GCSqGSIb3DQEBCwUAMIG0MRQwEgYDVQQK
# EwtFbnRydXN0Lm5ldDFAMD4GA1UECxQ3d3d3LmVudHJ1c3QubmV0L0NQU18yMDQ4
# IGluY29ycC4gYnkgcmVmLiAobGltaXRzIGxpYWIuKTElMCMGA1UECxMcKGMpIDE5
# OTkgRW50cnVzdC5uZXQgTGltaXRlZDEzMDEGA1UEAxMqRW50cnVzdC5uZXQgQ2Vy
# dGlmaWNhdGlvbiBBdXRob3JpdHkgKDIwNDgpMB4XDTE1MDcyMjE5MDI1NFoXDTI5
# MDYyMjE5MzI1NFowgbIxCzAJBgNVBAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJ
# bmMuMSgwJgYDVQQLEx9TZWUgd3d3LmVudHJ1c3QubmV0L2xlZ2FsLXRlcm1zMTkw
# NwYDVQQLEzAoYykgMjAxNSBFbnRydXN0LCBJbmMuIC0gZm9yIGF1dGhvcml6ZWQg
# dXNlIG9ubHkxJjAkBgNVBAMTHUVudHJ1c3QgVGltZXN0YW1waW5nIENBIC0gVFMx
# MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA2SPmFKTofEuFcVj7+IHm
# cotdRsOIAB840Irh1m5WMOWv2mRQfcITOfu9ZrTahPuD0Cgfy3boYFBpm/POTxPi
# wT7B3xLLMqP4XkQiDsw66Y1JuWB0yN5UPUFeQ18oRqmmt8oQKyK8W01bjBdlEob9
# LHfVxaCMysKD4EdXfOdwrmJFJzEYCtTApBhVUvdgxgRLs91oMm4QHzQRuBJ4ZPHu
# qeD347EijzRaZcuK9OFFUHTfk5emNObQTDufN0lSp1NOny5nXO2W/KW/dFGI46qO
# vdmxL19QMBb0UWAia5nL/+FUO7n7RDilCDkjm2lH+jzE0Oeq30ay7PKKGawpsjiV
# dQIDAQABo4IBIzCCAR8wEgYDVR0TAQH/BAgwBgEB/wIBADAOBgNVHQ8BAf8EBAMC
# AQYwOwYDVR0gBDQwMjAwBgRVHSAAMCgwJgYIKwYBBQUHAgEWGmh0dHA6Ly93d3cu
# ZW50cnVzdC5uZXQvcnBhMDMGCCsGAQUFBwEBBCcwJTAjBggrBgEFBQcwAYYXaHR0
# cDovL29jc3AuZW50cnVzdC5uZXQwMgYDVR0fBCswKTAnoCWgI4YhaHR0cDovL2Ny
# bC5lbnRydXN0Lm5ldC8yMDQ4Y2EuY3JsMBMGA1UdJQQMMAoGCCsGAQUFBwMIMB0G
# A1UdDgQWBBTDwnHSe9doBa47OZs0JQxiA8dXaDAfBgNVHSMEGDAWgBRV5IHREYC+
# 2Im5CKMx+aEkCRa5cDANBgkqhkiG9w0BAQsFAAOCAQEAHSTnmnRbqnD8sQ4xRdcs
# AH9mOiugmjSqrGNtifmf3w13/SQj/E+ct2+P8/QftsH91hzEjIhmwWONuld307ga
# HshRrcxgNhqHaijqEWXezDwsjHS36FBD08wo6BVsESqfFJUpyQVXtWc26Dypg+9B
# wSEW0373LRFHZnZgghJpjHZVcw/fL0td6Wwj+Af2tX3WaUWcWH1hLvx4S0NOiZFG
# RCygU6hFofYWWLuRE/JLxd8LwOeuKXq9RbPncDDnNI7revbTtdHeaxOZRrOL0k2T
# dbXxb7/cACjCJb+856NlNOw/DR2XjPqqiCKkGDXbBY524xDIKY9j0K6sGNnaxJ9R
# EjCCBgwwggT0oAMCAQICEQCNzhXzp5TFhwAAAABVkjP0MA0GCSqGSIb3DQEBCwUA
# MIGyMQswCQYDVQQGEwJVUzEWMBQGA1UEChMNRW50cnVzdCwgSW5jLjEoMCYGA1UE
# CxMfU2VlIHd3dy5lbnRydXN0Lm5ldC9sZWdhbC10ZXJtczE5MDcGA1UECxMwKGMp
# IDIwMTUgRW50cnVzdCwgSW5jLiAtIGZvciBhdXRob3JpemVkIHVzZSBvbmx5MSYw
# JAYDVQQDEx1FbnRydXN0IFRpbWVzdGFtcGluZyBDQSAtIFRTMTAeFw0yMDA3MjIx
# NTMzMjlaFw0zMDEyMjkxNjI5MjNaMHUxCzAJBgNVBAYTAkNBMRAwDgYDVQQIEwdP
# bnRhcmlvMQ8wDQYDVQQHEwZPdHRhd2ExFjAUBgNVBAoTDUVudHJ1c3QsIEluYy4x
# KzApBgNVBAMTIkVudHJ1c3QgVGltZXN0YW1wIEF1dGhvcml0eSAtIFRTQTEwggIi
# MA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoICAQDKPuwkYuH3/t/RNqk3ZtZ5FxSU
# QgCkhpe4J4zrT6n3067iqzAECChfm1Omh4ot3QJSX7W45bZQ8JyrEsHuGlZ4im5E
# P6mKj9fbU9nGR8gM3EZXAGcGFxqFt0Cqr3YH55BflJLVrtbXzXmhxTUrRIRfSRzV
# c7iBjXKUAmqpz1aSqjaUw1DJVpeIXOF/X/373xSOPaskDfZ7j2r6bh76lb19kPjk
# QhS/VV4EVJMxQ/fD58IFEWisQGnHIzfsWkwpyd81s35JTsZ6287CJZSeNz+I7CRN
# OY9/7xVrVExx8Q0hfFp10IdTiaBb4B37nAfAqKG0ItBipMcXfzdOzi06WOPl8CaG
# TUIHn76j4hmia3KlRr/LZFslyEX03ug8tv2c86Dvg0F8NnCQw1JisMd/PXvlloel
# Vv8O6kkF37TdE29F05vII3kqMJmdmdzMzaUugVNSIvLQPaI3UpGRRnDWxUsF/070
# 3GQGl/58kIYnr580VUiJqyLAdQeMIdkE0xyn6m2kyVIr4sQCiTBe55sx5jllrXGt
# 72db3KMk7Q3m4ql6OhhV3vBGLjRNGk2YgA1O0WyFdbgDwgDVIkom0Y7d7bXUJ9Y6
# fGdphtdUP5fPZL6Rq262nRkQebWXDvTRhcnkrsfAtKoHxB/BOlefzQ6meuUVhrKq
# 9KKTLM+M91H63YzQSQIDAQABo4IBVzCCAVMwDgYDVR0PAQH/BAQDAgeAMBYGA1Ud
# JQEB/wQMMAoGCCsGAQUFBwMIMEEGA1UdIAQ6MDgwNgYKYIZIAYb6bAoDBTAoMCYG
# CCsGAQUFBwIBFhpodHRwOi8vd3d3LmVudHJ1c3QubmV0L3JwYTAJBgNVHRMEAjAA
# MGgGCCsGAQUFBwEBBFwwWjAjBggrBgEFBQcwAYYXaHR0cDovL29jc3AuZW50cnVz
# dC5uZXQwMwYIKwYBBQUHMAKGJ2h0dHA6Ly9haWEuZW50cnVzdC5uZXQvdHMxLWNo
# YWluMjU2LmNlcjAxBgNVHR8EKjAoMCagJKAihiBodHRwOi8vY3JsLmVudHJ1c3Qu
# bmV0L3RzMWNhLmNybDAfBgNVHSMEGDAWgBTDwnHSe9doBa47OZs0JQxiA8dXaDAd
# BgNVHQ4EFgQULVaA7473SkMcQ6G13tnXqKprJigwDQYJKoZIhvcNAQELBQADggEB
# AFhLztj+gddR2MdcjZLSTpUehYZD7eAa5pohQjNd45G++FB8dowlqUHUhJno6KK2
# mZdooiC9MqiqKXwKdhqfyFWOq9N71ON+WX6ScDkP7fYv80//dFzz5zA0QKMRo2ty
# pDIRBXz9kYtHqFc2Usf6tUWE0bI+QuUWXt0D06n9PXBnetoT4ISCZzhgVsOtsIjh
# Cjd+YoEGuyME71igI6jRCWMwzdkZOPTrWndYvl+/65Qt/y8EMGQQjz5ZVi46Nk8O
# PJYPj8nqfn9JMh+jX27aIp/X2Rc5Wd5IF3oCS1hx/7cMLaHwZ6MR3PfJvNkey2wM
# FSd4SBZrLPGtl7h1bLuVw44xggSaMIIElgIBATCByDCBsjELMAkGA1UEBhMCVVMx
# FjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xKDAmBgNVBAsTH1NlZSB3d3cuZW50cnVz
# dC5uZXQvbGVnYWwtdGVybXMxOTA3BgNVBAsTMChjKSAyMDE1IEVudHJ1c3QsIElu
# Yy4gLSBmb3IgYXV0aG9yaXplZCB1c2Ugb25seTEmMCQGA1UEAxMdRW50cnVzdCBU
# aW1lc3RhbXBpbmcgQ0EgLSBUUzECEQCNzhXzp5TFhwAAAABVkjP0MAsGCWCGSAFl
# AwQCAaCCAaYwGgYJKoZIhvcNAQkDMQ0GCyqGSIb3DQEJEAEEMBwGCSqGSIb3DQEJ
# BTEPFw0yMjA3MTkxNDU1MzJaMCkGCSqGSIb3DQEJNDEcMBowCwYJYIZIAWUDBAIB
# oQsGCSqGSIb3DQEBCzAvBgkqhkiG9w0BCQQxIgQgxuHYa3YiKX9SqH1GcA00lLb4
# LAfanhyiathtDIzjkRYwggEMBgsqhkiG9w0BCRACLzGB/DCB+TCB9jCB8wQglQom
# /cfAIBjp95GpXDjybu89pDJnyrDNFaVVr2MQcskwgc4wgbikgbUwgbIxCzAJBgNV
# BAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSgwJgYDVQQLEx9TZWUgd3d3
# LmVudHJ1c3QubmV0L2xlZ2FsLXRlcm1zMTkwNwYDVQQLEzAoYykgMjAxNSBFbnRy
# dXN0LCBJbmMuIC0gZm9yIGF1dGhvcml6ZWQgdXNlIG9ubHkxJjAkBgNVBAMTHUVu
# dHJ1c3QgVGltZXN0YW1waW5nIENBIC0gVFMxAhEAjc4V86eUxYcAAAAAVZIz9DAL
# BgkqhkiG9w0BAQsEggIAaJxiDNnVNtmHUgjQwEfZja4DLTrFPgp6aRW6bi901bm5
# yNGTd4TBDb58BuD1vQeohxNHQlVQGuMTNfKgqRYpKQiD+PNbM1/zAFowiDx29nHq
# Ag1L/cpFvhcieHStDTxrmsdb5wiMlS5gear62RTKmpknSQLUZ+LyYStGsdNbXwP/
# YSr6mLsgJ+cizFf1E1BQmyMOWHhdVLwDdNRL1LoVRZNtYgsEbkkrIvJ5BkNzzLcx
# p/Pr5Q/f5VOC2W796q+YRhlNQ5DA7w/Uhm75uja4i6JGTsO9CC4GtRnkG+Q775Yu
# /IEuGtECa0OFkPcpez4yOqKOK0b7UmirEYKIundot+0iYaVnfY3+RoglF+kvm0KF
# 54fI06+7Xxc+Hj7pihhK7rXlhJ1UxZpNIttwBi/zVgC0bAgKjd56Zo+zPsYsu+HG
# ElnUfSSVpNxdHM1cgY9dInK4J2ifmnRYV6UWoOEtuT2Js/6Ekh4rpdLqdIhguKmt
# LiSDmVPcfgpy5huA95d4RTKjhMsZRJ/8Gxr+Kb3U4KXRpCd3cCpot1mfIQk8Yxz0
# lXRHsk+csK/wfMMADInzWQ2X3kIsEcyng1F40QjtOR8qH0OSLa3um7CkZfWo/AS2
# qnHvVR45x9AUlNfgudW0rGsa9vNtY0hezGL3Gs1y3y201C1rFe5pEoHOOKD99xo=
# SIG # End signature block
