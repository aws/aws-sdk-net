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
#pragma warning disable CS0612,CS0618

namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HeadersEvent Object
    /// </summary>
    public partial class HeadersEventUnmarshaller : IJsonUnmarshaller<HeadersEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public HeadersEvent Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new HeadersEvent();
            if (context.IsEmptyResponse) return null;

            if (context.ResponseData.IsEventHeaderPresent("blobHeader"))
            {
                unmarshalledObject.BlobHeader = new MemoryStream(context.ResponseData.GetEventStreamHeader("blobHeader").AsByteBuf());
            }
            if (context.ResponseData.IsEventHeaderPresent("booleanHeader"))
            {
                unmarshalledObject.BooleanHeader = context.ResponseData.GetEventStreamHeader("booleanHeader").AsBool();
            }
            if (context.ResponseData.IsEventHeaderPresent("byteHeader"))
            {
                unmarshalledObject.ByteHeader = context.ResponseData.GetEventStreamHeader("byteHeader").AsInt32();
            }
            if (context.ResponseData.IsEventHeaderPresent("intHeader"))
            {
                unmarshalledObject.IntHeader = context.ResponseData.GetEventStreamHeader("intHeader").AsInt32();
            }
            if (context.ResponseData.IsEventHeaderPresent("longHeader"))
            {
                unmarshalledObject.LongHeader = context.ResponseData.GetEventStreamHeader("longHeader").AsInt64();
            }
            if (context.ResponseData.IsEventHeaderPresent("shortHeader"))
            {
                unmarshalledObject.ShortHeader = context.ResponseData.GetEventStreamHeader("shortHeader").AsInt32();
            }
            if (context.ResponseData.IsEventHeaderPresent("stringHeader"))
            {
                unmarshalledObject.StringHeader = context.ResponseData.GetEventStreamHeader("stringHeader").AsString();
            }
            if (context.ResponseData.IsEventHeaderPresent("timestampHeader"))
            {
                unmarshalledObject.TimestampHeader = context.ResponseData.GetEventStreamHeader("timestampHeader").AsTimestamp();
            }
            return unmarshalledObject;
        }

        private static HeadersEventUnmarshaller _instance = new HeadersEventUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static HeadersEventUnmarshaller Instance => _instance;
    }
}
