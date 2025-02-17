﻿/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

using Amazon.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;

using System.Globalization;

namespace Amazon.Runtime.Internal.Auth
{
    public class CloudFrontSigner : AbstractAWSSigner
    {
        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            if (String.IsNullOrEmpty(awsAccessKeyId))
            {
                throw new ArgumentOutOfRangeException("awsAccessKeyId", "The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            DateTime dateTime = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(request.Endpoint.ToString());
            request.SignedAt = dateTime;
            string dateTimeString = dateTime.ToString(AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture);
            request.Headers.Add(HeaderKeys.XAmzDateHeader, dateTimeString);

            string signature = ComputeHash(dateTimeString, awsSecretAccessKey, SigningAlgorithm.HmacSHA1);

            request.Headers.Add(HeaderKeys.AuthorizationHeader, "AWS " + awsAccessKeyId + ":" + signature);
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, ImmutableCredentials credentials)
        {
            Sign(request, clientConfig, metrics, credentials.AccessKey, credentials.SecretKey);
        }
    }
}
