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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KafkaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KafkaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutoScalingDescription Object
    /// </summary>  
    public class AutoScalingDescriptionUnmarshaller : IUnmarshaller<AutoScalingDescription, XmlUnmarshallerContext>, IUnmarshaller<AutoScalingDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutoScalingDescription IUnmarshaller<AutoScalingDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AutoScalingDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AutoScalingDescription unmarshalledObject = new AutoScalingDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("maxWorkerCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxWorkerCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mcuCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.McuCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minWorkerCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinWorkerCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scaleInPolicy", targetDepth))
                {
                    var unmarshaller = ScaleInPolicyDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ScaleInPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scaleOutPolicy", targetDepth))
                {
                    var unmarshaller = ScaleOutPolicyDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ScaleOutPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AutoScalingDescriptionUnmarshaller _instance = new AutoScalingDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutoScalingDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}