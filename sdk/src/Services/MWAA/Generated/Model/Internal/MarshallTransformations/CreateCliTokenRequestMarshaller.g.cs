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

using Amazon.MWAA.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MWAA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCliToken Request Marshaller
    /// </summary>
    public partial class CreateCliTokenRequestMarshaller : IMarshaller<IRequest, CreateCliTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCliTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCliTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MWAA");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetName())
            {
                throw new AmazonMWAAException("Request object does not have required field Name set");
            }
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));

            request.ResourcePath = "/clitoken/{Name}";

            request.HostPrefix = $"env.";

            return request;
        }

        private static readonly CreateCliTokenRequestMarshaller _instance = new();

        internal static CreateCliTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCliTokenRequestMarshaller Instance => _instance;
    }
}
