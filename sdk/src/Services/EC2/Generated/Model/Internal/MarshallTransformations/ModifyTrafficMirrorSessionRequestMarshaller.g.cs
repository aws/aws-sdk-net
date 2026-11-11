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
    /// ModifyTrafficMirrorSession Request Marshaller
    /// </summary>
    public partial class ModifyTrafficMirrorSessionRequestMarshaller : IMarshaller<IRequest, ModifyTrafficMirrorSessionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTrafficMirrorSessionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyTrafficMirrorSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyTrafficMirrorSession");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetPacketLength())
            {
                request.Parameters.Add("PacketLength", StringUtils.FromInt(publicRequest.PacketLength.Value));
            }
            if (publicRequest.IsSetRemoveFields())
            {
                if (publicRequest.RemoveFields.Count == 0)
                {
                    request.Parameters.Add("RemoveField", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RemoveFields)
                    {
                        request.Parameters.Add("RemoveField" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSessionNumber())
            {
                request.Parameters.Add("SessionNumber", StringUtils.FromInt(publicRequest.SessionNumber.Value));
            }
            if (publicRequest.IsSetTrafficMirrorFilterId())
            {
                request.Parameters.Add("TrafficMirrorFilterId", StringUtils.FromString(publicRequest.TrafficMirrorFilterId));
            }
            if (publicRequest.IsSetTrafficMirrorSessionId())
            {
                request.Parameters.Add("TrafficMirrorSessionId", StringUtils.FromString(publicRequest.TrafficMirrorSessionId));
            }
            if (publicRequest.IsSetTrafficMirrorTargetId())
            {
                request.Parameters.Add("TrafficMirrorTargetId", StringUtils.FromString(publicRequest.TrafficMirrorTargetId));
            }
            if (publicRequest.IsSetVirtualNetworkId())
            {
                request.Parameters.Add("VirtualNetworkId", StringUtils.FromInt(publicRequest.VirtualNetworkId.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyTrafficMirrorSessionRequestMarshaller _instance = new();

        internal static ModifyTrafficMirrorSessionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyTrafficMirrorSessionRequestMarshaller Instance => _instance;
    }
}
