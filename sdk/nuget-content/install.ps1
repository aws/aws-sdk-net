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
# MIIqDQYJKoZIhvcNAQcCoIIp/jCCKfoCAQExDzANBglghkgBZQMEAgEFADB5Bgor
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
# uEE7MYIbCjCCGwYCAQEwfTBpMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNl
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
# K1uA0+HzQezW2q92+aGCGGAwghhcBgorBgEEAYI3AwMBMYIYTDCCGEgGCSqGSIb3
# DQEHAqCCGDkwghg1AgEDMQ0wCwYJYIZIAWUDBAIDMIH0BgsqhkiG9w0BCRABBKCB
# 5ASB4TCB3gIBAQYKYIZIAYb6bAoDBTAxMA0GCWCGSAFlAwQCAQUABCCa0NNlprWU
# ZZ5oDMcpZuM4BqYTLMezce4VH1Fuc8ogoQIJALf/LEenSC4wGA8yMDIyMDYxMDE5
# MDgyM1owAwIBAaB5pHcwdTELMAkGA1UEBhMCQ0ExEDAOBgNVBAgTB09udGFyaW8x
# DzANBgNVBAcTBk90dGF3YTEWMBQGA1UEChMNRW50cnVzdCwgSW5jLjErMCkGA1UE
# AxMiRW50cnVzdCBUaW1lc3RhbXAgQXV0aG9yaXR5IC0gVFNBMqCCEw4wggXfMIIE
# x6ADAgECAhBOQOQ3VO3mjAAAAABR05R/MA0GCSqGSIb3DQEBCwUAMIG+MQswCQYD
# VQQGEwJVUzEWMBQGA1UEChMNRW50cnVzdCwgSW5jLjEoMCYGA1UECxMfU2VlIHd3
# dy5lbnRydXN0Lm5ldC9sZWdhbC10ZXJtczE5MDcGA1UECxMwKGMpIDIwMDkgRW50
# cnVzdCwgSW5jLiAtIGZvciBhdXRob3JpemVkIHVzZSBvbmx5MTIwMAYDVQQDEylF
# bnRydXN0IFJvb3QgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkgLSBHMjAeFw0yMTA1
# MDcxNTQzNDVaFw0zMDExMDcxNjEzNDVaMGkxCzAJBgNVBAYTAlVTMRYwFAYDVQQK
# DA1FbnRydXN0LCBJbmMuMUIwQAYDVQQDDDlFbnRydXN0IENvZGUgU2lnbmluZyBS
# b290IENlcnRpZmljYXRpb24gQXV0aG9yaXR5IC0gQ1NCUjEwggIiMA0GCSqGSIb3
# DQEBAQUAA4ICDwAwggIKAoICAQCngY/3FEW2YkPy2K7TJV5IT1G/xX2fUBw10dZ+
# YSqUGW0nRqSmGl33VFFqgCLGqGZ1TVSDyV5oG6v2W2Swra0gvVTvRmttAudFrnX2
# joq5Mi6LuHccUk15iF+lOhjJUCyXJy2/2gB9Y3/vMuxGh2Pbmp/DWiE2e/mb1cqg
# bnIs/OHxnnBNCFYVb5Cr+0i6udfBgniFZS5/tcnA4hS3NxFBBuKK4Kj25X62eAUB
# w2DtTwdBLgoTSeOQm3/dvfqsv2RR0VybtPVc51z/O5uloBrXfQmywrf/bhy8yH3m
# 6Sv8crMU6UpVEoScRCV1HfYq8E+lID1oJethl3wP5bY9867DwRG8G47M4EcwXkIA
# hnHjWKwGymUfe5SmS1dnDH5erXhnW1XjXuvH2OxMbobL89z4n4eqclgSD32m+PhC
# OTs8LOQyTUmM4OEAwjignPqEPkHcblauxhpb9GdoBQHNG7+uh7ydU/Yu6LZr5Jne
# xU+HWKjSZR7IH9Vybu5ZHFc7CXKd18q3kMbNe0WSkUIDTH0/yvKquMIOhvMQn0Yu
# pGaGaFpoGHApOBGAYGuKQ6NzbOOzazf/5p1nAZKG3y9I0ftQYNVc/iHTAUJj/u9w
# tBfAj6ju08FLXxLq/f0uDodEYOOp9MIYo+P9zgyEIg3zp3jak/PbOM+5LzPG/wc8
# Xr5F0wIDAQABo4IBKzCCAScwDgYDVR0PAQH/BAQDAgGGMBIGA1UdEwEB/wQIMAYB
# Af8CAQEwHQYDVR0lBBYwFAYIKwYBBQUHAwMGCCsGAQUFBwMIMDsGA1UdIAQ0MDIw
# MAYEVR0gADAoMCYGCCsGAQUFBwIBFhpodHRwOi8vd3d3LmVudHJ1c3QubmV0L3Jw
# YTAzBggrBgEFBQcBAQQnMCUwIwYIKwYBBQUHMAGGF2h0dHA6Ly9vY3NwLmVudHJ1
# c3QubmV0MDAGA1UdHwQpMCcwJaAjoCGGH2h0dHA6Ly9jcmwuZW50cnVzdC5uZXQv
# ZzJjYS5jcmwwHQYDVR0OBBYEFIK61j2Xzp/PceiSN6/9s7VpNVfPMB8GA1UdIwQY
# MBaAFGpyJnrQHu995ztpUdRsjZ+QEmarMA0GCSqGSIb3DQEBCwUAA4IBAQAfXkEE
# toNwJFMsVXMdZTrA7LR7BJheWTgTCaRZlEJeUL9PbG4lIJCTWEAN9Rm0Yu4kXsIB
# WBUCHRAJb6jU+5J+Nzg+LxR9jx1DNmSzZhNfFMylcfdbIUvGl77clfxwfREc0yHd
# 0CQ5KcX+Chqlz3t57jpv3ty/6RHdFoMI0yyNf02oFHkvBWFSOOtg8xRofcuyiq3A
# lFzkJg4sit1Gw87kVlHFVuOFuE2bRXKLB/GK+0m4X9HyloFdaVIk8Qgj0tYjD+uL
# 136LwZNr+vFie1jpUJuXbheIDeHGQ5jXgWG2hZ1H7LGerj8gO0Od2KIc4NR8CMKv
# dgb4YmZ6tvf6yK81MIIGbzCCBFegAwIBAgIQJbwr8ynKEH8eqbqIhdSdOzANBgkq
# hkiG9w0BAQ0FADBpMQswCQYDVQQGEwJVUzEWMBQGA1UECgwNRW50cnVzdCwgSW5j
# LjFCMEAGA1UEAww5RW50cnVzdCBDb2RlIFNpZ25pbmcgUm9vdCBDZXJ0aWZpY2F0
# aW9uIEF1dGhvcml0eSAtIENTQlIxMB4XDTIxMDUwNzE5MjIxNFoXDTQwMTIyOTIz
# NTkwMFowTjELMAkGA1UEBhMCVVMxFjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xJzAl
# BgNVBAMTHkVudHJ1c3QgVGltZSBTdGFtcGluZyBDQSAtIFRTMjCCAiIwDQYJKoZI
# hvcNAQEBBQADggIPADCCAgoCggIBALUDKga2hE80zJ4xvuqOxntuICQPA9e9gTYz
# 5m/SPrvEnqqgzGZdQmA0UeItYYO6PJ5ouEvDZo6l3iu6my1Bpd7Qy1cFLYjZwEaI
# bTw1DRmQrLgMGfBMxdtFW9w7wryNRADgOP//XcjPCJo91LLre5XDxKUA4GIBZFlf
# jON7i6n5RbfGsKIKN0O4RoGrhn5/L97wX+vNIMylLTHjqC6Zm+B43fTbXYJjfTA5
# iH4kBuZ8YIR4yFwp5ZXL9XtPz1jckM+nonsUVMTgN5gwwZu2rpwp9mslQ+cSaj4Z
# i77A54HXSjAIfnyN3zzzSJMh3oGDap0APtdgutGzYgiW6bZJADj0XHYN2ndqPaCV
# 3h6hzFl6Xp/P6XZdQPK1FbVgaCzzWskjg9j1GmtpKKS21K5iBt4mRb3e6VZ3qtxk
# sEHNzBPxXXF0spQIS08ybn5wuHfp1TI3wnreQhLocRzi2GK/qmtBhgZb5mm+Jgn0
# l8L+TPSAcoRu297FB6mOFaJt4RvgCQ/1oAegu8R3cwk8B5ONAbUSZy1NGbW4xckQ
# q3DPQv+lJx3WEtbkGERg+zldhLtmtVMSnQMUgmUptOxJcv2zQ+XDAikkuh/4uL5d
# o7cuqfzPYtn6l8QTeONVuVp6hOv/u89piMC2+YtghUEQUMcFENJedp0+Nez2T4r5
# Ens/rws3AgMBAAGjggEsMIIBKDASBgNVHRMBAf8ECDAGAQH/AgEAMB0GA1UdDgQW
# BBQmD/DESAgbzd2R9VRUtrOz/JnxCDAfBgNVHSMEGDAWgBSCutY9l86fz3Hokjev
# /bO1aTVXzzAzBggrBgEFBQcBAQQnMCUwIwYIKwYBBQUHMAGGF2h0dHA6Ly9vY3Nw
# LmVudHJ1c3QubmV0MDEGA1UdHwQqMCgwJqAkoCKGIGh0dHA6Ly9jcmwuZW50cnVz
# dC5uZXQvY3NicjEuY3JsMA4GA1UdDwEB/wQEAwIBhjATBgNVHSUEDDAKBggrBgEF
# BQcDCDBFBgNVHSAEPjA8MDAGBFUdIAAwKDAmBggrBgEFBQcCARYaaHR0cDovL3d3
# dy5lbnRydXN0Lm5ldC9ycGEwCAYGZ4EMAQQCMA0GCSqGSIb3DQEBDQUAA4ICAQB2
# PUZohV8JwM7J+Me4136nXDsLRnPOIlOLOPYRunfEwochjyfZDJXr6EvlXNeQFW+o
# KiyKauAiETR5+r2Wech2Fs2xROpxUQ+bVckYfNWCeZzzpreTqQU4cgIGl6Gosnl+
# Xgjibmx5mqiHlM5/j1U2QA+fP1HVZr57q4bmboe6TmNdsdiOH8tnww1w2nrrk7IU
# hNI+fZM/Fgw2oFx5AJ8LbuWEKtiIwW0Etzfzkppw4DsD/c27J4LOL/yN5LLKvvgl
# hcbtdMg9NV84CT15T+sb4EFepXSBP1EVwPhJiI+6uwXUrUWCM3nBJY1fVD2R5Lif
# F5gAXa0o5U9fG/v4VLWlxCT88HY7+A1ezEewyqq7blHfU7VJGvFgh7f5/WkGdV9z
# 1hGQ8oBYjuXDDwOYjARTsymH3z/3sOlMV4EkRHlo/hs2B9ZlPexv1sK1qmF8Zgbs
# 0uVpgPhxki5c4hFGGEVL1voFZO+73gbKQyW9343JAXRhiNvwx6Y94wxxvH9L58jg
# buDagPkAnsBrJdWjulwr/sRgIBRKByMx5RrLkUSymntD8VuYtSFLuDE7IlTueWH3
# mpQbZicqxt/hZV3vcTnmUCX9hzS5rl18JzvnZZP4KISxb4aTLJOTtnCvoe7IpGGp
# hDv7Crf4uG0m7kdO9V4F+pwPEX3Xy5GuQyD3FVljvDCCBrQwggScoAMCAQICEHTZ
# 8ttRPCJn/UecNgc/ex0wDQYJKoZIhvcNAQENBQAwTjELMAkGA1UEBhMCVVMxFjAU
# BgNVBAoTDUVudHJ1c3QsIEluYy4xJzAlBgNVBAMTHkVudHJ1c3QgVGltZSBTdGFt
# cGluZyBDQSAtIFRTMjAeFw0yMTA1MTQwMDAwMDBaFw0zMjA4MTQwMDAwMDBaMHUx
# CzAJBgNVBAYTAkNBMRAwDgYDVQQIEwdPbnRhcmlvMQ8wDQYDVQQHEwZPdHRhd2Ex
# FjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xKzApBgNVBAMTIkVudHJ1c3QgVGltZXN0
# YW1wIEF1dGhvcml0eSAtIFRTQTIwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAwggIK
# AoICAQCvvyxGvGsxsCZ/Aqb4cOtkluhKGikMQVzgHEqluYIzk6bOVgYflJ6pUQIZ
# jbvyD57bidAzhFjjDqDe+VJBILxg1wthp09vQkxwnJwpIwvCp8Jc3Z64LPNeuEG5
# SMozcDQTdfdQXm0mbsUUMzEXzYG7uhJQoKzBewWDchBvKUP8G2kvxcLrhdeDlWAI
# I3XfXCL/pIEG0c7wt1wcTpmwqKQdgONwPNh5XsPJCQfZM5I1liFJf9TreNL4p/ML
# uUqAETWpLNhCm7ZumKtQw1ChLfbd8qcxnxsLZ1Uznhh7zGILlNQj06XpuiljESVm
# Z5Rb/zt5OLDTLRZ1ifTzeJBav2t+F6qDpPFQgZyC3B7KYrF1D4i/DRd6Cu0DxA2P
# te8sJdWIlOdcFtN4T7LyNHtZSRjPyoPcUAC+Im/KVLwmJyc6p63KOD4Mr6gh7ZVy
# 6NXSe3gS8Z5i2f4C36C7yX7wZGzI2K1D5CnNZ7ybTQVuc64eDHSDoNfxqNETusaT
# 3RHuBKNZYQ2iASRXFj8zBGRqBgfXaVbximSpGD8JsAw8B/UKP5nUhecPl8HRK8Md
# rofbcnUY85t2VUAJx1WcLEZHp9pMo5wR7+F0VHd7eMC2FOLP2pzURl3Q1gqTHwEn
# 59j8wwps33ytTx2Qs9aOJ+imv0tGcWY6xvlo6UT6eQcGTe8bvQIDAQABo4IBZTCC
# AWEwDAYDVR0TAQH/BAIwADAdBgNVHQ4EFgQUwvXRFsHNva14YVTOCBRu9gEPvmYw
# HwYDVR0jBBgwFoAUJg/wxEgIG83dkfVUVLazs/yZ8QgwaAYIKwYBBQUHAQEEXDBa
# MCMGCCsGAQUFBzABhhdodHRwOi8vb2NzcC5lbnRydXN0Lm5ldDAzBggrBgEFBQcw
# AoYnaHR0cDovL2FpYS5lbnRydXN0Lm5ldC90czItY2hhaW4yNTYuY2VyMDEGA1Ud
# HwQqMCgwJqAkoCKGIGh0dHA6Ly9jcmwuZW50cnVzdC5uZXQvdHMyY2EuY3JsMA4G
# A1UdDwEB/wQEAwIHgDAWBgNVHSUBAf8EDDAKBggrBgEFBQcDCDBMBgNVHSAERTBD
# MDcGCmCGSAGG+mwKAwUwKTAnBggrBgEFBQcCARYbaHR0cHM6Ly93d3cuZW50cnVz
# dC5uZXQvcnBhMAgGBmeBDAEEAjANBgkqhkiG9w0BAQ0FAAOCAgEAdSKLU8Bxl05K
# Ba1NDg4rlEDivKf7o2glxK1QZzXLFLx0lmB5/+Gxew8/aOvyhvkdPU9Xui7IJ9On
# uyeLk+PqGM9RLH+iOsWf4JsAK3Qo8pbg9MIahFi255CLxexJBrzoEQQUltW/3Z6d
# SjCv4crma6gE0qunkSKvzfxmWX9aJmO6Z0CGKIvs3Y4jujhA3MML1j9CjvnOAmgz
# i0uoG+aZpmxeHGuNjeQva4BNDc+SYmJ41gvBXIG67M07jotbrmsA27gcnzDImQKN
# DRpwWTP/2J+8EFCkwMAV+y/aBGPsOTqCvcUnS2SCtV0PcOd80lUVyDYStf7yWghk
# moPwyYtpPPq5cj7LT9eJcgwTF0BSOrn4EBJN5OgtWtXY+syZAYJM0hQv3WVmzjEC
# L17ZPF+T4ZKcuNZVrQ60r+v1M782F2G0NDZ47PYKjXKDdBUTvAh2G8v8Fp1g/6b/
# CJv8eVMidrJCNtmOJ/d48OFzfzBqsLBkZ9a7AU+NeHp3tsF9fX966FTk967a9Egw
# efvmKGO9fBzp97O0tXYPecTV7WETG3FGlh1m3hKmah8dq7Vu/1geR5D/6mU6SB0L
# IEmFIkd0tgGisLnf4IbtU92Ypi2u4b0oRybnbTMaIoerx/7zG2oEyLnf27L7Pdua
# I8lznl/H2FyiBJsSwaqijhv8FBGSbdwxggQWMIIEEgIBATBiME4xCzAJBgNVBAYT
# AlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMScwJQYDVQQDEx5FbnRydXN0IFRp
# bWUgU3RhbXBpbmcgQ0EgLSBUUzICEHTZ8ttRPCJn/UecNgc/ex0wCwYJYIZIAWUD
# BAIDoIIBiTAaBgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQwHAYJKoZIhvcNAQkF
# MQ8XDTIyMDYxMDE5MDgyM1owKQYJKoZIhvcNAQk0MRwwGjALBglghkgBZQMEAgOh
# CwYJKoZIhvcNAQENME8GCSqGSIb3DQEJBDFCBEBIk9/XsIHFGkyK7iTNsSQ6PDSd
# jiFkPYNh44AvwAt71ifROUFeTM7+Vfiq7EWQN0lAYxwvm7S2cv/LMGEgFHCoMIHQ
# BgsqhkiG9w0BCRACLzGBwDCBvTCBujCBtzALBglghkgBZQMEAgMEQGB5Xy0WxpxZ
# /aHeWWOtz+OkiBS2XOgRS9W/7g8SuzzwVjHkJBS5GbjBMdarreVC14LIijGQZS9L
# CvzyGRHJN4wwZjBSpFAwTjELMAkGA1UEBhMCVVMxFjAUBgNVBAoTDUVudHJ1c3Qs
# IEluYy4xJzAlBgNVBAMTHkVudHJ1c3QgVGltZSBTdGFtcGluZyBDQSAtIFRTMgIQ
# dNny21E8Imf9R5w2Bz97HTALBgkqhkiG9w0BAQ0EggIAIQyjBli4G1QL7Wu660Z4
# snG7ZErm2r+CiW0UMsRXI0dBPqGYszBq7D3ERPPPSURMt2vrifXiXiU7ZyMyfv5H
# 5dP07JmPGlhrpGelkM4u4GE3+YVEY8vS7Le/rymi2Nu8KCNWfoNyZLnEzq8D6KfJ
# 06Kk9Vke0DyliSS7ElnX0SZ/I6Sh+dWFHHGjvC2Gxulsyb2FBD0tIs76fUyY4/cn
# Fj5ZDPWD07KUd6tsjM/rZqIAWgbL32UiGs9IsbwDVgZTFMfc26CxvQxEgsbVzhGZ
# cSIzQcFwOR8+g6juNHhsXHCNuoxgxS8SaEEYIZSg9DfkbmfXF0RV+SX7tL44ZxCe
# XizM+sKXMWEe1nyynRC69/pN1QXMM7xbVRNl0tqCX+DP/rbZG9Np+E1KVvFquohk
# d7yUwLDtJDLAXbAAZ5ReElaV87YiURNQA2Xqu/dxoP4NsyeSDzG5kKEQeWOuoAFU
# 1zyFty9g5QYhCVcfWD7taCLztEh6Qg1Ywp5cS59e4KpHUaJRNEg/3NSNhsSZbxJz
# cjqC3Cw/QdfAUtCFXDdbxquOjnrFHF5KxZXxp1nSUbQZpnIUesnqQnlfGuNOzbH5
# p9Nm79DfM6d1mKpSk3iMJyJ5ssb7oc4txKJfS20CBAMJlVmS+0RsFxEJDQJamEXo
# TfIpR/XhGA83uO0qgBJ2rjg=
# SIG # End signature block
