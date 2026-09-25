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

using Amazon.IoTTwinMaker.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteComponentType Request Marshaller
    /// </summary>
    public partial class DeleteComponentTypeRequestMarshaller : IMarshaller<IRequest, DeleteComponentTypeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteComponentTypeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteComponentTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTTwinMaker");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-29";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetComponentTypeId())
            {
                throw new AmazonIoTTwinMakerException("Request object does not have required field ComponentTypeId set");
            }
            request.AddPathResource("{componentTypeId}", StringUtils.FromString(publicRequest.ComponentTypeId));

            if (!publicRequest.IsSetWorkspaceId())
            {
                throw new AmazonIoTTwinMakerException("Request object does not have required field WorkspaceId set");
            }
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));

            request.ResourcePath = "/workspaces/{workspaceId}/component-types/{componentTypeId}";

            request.HostPrefix = $"api.";

            return request;
        }

        private static readonly DeleteComponentTypeRequestMarshaller _instance = new();

        internal static DeleteComponentTypeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteComponentTypeRequestMarshaller Instance => _instance;
    }
}
