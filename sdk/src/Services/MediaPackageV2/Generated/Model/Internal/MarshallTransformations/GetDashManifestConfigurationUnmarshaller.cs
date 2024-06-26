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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDashManifestConfiguration Object
    /// </summary>  
    public class GetDashManifestConfigurationUnmarshaller : IUnmarshaller<GetDashManifestConfiguration, XmlUnmarshallerContext>, IUnmarshaller<GetDashManifestConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GetDashManifestConfiguration IUnmarshaller<GetDashManifestConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GetDashManifestConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            GetDashManifestConfiguration unmarshalledObject = new GetDashManifestConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DrmSignaling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DrmSignaling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterConfiguration", targetDepth))
                {
                    var unmarshaller = FilterConfigurationUnmarshaller.Instance;
                    unmarshalledObject.FilterConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestWindowSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ManifestWindowSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinBufferTimeSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinBufferTimeSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinUpdatePeriodSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinUpdatePeriodSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PeriodTriggers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PeriodTriggers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScteDash", targetDepth))
                {
                    var unmarshaller = ScteDashUnmarshaller.Instance;
                    unmarshalledObject.ScteDash = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentTemplateFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentTemplateFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SuggestedPresentationDelaySeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SuggestedPresentationDelaySeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Url", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UtcTiming", targetDepth))
                {
                    var unmarshaller = DashUtcTimingUnmarshaller.Instance;
                    unmarshalledObject.UtcTiming = unmarshaller.Unmarshall(context);
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