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
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.Route53.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetHealthCheck Request Marshaller
    /// </summary>
    public partial class GetHealthCheckRequestMarshaller : IMarshaller<IRequest, GetHealthCheckRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetHealthCheckRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetHealthCheckRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetHealthCheckId())
            {
                throw new AmazonRoute53Exception("Request object does not have required field HealthCheckId set");
            }
            request.AddPathResource("{HealthCheckId}", StringUtils.FromString(publicRequest.HealthCheckId));

            request.ResourcePath = "/2013-04-01/healthcheck/{HealthCheckId}";


            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly GetHealthCheckRequestMarshaller _instance = new();

        internal static GetHealthCheckRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetHealthCheckRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetHealthCheckRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, GetHealthCheckRequest publicRequest);
    }
}
