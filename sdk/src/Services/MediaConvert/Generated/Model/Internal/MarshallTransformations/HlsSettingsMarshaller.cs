/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAudioGroupId())
            {
                context.Writer.WritePropertyName("audioGroupId");
                context.Writer.Write(requestObject.AudioGroupId);
            }

            if(requestObject.IsSetAudioRenditionSets())
            {
                context.Writer.WritePropertyName("audioRenditionSets");
                context.Writer.Write(requestObject.AudioRenditionSets);
            }

            if(requestObject.IsSetAudioTrackType())
            {
                context.Writer.WritePropertyName("audioTrackType");
                context.Writer.Write(requestObject.AudioTrackType);
            }

            if(requestObject.IsSetIFrameOnlyManifest())
            {
                context.Writer.WritePropertyName("iFrameOnlyManifest");
                context.Writer.Write(requestObject.IFrameOnlyManifest);
            }

            if(requestObject.IsSetSegmentModifier())
            {
                context.Writer.WritePropertyName("segmentModifier");
                context.Writer.Write(requestObject.SegmentModifier);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HlsSettingsMarshaller Instance = new HlsSettingsMarshaller();

    }
}