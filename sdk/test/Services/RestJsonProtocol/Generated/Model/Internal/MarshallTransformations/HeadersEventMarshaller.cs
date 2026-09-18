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
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HeadersEvent Marshaller
    /// </summary>
    public class HeadersEventMarshaller : IRequestMarshaller<HeadersEvent, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HeadersEvent requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlobHeader())
            {
                var blobHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("blobHeader");
                blobHeaderHeader.SetByteBuf(requestObject.BlobHeader.ToArray());
                context.Request.EventHeaders.Add(blobHeaderHeader);
            }
            if(requestObject.IsSetBooleanHeader())
            {
                var booleanHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("booleanHeader");
                booleanHeaderHeader.SetBool(requestObject.BooleanHeader.Value);
                context.Request.EventHeaders.Add(booleanHeaderHeader);
            }
            if(requestObject.IsSetByteHeader())
            {
                var byteHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("byteHeader");
                byteHeaderHeader.SetInt32(requestObject.ByteHeader.Value);
                context.Request.EventHeaders.Add(byteHeaderHeader);
            }
            if(requestObject.IsSetIntHeader())
            {
                var intHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("intHeader");
                intHeaderHeader.SetInt32(requestObject.IntHeader.Value);
                context.Request.EventHeaders.Add(intHeaderHeader);
            }
            if(requestObject.IsSetLongHeader())
            {
                var longHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("longHeader");
                longHeaderHeader.SetInt64(requestObject.LongHeader.Value);
                context.Request.EventHeaders.Add(longHeaderHeader);
            }
            if(requestObject.IsSetShortHeader())
            {
                var shortHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("shortHeader");
                shortHeaderHeader.SetInt32(requestObject.ShortHeader.Value);
                context.Request.EventHeaders.Add(shortHeaderHeader);
            }
            if(requestObject.IsSetStringHeader())
            {
                var stringHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("stringHeader");
                stringHeaderHeader.SetString(requestObject.StringHeader);
                context.Request.EventHeaders.Add(stringHeaderHeader);
            }
            if(requestObject.IsSetTimestampHeader())
            {
                var timestampHeaderHeader = new Amazon.Runtime.EventStreams.EventStreamHeader("timestampHeader");
                timestampHeaderHeader.SetTimestamp(requestObject.TimestampHeader.Value);
                context.Request.EventHeaders.Add(timestampHeaderHeader);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HeadersEventMarshaller Instance = new HeadersEventMarshaller();

    }
}