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

#pragma warning disable CS0612,CS0618

namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HeadersEvent Marshaller
    /// </summary>
    public partial class HeadersEventMarshaller : IRequestMarshaller<HeadersEvent, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(HeadersEvent requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBlobHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("blobHeader");
                header.SetByteBuf(requestObject.BlobHeader.ToArray());
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetBooleanHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("booleanHeader");
                header.SetBool(requestObject.BooleanHeader.Value);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetByteHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("byteHeader");
                header.SetInt32(requestObject.ByteHeader.Value);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetIntHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("intHeader");
                header.SetInt32(requestObject.IntHeader.Value);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetLongHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("longHeader");
                header.SetInt64(requestObject.LongHeader.Value);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetShortHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("shortHeader");
                header.SetInt32(requestObject.ShortHeader.Value);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetStringHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("stringHeader");
                header.SetString(requestObject.StringHeader);
                context.Request.EventHeaders.Add(header);
            }

            if (requestObject.IsSetTimestampHeader())
            {
                var header = new Amazon.Runtime.EventStreams.EventStreamHeader("timestampHeader");
                header.SetTimestamp(requestObject.TimestampHeader.Value);
                context.Request.EventHeaders.Add(header);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static HeadersEventMarshaller Instance = new HeadersEventMarshaller();
    }
}
