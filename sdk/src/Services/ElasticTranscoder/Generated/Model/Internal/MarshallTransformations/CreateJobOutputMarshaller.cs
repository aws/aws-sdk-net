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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJobOutput Marshaller
    /// </summary>
    public class CreateJobOutputMarshaller : IRequestMarshaller<CreateJobOutput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateJobOutput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlbumArt())
            {
                context.Writer.WritePropertyName("AlbumArt");
                context.Writer.WriteStartObject();

                var marshaller = JobAlbumArtMarshaller.Instance;
                marshaller.Marshall(requestObject.AlbumArt, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptions())
            {
                context.Writer.WritePropertyName("Captions");
                context.Writer.WriteStartObject();

                var marshaller = CaptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Captions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetComposition())
            {
                context.Writer.WritePropertyName("Composition");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCompositionListValue in requestObject.Composition)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ClipMarshaller.Instance;
                    marshaller.Marshall(requestObjectCompositionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("Encryption");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.WriteStringValue(requestObject.Key);
            }

            if(requestObject.IsSetPresetId())
            {
                context.Writer.WritePropertyName("PresetId");
                context.Writer.WriteStringValue(requestObject.PresetId);
            }

            if(requestObject.IsSetRotate())
            {
                context.Writer.WritePropertyName("Rotate");
                context.Writer.WriteStringValue(requestObject.Rotate);
            }

            if(requestObject.IsSetSegmentDuration())
            {
                context.Writer.WritePropertyName("SegmentDuration");
                context.Writer.WriteStringValue(requestObject.SegmentDuration);
            }

            if(requestObject.IsSetThumbnailEncryption())
            {
                context.Writer.WritePropertyName("ThumbnailEncryption");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.ThumbnailEncryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetThumbnailPattern())
            {
                context.Writer.WritePropertyName("ThumbnailPattern");
                context.Writer.WriteStringValue(requestObject.ThumbnailPattern);
            }

            if(requestObject.IsSetWatermarks())
            {
                context.Writer.WritePropertyName("Watermarks");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWatermarksListValue in requestObject.Watermarks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = JobWatermarkMarshaller.Instance;
                    marshaller.Marshall(requestObjectWatermarksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateJobOutputMarshaller Instance = new CreateJobOutputMarshaller();

    }
}