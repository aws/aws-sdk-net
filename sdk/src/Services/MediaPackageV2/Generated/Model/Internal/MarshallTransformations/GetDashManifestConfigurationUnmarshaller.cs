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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDashManifestConfiguration Object
    /// </summary>  
    public class GetDashManifestConfigurationUnmarshaller : IJsonUnmarshaller<GetDashManifestConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GetDashManifestConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GetDashManifestConfiguration unmarshalledObject = new GetDashManifestConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BaseUrls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DashBaseUrl, DashBaseUrlUnmarshaller>(DashBaseUrlUnmarshaller.Instance);
                    unmarshalledObject.BaseUrls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Compactness", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Compactness = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DrmSignaling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DrmSignaling = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DvbSettings", targetDepth))
                {
                    var unmarshaller = DashDvbSettingsUnmarshaller.Instance;
                    unmarshalledObject.DvbSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FilterConfiguration", targetDepth))
                {
                    var unmarshaller = FilterConfigurationUnmarshaller.Instance;
                    unmarshalledObject.FilterConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManifestName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManifestWindowSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ManifestWindowSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MinBufferTimeSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MinBufferTimeSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MinUpdatePeriodSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MinUpdatePeriodSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PeriodTriggers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PeriodTriggers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Profiles", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Profiles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProgramInformation", targetDepth))
                {
                    var unmarshaller = DashProgramInformationUnmarshaller.Instance;
                    unmarshalledObject.ProgramInformation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ScteDash", targetDepth))
                {
                    var unmarshaller = ScteDashUnmarshaller.Instance;
                    unmarshalledObject.ScteDash = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SegmentTemplateFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentTemplateFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubtitleConfiguration", targetDepth))
                {
                    var unmarshaller = DashSubtitleConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SubtitleConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SuggestedPresentationDelaySeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SuggestedPresentationDelaySeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Url", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UtcTiming", targetDepth))
                {
                    var unmarshaller = DashUtcTimingUnmarshaller.Instance;
                    unmarshalledObject.UtcTiming = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GetDashManifestConfigurationUnmarshaller _instance = new GetDashManifestConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDashManifestConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}