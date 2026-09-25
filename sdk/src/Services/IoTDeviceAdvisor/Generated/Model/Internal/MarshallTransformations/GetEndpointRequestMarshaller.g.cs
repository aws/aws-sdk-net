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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.IoTDeviceAdvisor.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTDeviceAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEndpoint Request Marshaller
    /// </summary>
    public partial class GetEndpointRequestMarshaller : IMarshaller<IRequest, GetEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTDeviceAdvisor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-09-18";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAuthenticationMethod())
            {
                request.Parameters.Add("authenticationMethod", StringUtils.FromString(publicRequest.AuthenticationMethod));
            }

            if (publicRequest.IsSetCertificateArn())
            {
                request.Parameters.Add("certificateArn", StringUtils.FromString(publicRequest.CertificateArn));
            }

            if (publicRequest.IsSetDeviceRoleArn())
            {
                request.Parameters.Add("deviceRoleArn", StringUtils.FromString(publicRequest.DeviceRoleArn));
            }

            if (publicRequest.IsSetThingArn())
            {
                request.Parameters.Add("thingArn", StringUtils.FromString(publicRequest.ThingArn));
            }

            request.ResourcePath = "/endpoint";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetEndpointRequestMarshaller _instance = new();

        internal static GetEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEndpointRequestMarshaller Instance => _instance;
    }
}
