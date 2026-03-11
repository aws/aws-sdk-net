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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CmafIngestGroupSettings Marshaller
    /// </summary>
    public class CmafIngestGroupSettingsMarshaller : IRequestMarshaller<CmafIngestGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CmafIngestGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalDestinations())
            {
                context.Writer.WritePropertyName("additionalDestinations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalDestinationsListValue in requestObject.AdditionalDestinations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdditionalDestinationsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalDestinationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCaptionLanguageMappings())
            {
                context.Writer.WritePropertyName("captionLanguageMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptionLanguageMappingsListValue in requestObject.CaptionLanguageMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CmafIngestCaptionLanguageMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionLanguageMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStartObject();

                var marshaller = OutputLocationRefMarshaller.Instance;
                marshaller.Marshall(requestObject.Destination, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId3Behavior())
            {
                context.Writer.WritePropertyName("id3Behavior");
                context.Writer.WriteStringValue(requestObject.Id3Behavior);
            }

            if(requestObject.IsSetId3NameModifier())
            {
                context.Writer.WritePropertyName("id3NameModifier");
                context.Writer.WriteStringValue(requestObject.Id3NameModifier);
            }

            if(requestObject.IsSetKlvBehavior())
            {
                context.Writer.WritePropertyName("klvBehavior");
                context.Writer.WriteStringValue(requestObject.KlvBehavior);
            }

            if(requestObject.IsSetKlvNameModifier())
            {
                context.Writer.WritePropertyName("klvNameModifier");
                context.Writer.WriteStringValue(requestObject.KlvNameModifier);
            }

            if(requestObject.IsSetNielsenId3Behavior())
            {
                context.Writer.WritePropertyName("nielsenId3Behavior");
                context.Writer.WriteStringValue(requestObject.NielsenId3Behavior);
            }

            if(requestObject.IsSetNielsenId3NameModifier())
            {
                context.Writer.WritePropertyName("nielsenId3NameModifier");
                context.Writer.WriteStringValue(requestObject.NielsenId3NameModifier);
            }

            if(requestObject.IsSetScte35NameModifier())
            {
                context.Writer.WritePropertyName("scte35NameModifier");
                context.Writer.WriteStringValue(requestObject.Scte35NameModifier);
            }

            if(requestObject.IsSetScte35Type())
            {
                context.Writer.WritePropertyName("scte35Type");
                context.Writer.WriteStringValue(requestObject.Scte35Type);
            }

            if(requestObject.IsSetSegmentLength())
            {
                context.Writer.WritePropertyName("segmentLength");
                context.Writer.WriteNumberValue(requestObject.SegmentLength.Value);
            }

            if(requestObject.IsSetSegmentLengthUnits())
            {
                context.Writer.WritePropertyName("segmentLengthUnits");
                context.Writer.WriteStringValue(requestObject.SegmentLengthUnits);
            }

            if(requestObject.IsSetSendDelayMs())
            {
                context.Writer.WritePropertyName("sendDelayMs");
                context.Writer.WriteNumberValue(requestObject.SendDelayMs.Value);
            }

            if(requestObject.IsSetTimedMetadataId3Frame())
            {
                context.Writer.WritePropertyName("timedMetadataId3Frame");
                context.Writer.WriteStringValue(requestObject.TimedMetadataId3Frame);
            }

            if(requestObject.IsSetTimedMetadataId3Period())
            {
                context.Writer.WritePropertyName("timedMetadataId3Period");
                context.Writer.WriteNumberValue(requestObject.TimedMetadataId3Period.Value);
            }

            if(requestObject.IsSetTimedMetadataPassthrough())
            {
                context.Writer.WritePropertyName("timedMetadataPassthrough");
                context.Writer.WriteStringValue(requestObject.TimedMetadataPassthrough);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CmafIngestGroupSettingsMarshaller Instance = new CmafIngestGroupSettingsMarshaller();

    }
}