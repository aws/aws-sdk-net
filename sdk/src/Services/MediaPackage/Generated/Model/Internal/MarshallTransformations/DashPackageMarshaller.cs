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
    /// DashPackage Marshaller
    /// </summary>
    public class DashPackageMarshaller : IRequestMarshaller<DashPackage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DashPackage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteStartObject();

                var marshaller = DashEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIncludeIframeOnlyStream())
            {
                context.Writer.WritePropertyName("includeIframeOnlyStream");
                context.Writer.WriteBooleanValue(requestObject.IncludeIframeOnlyStream.Value);
            }

            if(requestObject.IsSetManifestLayout())
            {
                context.Writer.WritePropertyName("manifestLayout");
                context.Writer.WriteStringValue(requestObject.ManifestLayout);
            }

            if(requestObject.IsSetManifestWindowSeconds())
            {
                context.Writer.WritePropertyName("manifestWindowSeconds");
                context.Writer.WriteNumberValue(requestObject.ManifestWindowSeconds.Value);
            }

            if(requestObject.IsSetMinBufferTimeSeconds())
            {
                context.Writer.WritePropertyName("minBufferTimeSeconds");
                context.Writer.WriteNumberValue(requestObject.MinBufferTimeSeconds.Value);
            }

            if(requestObject.IsSetMinUpdatePeriodSeconds())
            {
                context.Writer.WritePropertyName("minUpdatePeriodSeconds");
                context.Writer.WriteNumberValue(requestObject.MinUpdatePeriodSeconds.Value);
            }

            if(requestObject.IsSetPeriodTriggers())
            {
                context.Writer.WritePropertyName("periodTriggers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPeriodTriggersListValue in requestObject.PeriodTriggers)
                {
                        context.Writer.WriteStringValue(requestObjectPeriodTriggersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("profile");
                context.Writer.WriteStringValue(requestObject.Profile);
            }

            if(requestObject.IsSetSegmentDurationSeconds())
            {
                context.Writer.WritePropertyName("segmentDurationSeconds");
                context.Writer.WriteNumberValue(requestObject.SegmentDurationSeconds.Value);
            }

            if(requestObject.IsSetSegmentTemplateFormat())
            {
                context.Writer.WritePropertyName("segmentTemplateFormat");
                context.Writer.WriteStringValue(requestObject.SegmentTemplateFormat);
            }

            if(requestObject.IsSetStreamSelection())
            {
                context.Writer.WritePropertyName("streamSelection");
                context.Writer.WriteStartObject();

                var marshaller = StreamSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamSelection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSuggestedPresentationDelaySeconds())
            {
                context.Writer.WritePropertyName("suggestedPresentationDelaySeconds");
                context.Writer.WriteNumberValue(requestObject.SuggestedPresentationDelaySeconds.Value);
            }

            if(requestObject.IsSetUtcTiming())
            {
                context.Writer.WritePropertyName("utcTiming");
                context.Writer.WriteStringValue(requestObject.UtcTiming);
            }

            if(requestObject.IsSetUtcTimingUri())
            {
                context.Writer.WritePropertyName("utcTimingUri");
                context.Writer.WriteStringValue(requestObject.UtcTimingUri);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DashPackageMarshaller Instance = new DashPackageMarshaller();

    }
}