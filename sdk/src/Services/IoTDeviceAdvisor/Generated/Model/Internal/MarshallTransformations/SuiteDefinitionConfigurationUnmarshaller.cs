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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTDeviceAdvisor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTDeviceAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SuiteDefinitionConfiguration Object
    /// </summary>  
    public class SuiteDefinitionConfigurationUnmarshaller : IUnmarshaller<SuiteDefinitionConfiguration, XmlUnmarshallerContext>, IUnmarshaller<SuiteDefinitionConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SuiteDefinitionConfiguration IUnmarshaller<SuiteDefinitionConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SuiteDefinitionConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SuiteDefinitionConfiguration unmarshalledObject = new SuiteDefinitionConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("devicePermissionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DevicePermissionRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("devices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DeviceUnderTest, DeviceUnderTestUnmarshaller>(DeviceUnderTestUnmarshaller.Instance);
                    unmarshalledObject.Devices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intendedForQualification", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IntendedForQualification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rootGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RootGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suiteDefinitionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SuiteDefinitionName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SuiteDefinitionConfigurationUnmarshaller _instance = new SuiteDefinitionConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SuiteDefinitionConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}