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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StudioComponentConfiguration Object
    /// </summary>  
    public class StudioComponentConfigurationUnmarshaller : IUnmarshaller<StudioComponentConfiguration, XmlUnmarshallerContext>, IUnmarshaller<StudioComponentConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StudioComponentConfiguration IUnmarshaller<StudioComponentConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StudioComponentConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StudioComponentConfiguration unmarshalledObject = new StudioComponentConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("activeDirectoryConfiguration", targetDepth))
                {
                    var unmarshaller = ActiveDirectoryConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ActiveDirectoryConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("computeFarmConfiguration", targetDepth))
                {
                    var unmarshaller = ComputeFarmConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ComputeFarmConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("licenseServiceConfiguration", targetDepth))
                {
                    var unmarshaller = LicenseServiceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LicenseServiceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sharedFileSystemConfiguration", targetDepth))
                {
                    var unmarshaller = SharedFileSystemConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SharedFileSystemConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StudioComponentConfigurationUnmarshaller _instance = new StudioComponentConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StudioComponentConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}