#!/usr/bin/env bash
# Mirrors windows-credentials-script.bat: $1 is the credential type (Basic, Session or Exit), $2 the optional version number.
credentialType=$1
if [ "$credentialType" = "Exit" ]; then
    exit 1
fi
echo '{'
if [ -n "$2" ]; then
    echo "\"Version\": $2,"
fi
if [ "$credentialType" = "Basic" ]; then
    echo '"AccessKeyId": "AccessKey",'
    echo '"SecretAccessKey": "SecretKey"'
fi
if [ "$credentialType" = "Session" ]; then
    # A new token per run lets the refresh test see a change; expiration is fixed in the future.
    token=$(uuidgen 2>/dev/null || cat /proc/sys/kernel/random/uuid)
    echo '"AccessKeyId": "AccessKey",'
    echo '"SecretAccessKey": "SecretKey",'
    echo "\"SessionToken\": \"$token\","
    echo '"Expiration": "2099-01-01T00:00:00Z"'
fi
echo '}'
