@ECHO OFF
FOR /F %%a IN ('POWERSHELL -COMMAND \"$([guid]::NewGuid().ToString())\"') DO   SET NEWGUID=%%a
for /f "tokens=2 delims==" %%G in ('wmic os get localdatetime /value') do set mydate=%%G
set year=%mydate:~0,4%
set month=%mydate:~4,2%
set day=%mydate:~6,2%
set mytime=%time:~0,-3%
for /F "tokens=1-3 delims=:." %%a in ("%time%") do (
   set timeHour=%%a
   set timeMinute=%%b
   set timeSeconds=%%c
)
rem Convert HH:MM to minutes + 1
set /A newTime=timeHour*60 + timeMinute + 1
rem Convert new time back to HH:MM
set /A timeHour=newTime/60, timeMinute=newTime%%60
rem Adjust new hour and minute
if %timeHour% gtr 23 set timeHour=0
if %timeHour% lss 10 set timeHour=0%timeHour%
if %timeMinute% lss 10 set timeMinute=0%timeMinute%
SET credentialType=%1
IF "%credentialType%" == "Exit" (
    exit /b 666
)
ECHO {
IF NOT [%2%] == [] (
    ECHO "Version":%2%,
)
IF "%credentialType%"=="Basic" (
    ECHO "AccessKeyId": "AccessKey",
    ECHO "SecretAccessKey": "SecretKey",
)
IF "%credentialType%"=="Session" (
    ECHO "AccessKeyId": "AccessKey",
    ECHO "SecretAccessKey": "SecretKey",
    ECHO "SessionToken": "%NEWGUID%",
    ECHO "Expiration": "%year%-%month%-%day%T%timeHour%:%timeMinute%:%timeSeconds%"
)
echo }