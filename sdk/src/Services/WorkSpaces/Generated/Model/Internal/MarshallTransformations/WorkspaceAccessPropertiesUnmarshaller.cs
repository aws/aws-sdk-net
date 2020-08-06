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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkspaceAccessProperties Object
    /// </summary>  
    public class WorkspaceAccessPropertiesUnmarshaller : IUnmarshaller<WorkspaceAccessProperties, XmlUnmarshallerContext>, IUnmarshaller<WorkspaceAccessProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WorkspaceAccessProperties IUnmarshaller<WorkspaceAccessProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public WorkspaceAccessProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            WorkspaceAccessProperties unmarshalledObject = new WorkspaceAccessProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeviceTypeAndroid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceTypeAndroid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceTypeChromeOs", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceTypeChromeOs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceTypeIos", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceTypeIos = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceTypeOsx", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceTypeOsx = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceTypeWeb", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceTypeWeb = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceTypeWindows", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceTypeWindows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceTypeZeroClient", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceTypeZeroClient = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static WorkspaceAccessPropertiesUnmarshaller _instance = new WorkspaceAccessPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkspaceAccessPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}