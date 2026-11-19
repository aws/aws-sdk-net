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
    /// CreateVpcEndpointConnectionNotification Request Marshaller
    /// </summary>
    public partial class CreateVpcEndpointConnectionNotificationRequestMarshaller : IMarshaller<IRequest, CreateVpcEndpointConnectionNotificationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpcEndpointConnectionNotificationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateVpcEndpointConnectionNotificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateVpcEndpointConnectionNotification");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetConnectionEvents())
            {
                if (publicRequest.ConnectionEvents.Count == 0)
                {
                    request.Parameters.Add("ConnectionEvents", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ConnectionEvents)
                    {
                        request.Parameters.Add("ConnectionEvents" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetConnectionNotificationArn())
            {
                request.Parameters.Add("ConnectionNotificationArn", StringUtils.FromString(publicRequest.ConnectionNotificationArn));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetServiceId())
            {
                request.Parameters.Add("ServiceId", StringUtils.FromString(publicRequest.ServiceId));
            }
            if (publicRequest.IsSetVpcEndpointId())
            {
                request.Parameters.Add("VpcEndpointId", StringUtils.FromString(publicRequest.VpcEndpointId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateVpcEndpointConnectionNotificationRequestMarshaller _instance = new();

        internal static CreateVpcEndpointConnectionNotificationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateVpcEndpointConnectionNotificationRequestMarshaller Instance => _instance;
    }
}
