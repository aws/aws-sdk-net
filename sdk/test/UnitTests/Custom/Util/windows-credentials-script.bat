@ECHO OFF
rem A new token per run lets the refresh test see a change.
SET NEWGUID=%RANDOM%%RANDOM%-%TIME: =0%
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
    ECHO "SecretAccessKey": "SecretKey"
)
IF "%credentialType%"=="Session" (
    ECHO "AccessKeyId": "AccessKey",
    ECHO "SecretAccessKey": "SecretKey",
    ECHO "SessionToken": "%NEWGUID%",
    ECHO "Expiration": "2099-01-01T00:00:00Z"
)
echo }
