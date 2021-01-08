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
    /// Response Unmarshaller for SuiteRunConfiguration Object
    /// </summary>  
    public class SuiteRunConfigurationUnmarshaller : IUnmarshaller<SuiteRunConfiguration, XmlUnmarshallerContext>, IUnmarshaller<SuiteRunConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SuiteRunConfiguration IUnmarshaller<SuiteRunConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SuiteRunConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SuiteRunConfiguration unmarshalledObject = new SuiteRunConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("primaryDevice", targetDepth))
                {
                    var unmarshaller = DeviceUnderTestUnmarshaller.Instance;
                    unmarshalledObject.PrimaryDevice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secondaryDevice", targetDepth))
                {
                    var unmarshaller = DeviceUnderTestUnmarshaller.Instance;
                    unmarshalledObject.SecondaryDevice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("selectedTestList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SelectedTestList = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SuiteRunConfigurationUnmarshaller _instance = new SuiteRunConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SuiteRunConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}