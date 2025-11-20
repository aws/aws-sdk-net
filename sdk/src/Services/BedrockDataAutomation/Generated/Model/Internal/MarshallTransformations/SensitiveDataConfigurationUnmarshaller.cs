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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SensitiveDataConfiguration Object
    /// </summary>  
    public class SensitiveDataConfigurationUnmarshaller : IUnmarshaller<SensitiveDataConfiguration, XmlUnmarshallerContext>, IUnmarshaller<SensitiveDataConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SensitiveDataConfiguration IUnmarshaller<SensitiveDataConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SensitiveDataConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            SensitiveDataConfiguration unmarshalledObject = new SensitiveDataConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("detectionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DetectionMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("detectionScope", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DetectionScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("piiEntitiesConfiguration", targetDepth))
                {
                    var unmarshaller = PIIEntitiesConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PiiEntitiesConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SensitiveDataConfigurationUnmarshaller _instance = new SensitiveDataConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SensitiveDataConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}