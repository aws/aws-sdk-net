/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

using Amazon.S3.Model;

namespace Amazon.S3.Util
{
    internal static class S3Constants
    {
        internal const int PutObjectDefaultTimeout = 20 * 60 * 1000;

        internal static readonly long MinPartSize = 5 * (long)Math.Pow(2, 20);
        internal const int MaxNumberOfParts = 10000;

        internal const int DefaultBufferSize = 8192;

        internal const string S3DefaultEndpoint = "s3.amazonaws.com";
        internal const string S3AlternateDefaultEndpoint = "s3-external-1.amazonaws.com";

        // Bucket Validation constants
        internal const int MinBucketLength = 3;
        internal const int MaxBucketLength = 63;

        // The maximum number of keys that can be passed into a DeleteObjects call.
        internal const int MULTIPLE_OBJECT_DELETE_LIMIT = 1000;

        internal const string 
            AmzGrantHeaderRead        = "x-amz-grant-read",
            AmzGrantHeaderWrite       = "x-amz-grant-write",
            AmzGrantHeaderReadAcp     = "x-amz-grant-read-acp",
            AmzGrantHeaderWriteAcp    = "x-amz-grant-write-acp",
            AmzGrantHeaderRestoreObject = "x-amz-grant-restore-object",
            AmzGrantHeaderFullControl = "x-amz-grant-full-control";

        // Fields for POST uploads
        internal static string
            PostFormDataObjectKey = "key",
            PostFormDataAcl = "acl",
            PostFormDataRedirect = "success_action_redirect",
            PostFormDataStatus = "success_action_status",
            PostFormDataContentType = "Content-Type",
            PostFormDataMetaPrefix = "x-amz-meta-",
            PostFormDataXAmzPrefix = "x-amz-",
            PostFormDataAccessKeyId = "AWSAccessKeyId",
            PostFormDataPolicy = "Policy",
            PostFormDataSignature = "Signature",
            PostFormDataXAmzSignature = "x-amz-signature",
            PostFormDataXAmzAlgorithm = "x-amz-algorithm",
            PostFormDataXAmzCredential = "x-amz-credential",
            PostFormDataXAmzDate = "x-amz-date",
            PostFormDataSecurityToken = "x-amz-security-token";

        // Commonly used static strings
        //internal const string RequestParam = "request";

        // Bucket Version strings
        internal static readonly string[] BucketVersions = { "", "V1", "V2" };

        // Location Constraint strings
        // These strings need to be ordered like the S3Region enumeration
        internal static readonly string[] LocationConstraints = {"",
                                                "EU",
                                                "us-west-1",
                                                "us-west-2",
                                                "ap-southeast-1",
                                                "ap-southeast-2",
                                                "ap-northeast-1",
                                                "sa-east-1"};

        internal const string REGION_US_EAST_1 = "us-east-1";
        internal const string REGION_EU_WEST_1 = "eu-west-1";

        // Metadata Directives as strings
        internal static readonly string[] MetadataDirectives = { "COPY", "REPLACE" };

        // S3 Bucket Versioning Configuration statuses
        internal const string VersioningOff = "Off";
        internal const string VersioningSuspended = "Suspended";
        internal const string VersioningEnabled = "Enabled";

        // Error Codes
        internal const string NoSuchBucketPolicy = "NoSuchBucketPolicy";
        internal const string NoSuchWebsiteConfiguration = "NoSuchWebsiteConfiguration";
        internal const string NoSuchLifecycleConfiguration = "NoSuchLifecycleConfiguration";
        internal const string NoSuchCORSConfiguration = "NoSuchCORSConfiguration";

        internal static HashSet<string> GetObjectExtraSubResources = new HashSet<string>
        {
            ResponseHeaderOverrides.RESPONSE_CACHE_CONTROL,
            ResponseHeaderOverrides.RESPONSE_CONTENT_DISPOSITION,
            ResponseHeaderOverrides.RESPONSE_CONTENT_ENCODING,
            ResponseHeaderOverrides.RESPONSE_CONTENT_LANGUAGE,
            ResponseHeaderOverrides.RESPONSE_CONTENT_TYPE,
            ResponseHeaderOverrides.RESPONSE_EXPIRES
        };
    }
}