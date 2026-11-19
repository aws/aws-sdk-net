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
    /// AttachNetworkInterface Request Marshaller
    /// </summary>
    public partial class AttachNetworkInterfaceRequestMarshaller : IMarshaller<IRequest, AttachNetworkInterfaceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AttachNetworkInterfaceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AttachNetworkInterfaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AttachNetworkInterface");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDeviceIndex())
            {
                request.Parameters.Add("DeviceIndex", StringUtils.FromInt(publicRequest.DeviceIndex.Value));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEnaQueueCount())
            {
                request.Parameters.Add("EnaQueueCount", StringUtils.FromInt(publicRequest.EnaQueueCount.Value));
            }
            if (publicRequest.IsSetEnaSrdSpecification())
            {
                if (publicRequest.EnaSrdSpecification.IsSetEnaSrdEnabled())
                {
                    request.Parameters.Add("EnaSrdSpecification" + ".EnaSrdEnabled", StringUtils.FromBool(publicRequest.EnaSrdSpecification.EnaSrdEnabled.Value));
                }
                if (publicRequest.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                {
                    if (publicRequest.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                    {
                        request.Parameters.Add("EnaSrdSpecification" + ".EnaSrdUdpSpecification" + ".EnaSrdUdpEnabled", StringUtils.FromBool(publicRequest.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled.Value));
                    }
                }
            }
            if (publicRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
            }
            if (publicRequest.IsSetNetworkCardIndex())
            {
                request.Parameters.Add("NetworkCardIndex", StringUtils.FromInt(publicRequest.NetworkCardIndex.Value));
            }
            if (publicRequest.IsSetNetworkInterfaceId())
            {
                request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly AttachNetworkInterfaceRequestMarshaller _instance = new();

        internal static AttachNetworkInterfaceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AttachNetworkInterfaceRequestMarshaller Instance => _instance;
    }
}
