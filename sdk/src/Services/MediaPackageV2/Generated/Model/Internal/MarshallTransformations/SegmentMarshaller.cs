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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Segment Marshaller
    /// </summary>
    public class SegmentMarshaller : IRequestMarshaller<Segment, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Segment requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("Encryption");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIncludeIframeOnlyStreams())
            {
                context.Writer.WritePropertyName("IncludeIframeOnlyStreams");
                context.Writer.Write(requestObject.IncludeIframeOnlyStreams);
            }

            if(requestObject.IsSetScte())
            {
                context.Writer.WritePropertyName("Scte");
                context.Writer.WriteObjectStart();

                var marshaller = ScteMarshaller.Instance;
                marshaller.Marshall(requestObject.Scte, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSegmentDurationSeconds())
            {
                context.Writer.WritePropertyName("SegmentDurationSeconds");
                context.Writer.Write(requestObject.SegmentDurationSeconds);
            }

            if(requestObject.IsSetSegmentName())
            {
                context.Writer.WritePropertyName("SegmentName");
                context.Writer.Write(requestObject.SegmentName);
            }

            if(requestObject.IsSetTsIncludeDvbSubtitles())
            {
                context.Writer.WritePropertyName("TsIncludeDvbSubtitles");
                context.Writer.Write(requestObject.TsIncludeDvbSubtitles);
            }

            if(requestObject.IsSetTsUseAudioRenditionGroup())
            {
                context.Writer.WritePropertyName("TsUseAudioRenditionGroup");
                context.Writer.Write(requestObject.TsUseAudioRenditionGroup);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SegmentMarshaller Instance = new SegmentMarshaller();

    }
}