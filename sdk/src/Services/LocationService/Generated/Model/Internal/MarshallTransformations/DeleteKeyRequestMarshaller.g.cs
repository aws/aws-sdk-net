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

using Amazon.LocationService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteKey Request Marshaller
    /// </summary>
    public partial class DeleteKeyRequestMarshaller : IMarshaller<IRequest, DeleteKeyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteKeyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetForceDelete())
            {
                request.Parameters.Add("forceDelete", StringUtils.FromBool(publicRequest.ForceDelete.Value));
            }

            if (!publicRequest.IsSetKeyName())
            {
                throw new AmazonLocationServiceException("Request object does not have required field KeyName set");
            }
            request.AddPathResource("{KeyName}", StringUtils.FromString(publicRequest.KeyName));

            request.ResourcePath = "/metadata/v0/keys/{KeyName}";

            request.UseQueryString = true;

            request.HostPrefix = $"cp.metadata.";

            return request;
        }

        private static readonly DeleteKeyRequestMarshaller _instance = new();

        internal static DeleteKeyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteKeyRequestMarshaller Instance => _instance;
    }
}
