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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MediaInsightsPipelineConfiguration Object
    /// </summary>  
    public class MediaInsightsPipelineConfigurationUnmarshaller : IUnmarshaller<MediaInsightsPipelineConfiguration, XmlUnmarshallerContext>, IUnmarshaller<MediaInsightsPipelineConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MediaInsightsPipelineConfiguration IUnmarshaller<MediaInsightsPipelineConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MediaInsightsPipelineConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MediaInsightsPipelineConfiguration unmarshalledObject = new MediaInsightsPipelineConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Elements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MediaInsightsPipelineConfigurationElement, MediaInsightsPipelineConfigurationElementUnmarshaller>(MediaInsightsPipelineConfigurationElementUnmarshaller.Instance);
                    unmarshalledObject.Elements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaInsightsPipelineConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaInsightsPipelineConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaInsightsPipelineConfigurationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaInsightsPipelineConfigurationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaInsightsPipelineConfigurationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaInsightsPipelineConfigurationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RealTimeAlertConfiguration", targetDepth))
                {
                    var unmarshaller = RealTimeAlertConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RealTimeAlertConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceAccessRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MediaInsightsPipelineConfigurationUnmarshaller _instance = new MediaInsightsPipelineConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MediaInsightsPipelineConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}