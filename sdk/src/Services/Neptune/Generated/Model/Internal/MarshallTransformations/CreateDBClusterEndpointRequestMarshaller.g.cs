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

using Amazon.Neptune.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDBClusterEndpoint Request Marshaller
    /// </summary>
    public partial class CreateDBClusterEndpointRequestMarshaller : IMarshaller<IRequest, CreateDBClusterEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDBClusterEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDBClusterEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptune");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateDBClusterEndpoint");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetDBClusterEndpointIdentifier())
            {
                request.Parameters.Add("DBClusterEndpointIdentifier", StringUtils.FromString(publicRequest.DBClusterEndpointIdentifier));
            }
            if (publicRequest.IsSetDBClusterIdentifier())
            {
                request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
            }
            if (publicRequest.IsSetEndpointType())
            {
                request.Parameters.Add("EndpointType", StringUtils.FromString(publicRequest.EndpointType));
            }
            if (publicRequest.IsSetExcludedMembers())
            {
                if (publicRequest.ExcludedMembers.Count == 0)
                {
                    request.Parameters.Add("ExcludedMembers", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ExcludedMembers)
                    {
                        request.Parameters.Add("ExcludedMembers" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetStaticMembers())
            {
                if (publicRequest.StaticMembers.Count == 0)
                {
                    request.Parameters.Add("StaticMembers", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.StaticMembers)
                    {
                        request.Parameters.Add("StaticMembers" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
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

        private static readonly CreateDBClusterEndpointRequestMarshaller _instance = new();

        internal static CreateDBClusterEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDBClusterEndpointRequestMarshaller Instance => _instance;
    }
}
