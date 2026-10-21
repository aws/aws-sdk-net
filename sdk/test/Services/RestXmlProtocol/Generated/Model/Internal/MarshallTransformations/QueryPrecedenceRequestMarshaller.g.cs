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

using Amazon.RestXmlProtocol.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryPrecedence Request Marshaller
    /// </summary>
    public partial class QueryPrecedenceRequestMarshaller : IMarshaller<IRequest, QueryPrecedenceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryPrecedenceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(QueryPrecedenceRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";

            request.ResourcePath = "/Precedence";

            if (publicRequest.IsSetFoo())
            {
                request.Parameters.Add("bar", StringUtils.FromString(publicRequest.Foo));
            }

            if (publicRequest.IsSetBaz())
            {
                foreach (var kvp in publicRequest.Baz)
                {
                    if (!request.Parameters.ContainsKey(kvp.Key))
                    {
                        request.Parameters.Add(kvp.Key, StringUtils.FromString(kvp.Value));
                    }
                }
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly QueryPrecedenceRequestMarshaller _instance = new();

        internal static QueryPrecedenceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static QueryPrecedenceRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, QueryPrecedenceRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, QueryPrecedenceRequest publicRequest);
    }
}
