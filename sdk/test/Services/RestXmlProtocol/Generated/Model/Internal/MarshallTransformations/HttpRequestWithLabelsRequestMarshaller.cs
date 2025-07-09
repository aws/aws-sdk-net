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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpRequestWithLabels Request Marshaller
    /// </summary>       
    public partial class HttpRequestWithLabelsRequestMarshaller : IMarshaller<IRequest, HttpRequestWithLabelsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpRequestWithLabelsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(HttpRequestWithLabelsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "GET";
            if (!publicRequest.IsSetBoolean())
                throw new AmazonRestXmlProtocolException("Request object does not have required field Boolean set");
            request.AddPathResource("{boolean}", StringUtils.FromBool(publicRequest.Boolean));
            if (!publicRequest.IsSetDouble())
                throw new AmazonRestXmlProtocolException("Request object does not have required field Double set");
            request.AddPathResource("{double}", StringUtils.FromDouble(publicRequest.Double));
            if (!publicRequest.IsSetFloat())
                throw new AmazonRestXmlProtocolException("Request object does not have required field Float set");
            request.AddPathResource("{float}", StringUtils.FromFloat(publicRequest.Float));
            if (!publicRequest.IsSetInteger())
                throw new AmazonRestXmlProtocolException("Request object does not have required field Integer set");
            request.AddPathResource("{integer}", StringUtils.FromInt(publicRequest.Integer));
            if (!publicRequest.IsSetLong())
                throw new AmazonRestXmlProtocolException("Request object does not have required field Long set");
            request.AddPathResource("{long}", StringUtils.FromLong(publicRequest.Long));
            if (!publicRequest.IsSetShort())
                throw new AmazonRestXmlProtocolException("Request object does not have required field Short set");
            request.AddPathResource("{short}", StringUtils.FromInt(publicRequest.Short));
            if (!publicRequest.IsSetString())
                throw new AmazonRestXmlProtocolException("Request object does not have required field String set");
            request.AddPathResource("{string}", StringUtils.FromString(publicRequest.String));
            if (!publicRequest.IsSetTimestamp())
                throw new AmazonRestXmlProtocolException("Request object does not have required field Timestamp set");
            request.AddPathResource("{timestamp}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Timestamp));
            request.ResourcePath = "/HttpRequestWithLabels/{string}/{short}/{integer}/{long}/{float}/{double}/{boolean}/{timestamp}";


            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static HttpRequestWithLabelsRequestMarshaller _instance = new HttpRequestWithLabelsRequestMarshaller();        

        internal static HttpRequestWithLabelsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpRequestWithLabelsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, HttpRequestWithLabelsRequest publicRequest);
    }    
}