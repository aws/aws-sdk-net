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

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIntegration Request Marshaller
    /// </summary>
    public partial class CreateIntegrationRequestMarshaller : IMarshaller<IRequest, CreateIntegrationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIntegrationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateIntegration");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetAdditionalEncryptionContext())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.AdditionalEncryptionContext)
                {
                    request.Parameters.Add("AdditionalEncryptionContext" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    request.Parameters.Add("AdditionalEncryptionContext" + ".entry" + "." + index0 + ".value", StringUtils.FromString(kvp0.Value));
                    index0++;
                }
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetIntegrationName())
            {
                request.Parameters.Add("IntegrationName", StringUtils.FromString(publicRequest.IntegrationName));
            }
            if (publicRequest.IsSetKMSKeyId())
            {
                request.Parameters.Add("KMSKeyId", StringUtils.FromString(publicRequest.KMSKeyId));
            }
            if (publicRequest.IsSetSourceArn())
            {
                request.Parameters.Add("SourceArn", StringUtils.FromString(publicRequest.SourceArn));
            }
            if (publicRequest.IsSetTagList())
            {
                if (publicRequest.TagList.Count == 0)
                {
                    request.Parameters.Add("TagList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagList)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("TagList" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("TagList" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetArn())
            {
                request.Parameters.Add("TargetArn", StringUtils.FromString(publicRequest.TargetArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateIntegrationRequestMarshaller _instance = new();

        internal static CreateIntegrationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateIntegrationRequestMarshaller Instance => _instance;
    }
}
