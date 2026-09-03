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

using Amazon.MediaConnect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveBridgeOutput Request Marshaller
    /// </summary>
    public partial class RemoveBridgeOutputRequestMarshaller : IMarshaller<IRequest, RemoveBridgeOutputRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveBridgeOutputRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RemoveBridgeOutputRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetBridgeArn())
            {
                throw new AmazonMediaConnectException("Request object does not have required field BridgeArn set");
            }
            request.AddPathResource("{BridgeArn}", StringUtils.FromString(publicRequest.BridgeArn));

            if (!publicRequest.IsSetOutputName())
            {
                throw new AmazonMediaConnectException("Request object does not have required field OutputName set");
            }
            request.AddPathResource("{OutputName}", StringUtils.FromString(publicRequest.OutputName));

            request.ResourcePath = "/v1/bridges/{BridgeArn}/outputs/{OutputName}";

            return request;
        }

        private static readonly RemoveBridgeOutputRequestMarshaller _instance = new();

        internal static RemoveBridgeOutputRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RemoveBridgeOutputRequestMarshaller Instance => _instance;
    }
}
