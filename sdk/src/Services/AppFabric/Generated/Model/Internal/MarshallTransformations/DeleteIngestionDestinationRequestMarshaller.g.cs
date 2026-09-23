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

using Amazon.AppFabric.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteIngestionDestination Request Marshaller
    /// </summary>
    public partial class DeleteIngestionDestinationRequestMarshaller : IMarshaller<IRequest, DeleteIngestionDestinationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteIngestionDestinationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteIngestionDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppFabric");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-19";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAppBundleIdentifier())
            {
                throw new AmazonAppFabricException("Request object does not have required field AppBundleIdentifier set");
            }
            request.AddPathResource("{appBundleIdentifier}", StringUtils.FromString(publicRequest.AppBundleIdentifier));

            if (!publicRequest.IsSetIngestionDestinationIdentifier())
            {
                throw new AmazonAppFabricException("Request object does not have required field IngestionDestinationIdentifier set");
            }
            request.AddPathResource("{ingestionDestinationIdentifier}", StringUtils.FromString(publicRequest.IngestionDestinationIdentifier));

            if (!publicRequest.IsSetIngestionIdentifier())
            {
                throw new AmazonAppFabricException("Request object does not have required field IngestionIdentifier set");
            }
            request.AddPathResource("{ingestionIdentifier}", StringUtils.FromString(publicRequest.IngestionIdentifier));

            request.ResourcePath = "/appbundles/{appBundleIdentifier}/ingestions/{ingestionIdentifier}/ingestiondestinations/{ingestionDestinationIdentifier}";

            return request;
        }

        private static readonly DeleteIngestionDestinationRequestMarshaller _instance = new();

        internal static DeleteIngestionDestinationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteIngestionDestinationRequestMarshaller Instance => _instance;
    }
}
