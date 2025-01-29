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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails Object
    /// </summary>  
    public class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsUnmarshaller : IJsonUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails unmarshalledObject = new AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Capabilities", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetailsUnmarshaller.Instance;
                    unmarshalledObject.Capabilities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Devices", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetails, AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetailsUnmarshaller.Instance);
                    unmarshalledObject.Devices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InitProcessEnabled", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.InitProcessEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxSwap", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxSwap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SharedMemorySize", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SharedMemorySize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Swappiness", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Swappiness = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tmpfs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails, AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsUnmarshaller>(AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsUnmarshaller.Instance);
                    unmarshalledObject.Tmpfs = unmarshaller.Unmarshall(context, ref reader);
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