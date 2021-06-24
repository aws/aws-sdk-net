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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails Object
    /// </summary>  
    public class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsUnmarshaller : IUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails IUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails unmarshalledObject = new AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Capabilities", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetailsUnmarshaller.Instance;
                    unmarshalledObject.Capabilities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Devices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetails, AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetailsUnmarshaller.Instance);
                    unmarshalledObject.Devices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitProcessEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.InitProcessEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxSwap", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxSwap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharedMemorySize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SharedMemorySize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Swappiness", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Swappiness = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tmpfs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails, AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsUnmarshaller.Instance);
                    unmarshalledObject.Tmpfs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsUnmarshaller _instance = new AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}