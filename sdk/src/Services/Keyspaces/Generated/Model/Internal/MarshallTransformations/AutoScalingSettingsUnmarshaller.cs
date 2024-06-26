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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutoScalingSettings Object
    /// </summary>  
    public class AutoScalingSettingsUnmarshaller : IUnmarshaller<AutoScalingSettings, XmlUnmarshallerContext>, IUnmarshaller<AutoScalingSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutoScalingSettings IUnmarshaller<AutoScalingSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutoScalingSettings Unmarshall(JsonUnmarshallerContext context)
        {
            AutoScalingSettings unmarshalledObject = new AutoScalingSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("autoScalingDisabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingDisabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maximumUnits", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaximumUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minimumUnits", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MinimumUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scalingPolicy", targetDepth))
                {
                    var unmarshaller = AutoScalingPolicyUnmarshaller.Instance;
                    unmarshalledObject.ScalingPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutoScalingSettingsUnmarshaller _instance = new AutoScalingSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutoScalingSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}