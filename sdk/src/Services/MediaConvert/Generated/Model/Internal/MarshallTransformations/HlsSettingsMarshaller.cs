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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HlsSettings Marshaller
    /// </summary>
    public class HlsSettingsMarshaller : IRequestMarshaller<HlsSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioGroupId())
            {
                context.Writer.WritePropertyName("audioGroupId");
                context.Writer.WriteStringValue(requestObject.AudioGroupId);
            }

            if(requestObject.IsSetAudioOnlyContainer())
            {
                context.Writer.WritePropertyName("audioOnlyContainer");
                context.Writer.WriteStringValue(requestObject.AudioOnlyContainer);
            }

            if(requestObject.IsSetAudioRenditionSets())
            {
                context.Writer.WritePropertyName("audioRenditionSets");
                context.Writer.WriteStringValue(requestObject.AudioRenditionSets);
            }

            if(requestObject.IsSetAudioTrackType())
            {
                context.Writer.WritePropertyName("audioTrackType");
                context.Writer.WriteStringValue(requestObject.AudioTrackType);
            }

            if(requestObject.IsSetDescriptiveVideoServiceFlag())
            {
                context.Writer.WritePropertyName("descriptiveVideoServiceFlag");
                context.Writer.WriteStringValue(requestObject.DescriptiveVideoServiceFlag);
            }

            if(requestObject.IsSetIFrameOnlyManifest())
            {
                context.Writer.WritePropertyName("iFrameOnlyManifest");
                context.Writer.WriteStringValue(requestObject.IFrameOnlyManifest);
            }

            if(requestObject.IsSetSegmentModifier())
            {
                context.Writer.WritePropertyName("segmentModifier");
                context.Writer.WriteStringValue(requestObject.SegmentModifier);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HlsSettingsMarshaller Instance = new HlsSettingsMarshaller();

    }
}