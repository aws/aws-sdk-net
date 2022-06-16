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
# MIIpFAYJKoZIhvcNAQcCoIIpBTCCKQECAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCD5YDSJCqst/cbt
# sDsenRhb8aFQrp5wSSSmT4bMyjoNO6CCDlkwggawMIIEmKADAgECAhAIrUCyYNKc
# TJ9ezam9k67ZMA0GCSqGSIb3DQEBDAUAMGIxCzAJBgNVBAYTAlVTMRUwEwYDVQQK
# EwxEaWdpQ2VydCBJbmMxGTAXBgNVBAsTEHd3dy5kaWdpY2VydC5jb20xITAfBgNV
# BAMTGERpZ2lDZXJ0IFRydXN0ZWQgUm9vdCBHNDAeFw0yMTA0MjkwMDAwMDBaFw0z
# NjA0MjgyMzU5NTlaMGkxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwg
# SW5jLjFBMD8GA1UEAxM4RGlnaUNlcnQgVHJ1c3RlZCBHNCBDb2RlIFNpZ25pbmcg
# UlNBNDA5NiBTSEEzODQgMjAyMSBDQTEwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAw
# ggIKAoICAQDVtC9C0CiteLdd1TlZG7GIQvUzjOs9gZdwxbvEhSYwn6SOaNhc9es0
# JAfhS0/TeEP0F9ce2vnS1WcaUk8OoVf8iJnBkcyBAz5NcCRks43iCH00fUyAVxJr
# Q5qZ8sU7H/Lvy0daE6ZMswEgJfMQ04uy+wjwiuCdCcBlp/qYgEk1hz1RGeiQIXhF
# LqGfLOEYwhrMxe6TSXBCMo/7xuoc82VokaJNTIIRSFJo3hC9FFdd6BgTZcV/sk+F
# LEikVoQ11vkunKoAFdE3/hoGlMJ8yOobMubKwvSnowMOdKWvObarYBLj6Na59zHh
# 3K3kGKDYwSNHR7OhD26jq22YBoMbt2pnLdK9RBqSEIGPsDsJ18ebMlrC/2pgVItJ
# wZPt4bRc4G/rJvmM1bL5OBDm6s6R9b7T+2+TYTRcvJNFKIM2KmYoX7BzzosmJQay
# g9Rc9hUZTO1i4F4z8ujo7AqnsAMrkbI2eb73rQgedaZlzLvjSFDzd5Ea/ttQokbI
# YViY9XwCFjyDKK05huzUtw1T0PhH5nUwjewwk3YUpltLXXRhTT8SkXbev1jLchAp
# QfDVxW0mdmgRQRNYmtwmKwH0iU1Z23jPgUo+QEdfyYFQc4UQIyFZYIpkVMHMIRro
# OBl8ZhzNeDhFMJlP/2NPTLuqDQhTQXxYPUez+rbsjDIJAsxsPAxWEQIDAQABo4IB
# WTCCAVUwEgYDVR0TAQH/BAgwBgEB/wIBADAdBgNVHQ4EFgQUaDfg67Y7+F8Rhvv+
# YXsIiGX0TkIwHwYDVR0jBBgwFoAU7NfjgtJxXWRM3y5nP+e6mK4cD08wDgYDVR0P
# AQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUFBwMDMHcGCCsGAQUFBwEBBGswaTAk
# BggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29tMEEGCCsGAQUFBzAC
# hjVodHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkUm9v
# dEc0LmNydDBDBgNVHR8EPDA6MDigNqA0hjJodHRwOi8vY3JsMy5kaWdpY2VydC5j
# b20vRGlnaUNlcnRUcnVzdGVkUm9vdEc0LmNybDAcBgNVHSAEFTATMAcGBWeBDAED
# MAgGBmeBDAEEATANBgkqhkiG9w0BAQwFAAOCAgEAOiNEPY0Idu6PvDqZ01bgAhql
# +Eg08yy25nRm95RysQDKr2wwJxMSnpBEn0v9nqN8JtU3vDpdSG2V1T9J9Ce7FoFF
# UP2cvbaF4HZ+N3HLIvdaqpDP9ZNq4+sg0dVQeYiaiorBtr2hSBh+3NiAGhEZGM1h
# mYFW9snjdufE5BtfQ/g+lP92OT2e1JnPSt0o618moZVYSNUa/tcnP/2Q0XaG3Ryw
# YFzzDaju4ImhvTnhOE7abrs2nfvlIVNaw8rpavGiPttDuDPITzgUkpn13c5Ubdld
# AhQfQDN8A+KVssIhdXNSy0bYxDQcoqVLjc1vdjcshT8azibpGL6QB7BDf5WIIIJw
# 8MzK7/0pNVwfiThV9zeKiwmhywvpMRr/LhlcOXHhvpynCgbWJme3kuZOX956rEnP
# LqR0kq3bPKSchh/jwVYbKyP/j7XqiHtwa+aguv06P0WmxOgWkVKLQcBIhEuWTatE
# QOON8BUozu3xGFYHKi8QxAwIZDwzj64ojDzLj4gLDb879M4ee47vtevLt/B3E+bn
# KD+sEq6lLyJsQfmCXBVmzGwOysWGw/YmMwwHS6DTBwJqakAwSEs0qFEgu60bhQji
# WQ1tygVQK+pKHJ6l/aCnHwZ05/LWUpD9r4VIIflXO7ScA+2GRfS0YW6/aOImYIbq
# yK+p/pQd52MbOoZWeE4wggehMIIFiaADAgECAhALyko14sGCglkXWPsT8gmbMA0G
# CSqGSIb3DQEBCwUAMGkxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwg
# SW5jLjFBMD8GA1UEAxM4RGlnaUNlcnQgVHJ1c3RlZCBHNCBDb2RlIFNpZ25pbmcg
# UlNBNDA5NiBTSEEzODQgMjAyMSBDQTEwHhcNMjExMjI4MDAwMDAwWhcNMjMwMTAz
# MjM1OTU5WjCB9jEdMBsGA1UEDwwUUHJpdmF0ZSBPcmdhbml6YXRpb24xEzARBgsr
# BgEEAYI3PAIBAxMCVVMxGTAXBgsrBgEEAYI3PAIBAhMIRGVsYXdhcmUxEDAOBgNV
# BAUTBzQxNTI5NTQxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAw
# DgYDVQQHEwdTZWF0dGxlMSIwIAYDVQQKExlBbWF6b24gV2ViIFNlcnZpY2VzLCBJ
# bmMuMRcwFQYDVQQLEw5TREtzIGFuZCBUb29sczEiMCAGA1UEAxMZQW1hem9uIFdl
# YiBTZXJ2aWNlcywgSW5jLjCCAaIwDQYJKoZIhvcNAQEBBQADggGPADCCAYoCggGB
# AKHRLdQSyJ6AfhQ8U7Gi6le7gshUhu34xQ7jaTCfpKaKQRGu+oNfAYDRSSfh498e
# K+jFnGHU/TMzVHEgBb4TUrc1e2f5LHhXAtYTJK0uis9OJ5n3MjHwOJt/uGSSMUAI
# IIselvbSF2mOE0lIz0CNMIlUiXI9O+y9+FJP7Vsg/NU/zAVsQ4Ok0GLd+Yp566nR
# uj9aNU+L+TxRhSHA7KKjJ9oE0mVblUGQaeNrOd1Ql9djJy0pg6oT2s9Peh8lqB3t
# UsMaoQ/FMV0P/e1S6V3yFg/I1OvQdtm29ryJTdg9ZvIV/FGnIYdW5s5T8t//nf+7
# LToQVhpML/ZWEhFRAa6We80Y8zs9glIPDZyYmi6OPbpY7kVHa4dr8S49tPwrVMjC
# 3hk9v9S6poDx/hR9kytwVt1Lo4LjAlpmKLeHVmOnn5uenpXqFOJMbTMYmciwHz8y
# WJwZYMKKLJPCGa79xaAkZj9HCop5yPUPccqjyz2i0v/Pt8yFH77s8q86e99O2a+/
# oQIDAQABo4ICNTCCAjEwHwYDVR0jBBgwFoAUaDfg67Y7+F8Rhvv+YXsIiGX0TkIw
# HQYDVR0OBBYEFGmlIp+0bnVEmnOvWcJjnCup9DbsMC4GA1UdEQQnMCWgIwYIKwYB
# BQUHCAOgFzAVDBNVUy1ERUxBV0FSRS00MTUyOTU0MA4GA1UdDwEB/wQEAwIHgDAT
# BgNVHSUEDDAKBggrBgEFBQcDAzCBtQYDVR0fBIGtMIGqMFOgUaBPhk1odHRwOi8v
# Y3JsMy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkRzRDb2RlU2lnbmluZ1JT
# QTQwOTZTSEEzODQyMDIxQ0ExLmNybDBToFGgT4ZNaHR0cDovL2NybDQuZGlnaWNl
# cnQuY29tL0RpZ2lDZXJ0VHJ1c3RlZEc0Q29kZVNpZ25pbmdSU0E0MDk2U0hBMzg0
# MjAyMUNBMS5jcmwwPQYDVR0gBDYwNDAyBgVngQwBAzApMCcGCCsGAQUFBwIBFhto
# dHRwOi8vd3d3LmRpZ2ljZXJ0LmNvbS9DUFMwgZQGCCsGAQUFBwEBBIGHMIGEMCQG
# CCsGAQUFBzABhhhodHRwOi8vb2NzcC5kaWdpY2VydC5jb20wXAYIKwYBBQUHMAKG
# UGh0dHA6Ly9jYWNlcnRzLmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydFRydXN0ZWRHNENv
# ZGVTaWduaW5nUlNBNDA5NlNIQTM4NDIwMjFDQTEuY3J0MAwGA1UdEwEB/wQCMAAw
# DQYJKoZIhvcNAQELBQADggIBALlYa6PSDPPulVJbqEi7XGz23lFZwYa1PiXk+PkJ
# O2HDXv2zep26LZriwBHT2yA/KbDvbwZpf4VOBKn5lQC9R+DsgwW/xZbNq7y3cWf9
# Ad1AQ9Do/FXfBqVO1if+GpqFbqUme5wOjn8/8dc4nFR4erbDgkM4ICn/astBigYn
# fM5wTO+J8ex+7fE2D1kFAwfZAuiRNdDreVMDlYXpJMQ4CtTKVLHYentLR747zzRj
# O4PqgL1exvbvpOMZlSDLWhaDjtKwUDb645ziHDA3DXe8K51+hIFuadKTinJa8Pfs
# bgg2W7aTfBdi2gTyXkeVJ836631Ks4KD3cXui9Jx2PWRAVxKIEvXuebZ09Mph2ji
# BH75urqS57i1mpS7OA5lIj7a7NIYsVl26PVpJUEr3LRKV8GO3tRC7KP0zE7sB7k2
# VQKwBXbsifq/vpcmeyy4OeQbZ1i8GwZLPHuygP9exTWK2o2wWByJs62Wdk6JmSRE
# vr9Wr59BVNbQfRSRaF9q058bBK68hGZtDBpJ9gJX4V12DI2UpSbcGf10+afL1J4z
# FDv98GIGkgmfLQJUpJeC/FnNrEXJbINndCsOb6gdLvLX1grMdUPmPkpRZyvG3HEy
# EMCV5ODMItTx7K6TDyeZDIXXP5oBnBMK9EjtRD3XkEb9dDfuzCrdlTpEoTElt2mG
# uEE7MYIaETCCGg0CAQEwfTBpMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNl
# cnQsIEluYy4xQTA/BgNVBAMTOERpZ2lDZXJ0IFRydXN0ZWQgRzQgQ29kZSBTaWdu
# aW5nIFJTQTQwOTYgU0hBMzg0IDIwMjEgQ0ExAhALyko14sGCglkXWPsT8gmbMA0G
# CWCGSAFlAwQCAQUAoHwwEAYKKwYBBAGCNwIBDDECMAAwGQYJKoZIhvcNAQkDMQwG
# CisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZI
# hvcNAQkEMSIEIK61EKI3E83uBQw2QlFhFvOqB2zYRU+jUG2AWNwCS1w5MA0GCSqG
# SIb3DQEBAQUABIIBgFmxk+5K2ZDC/aFp8E1saXKAauRBXbDoshdIIZ6BwuZlpp6v
# Gb32Y3fVkCYqc/lZ+yEiBTbN8tXfxYDH3pl24zX1UOL0WjkxHel46R2rbN7DiRgd
# zgBfwOL2jbHTBSarOK/riuG5nzCFiF9goM4T804l2oSIONBPYuNpG17y0Fr72CHT
# IV/z0+eGCf1j5HEi9lM9CrusjM1zCPp/Hi1CsZbUvgRxuXjlo2rLfVcamMlppGZm
# IsxANr7T967KNEORmdaXNISswg4NBfvnXXvi2JffPfd52MHalEajEY0IWoArmnBQ
# rq5bxNkDN53AEYju6TcqGvgCOr4FmdOibnwrLPLOg7pmhpdqJZLznhYqM+4lbBus
# Cbb6ipnwuCRrE/gx6QblODDaR6/8kEfb1US0uSDrQqZk97YNYZ7GBFs/LCK4dw4K
# TG4ZtmqcqKwM++bwlaDuDH/AmElHm6qtL776SIhc1n0LqjHA0/McuWvVJQ67LOs8
# K1uA0+HzQezW2q92+aGCF2cwghdjBgorBgEEAYI3AwMBMYIXUzCCF08GCSqGSIb3
# DQEHAqCCF0Awghc8AgEDMQ8wDQYJYIZIAWUDBAIBBQAwdwYLKoZIhvcNAQkQAQSg
# aARmMGQCAQEGCWCGSAGG/WwHATAxMA0GCWCGSAFlAwQCAQUABCCa0NNlprWUZZ5o
# DMcpZuM4BqYTLMezce4VH1Fuc8ogoQIQRBSqQ04Jv1pt24geApicexgPMjAyMjA2
# MTYxODQwMzZaoIITMTCCBsYwggSuoAMCAQICEAp6SoieyZlCkAZjOE2Gl50wDQYJ
# KoZIhvcNAQELBQAwYzELMAkGA1UEBhMCVVMxFzAVBgNVBAoTDkRpZ2lDZXJ0LCBJ
# bmMuMTswOQYDVQQDEzJEaWdpQ2VydCBUcnVzdGVkIEc0IFJTQTQwOTYgU0hBMjU2
# IFRpbWVTdGFtcGluZyBDQTAeFw0yMjAzMjkwMDAwMDBaFw0zMzAzMTQyMzU5NTla
# MEwxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwgSW5jLjEkMCIGA1UE
# AxMbRGlnaUNlcnQgVGltZXN0YW1wIDIwMjIgLSAyMIICIjANBgkqhkiG9w0BAQEF
# AAOCAg8AMIICCgKCAgEAuSqWI6ZcvF/WSfAVghj0M+7MXGzj4CUu0jHkPECu+6vE
# 43hdflw26vUljUOjges4Y/k8iGnePNIwUQ0xB7pGbumjS0joiUF/DbLW+YTxmD4L
# vwqEEnFsoWImAdPOw2z9rDt+3Cocqb0wxhbY2rzrsvGD0Z/NCcW5QWpFQiNBWvhg
# 02UsPn5evZan8Pyx9PQoz0J5HzvHkwdoaOVENFJfD1De1FksRHTAMkcZW+KYLo/Q
# yj//xmfPPJOVToTpdhiYmREUxSsMoDPbTSSF6IKU4S8D7n+FAsmG4dUYFLcERfPg
# OL2ivXpxmOwV5/0u7NKbAIqsHY07gGj+0FmYJs7g7a5/KC7CnuALS8gI0TK7g/oj
# PNn/0oy790Mj3+fDWgVifnAs5SuyPWPqyK6BIGtDich+X7Aa3Rm9n3RBCq+5jgnT
# dKEvsFR2wZBPlOyGYf/bES+SAzDOMLeLD11Es0MdI1DNkdcvnfv8zbHBp8QOxO9A
# Phk6AtQxqWmgSfl14ZvoaORqDI/r5LEhe4ZnWH5/H+gr5BSyFtaBocraMJBr7m91
# wLA2JrIIO/+9vn9sExjfxm2keUmti39hhwVo99Rw40KV6J67m0uy4rZBPeevpxoo
# ya1hsKBBGBlO7UebYZXtPgthWuo+epiSUc0/yUTngIspQnL3ebLdhOon7v59emsC
# AwEAAaOCAYswggGHMA4GA1UdDwEB/wQEAwIHgDAMBgNVHRMBAf8EAjAAMBYGA1Ud
# JQEB/wQMMAoGCCsGAQUFBwMIMCAGA1UdIAQZMBcwCAYGZ4EMAQQCMAsGCWCGSAGG
# /WwHATAfBgNVHSMEGDAWgBS6FtltTYUvcyl2mi91jGogj57IbzAdBgNVHQ4EFgQU
# jWS3iSH+VlhEhGGn6m8cNo/drw0wWgYDVR0fBFMwUTBPoE2gS4ZJaHR0cDovL2Ny
# bDMuZGlnaWNlcnQuY29tL0RpZ2lDZXJ0VHJ1c3RlZEc0UlNBNDA5NlNIQTI1NlRp
# bWVTdGFtcGluZ0NBLmNybDCBkAYIKwYBBQUHAQEEgYMwgYAwJAYIKwYBBQUHMAGG
# GGh0dHA6Ly9vY3NwLmRpZ2ljZXJ0LmNvbTBYBggrBgEFBQcwAoZMaHR0cDovL2Nh
# Y2VydHMuZGlnaWNlcnQuY29tL0RpZ2lDZXJ0VHJ1c3RlZEc0UlNBNDA5NlNIQTI1
# NlRpbWVTdGFtcGluZ0NBLmNydDANBgkqhkiG9w0BAQsFAAOCAgEADS0jdKbR9fjq
# S5k/AeT2DOSvFp3Zs4yXgimcQ28BLas4tXARv4QZiz9d5YZPvpM63io5WjlO2IRZ
# pbwbmKrobO/RSGkZOFvPiTkdcHDZTt8jImzV3/ZZy6HC6kx2yqHcoSuWuJtVqRpr
# fdH1AglPgtalc4jEmIDf7kmVt7PMxafuDuHvHjiKn+8RyTFKWLbfOHzL+lz35FO/
# bgp8ftfemNUpZYkPopzAZfQBImXH6l50pls1klB89Bemh2RPPkaJFmMga8vye9A1
# 40pwSKm25x1gvQQiFSVwBnKpRDtpRxHT7unHoD5PELkwNuTzqmkJqIt+ZKJllBH7
# bjLx9bs4rc3AkxHVMnhKSzcqTPNc3LaFwLtwMFV41pj+VG1/calIGnjdRncuG3rA
# M4r4SiiMEqhzzy350yPynhngDZQooOvbGlGglYKOKGukzp123qlzqkhqWUOuX+r4
# DwZCnd8GaJb+KqB0W2Nm3mssuHiqTXBt8CzxBxV+NbTmtQyimaXXFWs1DoXW4CzM
# 4AwkuHxSCx6ZfO/IyMWMWGmvqz3hz8x9Fa4Uv4px38qXsdhH6hyF4EVOEhwUKVjM
# b9N/y77BDkpvIJyu2XMyWQjnLZKhGhH+MpimXSuX4IvTnMxttQ2uR2M4RxdbbxPa
# ahBuH0m3RFu0CAqHWlkEdhGhp3cCExwwggauMIIElqADAgECAhAHNje3JFR82Ees
# /ShmKl5bMA0GCSqGSIb3DQEBCwUAMGIxCzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxE
# aWdpQ2VydCBJbmMxGTAXBgNVBAsTEHd3dy5kaWdpY2VydC5jb20xITAfBgNVBAMT
# GERpZ2lDZXJ0IFRydXN0ZWQgUm9vdCBHNDAeFw0yMjAzMjMwMDAwMDBaFw0zNzAz
# MjIyMzU5NTlaMGMxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwgSW5j
# LjE7MDkGA1UEAxMyRGlnaUNlcnQgVHJ1c3RlZCBHNCBSU0E0MDk2IFNIQTI1NiBU
# aW1lU3RhbXBpbmcgQ0EwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoICAQDG
# hjUGSbPBPXJJUVXHJQPE8pE3qZdRodbSg9GeTKJtoLDMg/la9hGhRBVCX6SI82j6
# ffOciQt/nR+eDzMfUBMLJnOWbfhXqAJ9/UO0hNoR8XOxs+4rgISKIhjf69o9xBd/
# qxkrPkLcZ47qUT3w1lbU5ygt69OxtXXnHwZljZQp09nsad/ZkIdGAHvbREGJ3Hxq
# V3rwN3mfXazL6IRktFLydkf3YYMZ3V+0VAshaG43IbtArF+y3kp9zvU5EmfvDqVj
# bOSmxR3NNg1c1eYbqMFkdECnwHLFuk4fsbVYTXn+149zk6wsOeKlSNbwsDETqVcp
# licu9Yemj052FVUmcJgmf6AaRyBD40NjgHt1biclkJg6OBGz9vae5jtb7IHeIhTZ
# girHkr+g3uM+onP65x9abJTyUpURK1h0QCirc0PO30qhHGs4xSnzyqqWc0Jon7ZG
# s506o9UD4L/wojzKQtwYSH8UNM/STKvvmz3+DrhkKvp1KCRB7UK/BZxmSVJQ9FHz
# NklNiyDSLFc1eSuo80VgvCONWPfcYd6T/jnA+bIwpUzX6ZhKWD7TA4j+s4/TXkt2
# ElGTyYwMO1uKIqjBJgj5FBASA31fI7tk42PgpuE+9sJ0sj8eCXbsq11GdeJgo1gJ
# ASgADoRU7s7pXcheMBK9Rp6103a50g5rmQzSM7TNsQIDAQABo4IBXTCCAVkwEgYD
# VR0TAQH/BAgwBgEB/wIBADAdBgNVHQ4EFgQUuhbZbU2FL3MpdpovdYxqII+eyG8w
# HwYDVR0jBBgwFoAU7NfjgtJxXWRM3y5nP+e6mK4cD08wDgYDVR0PAQH/BAQDAgGG
# MBMGA1UdJQQMMAoGCCsGAQUFBwMIMHcGCCsGAQUFBwEBBGswaTAkBggrBgEFBQcw
# AYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29tMEEGCCsGAQUFBzAChjVodHRwOi8v
# Y2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkUm9vdEc0LmNydDBD
# BgNVHR8EPDA6MDigNqA0hjJodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vRGlnaUNl
# cnRUcnVzdGVkUm9vdEc0LmNybDAgBgNVHSAEGTAXMAgGBmeBDAEEAjALBglghkgB
# hv1sBwEwDQYJKoZIhvcNAQELBQADggIBAH1ZjsCTtm+YqUQiAX5m1tghQuGwGC4Q
# TRPPMFPOvxj7x1Bd4ksp+3CKDaopafxpwc8dB+k+YMjYC+VcW9dth/qEICU0MWfN
# thKWb8RQTGIdDAiCqBa9qVbPFXONASIlzpVpP0d3+3J0FNf/q0+KLHqrhc1DX+1g
# tqpPkWaeLJ7giqzl/Yy8ZCaHbJK9nXzQcAp876i8dU+6WvepELJd6f8oVInw1Ypx
# dmXazPByoyP6wCeCRK6ZJxurJB4mwbfeKuv2nrF5mYGjVoarCkXJ38SNoOeY+/um
# nXKvxMfBwWpx2cYTgAnEtp/Nh4cku0+jSbl3ZpHxcpzpSwJSpzd+k1OsOx0ISQ+U
# zTl63f8lY5knLD0/a6fxZsNBzU+2QJshIUDQtxMkzdwdeDrknq3lNHGS1yZr5Dhz
# q6YBT70/O3itTK37xJV77QpfMzmHQXh6OOmc4d0j/R0o08f56PGYX/sr2H7yRp11
# LB4nLCbbbxV7HhmLNriT1ObyF5lZynDwN7+YAN8gFk8n+2BnFqFmut1VwDophrCY
# oCvtlUG3OtUVmDG0YgkPCr2B2RP+v6TR81fZvAT6gt4y3wSJ8ADNXcL50CN/AAvk
# dgIm2fBldkKmKYcJRyvmfxqkhQ/8mJb2VVQrH4D6wPIOK+XW+6kvRBVK5xMOHds3
# OBqhK/bt1nz8MIIFsTCCBJmgAwIBAgIQASQK+x44C4oW8UtxnfTTwDANBgkqhkiG
# 9w0BAQwFADBlMQswCQYDVQQGEwJVUzEVMBMGA1UEChMMRGlnaUNlcnQgSW5jMRkw
# FwYDVQQLExB3d3cuZGlnaWNlcnQuY29tMSQwIgYDVQQDExtEaWdpQ2VydCBBc3N1
# cmVkIElEIFJvb3QgQ0EwHhcNMjIwNjA5MDAwMDAwWhcNMzExMTA5MjM1OTU5WjBi
# MQswCQYDVQQGEwJVUzEVMBMGA1UEChMMRGlnaUNlcnQgSW5jMRkwFwYDVQQLExB3
# d3cuZGlnaWNlcnQuY29tMSEwHwYDVQQDExhEaWdpQ2VydCBUcnVzdGVkIFJvb3Qg
# RzQwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoICAQC/5pBzaN675F1KPDAi
# MGkz7MKnJS7JIT3yithZwuEppz1Yq3aaza57G4QNxDAf8xukOBbrVsaXbR2rsnny
# yhHS5F/WBTxSD1Ifxp4VpX6+n6lXFllVcq9ok3DCsrp1mWpzMpTREEQQLt+C8weE
# 5nQ7bXHiLQwb7iDVySAdYyktzuxeTsiT+CFhmzTrBcZe7FsavOvJz82sNEBfsXpm
# 7nfISKhmV1efVFiODCu3T6cw2Vbuyntd463JT17lNecxy9qTXtyOj4DatpGYQJB5
# w3jHtrHEtWoYOAMQjdjUN6QuBX2I9YI+EJFwq1WCQTLX2wRzKm6RAXwhTNS8rhsD
# dV14Ztk6MUSaM0C/CNdaSaTC5qmgZ92kJ7yhTzm1EVgX9yRcRo9k98FpiHaYdj1Z
# XUJ2h4mXaXpI8OCiEhtmmnTK3kse5w5jrubU75KSOp493ADkRSWJtppEGSt+wJS0
# 0mFt6zPZxd9LBADMfRyVw4/3IbKyEbe7f/LVjHAsQWCqsWMYRJUadmJ+9oCw++hk
# pjPRiQfhvbfmQ6QYuKZ3AeEPlAwhHbJUKSWJbOUOUlFHdL4mrLZBdd56rF+NP8m8
# 00ERElvlEFDrMcXKchYiCd98THU/Y+whX8QgUWtvsauGi0/C1kVfnSD8oR7FwI+i
# sX4KJpn15GkvmB0t9dmpsh3lGwIDAQABo4IBXjCCAVowDwYDVR0TAQH/BAUwAwEB
# /zAdBgNVHQ4EFgQU7NfjgtJxXWRM3y5nP+e6mK4cD08wHwYDVR0jBBgwFoAUReui
# r/SSy4IxLVGLp6chnfNtyA8wDgYDVR0PAQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsG
# AQUFBwMIMHkGCCsGAQUFBwEBBG0wazAkBggrBgEFBQcwAYYYaHR0cDovL29jc3Au
# ZGlnaWNlcnQuY29tMEMGCCsGAQUFBzAChjdodHRwOi8vY2FjZXJ0cy5kaWdpY2Vy
# dC5jb20vRGlnaUNlcnRBc3N1cmVkSURSb290Q0EuY3J0MEUGA1UdHwQ+MDwwOqA4
# oDaGNGh0dHA6Ly9jcmwzLmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydEFzc3VyZWRJRFJv
# b3RDQS5jcmwwIAYDVR0gBBkwFzAIBgZngQwBBAIwCwYJYIZIAYb9bAcBMA0GCSqG
# SIb3DQEBDAUAA4IBAQCaFgKlAe+B+w20WLJ4ragjGdlzN9pgnlHXy/gvQLmjH3xA
# TjM+kDzniQF1hehiex1W4HG63l7GN7x5XGIATfhJelFNBjLzxdIAKicg6okuFTng
# LD74dXwsgkFhNQ8j0O01ldKIlSlDy+CmWBB8U46fRckgNxTA7Rm6fnc50lSWx6YR
# 3zQz9nVSQkscnY2W1ZVsRxIUJF8mQfoaRr3esOWRRwOsGAjLy9tmiX8rnGW/vjdO
# vi3znUrDzMxHXsiVla3Ry7sqBiD5P3LqNutFcpJ6KXsUAzz7TdZIcXoQEYoIdM1s
# GwRc0oqVA3ZRUFPWLvdKRsOuECxxTLCHtic3RGBEMYIDdjCCA3ICAQEwdzBjMQsw
# CQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNlcnQsIEluYy4xOzA5BgNVBAMTMkRp
# Z2lDZXJ0IFRydXN0ZWQgRzQgUlNBNDA5NiBTSEEyNTYgVGltZVN0YW1waW5nIENB
# AhAKekqInsmZQpAGYzhNhpedMA0GCWCGSAFlAwQCAQUAoIHRMBoGCSqGSIb3DQEJ
# AzENBgsqhkiG9w0BCRABBDAcBgkqhkiG9w0BCQUxDxcNMjIwNjE2MTg0MDM2WjAr
# BgsqhkiG9w0BCRACDDEcMBowGDAWBBSFCPOGUVyz0wd9trS3wH8bSl5B3jAvBgkq
# hkiG9w0BCQQxIgQg25SIA5JOuY5LruMvkQhJxrL2P2QmszW2b5ZxtcrdeJcwNwYL
# KoZIhvcNAQkQAi8xKDAmMCQwIgQgnaaQFcNJxsGJeEW6NYKtcMiPpCk722q+nCvS
# U5J55jswDQYJKoZIhvcNAQEBBQAEggIAWkAZSFkS4S4hQMr1hXuyKUY74vktTTgV
# Zq8629g5mCrc1wE9iOKJJKSGN421TTlB1ndSGAAf2xRsN0pqnfcfZ7nygpcAo2Eo
# 0Ud4S3vhMudKuvWxCdUiVBMu1INkNC4K+e264k624Y8JgjmlTLZILiwydZSKObph
# 5md7PzzxjwQymGfD8lV8+n2twilTPqMIN0MBNhG3EguKVYwBoNWzHqAehW288tf+
# G9EgeufuYqBTDexEtUusiiBmMMIgH+GlRhurKhJJYfNB0LQSuBjbjFB8tkjEyvIs
# z9bb+dBu619+FF7WgTzTw1YfJTTEkCBVbQ4lLAGfHTAHXqhCgsiHa7rOY3r5rTD/
# np+nauD470w83HLCg7WD1x030e1nIRxZEPyyQhMObBijA6qqlh86nXDC2gU7ebeS
# 1ssnWPcdAEYoZhXTVWanzlIv49q7tZ5R51opGk1GBEXgTusLhMutNj3DsGPIdEUQ
# CJDFi2WZsH92QITmbIxz1Rty+gYn6eTT6jserKHP/yjXmdxeRWPMwZZF7KEa7Iia
# 7X7vD6jvRZzu3M2mhzdsuGgdolxsoO76JVF1CnA3N1uqrrBIzRg/GP3ohXmJxUWi
# en9XMgAA00TbZwJUwK6zbxf2bQk96YBgjoHzpUOyR/ylBsb2g8Zd4vJzHRWEN101
# zJtCIewNgEk=
# SIG # End signature block
