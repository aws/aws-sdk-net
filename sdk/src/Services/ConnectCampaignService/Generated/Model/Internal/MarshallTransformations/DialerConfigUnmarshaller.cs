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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConnectCampaignService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DialerConfig Object
    /// </summary>  
    public class DialerConfigUnmarshaller : IUnmarshaller<DialerConfig, XmlUnmarshallerContext>, IUnmarshaller<DialerConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DialerConfig IUnmarshaller<DialerConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DialerConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DialerConfig unmarshalledObject = new DialerConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentlessDialerConfig", targetDepth))
                {
                    var unmarshaller = AgentlessDialerConfigUnmarshaller.Instance;
                    unmarshalledObject.AgentlessDialerConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("predictiveDialerConfig", targetDepth))
                {
                    var unmarshaller = PredictiveDialerConfigUnmarshaller.Instance;
                    unmarshalledObject.PredictiveDialerConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("progressiveDialerConfig", targetDepth))
                {
                    var unmarshaller = ProgressiveDialerConfigUnmarshaller.Instance;
                    unmarshalledObject.ProgressiveDialerConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DialerConfigUnmarshaller _instance = new DialerConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DialerConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}