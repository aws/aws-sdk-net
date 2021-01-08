﻿/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Runtime.CompilerServices;

namespace Amazon.Util
{
    public abstract class HeaderKeys
    {
        public const string IfModifiedSinceHeader = "If-Modified-Since";
        public const string IfMatchHeader = "If-Match";
        public const string IfNoneMatchHeader = "If-None-Match";
        public const string IfUnmodifiedSinceHeader = "If-Unmodified-Since";
        public const string ConfirmSelfBucketAccess = "x-amz-confirm-remove-self-bucket-access";
        public const string ContentRangeHeader = "Content-Range";
        public const string ContentTypeHeader = "Content-Type";
        public const string ContentLengthHeader = "Content-Length";
        public const string ContentMD5Header = "Content-MD5";
        public const string ContentEncodingHeader = "Content-Encoding";
        public const string ContentDispositionHeader = "Content-Disposition";
        public const string ETagHeader = "ETag";
        public const string Expires = "Expires";
        public const string AuthorizationHeader = "Authorization";
        public const string HostHeader = "host";
        public const string UserAgentHeader = "User-Agent";
        public const string LocationHeader = "location";
        public const string DateHeader = "Date";
        public const string RangeHeader = "Range";
        public const string ExpectHeader = "Expect";
        public const string AcceptHeader = "Accept";
        public const string ConnectionHeader = "Connection";
        public const string StatusHeader = "Status";
        public const string XHttpMethodOverrideHeader = "X-HTTP-Method-Override";
        public const string TransferEncodingHeader = "transfer-encoding";

        public const string RequestIdHeader = "x-amzn-RequestId";
        public const string XAmzId2Header = "x-amz-id-2";
        public const string XAmzCloudFrontIdHeader = "X-Amz-Cf-Id";
        public const string XAmzRequestIdHeader = "x-amz-request-id";
        public const string XAmzDateHeader = "X-Amz-Date";
        public const string XAmzErrorType = "x-amzn-ErrorType";
        public const string XAmznErrorMessage = "x-amzn-error-message";
        public const string XAmzSignedHeadersHeader = "X-Amz-SignedHeaders";
        public const string XAmzContentSha256Header = "X-Amz-Content-SHA256";
        public const string XAmzDecodedContentLengthHeader = "X-Amz-Decoded-Content-Length";
        public const string XAmzSecurityTokenHeader = "x-amz-security-token";
        public const string XAmzAuthorizationHeader = "X-Amzn-Authorization";
        public const string XAmzNonceHeader = "x-amz-nonce";
        public const string XAmzServerSideEncryptionHeader = "x-amz-server-side-encryption";
        public const string XAmzServerSideEncryptionAwsKmsKeyIdHeader = "x-amz-server-side-encryption-aws-kms-key-id";
        public const string XAmzBucketRegion = "x-amz-bucket-region";
        public const string XAmzAccountId = "x-amz-account-id";
        public const string XAmzOutpostId = "x-amz-outpost-id";
        public const string XAmzApiVersion = "x-amz-api-version";

        public const string XAmzSSECustomerAlgorithmHeader = "x-amz-server-side-encryption-customer-algorithm";
        public const string XAmzSSECustomerKeyHeader = "x-amz-server-side-encryption-customer-key";
        public const string XAmzSSECustomerKeyMD5Header = "x-amz-server-side-encryption-customer-key-MD5";

        public const string XAmzCopySourceSSECustomerAlgorithmHeader = "x-amz-copy-source-server-side-encryption-customer-algorithm";
        public const string XAmzCopySourceSSECustomerKeyHeader = "x-amz-copy-source-server-side-encryption-customer-key";
        public const string XAmzCopySourceSSECustomerKeyMD5Header = "x-amz-copy-source-server-side-encryption-customer-key-MD5";

        public const string XAmzStorageClassHeader = "x-amz-storage-class";
        public const string XAmzWebsiteRedirectLocationHeader = "x-amz-website-redirect-location";
        public const string XAmzContentLengthHeader = "x-amz-content-length";
        public const string XAmzAclHeader = "x-amz-acl";
        public const string XAmzCopySourceHeader = "x-amz-copy-source";
        public const string XAmzCopySourceRangeHeader = "x-amz-copy-source-range";
        public const string XAmzCopySourceIfMatchHeader = "x-amz-copy-source-if-match";
        public const string XAmzCopySourceIfModifiedSinceHeader = "x-amz-copy-source-if-modified-since";
        public const string XAmzCopySourceIfNoneMatchHeader = "x-amz-copy-source-if-none-match";
        public const string XAmzCopySourceIfUnmodifiedSinceHeader = "x-amz-copy-source-if-unmodified-since";
        public const string XAmzMetadataDirectiveHeader = "x-amz-metadata-directive";
        public const string XAmzMfaHeader = "x-amz-mfa";
        public const string XAmzVersionIdHeader = "x-amz-version-id";
        public const string XAmzUserAgentHeader = "x-amz-user-agent";
        public const string XAmzAbortDateHeader = "x-amz-abort-date";
        public const string XAmzAbortRuleIdHeader = "x-amz-abort-rule-id";
        public const string XAmznTraceIdHeader = "x-amzn-trace-id";

        public const string XAwsEc2MetadataTokenTtlSeconds = "x-aws-ec2-metadata-token-ttl-seconds";
        public const string XAwsEc2MetadataToken = "x-aws-ec2-metadata-token";
    }
}
