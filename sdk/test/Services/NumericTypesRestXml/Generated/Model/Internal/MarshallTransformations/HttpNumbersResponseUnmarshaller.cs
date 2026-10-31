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
 * Do not modify this file. This file is generated from the numerictypesrestxml-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesRestXml.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesRestXml.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HttpNumbers operation
    /// </summary>  
    public partial class HttpNumbersResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            HttpNumbersResponse response = new HttpNumbersResponse();
            if (context.ResponseData.IsHeaderPresent("X-BigDecimal"))
                response.HeaderBigDecimal = Amazon.Extensions.Numerics.BigDecimal.Parse(context.ResponseData.GetHeaderValue("X-BigDecimal"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-BigDecimalList"))
                response.HeaderBigDecimalList = MultiValueHeaderParser.ToValueTypeList<Amazon.Extensions.Numerics.BigDecimal>(context.ResponseData.GetHeaderValue("X-BigDecimalList"), s => Amazon.Extensions.Numerics.BigDecimal.Parse(s, CultureInfo.InvariantCulture));
            if (context.ResponseData.IsHeaderPresent("X-BigInteger"))
                response.HeaderBigInteger = System.Numerics.BigInteger.Parse(context.ResponseData.GetHeaderValue("X-BigInteger"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-BigIntegerList"))
                response.HeaderBigIntegerList = MultiValueHeaderParser.ToValueTypeList<System.Numerics.BigInteger>(context.ResponseData.GetHeaderValue("X-BigIntegerList"), s => System.Numerics.BigInteger.Parse(s, CultureInfo.InvariantCulture));
            if (context.ResponseData.IsHeaderPresent("X-Byte"))
                response.HeaderByte = sbyte.Parse(context.ResponseData.GetHeaderValue("X-Byte"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-Short"))
                response.HeaderShort = short.Parse(context.ResponseData.GetHeaderValue("X-Short"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-ShortList"))
                response.HeaderShortList = MultiValueHeaderParser.ToValueTypeList<short>(context.ResponseData.GetHeaderValue("X-ShortList"), s => short.Parse(s, CultureInfo.InvariantCulture));
            
            PostUnmarshallCustomization(context, response);
            return response;
        }        
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonNumericTypesRestXmlException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, HttpNumbersResponse response);

        private static HttpNumbersResponseUnmarshaller _instance = new HttpNumbersResponseUnmarshaller();        

        internal static HttpNumbersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpNumbersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}