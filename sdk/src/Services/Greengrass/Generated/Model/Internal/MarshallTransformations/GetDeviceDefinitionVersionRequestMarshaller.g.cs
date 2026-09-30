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

using Amazon.Greengrass.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDeviceDefinitionVersion Request Marshaller
    /// </summary>
    public partial class GetDeviceDefinitionVersionRequestMarshaller : IMarshaller<IRequest, GetDeviceDefinitionVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDeviceDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetDeviceDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetDeviceDefinitionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field DeviceDefinitionId set");
            }
            request.AddPathResource("{DeviceDefinitionId}", StringUtils.FromString(publicRequest.DeviceDefinitionId));

            if (!publicRequest.IsSetDeviceDefinitionVersionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field DeviceDefinitionVersionId set");
            }
            request.AddPathResource("{DeviceDefinitionVersionId}", StringUtils.FromString(publicRequest.DeviceDefinitionVersionId));

            request.ResourcePath = "/greengrass/definition/devices/{DeviceDefinitionId}/versions/{DeviceDefinitionVersionId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetDeviceDefinitionVersionRequestMarshaller _instance = new();

        internal static GetDeviceDefinitionVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDeviceDefinitionVersionRequestMarshaller Instance => _instance;
    }
}
