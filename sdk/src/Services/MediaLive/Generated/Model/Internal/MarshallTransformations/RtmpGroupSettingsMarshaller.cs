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
    /// RtmpGroupSettings Marshaller
    /// </summary>
    public class RtmpGroupSettingsMarshaller : IRequestMarshaller<RtmpGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RtmpGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdMarkers())
            {
                context.Writer.WritePropertyName("adMarkers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdMarkersListValue in requestObject.AdMarkers)
                {
                        context.Writer.WriteStringValue(requestObjectAdMarkersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAuthenticationScheme())
            {
                context.Writer.WritePropertyName("authenticationScheme");
                context.Writer.WriteStringValue(requestObject.AuthenticationScheme);
            }

            if(requestObject.IsSetCacheFullBehavior())
            {
                context.Writer.WritePropertyName("cacheFullBehavior");
                context.Writer.WriteStringValue(requestObject.CacheFullBehavior);
            }

            if(requestObject.IsSetCacheLength())
            {
                context.Writer.WritePropertyName("cacheLength");
                context.Writer.WriteNumberValue(requestObject.CacheLength.Value);
            }

            if(requestObject.IsSetCaptionData())
            {
                context.Writer.WritePropertyName("captionData");
                context.Writer.WriteStringValue(requestObject.CaptionData);
            }

            if(requestObject.IsSetIncludeFillerNalUnits())
            {
                context.Writer.WritePropertyName("includeFillerNalUnits");
                context.Writer.WriteStringValue(requestObject.IncludeFillerNalUnits);
            }

            if(requestObject.IsSetInputLossAction())
            {
                context.Writer.WritePropertyName("inputLossAction");
                context.Writer.WriteStringValue(requestObject.InputLossAction);
            }

            if(requestObject.IsSetRestartDelay())
            {
                context.Writer.WritePropertyName("restartDelay");
                context.Writer.WriteNumberValue(requestObject.RestartDelay.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RtmpGroupSettingsMarshaller Instance = new RtmpGroupSettingsMarshaller();

    }
}