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
    /// Response Unmarshaller for RealTimeAlertRule Object
    /// </summary>  
    public class RealTimeAlertRuleUnmarshaller : IUnmarshaller<RealTimeAlertRule, XmlUnmarshallerContext>, IUnmarshaller<RealTimeAlertRule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RealTimeAlertRule IUnmarshaller<RealTimeAlertRule, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RealTimeAlertRule Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RealTimeAlertRule unmarshalledObject = new RealTimeAlertRule();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("IssueDetectionConfiguration", targetDepth))
                {
                    var unmarshaller = IssueDetectionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.IssueDetectionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeywordMatchConfiguration", targetDepth))
                {
                    var unmarshaller = KeywordMatchConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KeywordMatchConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SentimentConfiguration", targetDepth))
                {
                    var unmarshaller = SentimentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SentimentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RealTimeAlertRuleUnmarshaller _instance = new RealTimeAlertRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RealTimeAlertRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}