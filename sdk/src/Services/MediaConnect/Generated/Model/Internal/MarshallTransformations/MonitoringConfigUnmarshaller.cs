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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MonitoringConfig Object
    /// </summary>  
    public class MonitoringConfigUnmarshaller : IUnmarshaller<MonitoringConfig, XmlUnmarshallerContext>, IUnmarshaller<MonitoringConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MonitoringConfig IUnmarshaller<MonitoringConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MonitoringConfig Unmarshall(JsonUnmarshallerContext context)
        {
            MonitoringConfig unmarshalledObject = new MonitoringConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioMonitoringSettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AudioMonitoringSetting, AudioMonitoringSettingUnmarshaller>(AudioMonitoringSettingUnmarshaller.Instance);
                    unmarshalledObject.AudioMonitoringSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contentQualityAnalysisState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentQualityAnalysisState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("thumbnailState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThumbnailState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoMonitoringSettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VideoMonitoringSetting, VideoMonitoringSettingUnmarshaller>(VideoMonitoringSettingUnmarshaller.Instance);
                    unmarshalledObject.VideoMonitoringSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MonitoringConfigUnmarshaller _instance = new MonitoringConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MonitoringConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}