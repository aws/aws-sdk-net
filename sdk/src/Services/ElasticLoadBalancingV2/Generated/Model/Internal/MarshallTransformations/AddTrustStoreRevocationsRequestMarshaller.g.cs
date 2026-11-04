/*
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElasticLoadBalancingV2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddTrustStoreRevocations Request Marshaller
    /// </summary>
    public partial class AddTrustStoreRevocationsRequestMarshaller : IMarshaller<IRequest, AddTrustStoreRevocationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddTrustStoreRevocationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AddTrustStoreRevocationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AddTrustStoreRevocations");
            request.Parameters.Add("Version", "2015-12-01");

            if (publicRequest.IsSetRevocationContents())
            {
                if (publicRequest.RevocationContents.Count == 0)
                {
                    request.Parameters.Add("RevocationContents", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RevocationContents)
                    {
                        if (item0.IsSetRevocationType())
                        {
                            request.Parameters.Add("RevocationContents" + ".member" + "." + index0 + ".RevocationType", StringUtils.FromString(item0.RevocationType));
                        }
                        if (item0.IsSetS3Bucket())
                        {
                            request.Parameters.Add("RevocationContents" + ".member" + "." + index0 + ".S3Bucket", StringUtils.FromString(item0.S3Bucket));
                        }
                        if (item0.IsSetS3Key())
                        {
                            request.Parameters.Add("RevocationContents" + ".member" + "." + index0 + ".S3Key", StringUtils.FromString(item0.S3Key));
                        }
                        if (item0.IsSetS3ObjectVersion())
                        {
                            request.Parameters.Add("RevocationContents" + ".member" + "." + index0 + ".S3ObjectVersion", StringUtils.FromString(item0.S3ObjectVersion));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTrustStoreArn())
            {
                request.Parameters.Add("TrustStoreArn", StringUtils.FromString(publicRequest.TrustStoreArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly AddTrustStoreRevocationsRequestMarshaller _instance = new();

        internal static AddTrustStoreRevocationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AddTrustStoreRevocationsRequestMarshaller Instance => _instance;
    }
}
