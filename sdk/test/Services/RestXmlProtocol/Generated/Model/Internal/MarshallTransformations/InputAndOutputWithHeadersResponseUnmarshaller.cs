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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InputAndOutputWithHeaders operation
    /// </summary>  
    public class InputAndOutputWithHeadersResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            InputAndOutputWithHeadersResponse response = new InputAndOutputWithHeadersResponse();
            if (context.ResponseData.IsHeaderPresent("X-BooleanList"))
                response.HeaderBooleanList = MultiValueHeaderParser.ToValueTypeList<bool>(context.ResponseData.GetHeaderValue("X-BooleanList"));
            if (context.ResponseData.IsHeaderPresent("X-Byte"))
                response.HeaderByte = int.Parse(context.ResponseData.GetHeaderValue("X-Byte"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-Double"))
                response.HeaderDouble = double.Parse(context.ResponseData.GetHeaderValue("X-Double"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-Enum"))
                response.HeaderEnum = context.ResponseData.GetHeaderValue("X-Enum");
            if (context.ResponseData.IsHeaderPresent("X-EnumList"))
                response.HeaderEnumList = MultiValueHeaderParser.ToStringList(context.ResponseData.GetHeaderValue("X-EnumList"));
            if (context.ResponseData.IsHeaderPresent("X-Boolean2"))
                response.HeaderFalseBool = bool.Parse(context.ResponseData.GetHeaderValue("X-Boolean2"));
            if (context.ResponseData.IsHeaderPresent("X-Float"))
                response.HeaderFloat = float.Parse(context.ResponseData.GetHeaderValue("X-Float"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-Integer"))
                response.HeaderInteger = int.Parse(context.ResponseData.GetHeaderValue("X-Integer"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-IntegerList"))
                response.HeaderIntegerList = MultiValueHeaderParser.ToValueTypeList<int>(context.ResponseData.GetHeaderValue("X-IntegerList"));
            if (context.ResponseData.IsHeaderPresent("X-Long"))
                response.HeaderLong = long.Parse(context.ResponseData.GetHeaderValue("X-Long"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-Short"))
                response.HeaderShort = int.Parse(context.ResponseData.GetHeaderValue("X-Short"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-String"))
                response.HeaderString = context.ResponseData.GetHeaderValue("X-String");
            if (context.ResponseData.IsHeaderPresent("X-StringList"))
                response.HeaderStringList = MultiValueHeaderParser.ToStringList(context.ResponseData.GetHeaderValue("X-StringList"));
            if (context.ResponseData.IsHeaderPresent("X-StringSet"))
                response.HeaderStringSet = MultiValueHeaderParser.ToStringList(context.ResponseData.GetHeaderValue("X-StringSet"));
            if (context.ResponseData.IsHeaderPresent("X-TimestampList"))
                response.HeaderTimestampList = MultiValueHeaderParser.ToDateTimeList(context.ResponseData.GetHeaderValue("X-TimestampList"), "RFC822");
            if (context.ResponseData.IsHeaderPresent("X-Boolean1"))
                response.HeaderTrueBool = bool.Parse(context.ResponseData.GetHeaderValue("X-Boolean1"));
            
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
            return new AmazonRestXmlProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static InputAndOutputWithHeadersResponseUnmarshaller _instance = new InputAndOutputWithHeadersResponseUnmarshaller();        

        internal static InputAndOutputWithHeadersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InputAndOutputWithHeadersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}