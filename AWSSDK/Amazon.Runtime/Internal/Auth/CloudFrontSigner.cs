/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Globalization;
using System.Web;
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Auth
{
    internal class CloudFrontSigner : AbstractAWSSigner
    {
        public override void Sign(IRequest request, ClientConfig clientConfig, string awsAccessKeyId, string awsSecretAccessKey, SecureString secureKey)
        {
            if (String.IsNullOrEmpty(awsAccessKeyId))
            {
                throw new Exception("The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            string dateTime = AWSSDKUtils.GetFormattedTimestampRFC822(0);
            request.Headers.Add("X-Amz-Date", dateTime);

            string signature = ComputeHash(dateTime, awsSecretAccessKey, secureKey, SigningAlgorithm.HmacSHA1);

            request.Headers.Add("Authorization", "AWS " + awsAccessKeyId + ":" + signature);
        }
    }
}
