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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBaseUrlsListValue in requestObject.BaseUrls)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DashBaseUrlMarshaller.Instance;
                    marshaller.Marshall(requestObjectBaseUrlsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCompactness())
            {
                context.Writer.WritePropertyName("Compactness");
                context.Writer.Write(requestObject.Compactness);
            }

            if(requestObject.IsSetDrmSignaling())
            {
                context.Writer.WritePropertyName("DrmSignaling");
                context.Writer.Write(requestObject.DrmSignaling);
            }

            if(requestObject.IsSetDvbSettings())
            {
                context.Writer.WritePropertyName("DvbSettings");
                context.Writer.WriteObjectStart();

                var marshaller = DashDvbSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DvbSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilterConfiguration())
            {
                context.Writer.WritePropertyName("FilterConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FilterConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetManifestName())
            {
                context.Writer.WritePropertyName("ManifestName");
                context.Writer.Write(requestObject.ManifestName);
            }

            if(requestObject.IsSetManifestWindowSeconds())
            {
                context.Writer.WritePropertyName("ManifestWindowSeconds");
                context.Writer.Write(requestObject.ManifestWindowSeconds);
            }

            if(requestObject.IsSetMinBufferTimeSeconds())
            {
                context.Writer.WritePropertyName("MinBufferTimeSeconds");
                context.Writer.Write(requestObject.MinBufferTimeSeconds);
            }

            if(requestObject.IsSetMinUpdatePeriodSeconds())
            {
                context.Writer.WritePropertyName("MinUpdatePeriodSeconds");
                context.Writer.Write(requestObject.MinUpdatePeriodSeconds);
            }

            if(requestObject.IsSetPeriodTriggers())
            {
                context.Writer.WritePropertyName("PeriodTriggers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPeriodTriggersListValue in requestObject.PeriodTriggers)
                {
                        context.Writer.Write(requestObjectPeriodTriggersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProfiles())
            {
                context.Writer.WritePropertyName("Profiles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProfilesListValue in requestObject.Profiles)
                {
                        context.Writer.Write(requestObjectProfilesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProgramInformation())
            {
                context.Writer.WritePropertyName("ProgramInformation");
                context.Writer.WriteObjectStart();

                var marshaller = DashProgramInformationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProgramInformation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScteDash())
            {
                context.Writer.WritePropertyName("ScteDash");
                context.Writer.WriteObjectStart();

                var marshaller = ScteDashMarshaller.Instance;
                marshaller.Marshall(requestObject.ScteDash, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSegmentTemplateFormat())
            {
                context.Writer.WritePropertyName("SegmentTemplateFormat");
                context.Writer.Write(requestObject.SegmentTemplateFormat);
            }

            if(requestObject.IsSetSubtitleConfiguration())
            {
                context.Writer.WritePropertyName("SubtitleConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DashSubtitleConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SubtitleConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuggestedPresentationDelaySeconds())
            {
                context.Writer.WritePropertyName("SuggestedPresentationDelaySeconds");
                context.Writer.Write(requestObject.SuggestedPresentationDelaySeconds);
            }

            if(requestObject.IsSetUtcTiming())
            {
                context.Writer.WritePropertyName("UtcTiming");
                context.Writer.WriteObjectStart();

                var marshaller = DashUtcTimingMarshaller.Instance;
                marshaller.Marshall(requestObject.UtcTiming, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateDashManifestConfigurationMarshaller Instance = new CreateDashManifestConfigurationMarshaller();

    }
}