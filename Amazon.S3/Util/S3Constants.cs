/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Util
{
    internal static class S3Constants
    {
        internal const int PutObjectDefaultTimeout = 20 * 60 * 1000;
        internal static readonly long MaxS3ObjectSize = 5 * (long)Math.Pow(2, 30);

        internal const string S3DefaultEndpoint = "s3.amazonaws.com";

        // Bucket Validation constants
        internal const int MinBucketLength = 3;
        internal const int MaxBucketLength = 63;

        // Commonly used headers
        internal const string AmzRequestIdHeader = "x-amz-request-id";
        internal const string AmzId2Header = "x-amz-id-2";
        internal const string AmzAclHeader = "x-amz-acl";
        internal const string AmzDateHeader = "x-amz-date";
        internal const string AmzMetadataDirectiveHeader = "x-amz-metadata-directive";
        internal const string AuthorizationHeader = "Authorization";
        internal const string AmzVersionIdHeader = "x-amz-version-id";
        internal const string AmzDeleteMarkerHeader = "x-amz-delete-marker";
        internal const string AmzMfaHeader = "x-amz-mfa";

        // Accepted HTTP Verbs
        internal static readonly string[] Verbs = { "GET", "HEAD", "PUT", "DELETE" };
        internal static readonly string GetVerb = Verbs[0];
        internal static readonly string HeadVerb = Verbs[1];
        internal static readonly string PutVerb = Verbs[2];
        internal static readonly string DeleteVerb = Verbs[3];

        // Commonly used static strings
        internal const string RequestParam = "request";

        // Bucket Version strings
        internal static readonly string[] BucketVersions = { "", "V1", "V2" };

        // ACL related strings
        internal static readonly string[] CannedAcls = { "", 
                                                "private", 
                                                "public-read", 
                                                "public-read-write", 
                                                "authenticated-read", 
                                                "bucket-owner-read", 
                                                "bucket-owner-full-control"};

        // Metadata Directives as strings
        internal static readonly string[] MetaDataDirectives = { "COPY", "REPLACE" };

        // S3 Bucket Versioning Configuration statuses
        internal const string VersioningOff = "Off";
        internal const string VersioningSuspended = "Suspended";
        internal const string VersioningEnabled = "Enabled";
    }
}