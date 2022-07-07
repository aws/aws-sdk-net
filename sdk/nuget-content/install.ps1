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
# MIIpzwYJKoZIhvcNAQcCoIIpwDCCKbwCAQExDzANBglghkgBZQMEAgEFADB5Bgor
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
# uEE7MYIazDCCGsgCAQEwfTBpMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNl
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
# K1uA0+HzQezW2q92+aGCGCIwghgeBgorBgEEAYI3AwMBMYIYDjCCGAoGCSqGSIb3
# DQEHAqCCF/swghf3AgEDMQ0wCwYJYIZIAWUDBAIDMIHzBgsqhkiG9w0BCRABBKCB
# 4wSB4DCB3QIBAQYKYIZIAYb6bAoDBTAxMA0GCWCGSAFlAwQCAQUABCCa0NNlprWU
# ZZ5oDMcpZuM4BqYTLMezce4VH1Fuc8ogoQIIGJMGTOPMh34YDzIwMjIwNzA3MTg0
# MzA2WjADAgEBoHmkdzB1MQswCQYDVQQGEwJDQTEQMA4GA1UECBMHT250YXJpbzEP
# MA0GA1UEBxMGT3R0YXdhMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSswKQYDVQQD
# EyJFbnRydXN0IFRpbWVzdGFtcCBBdXRob3JpdHkgLSBUU0EyoIIS0TCCBaIwggOK
# oAMCAQICFH/xqPn0OuiHbi3G/15DPbLuMKZDMA0GCSqGSIb3DQEBDQUAMGkxCzAJ
# BgNVBAYTAlVTMRYwFAYDVQQKDA1FbnRydXN0LCBJbmMuMUIwQAYDVQQDDDlFbnRy
# dXN0IENvZGUgU2lnbmluZyBSb290IENlcnRpZmljYXRpb24gQXV0aG9yaXR5IC0g
# Q1NCUjEwHhcNMjEwNTA3MTMyNjM2WhcNNDAxMjMwMTMyNjM2WjBpMQswCQYDVQQG
# EwJVUzEWMBQGA1UECgwNRW50cnVzdCwgSW5jLjFCMEAGA1UEAww5RW50cnVzdCBD
# b2RlIFNpZ25pbmcgUm9vdCBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eSAtIENTQlIx
# MIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAp4GP9xRFtmJD8tiu0yVe
# SE9Rv8V9n1AcNdHWfmEqlBltJ0akphpd91RRaoAixqhmdU1Ug8leaBur9ltksK2t
# IL1U70ZrbQLnRa519o6KuTIui7h3HFJNeYhfpToYyVAslyctv9oAfWN/7zLsRodj
# 25qfw1ohNnv5m9XKoG5yLPzh8Z5wTQhWFW+Qq/tIurnXwYJ4hWUuf7XJwOIUtzcR
# QQbiiuCo9uV+tngFAcNg7U8HQS4KE0njkJt/3b36rL9kUdFcm7T1XOdc/zubpaAa
# 130JssK3/24cvMh95ukr/HKzFOlKVRKEnEQldR32KvBPpSA9aCXrYZd8D+W2PfOu
# w8ERvBuOzOBHMF5CAIZx41isBsplH3uUpktXZwx+Xq14Z1tV417rx9jsTG6Gy/Pc
# +J+HqnJYEg99pvj4Qjk7PCzkMk1JjODhAMI4oJz6hD5B3G5WrsYaW/RnaAUBzRu/
# roe8nVP2Lui2a+SZ3sVPh1io0mUeyB/Vcm7uWRxXOwlyndfKt5DGzXtFkpFCA0x9
# P8ryqrjCDobzEJ9GLqRmhmhaaBhwKTgRgGBrikOjc2zjs2s3/+adZwGSht8vSNH7
# UGDVXP4h0wFCY/7vcLQXwI+o7tPBS18S6v39Lg6HRGDjqfTCGKPj/c4MhCIN86d4
# 2pPz2zjPuS8zxv8HPF6+RdMCAwEAAaNCMEAwHQYDVR0OBBYEFIK61j2Xzp/PceiS
# N6/9s7VpNVfPMA8GA1UdEwEB/wQFMAMBAf8wDgYDVR0PAQH/BAQDAgGGMA0GCSqG
# SIb3DQEBDQUAA4ICAQAS7zihiOGho9Zl3Eec87zcz6xLjDwaviv099BnF2iGTXCo
# 8s3QMQJXfakMijtXOZ7wbvckIgVn0cGWwb7R8PhWZwveuteIm43Xawh29ViR2bXD
# QFMapPGFzT8ATj9Okzt4udIHUmQMhmlt6FRlVhfoAFOEivPb+7POC1Vij81MSQY4
# f1LD8xzXPfczyjKtwamvb+sRy+6sUb+wJpp6TiO0SvZptEJp1qCNtoxHSjsgN7dB
# B+8vINhmHGmXqGwwfHdDXmu+JpiDDzrWx3AqFkYtJVSGY2VXQvcjQelQagdDzk61
# 6R9o2NjWCUqo6LL8kGeS5JAm80f61iD7iYDiRHM594qGMwv4qqnnTezcb9XPMU2r
# jh+QQNZ8XIIPrhdScems50047SrYdnmHrRejTKu3Qle/Bqzl0E0w6VVP40XK8+Bq
# ITSNx58co2NIktKWB76lRz7CKpk4p47aIXxRbdzLPQfpqb1J1F01X1uMBFHqmliQ
# uhuvaHixFg+UKTuPmyqPySDwcUJMXE2rMYyr6X8maGmgpRYNgcTRBQzDh2blB2Oq
# G07/sgdBT6UiRlCsZgCHUmw8sjucl6FGtFvez8JqWVUHjKOk0Xc1Z0YEL9k4uUav
# uo4bciYCL3ZU74PCLyx3cMx3EJKqA63KzOBP6YNG5bM8GW96eYe2OJq9Qs6kYjCC
# Bm8wggRXoAMCAQICECW8K/MpyhB/Hqm6iIXUnTswDQYJKoZIhvcNAQENBQAwaTEL
# MAkGA1UEBhMCVVMxFjAUBgNVBAoMDUVudHJ1c3QsIEluYy4xQjBABgNVBAMMOUVu
# dHJ1c3QgQ29kZSBTaWduaW5nIFJvb3QgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkg
# LSBDU0JSMTAeFw0yMTA1MDcxOTIyMTRaFw00MDEyMjkyMzU5MDBaME4xCzAJBgNV
# BAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMScwJQYDVQQDEx5FbnRydXN0
# IFRpbWUgU3RhbXBpbmcgQ0EgLSBUUzIwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAw
# ggIKAoICAQC1AyoGtoRPNMyeMb7qjsZ7biAkDwPXvYE2M+Zv0j67xJ6qoMxmXUJg
# NFHiLWGDujyeaLhLw2aOpd4rupstQaXe0MtXBS2I2cBGiG08NQ0ZkKy4DBnwTMXb
# RVvcO8K8jUQA4Dj//13IzwiaPdSy63uVw8SlAOBiAWRZX4zje4up+UW3xrCiCjdD
# uEaBq4Z+fy/e8F/rzSDMpS0x46gumZvgeN30212CY30wOYh+JAbmfGCEeMhcKeWV
# y/V7T89Y3JDPp6J7FFTE4DeYMMGbtq6cKfZrJUPnEmo+GYu+wOeB10owCH58jd88
# 80iTId6Bg2qdAD7XYLrRs2IIlum2SQA49Fx2Ddp3aj2gld4eocxZel6fz+l2XUDy
# tRW1YGgs81rJI4PY9RpraSikttSuYgbeJkW93ulWd6rcZLBBzcwT8V1xdLKUCEtP
# Mm5+cLh36dUyN8J63kIS6HEc4thiv6prQYYGW+ZpviYJ9JfC/kz0gHKEbtvexQep
# jhWibeEb4AkP9aAHoLvEd3MJPAeTjQG1EmctTRm1uMXJEKtwz0L/pScd1hLW5BhE
# YPs5XYS7ZrVTEp0DFIJlKbTsSXL9s0PlwwIpJLof+Li+XaO3Lqn8z2LZ+pfEE3jj
# VblaeoTr/7vPaYjAtvmLYIVBEFDHBRDSXnadPjXs9k+K+RJ7P68LNwIDAQABo4IB
# LDCCASgwEgYDVR0TAQH/BAgwBgEB/wIBADAdBgNVHQ4EFgQUJg/wxEgIG83dkfVU
# VLazs/yZ8QgwHwYDVR0jBBgwFoAUgrrWPZfOn89x6JI3r/2ztWk1V88wMwYIKwYB
# BQUHAQEEJzAlMCMGCCsGAQUFBzABhhdodHRwOi8vb2NzcC5lbnRydXN0Lm5ldDAx
# BgNVHR8EKjAoMCagJKAihiBodHRwOi8vY3JsLmVudHJ1c3QubmV0L2NzYnIxLmNy
# bDAOBgNVHQ8BAf8EBAMCAYYwEwYDVR0lBAwwCgYIKwYBBQUHAwgwRQYDVR0gBD4w
# PDAwBgRVHSAAMCgwJgYIKwYBBQUHAgEWGmh0dHA6Ly93d3cuZW50cnVzdC5uZXQv
# cnBhMAgGBmeBDAEEAjANBgkqhkiG9w0BAQ0FAAOCAgEAdj1GaIVfCcDOyfjHuNd+
# p1w7C0ZzziJTizj2Ebp3xMKHIY8n2QyV6+hL5VzXkBVvqCosimrgIhE0efq9lnnI
# dhbNsUTqcVEPm1XJGHzVgnmc86a3k6kFOHICBpehqLJ5fl4I4m5seZqoh5TOf49V
# NkAPnz9R1Wa+e6uG5m6Huk5jXbHYjh/LZ8MNcNp665OyFITSPn2TPxYMNqBceQCf
# C27lhCrYiMFtBLc385KacOA7A/3NuyeCzi/8jeSyyr74JYXG7XTIPTVfOAk9eU/r
# G+BBXqV0gT9RFcD4SYiPursF1K1FgjN5wSWNX1Q9keS4nxeYAF2tKOVPXxv7+FS1
# pcQk/PB2O/gNXsxHsMqqu25R31O1SRrxYIe3+f1pBnVfc9YRkPKAWI7lww8DmIwE
# U7Mph98/97DpTFeBJER5aP4bNgfWZT3sb9bCtaphfGYG7NLlaYD4cZIuXOIRRhhF
# S9b6BWTvu94GykMlvd+NyQF0YYjb8MemPeMMcbx/S+fI4G7g2oD5AJ7AayXVo7pc
# K/7EYCAUSgcjMeUay5FEspp7Q/FbmLUhS7gxOyJU7nlh95qUG2YnKsbf4WVd73E5
# 5lAl/Yc0ua5dfCc752WT+CiEsW+GkyyTk7Zwr6HuyKRhqYQ7+wq3+LhtJu5HTvVe
# BfqcDxF918uRrkMg9xVZY7wwgga0MIIEnKADAgECAhB02fLbUTwiZ/1HnDYHP3sd
# MA0GCSqGSIb3DQEBDQUAME4xCzAJBgNVBAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0
# LCBJbmMuMScwJQYDVQQDEx5FbnRydXN0IFRpbWUgU3RhbXBpbmcgQ0EgLSBUUzIw
# HhcNMjEwNTE0MDAwMDAwWhcNMzIwODE0MDAwMDAwWjB1MQswCQYDVQQGEwJDQTEQ
# MA4GA1UECBMHT250YXJpbzEPMA0GA1UEBxMGT3R0YXdhMRYwFAYDVQQKEw1FbnRy
# dXN0LCBJbmMuMSswKQYDVQQDEyJFbnRydXN0IFRpbWVzdGFtcCBBdXRob3JpdHkg
# LSBUU0EyMIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAr78sRrxrMbAm
# fwKm+HDrZJboShopDEFc4BxKpbmCM5OmzlYGH5SeqVECGY278g+e24nQM4RY4w6g
# 3vlSQSC8YNcLYadPb0JMcJycKSMLwqfCXN2euCzzXrhBuUjKM3A0E3X3UF5tJm7F
# FDMxF82Bu7oSUKCswXsFg3IQbylD/BtpL8XC64XXg5VgCCN131wi/6SBBtHO8Ldc
# HE6ZsKikHYDjcDzYeV7DyQkH2TOSNZYhSX/U63jS+KfzC7lKgBE1qSzYQpu2bpir
# UMNQoS323fKnMZ8bC2dVM54Ye8xiC5TUI9Ol6bopYxElZmeUW/87eTiw0y0WdYn0
# 83iQWr9rfheqg6TxUIGcgtweymKxdQ+Ivw0XegrtA8QNj7XvLCXViJTnXBbTeE+y
# 8jR7WUkYz8qD3FAAviJvylS8JicnOqetyjg+DK+oIe2VcujV0nt4EvGeYtn+At+g
# u8l+8GRsyNitQ+QpzWe8m00FbnOuHgx0g6DX8ajRE7rGk90R7gSjWWENogEkVxY/
# MwRkagYH12lW8YpkqRg/CbAMPAf1Cj+Z1IXnD5fB0SvDHa6H23J1GPObdlVACcdV
# nCxGR6faTKOcEe/hdFR3e3jAthTiz9qc1EZd0NYKkx8BJ+fY/MMKbN98rU8dkLPW
# jifopr9LRnFmOsb5aOlE+nkHBk3vG70CAwEAAaOCAWUwggFhMAwGA1UdEwEB/wQC
# MAAwHQYDVR0OBBYEFML10RbBzb2teGFUzggUbvYBD75mMB8GA1UdIwQYMBaAFCYP
# 8MRICBvN3ZH1VFS2s7P8mfEIMGgGCCsGAQUFBwEBBFwwWjAjBggrBgEFBQcwAYYX
# aHR0cDovL29jc3AuZW50cnVzdC5uZXQwMwYIKwYBBQUHMAKGJ2h0dHA6Ly9haWEu
# ZW50cnVzdC5uZXQvdHMyLWNoYWluMjU2LmNlcjAxBgNVHR8EKjAoMCagJKAihiBo
# dHRwOi8vY3JsLmVudHJ1c3QubmV0L3RzMmNhLmNybDAOBgNVHQ8BAf8EBAMCB4Aw
# FgYDVR0lAQH/BAwwCgYIKwYBBQUHAwgwTAYDVR0gBEUwQzA3BgpghkgBhvpsCgMF
# MCkwJwYIKwYBBQUHAgEWG2h0dHBzOi8vd3d3LmVudHJ1c3QubmV0L3JwYTAIBgZn
# gQwBBAIwDQYJKoZIhvcNAQENBQADggIBAHUii1PAcZdOSgWtTQ4OK5RA4ryn+6No
# JcStUGc1yxS8dJZgef/hsXsPP2jr8ob5HT1PV7ouyCfTp7sni5Pj6hjPUSx/ojrF
# n+CbACt0KPKW4PTCGoRYtueQi8XsSQa86BEEFJbVv92enUowr+HK5muoBNKrp5Ei
# r838Zll/WiZjumdAhiiL7N2OI7o4QNzDC9Y/Qo75zgJoM4tLqBvmmaZsXhxrjY3k
# L2uATQ3PkmJieNYLwVyBuuzNO46LW65rANu4HJ8wyJkCjQ0acFkz/9ifvBBQpMDA
# Ffsv2gRj7Dk6gr3FJ0tkgrVdD3DnfNJVFcg2ErX+8loIZJqD8MmLaTz6uXI+y0/X
# iXIMExdAUjq5+BASTeToLVrV2PrMmQGCTNIUL91lZs4xAi9e2Txfk+GSnLjWVa0O
# tK/r9TO/NhdhtDQ2eOz2Co1yg3QVE7wIdhvL/BadYP+m/wib/HlTInayQjbZjif3
# ePDhc38warCwZGfWuwFPjXh6d7bBfX1/euhU5Peu2vRIMHn75ihjvXwc6feztLV2
# D3nE1e1hExtxRpYdZt4SpmofHau1bv9YHkeQ/+plOkgdCyBJhSJHdLYBorC53+CG
# 7VPdmKYtruG9KEcm520zGiKHq8f+8xtqBMi539uy+z3bmiPJc55fx9hcogSbEsGq
# oo4b/BQRkm3cMYIEFjCCBBICAQEwYjBOMQswCQYDVQQGEwJVUzEWMBQGA1UEChMN
# RW50cnVzdCwgSW5jLjEnMCUGA1UEAxMeRW50cnVzdCBUaW1lIFN0YW1waW5nIENB
# IC0gVFMyAhB02fLbUTwiZ/1HnDYHP3sdMAsGCWCGSAFlAwQCA6CCAYkwGgYJKoZI
# hvcNAQkDMQ0GCyqGSIb3DQEJEAEEMBwGCSqGSIb3DQEJBTEPFw0yMjA3MDcxODQz
# MDZaMCkGCSqGSIb3DQEJNDEcMBowCwYJYIZIAWUDBAIDoQsGCSqGSIb3DQEBDTBP
# BgkqhkiG9w0BCQQxQgRAWqbMgMWVhQWABJ+383k1cbNZJBIRzE/OAkV389ILpkCZ
# for5iYu2E0wmvG0v+UJ8I2BrnN6y0DMp0YIFpDD3JjCB0AYLKoZIhvcNAQkQAi8x
# gcAwgb0wgbowgbcwCwYJYIZIAWUDBAIDBEBgeV8tFsacWf2h3lljrc/jpIgUtlzo
# EUvVv+4PErs88FYx5CQUuRm4wTHWq63lQteCyIoxkGUvSwr88hkRyTeMMGYwUqRQ
# ME4xCzAJBgNVBAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMScwJQYDVQQD
# Ex5FbnRydXN0IFRpbWUgU3RhbXBpbmcgQ0EgLSBUUzICEHTZ8ttRPCJn/UecNgc/
# ex0wCwYJKoZIhvcNAQENBIICAIfGIJnXCf0Wof2jLZelS1Si2BEwgicTBk0B2R5r
# LXIjNTpQnGVr4TZUKPDlCFcAra7bMSTWIZahEGW4lgWO62QbHulmLbtmAso2/GRY
# l/6C1BtYfDverNa3n5FFBdltbbq4E0ZAFjPyeLRmtm49H7DH1fX5xXvueor6r2oy
# yEsGrVnzShEqGQrwFAFHG4Y4zsOhEpEzDwDLuYzWaSAIPzua53S8eUXluqJjvVi5
# rXa9UN66QIG6TPW0eILA+bLFjp9OBAmlYzF4UVDIXkwfveVLZR7hLcQa/N+EUxeX
# 94tPpoxshbD0nN5z1hy0FJtwxg+A4LOo7yAsYekuvDOCqJ2v4Ac8dWgwJOckNu9C
# E23mVW8QUmnKkoeH6gCCLO0b5vza1t/OKaH/uJEabYzcU6mdKCitZPJu5j8jKK7O
# ZurSX7+ZbQalsRlmLEBy7vcoiVEqEBx7roLy2RoZJcX/tnOMQ9sKGEiV9LLggUGR
# eQ5wlew6iG/bAG+kJqiALV83TqyVlE0PjCo6gGyxtUrn2Eu/z8N4XQG8FgZ5nqyI
# 0ar9GKD+sBTtvVXRdBs4x1vXWB548BSS0fxTTVcSdKEmswDyZkhSUTK/iCmzPqDx
# wLaV81JwfW7L98Bi9WDQX52FCmKJImM2IpixhWSLAkArLfumYZg35i++taSJvkYU
# Msij
# SIG # End signature block
