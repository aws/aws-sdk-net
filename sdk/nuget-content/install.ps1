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
# MIIm1wYJKoZIhvcNAQcCoIImyDCCJsQCAQExDzANBglghkgBZQMEAgEFADB5Bgor
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
# uEE7MYIX1DCCF9ACAQEwfTBpMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNl
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
# K1uA0+HzQezW2q92+aGCFSowghUmBgorBgEEAYI3AwMBMYIVFjCCFRIGCSqGSIb3
# DQEHAqCCFQMwghT/AgEDMQ0wCwYJYIZIAWUDBAIBMIHzBgsqhkiG9w0BCRABBKCB
# 4wSB4DCB3QIBAQYKYIZIAYb6bAoDBTAxMA0GCWCGSAFlAwQCAQUABCCa0NNlprWU
# ZZ5oDMcpZuM4BqYTLMezce4VH1Fuc8ogoQIIe4bFQiJQTUsYDzIwMjIwNjIwMTgz
# ODE3WjADAgEBoHmkdzB1MQswCQYDVQQGEwJDQTEQMA4GA1UECBMHT250YXJpbzEP
# MA0GA1UEBxMGT3R0YXdhMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSswKQYDVQQD
# EyJFbnRydXN0IFRpbWVzdGFtcCBBdXRob3JpdHkgLSBUU0ExoIIPVTCCBCowggMS
# oAMCAQICBDhj3vgwDQYJKoZIhvcNAQEFBQAwgbQxFDASBgNVBAoTC0VudHJ1c3Qu
# bmV0MUAwPgYDVQQLFDd3d3cuZW50cnVzdC5uZXQvQ1BTXzIwNDggaW5jb3JwLiBi
# eSByZWYuIChsaW1pdHMgbGlhYi4pMSUwIwYDVQQLExwoYykgMTk5OSBFbnRydXN0
# Lm5ldCBMaW1pdGVkMTMwMQYDVQQDEypFbnRydXN0Lm5ldCBDZXJ0aWZpY2F0aW9u
# IEF1dGhvcml0eSAoMjA0OCkwHhcNOTkxMjI0MTc1MDUxWhcNMjkwNzI0MTQxNTEy
# WjCBtDEUMBIGA1UEChMLRW50cnVzdC5uZXQxQDA+BgNVBAsUN3d3dy5lbnRydXN0
# Lm5ldC9DUFNfMjA0OCBpbmNvcnAuIGJ5IHJlZi4gKGxpbWl0cyBsaWFiLikxJTAj
# BgNVBAsTHChjKSAxOTk5IEVudHJ1c3QubmV0IExpbWl0ZWQxMzAxBgNVBAMTKkVu
# dHJ1c3QubmV0IENlcnRpZmljYXRpb24gQXV0aG9yaXR5ICgyMDQ4KTCCASIwDQYJ
# KoZIhvcNAQEBBQADggEPADCCAQoCggEBAK1NS6kShrLqoyAHFRZkKitL0b8LSk2O
# 7YB2pWe3eEDAc0LIaMDbUyvdXrh2mDWTixqdfBM6Dh9btx7P5SQUHrGBqY19uMxr
# SwPxAgzcq6VAJAB/dJShnQgps4gL9Yd3nVXN5MN+12pkq4UUhpVblzJQbz3IumYM
# 4/y9uEnBdolJGf3AqL2Jo2cvxp+8cRlguC3pLMmQdmZ7lOKveNZlU1081pyyzykD
# +S+kULLUSM4FMlWK/bJkTA7kmAd123/fuQhVYIUwKfl7SKRphuM1Px6GXXp6Fb3v
# AI4VIlQXAJAmk7wOSWiRv/hH052VQsEOTd9vJs/DGCFiZkNw1tXAB+ECAwEAAaNC
# MEAwDgYDVR0PAQH/BAQDAgEGMA8GA1UdEwEB/wQFMAMBAf8wHQYDVR0OBBYEFFXk
# gdERgL7YibkIozH5oSQJFrlwMA0GCSqGSIb3DQEBBQUAA4IBAQA7m49WmzDnU5l8
# enmnTZfXGZWQ+wYfyjN8RmOPlmYk+kAbISfK5nJz8k/+MZn9yAxMaFPGgIITmPq2
# rdpdPfHObvYVEZSCDO4/la8Rqw/XL94fA49XLB7Ju5oaRJXrGE+mH819VxAvmwQJ
# WoS1btgdOuHWntFseV55HBTF49BMkztlPO3fPb6m5ZUaw7UZw71eW7v/I+9oGcsS
# kydcAy1vMNAethqs3lr30aqoJ6b+eYHEeZkzV7oSsKngQmyTylbe/m2ECwiLfo3q
# 15ghxvPnPHkvXpzRTBWN4ewiN8yaQwuX3ICQjbNnm29ICBVWz7/xK3xemnbpWZDF
# fIM1EWVRMIIFEzCCA/ugAwIBAgIMWNoT/wAAAABRzg33MA0GCSqGSIb3DQEBCwUA
# MIG0MRQwEgYDVQQKEwtFbnRydXN0Lm5ldDFAMD4GA1UECxQ3d3d3LmVudHJ1c3Qu
# bmV0L0NQU18yMDQ4IGluY29ycC4gYnkgcmVmLiAobGltaXRzIGxpYWIuKTElMCMG
# A1UECxMcKGMpIDE5OTkgRW50cnVzdC5uZXQgTGltaXRlZDEzMDEGA1UEAxMqRW50
# cnVzdC5uZXQgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkgKDIwNDgpMB4XDTE1MDcy
# MjE5MDI1NFoXDTI5MDYyMjE5MzI1NFowgbIxCzAJBgNVBAYTAlVTMRYwFAYDVQQK
# Ew1FbnRydXN0LCBJbmMuMSgwJgYDVQQLEx9TZWUgd3d3LmVudHJ1c3QubmV0L2xl
# Z2FsLXRlcm1zMTkwNwYDVQQLEzAoYykgMjAxNSBFbnRydXN0LCBJbmMuIC0gZm9y
# IGF1dGhvcml6ZWQgdXNlIG9ubHkxJjAkBgNVBAMTHUVudHJ1c3QgVGltZXN0YW1w
# aW5nIENBIC0gVFMxMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA2SPm
# FKTofEuFcVj7+IHmcotdRsOIAB840Irh1m5WMOWv2mRQfcITOfu9ZrTahPuD0Cgf
# y3boYFBpm/POTxPiwT7B3xLLMqP4XkQiDsw66Y1JuWB0yN5UPUFeQ18oRqmmt8oQ
# KyK8W01bjBdlEob9LHfVxaCMysKD4EdXfOdwrmJFJzEYCtTApBhVUvdgxgRLs91o
# Mm4QHzQRuBJ4ZPHuqeD347EijzRaZcuK9OFFUHTfk5emNObQTDufN0lSp1NOny5n
# XO2W/KW/dFGI46qOvdmxL19QMBb0UWAia5nL/+FUO7n7RDilCDkjm2lH+jzE0Oeq
# 30ay7PKKGawpsjiVdQIDAQABo4IBIzCCAR8wEgYDVR0TAQH/BAgwBgEB/wIBADAO
# BgNVHQ8BAf8EBAMCAQYwOwYDVR0gBDQwMjAwBgRVHSAAMCgwJgYIKwYBBQUHAgEW
# Gmh0dHA6Ly93d3cuZW50cnVzdC5uZXQvcnBhMDMGCCsGAQUFBwEBBCcwJTAjBggr
# BgEFBQcwAYYXaHR0cDovL29jc3AuZW50cnVzdC5uZXQwMgYDVR0fBCswKTAnoCWg
# I4YhaHR0cDovL2NybC5lbnRydXN0Lm5ldC8yMDQ4Y2EuY3JsMBMGA1UdJQQMMAoG
# CCsGAQUFBwMIMB0GA1UdDgQWBBTDwnHSe9doBa47OZs0JQxiA8dXaDAfBgNVHSME
# GDAWgBRV5IHREYC+2Im5CKMx+aEkCRa5cDANBgkqhkiG9w0BAQsFAAOCAQEAHSTn
# mnRbqnD8sQ4xRdcsAH9mOiugmjSqrGNtifmf3w13/SQj/E+ct2+P8/QftsH91hzE
# jIhmwWONuld307gaHshRrcxgNhqHaijqEWXezDwsjHS36FBD08wo6BVsESqfFJUp
# yQVXtWc26Dypg+9BwSEW0373LRFHZnZgghJpjHZVcw/fL0td6Wwj+Af2tX3WaUWc
# WH1hLvx4S0NOiZFGRCygU6hFofYWWLuRE/JLxd8LwOeuKXq9RbPncDDnNI7revbT
# tdHeaxOZRrOL0k2TdbXxb7/cACjCJb+856NlNOw/DR2XjPqqiCKkGDXbBY524xDI
# KY9j0K6sGNnaxJ9REjCCBgwwggT0oAMCAQICEQCNzhXzp5TFhwAAAABVkjP0MA0G
# CSqGSIb3DQEBCwUAMIGyMQswCQYDVQQGEwJVUzEWMBQGA1UEChMNRW50cnVzdCwg
# SW5jLjEoMCYGA1UECxMfU2VlIHd3dy5lbnRydXN0Lm5ldC9sZWdhbC10ZXJtczE5
# MDcGA1UECxMwKGMpIDIwMTUgRW50cnVzdCwgSW5jLiAtIGZvciBhdXRob3JpemVk
# IHVzZSBvbmx5MSYwJAYDVQQDEx1FbnRydXN0IFRpbWVzdGFtcGluZyBDQSAtIFRT
# MTAeFw0yMDA3MjIxNTMzMjlaFw0zMDEyMjkxNjI5MjNaMHUxCzAJBgNVBAYTAkNB
# MRAwDgYDVQQIEwdPbnRhcmlvMQ8wDQYDVQQHEwZPdHRhd2ExFjAUBgNVBAoTDUVu
# dHJ1c3QsIEluYy4xKzApBgNVBAMTIkVudHJ1c3QgVGltZXN0YW1wIEF1dGhvcml0
# eSAtIFRTQTEwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoICAQDKPuwkYuH3
# /t/RNqk3ZtZ5FxSUQgCkhpe4J4zrT6n3067iqzAECChfm1Omh4ot3QJSX7W45bZQ
# 8JyrEsHuGlZ4im5EP6mKj9fbU9nGR8gM3EZXAGcGFxqFt0Cqr3YH55BflJLVrtbX
# zXmhxTUrRIRfSRzVc7iBjXKUAmqpz1aSqjaUw1DJVpeIXOF/X/373xSOPaskDfZ7
# j2r6bh76lb19kPjkQhS/VV4EVJMxQ/fD58IFEWisQGnHIzfsWkwpyd81s35JTsZ6
# 287CJZSeNz+I7CRNOY9/7xVrVExx8Q0hfFp10IdTiaBb4B37nAfAqKG0ItBipMcX
# fzdOzi06WOPl8CaGTUIHn76j4hmia3KlRr/LZFslyEX03ug8tv2c86Dvg0F8NnCQ
# w1JisMd/PXvlloelVv8O6kkF37TdE29F05vII3kqMJmdmdzMzaUugVNSIvLQPaI3
# UpGRRnDWxUsF/0703GQGl/58kIYnr580VUiJqyLAdQeMIdkE0xyn6m2kyVIr4sQC
# iTBe55sx5jllrXGt72db3KMk7Q3m4ql6OhhV3vBGLjRNGk2YgA1O0WyFdbgDwgDV
# Ikom0Y7d7bXUJ9Y6fGdphtdUP5fPZL6Rq262nRkQebWXDvTRhcnkrsfAtKoHxB/B
# OlefzQ6meuUVhrKq9KKTLM+M91H63YzQSQIDAQABo4IBVzCCAVMwDgYDVR0PAQH/
# BAQDAgeAMBYGA1UdJQEB/wQMMAoGCCsGAQUFBwMIMEEGA1UdIAQ6MDgwNgYKYIZI
# AYb6bAoDBTAoMCYGCCsGAQUFBwIBFhpodHRwOi8vd3d3LmVudHJ1c3QubmV0L3Jw
# YTAJBgNVHRMEAjAAMGgGCCsGAQUFBwEBBFwwWjAjBggrBgEFBQcwAYYXaHR0cDov
# L29jc3AuZW50cnVzdC5uZXQwMwYIKwYBBQUHMAKGJ2h0dHA6Ly9haWEuZW50cnVz
# dC5uZXQvdHMxLWNoYWluMjU2LmNlcjAxBgNVHR8EKjAoMCagJKAihiBodHRwOi8v
# Y3JsLmVudHJ1c3QubmV0L3RzMWNhLmNybDAfBgNVHSMEGDAWgBTDwnHSe9doBa47
# OZs0JQxiA8dXaDAdBgNVHQ4EFgQULVaA7473SkMcQ6G13tnXqKprJigwDQYJKoZI
# hvcNAQELBQADggEBAFhLztj+gddR2MdcjZLSTpUehYZD7eAa5pohQjNd45G++FB8
# dowlqUHUhJno6KK2mZdooiC9MqiqKXwKdhqfyFWOq9N71ON+WX6ScDkP7fYv80//
# dFzz5zA0QKMRo2typDIRBXz9kYtHqFc2Usf6tUWE0bI+QuUWXt0D06n9PXBnetoT
# 4ISCZzhgVsOtsIjhCjd+YoEGuyME71igI6jRCWMwzdkZOPTrWndYvl+/65Qt/y8E
# MGQQjz5ZVi46Nk8OPJYPj8nqfn9JMh+jX27aIp/X2Rc5Wd5IF3oCS1hx/7cMLaHw
# Z6MR3PfJvNkey2wMFSd4SBZrLPGtl7h1bLuVw44xggSaMIIElgIBATCByDCBsjEL
# MAkGA1UEBhMCVVMxFjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xKDAmBgNVBAsTH1Nl
# ZSB3d3cuZW50cnVzdC5uZXQvbGVnYWwtdGVybXMxOTA3BgNVBAsTMChjKSAyMDE1
# IEVudHJ1c3QsIEluYy4gLSBmb3IgYXV0aG9yaXplZCB1c2Ugb25seTEmMCQGA1UE
# AxMdRW50cnVzdCBUaW1lc3RhbXBpbmcgQ0EgLSBUUzECEQCNzhXzp5TFhwAAAABV
# kjP0MAsGCWCGSAFlAwQCAaCCAaYwGgYJKoZIhvcNAQkDMQ0GCyqGSIb3DQEJEAEE
# MBwGCSqGSIb3DQEJBTEPFw0yMjA2MjAxODM4MTdaMCkGCSqGSIb3DQEJNDEcMBow
# CwYJYIZIAWUDBAIBoQsGCSqGSIb3DQEBCzAvBgkqhkiG9w0BCQQxIgQgYuspfvru
# SWAy3Lfk90H4QDBFX2GBISEw131pAGr3320wggEMBgsqhkiG9w0BCRACLzGB/DCB
# +TCB9jCB8wQglQom/cfAIBjp95GpXDjybu89pDJnyrDNFaVVr2MQcskwgc4wgbik
# gbUwgbIxCzAJBgNVBAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSgwJgYD
# VQQLEx9TZWUgd3d3LmVudHJ1c3QubmV0L2xlZ2FsLXRlcm1zMTkwNwYDVQQLEzAo
# YykgMjAxNSBFbnRydXN0LCBJbmMuIC0gZm9yIGF1dGhvcml6ZWQgdXNlIG9ubHkx
# JjAkBgNVBAMTHUVudHJ1c3QgVGltZXN0YW1waW5nIENBIC0gVFMxAhEAjc4V86eU
# xYcAAAAAVZIz9DALBgkqhkiG9w0BAQsEggIAq/Gc6nM1UOcXACnQVN8tKMpVpTi6
# kv3VM+Mky7jibav8WZqC57KQKE/q6UcRp8tgKv5m/ND3TNLucKoS5JZs/3cTtf9j
# dNLQ2IAhXA2XA4bqldcY3e2vkskzlrMapiQqvbqgepy5xOkgjGfRaD+lViKv4mu2
# DPKmJqLEtGqaIyZ7wLEzW0HM3w2w/J5fESbHE4sIasMZI+Sp6RROgrYwmLAHmket
# slROSVCg8owud1vIB0sMjk1eUesL9u2mrE11NnuL68AK5VEmY1RGWsx6fxtUowze
# xWw5DF7o7PfCzeAQZo+G7Vu2RU2V+cGuwSIGU7bYmPs8IFfVJ+yfr4TlSPA+jypn
# J/NFqoBnDo/UD0Vys8ZxAFvYB9wwaz/BY89nIT2GW92+FWQxL89DlNTaX2tgz+ZJ
# i+RxzzLQqfVMkTOdIa7qSRfD/pjj8TNQ9Zpy3pgL56VUpzsMz60uaYbRJ0uwb4h2
# pKhzvNAjEXTLIpD3tPz0MBP7FiePpDlwFkWRh/t8xUah+CoXYmIKvgpu5AbiyAq+
# o7h46cDnblgwTHEFrYBNqADmolH7CHVrECCwuPQyvAsxtFSRk6JEZvsyklWcHyNc
# 1iGT+JbD/wdxosTp1vhsHn1p87yLOSIvJRSG2okcCBWyWnrzAN5/3vOinsYiPRbI
# LiWJV2lGBH7GQMo=
# SIG # End signature block
