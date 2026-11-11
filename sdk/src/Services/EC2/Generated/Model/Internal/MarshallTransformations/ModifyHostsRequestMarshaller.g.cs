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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyHosts Request Marshaller
    /// </summary>
    public partial class ModifyHostsRequestMarshaller : IMarshaller<IRequest, ModifyHostsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyHostsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyHostsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyHosts");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAutoPlacement())
            {
                request.Parameters.Add("AutoPlacement", StringUtils.FromString(publicRequest.AutoPlacement));
            }
            if (publicRequest.IsSetHostIds())
            {
                if (publicRequest.HostIds.Count == 0)
                {
                    request.Parameters.Add("HostId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.HostIds)
                    {
                        request.Parameters.Add("HostId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetHostMaintenance())
            {
                request.Parameters.Add("HostMaintenance", StringUtils.FromString(publicRequest.HostMaintenance));
            }
            if (publicRequest.IsSetHostRecovery())
            {
                request.Parameters.Add("HostRecovery", StringUtils.FromString(publicRequest.HostRecovery));
            }
            if (publicRequest.IsSetInstanceFamily())
            {
                request.Parameters.Add("InstanceFamily", StringUtils.FromString(publicRequest.InstanceFamily));
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyHostsRequestMarshaller _instance = new();

        internal static ModifyHostsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyHostsRequestMarshaller Instance => _instance;
    }
}
