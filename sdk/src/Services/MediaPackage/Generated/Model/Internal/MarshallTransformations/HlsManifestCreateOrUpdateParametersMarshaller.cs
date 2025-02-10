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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HlsManifestCreateOrUpdateParameters Marshaller
    /// </summary>
    public class HlsManifestCreateOrUpdateParametersMarshaller : IRequestMarshaller<HlsManifestCreateOrUpdateParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsManifestCreateOrUpdateParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdMarkers())
            {
                context.Writer.WritePropertyName("adMarkers");
                context.Writer.WriteStringValue(requestObject.AdMarkers);
            }

            if(requestObject.IsSetAdsOnDeliveryRestrictions())
            {
                context.Writer.WritePropertyName("adsOnDeliveryRestrictions");
                context.Writer.WriteStringValue(requestObject.AdsOnDeliveryRestrictions);
            }

            if(requestObject.IsSetAdTriggers())
            {
                context.Writer.WritePropertyName("adTriggers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdTriggersListValue in requestObject.AdTriggers)
                {
                        context.Writer.WriteStringValue(requestObjectAdTriggersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetIncludeIframeOnlyStream())
            {
                context.Writer.WritePropertyName("includeIframeOnlyStream");
                context.Writer.WriteBooleanValue(requestObject.IncludeIframeOnlyStream.Value);
            }

            if(requestObject.IsSetManifestName())
            {
                context.Writer.WritePropertyName("manifestName");
                context.Writer.WriteStringValue(requestObject.ManifestName);
            }

            if(requestObject.IsSetPlaylistType())
            {
                context.Writer.WritePropertyName("playlistType");
                context.Writer.WriteStringValue(requestObject.PlaylistType);
            }

            if(requestObject.IsSetPlaylistWindowSeconds())
            {
                context.Writer.WritePropertyName("playlistWindowSeconds");
                context.Writer.WriteNumberValue(requestObject.PlaylistWindowSeconds.Value);
            }

            if(requestObject.IsSetProgramDateTimeIntervalSeconds())
            {
                context.Writer.WritePropertyName("programDateTimeIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.ProgramDateTimeIntervalSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HlsManifestCreateOrUpdateParametersMarshaller Instance = new HlsManifestCreateOrUpdateParametersMarshaller();

    }
}