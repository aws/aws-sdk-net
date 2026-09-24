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
    # A new token per run lets the refresh test see a change; expiration is one minute out (GNU date first, then BSD date).
    token=$(uuidgen 2>/dev/null || cat /proc/sys/kernel/random/uuid)
    expiration=$(date -u -d '+1 minute' +%Y-%m-%dT%H:%M:%SZ 2>/dev/null || date -u -v+1M +%Y-%m-%dT%H:%M:%SZ)
    echo '"AccessKeyId": "AccessKey",'
    echo '"SecretAccessKey": "SecretKey",'
    echo "\"SessionToken\": \"$token\","
    echo "\"Expiration\": \"$expiration\""
fi
echo '}'
