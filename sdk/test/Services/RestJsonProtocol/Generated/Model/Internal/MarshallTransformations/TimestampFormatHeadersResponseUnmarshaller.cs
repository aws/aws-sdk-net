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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TimestampFormatHeaders operation
    /// </summary>  
    public class TimestampFormatHeadersResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            TimestampFormatHeadersResponse response = new TimestampFormatHeadersResponse();
            if (context.ResponseData.IsHeaderPresent("X-defaultFormat"))
                response.DefaultFormat = DateTime.Parse(context.ResponseData.GetHeaderValue("X-defaultFormat"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-memberDateTime"))
                response.MemberDateTime = DateTime.Parse(context.ResponseData.GetHeaderValue("X-memberDateTime"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-memberEpochSeconds"))
                response.MemberEpochSeconds = Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(context.ResponseData.GetHeaderValue("X-memberEpochSeconds"), CultureInfo.InvariantCulture));
            if (context.ResponseData.IsHeaderPresent("X-memberHttpDate"))
                response.MemberHttpDate = DateTime.Parse(context.ResponseData.GetHeaderValue("X-memberHttpDate"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-targetDateTime"))
                response.TargetDateTime = DateTime.Parse(context.ResponseData.GetHeaderValue("X-targetDateTime"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("X-targetEpochSeconds"))
                response.TargetEpochSeconds = Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(context.ResponseData.GetHeaderValue("X-targetEpochSeconds"), CultureInfo.InvariantCulture));
            if (context.ResponseData.IsHeaderPresent("X-targetHttpDate"))
                response.TargetHttpDate = DateTime.Parse(context.ResponseData.GetHeaderValue("X-targetHttpDate"), CultureInfo.InvariantCulture);

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
            }
            return new AmazonRestJsonProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static TimestampFormatHeadersResponseUnmarshaller _instance = new TimestampFormatHeadersResponseUnmarshaller();        

        internal static TimestampFormatHeadersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TimestampFormatHeadersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}