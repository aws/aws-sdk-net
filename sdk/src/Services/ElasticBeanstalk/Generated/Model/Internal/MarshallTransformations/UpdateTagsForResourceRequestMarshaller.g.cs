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

using Amazon.ElasticBeanstalk.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTagsForResource Request Marshaller
    /// </summary>
    public partial class UpdateTagsForResourceRequestMarshaller : IMarshaller<IRequest, UpdateTagsForResourceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTagsForResourceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateTagsForResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "UpdateTagsForResource");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetResourceArn())
            {
                request.Parameters.Add("ResourceArn", StringUtils.FromString(publicRequest.ResourceArn));
            }
            if (publicRequest.IsSetTagsToAdd())
            {
                if (publicRequest.TagsToAdd.Count == 0)
                {
                    request.Parameters.Add("TagsToAdd", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagsToAdd)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("TagsToAdd" + ".member" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("TagsToAdd" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTagsToRemove())
            {
                if (publicRequest.TagsToRemove.Count == 0)
                {
                    request.Parameters.Add("TagsToRemove", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagsToRemove)
                    {
                        request.Parameters.Add("TagsToRemove" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly UpdateTagsForResourceRequestMarshaller _instance = new();

        internal static UpdateTagsForResourceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateTagsForResourceRequestMarshaller Instance => _instance;
    }
}
