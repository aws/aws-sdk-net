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
    /// OmitsNullSerializesEmptyString Request Marshaller
    /// </summary>
    public partial class OmitsNullSerializesEmptyStringRequestMarshaller : IMarshaller<IRequest, OmitsNullSerializesEmptyStringRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((OmitsNullSerializesEmptyStringRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(OmitsNullSerializesEmptyStringRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";

            request.ResourcePath = "/OmitsNullSerializesEmptyString";

            if (publicRequest.IsSetEmptyString())
            {
                request.Parameters.Add("Empty", StringUtils.FromString(publicRequest.EmptyString));
            }

            if (publicRequest.IsSetNullValue())
            {
                request.Parameters.Add("Null", StringUtils.FromString(publicRequest.NullValue));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly OmitsNullSerializesEmptyStringRequestMarshaller _instance = new();

        internal static OmitsNullSerializesEmptyStringRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static OmitsNullSerializesEmptyStringRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, OmitsNullSerializesEmptyStringRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, OmitsNullSerializesEmptyStringRequest publicRequest);
    }
}
