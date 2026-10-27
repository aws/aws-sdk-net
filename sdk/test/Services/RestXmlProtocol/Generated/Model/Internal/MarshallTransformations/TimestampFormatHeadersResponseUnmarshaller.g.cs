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
    /// Response Unmarshaller for TimestampFormatHeaders operation.
    /// </summary>
    public partial class TimestampFormatHeadersResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            TimestampFormatHeadersResponse unmarshalledObject = new TimestampFormatHeadersResponse();
            if (context.ResponseData.IsHeaderPresent("X-defaultFormat"))
            {
                unmarshalledObject.DefaultFormat = DateTime.Parse(context.ResponseData.GetHeaderValue("X-defaultFormat"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            }
            if (context.ResponseData.IsHeaderPresent("X-memberDateTime"))
            {
                unmarshalledObject.MemberDateTime = DateTime.Parse(context.ResponseData.GetHeaderValue("X-memberDateTime"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            }
            if (context.ResponseData.IsHeaderPresent("X-memberEpochSeconds"))
            {
                unmarshalledObject.MemberEpochSeconds = Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(context.ResponseData.GetHeaderValue("X-memberEpochSeconds"), CultureInfo.InvariantCulture));
            }
            if (context.ResponseData.IsHeaderPresent("X-memberHttpDate"))
            {
                unmarshalledObject.MemberHttpDate = DateTime.Parse(context.ResponseData.GetHeaderValue("X-memberHttpDate"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            }
            if (context.ResponseData.IsHeaderPresent("X-targetDateTime"))
            {
                unmarshalledObject.TargetDateTime = DateTime.Parse(context.ResponseData.GetHeaderValue("X-targetDateTime"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            }
            if (context.ResponseData.IsHeaderPresent("X-targetEpochSeconds"))
            {
                unmarshalledObject.TargetEpochSeconds = Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(context.ResponseData.GetHeaderValue("X-targetEpochSeconds"), CultureInfo.InvariantCulture));
            }
            if (context.ResponseData.IsHeaderPresent("X-targetHttpDate"))
            {
                unmarshalledObject.TargetHttpDate = DateTime.Parse(context.ResponseData.GetHeaderValue("X-targetHttpDate"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
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

        partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, TimestampFormatHeadersResponse unmarshalledObject);
        private static TimestampFormatHeadersResponseUnmarshaller _instance = new TimestampFormatHeadersResponseUnmarshaller();

        internal static TimestampFormatHeadersResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TimestampFormatHeadersResponseUnmarshaller Instance => _instance;
    }
}
