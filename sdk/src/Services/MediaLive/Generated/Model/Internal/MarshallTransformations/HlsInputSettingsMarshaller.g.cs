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

using Amazon.MediaLive.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HlsInputSettings Marshaller
    /// </summary>
    public partial class HlsInputSettingsMarshaller : IRequestMarshaller<HlsInputSettings, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(HlsInputSettings requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBandwidth())
            {
                context.Writer.WritePropertyName("bandwidth");
                context.Writer.WriteNumberValue(requestObject.Bandwidth.Value);
            }

            if (requestObject.IsSetBufferSegments())
            {
                context.Writer.WritePropertyName("bufferSegments");
                context.Writer.WriteNumberValue(requestObject.BufferSegments.Value);
            }

            if (requestObject.IsSetRetries())
            {
                context.Writer.WritePropertyName("retries");
                context.Writer.WriteNumberValue(requestObject.Retries.Value);
            }

            if (requestObject.IsSetRetryInterval())
            {
                context.Writer.WritePropertyName("retryInterval");
                context.Writer.WriteNumberValue(requestObject.RetryInterval.Value);
            }

            if (requestObject.IsSetScte35Source())
            {
                context.Writer.WritePropertyName("scte35Source");
                context.Writer.WriteStringValue(requestObject.Scte35Source);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static HlsInputSettingsMarshaller Instance = new HlsInputSettingsMarshaller();
    }
}
