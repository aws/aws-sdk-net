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

using Amazon.ElastiCache.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyCacheParameterGroup Request Marshaller
    /// </summary>
    public partial class ModifyCacheParameterGroupRequestMarshaller : IMarshaller<IRequest, ModifyCacheParameterGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyCacheParameterGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyCacheParameterGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyCacheParameterGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetCacheParameterGroupName())
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(publicRequest.CacheParameterGroupName));
            }
            if (publicRequest.IsSetParameterNameValues())
            {
                if (publicRequest.ParameterNameValues.Count == 0)
                {
                    request.Parameters.Add("ParameterNameValues", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ParameterNameValues)
                    {
                        if (item0.IsSetParameterName())
                        {
                            request.Parameters.Add("ParameterNameValues" + ".ParameterNameValue" + "." + index0 + ".ParameterName", StringUtils.FromString(item0.ParameterName));
                        }
                        if (item0.IsSetParameterValue())
                        {
                            request.Parameters.Add("ParameterNameValues" + ".ParameterNameValue" + "." + index0 + ".ParameterValue", StringUtils.FromString(item0.ParameterValue));
                        }
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

        private static readonly ModifyCacheParameterGroupRequestMarshaller _instance = new();

        internal static ModifyCacheParameterGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyCacheParameterGroupRequestMarshaller Instance => _instance;
    }
}
