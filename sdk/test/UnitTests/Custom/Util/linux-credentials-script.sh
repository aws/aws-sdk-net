#!/usr/bin/env bash
echo '{';
echo '"Version": 1,';
echo '"AccessKeyId": "AccessKey",';
echo '"SecretAccessKey": "SecretKey"';
if [ $1 == 'Session' ]; then
    echo ','
    echo '"SessionToken": "sessionToken",';
    echo '"Expiration": "2018-12-11T17:46:28Z"';
fi;
echo '}';