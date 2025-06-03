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
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDashManifestConfiguration Marshaller
    /// </summary>
    public class CreateDashManifestConfigurationMarshaller : IRequestMarshaller<CreateDashManifestConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateDashManifestConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBaseUrls())
            {
                context.Writer.WritePropertyName("BaseUrls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBaseUrlsListValue in requestObject.BaseUrls)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DashBaseUrlMarshaller.Instance;
                    marshaller.Marshall(requestObjectBaseUrlsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCompactness())
            {
                context.Writer.WritePropertyName("Compactness");
                context.Writer.WriteStringValue(requestObject.Compactness);
            }

            if(requestObject.IsSetDrmSignaling())
            {
                context.Writer.WritePropertyName("DrmSignaling");
                context.Writer.WriteStringValue(requestObject.DrmSignaling);
            }

            if(requestObject.IsSetDvbSettings())
            {
                context.Writer.WritePropertyName("DvbSettings");
                context.Writer.WriteStartObject();

                var marshaller = DashDvbSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterConfiguration())
            {
                context.Writer.WritePropertyName("FilterConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FilterConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManifestName())
            {
                context.Writer.WritePropertyName("ManifestName");
                context.Writer.WriteStringValue(requestObject.ManifestName);
            }

            if(requestObject.IsSetManifestWindowSeconds())
            {
                context.Writer.WritePropertyName("ManifestWindowSeconds");
                context.Writer.WriteNumberValue(requestObject.ManifestWindowSeconds.Value);
            }

            if(requestObject.IsSetMinBufferTimeSeconds())
            {
                context.Writer.WritePropertyName("MinBufferTimeSeconds");
                context.Writer.WriteNumberValue(requestObject.MinBufferTimeSeconds.Value);
            }

            if(requestObject.IsSetMinUpdatePeriodSeconds())
            {
                context.Writer.WritePropertyName("MinUpdatePeriodSeconds");
                context.Writer.WriteNumberValue(requestObject.MinUpdatePeriodSeconds.Value);
            }

            if(requestObject.IsSetPeriodTriggers())
            {
                context.Writer.WritePropertyName("PeriodTriggers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPeriodTriggersListValue in requestObject.PeriodTriggers)
                {
                        context.Writer.WriteStringValue(requestObjectPeriodTriggersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProfiles())
            {
                context.Writer.WritePropertyName("Profiles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProfilesListValue in requestObject.Profiles)
                {
                        context.Writer.WriteStringValue(requestObjectProfilesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProgramInformation())
            {
                context.Writer.WritePropertyName("ProgramInformation");
                context.Writer.WriteStartObject();

                var marshaller = DashProgramInformationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProgramInformation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScteDash())
            {
                context.Writer.WritePropertyName("ScteDash");
                context.Writer.WriteStartObject();

                var marshaller = ScteDashMarshaller.Instance;
                marshaller.Marshall(requestObject.ScteDash, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSegmentTemplateFormat())
            {
                context.Writer.WritePropertyName("SegmentTemplateFormat");
                context.Writer.WriteStringValue(requestObject.SegmentTemplateFormat);
            }

            if(requestObject.IsSetSubtitleConfiguration())
            {
                context.Writer.WritePropertyName("SubtitleConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DashSubtitleConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SubtitleConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSuggestedPresentationDelaySeconds())
            {
                context.Writer.WritePropertyName("SuggestedPresentationDelaySeconds");
                context.Writer.WriteNumberValue(requestObject.SuggestedPresentationDelaySeconds.Value);
            }

            if(requestObject.IsSetUtcTiming())
            {
                context.Writer.WritePropertyName("UtcTiming");
                context.Writer.WriteStartObject();

                var marshaller = DashUtcTimingMarshaller.Instance;
                marshaller.Marshall(requestObject.UtcTiming, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateDashManifestConfigurationMarshaller Instance = new CreateDashManifestConfigurationMarshaller();

    }
}