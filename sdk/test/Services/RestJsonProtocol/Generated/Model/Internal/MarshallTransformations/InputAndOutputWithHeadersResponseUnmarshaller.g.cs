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

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InputAndOutputWithHeaders operation.
    /// </summary>
    public partial class InputAndOutputWithHeadersResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new InputAndOutputWithHeadersResponse();
            if (context.ResponseData.IsHeaderPresent("X-BooleanList"))
            {
                unmarshalledObject.HeaderBooleanList = MultiValueHeaderParser.ToValueTypeList<bool>(context.ResponseData.GetHeaderValue("X-BooleanList"));
            }
            if (context.ResponseData.IsHeaderPresent("X-Byte"))
            {
                unmarshalledObject.HeaderByte = int.Parse(context.ResponseData.GetHeaderValue("X-Byte"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("X-Double"))
            {
                unmarshalledObject.HeaderDouble = double.Parse(context.ResponseData.GetHeaderValue("X-Double"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("X-Enum"))
            {
                unmarshalledObject.HeaderEnum = context.ResponseData.GetHeaderValue("X-Enum");
            }
            if (context.ResponseData.IsHeaderPresent("X-EnumList"))
            {
                unmarshalledObject.HeaderEnumList = MultiValueHeaderParser.ToStringList(context.ResponseData.GetHeaderValue("X-EnumList"));
            }
            if (context.ResponseData.IsHeaderPresent("X-Boolean2"))
            {
                unmarshalledObject.HeaderFalseBool = bool.Parse(context.ResponseData.GetHeaderValue("X-Boolean2"));
            }
            if (context.ResponseData.IsHeaderPresent("X-Float"))
            {
                unmarshalledObject.HeaderFloat = float.Parse(context.ResponseData.GetHeaderValue("X-Float"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("X-Integer"))
            {
                unmarshalledObject.HeaderInteger = int.Parse(context.ResponseData.GetHeaderValue("X-Integer"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("X-IntegerEnum"))
            {
                unmarshalledObject.HeaderIntegerEnum = int.Parse(context.ResponseData.GetHeaderValue("X-IntegerEnum"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("X-IntegerEnumList"))
            {
                unmarshalledObject.HeaderIntegerEnumList = MultiValueHeaderParser.ToValueTypeList<int>(context.ResponseData.GetHeaderValue("X-IntegerEnumList"));
            }
            if (context.ResponseData.IsHeaderPresent("X-IntegerList"))
            {
                unmarshalledObject.HeaderIntegerList = MultiValueHeaderParser.ToValueTypeList<int>(context.ResponseData.GetHeaderValue("X-IntegerList"));
            }
            if (context.ResponseData.IsHeaderPresent("X-Long"))
            {
                unmarshalledObject.HeaderLong = long.Parse(context.ResponseData.GetHeaderValue("X-Long"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("X-Short"))
            {
                unmarshalledObject.HeaderShort = int.Parse(context.ResponseData.GetHeaderValue("X-Short"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("X-String"))
            {
                unmarshalledObject.HeaderString = context.ResponseData.GetHeaderValue("X-String");
            }
            if (context.ResponseData.IsHeaderPresent("X-StringList"))
            {
                unmarshalledObject.HeaderStringList = MultiValueHeaderParser.ToStringList(context.ResponseData.GetHeaderValue("X-StringList"));
            }
            if (context.ResponseData.IsHeaderPresent("X-StringSet"))
            {
                unmarshalledObject.HeaderStringSet = MultiValueHeaderParser.ToStringList(context.ResponseData.GetHeaderValue("X-StringSet"));
            }
            if (context.ResponseData.IsHeaderPresent("X-TimestampList"))
            {
                unmarshalledObject.HeaderTimestampList = MultiValueHeaderParser.ToDateTimeList(context.ResponseData.GetHeaderValue("X-TimestampList"), "RFC822");
            }
            if (context.ResponseData.IsHeaderPresent("X-Boolean1"))
            {
                unmarshalledObject.HeaderTrueBool = bool.Parse(context.ResponseData.GetHeaderValue("X-Boolean1"));
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                }
            }
            return new AmazonRestJsonProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static InputAndOutputWithHeadersResponseUnmarshaller _instance = new InputAndOutputWithHeadersResponseUnmarshaller();

        internal static InputAndOutputWithHeadersResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InputAndOutputWithHeadersResponseUnmarshaller Instance => _instance;
    }
}
