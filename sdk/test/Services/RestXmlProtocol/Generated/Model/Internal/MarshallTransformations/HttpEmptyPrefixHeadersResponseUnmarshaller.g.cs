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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HttpEmptyPrefixHeaders operation.
    /// </summary>
    public partial class HttpEmptyPrefixHeadersResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            HttpEmptyPrefixHeadersResponse unmarshalledObject = new HttpEmptyPrefixHeadersResponse();
            if (context.ResponseData.IsHeaderPresent("hello"))
            {
                unmarshalledObject.SpecificHeader = context.ResponseData.GetHeaderValue("hello");
            }
            var headersForPrefixHeaders = new Dictionary<string, string>();
            foreach (var headerName in context.ResponseData.GetHeaderNames())
            {
                var keyToUse = headerName;
                if ("".Length > 0 && keyToUse.StartsWith(""))
                {
                    keyToUse = keyToUse.Substring("".Length);
                }
                if (context.ResponseData.IsHeaderPresent($"{keyToUse}"))
                {
                    headersForPrefixHeaders.Add(keyToUse, context.ResponseData.GetHeaderValue($"{keyToUse}"));
                }
            }
            if (headersForPrefixHeaders.Count > 0)
            {
                unmarshalledObject.PrefixHeaders = headersForPrefixHeaders;
            }

            PostUnmarshallCustomization(context, unmarshalledObject);
            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                }
            }
            return new AmazonRestXmlProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, HttpEmptyPrefixHeadersResponse unmarshalledObject);
        private static HttpEmptyPrefixHeadersResponseUnmarshaller _instance = new HttpEmptyPrefixHeadersResponseUnmarshaller();

        internal static HttpEmptyPrefixHeadersResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static HttpEmptyPrefixHeadersResponseUnmarshaller Instance => _instance;
    }
}
