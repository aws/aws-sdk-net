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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecoveryInstanceProperties Object
    /// </summary>  
    public class RecoveryInstancePropertiesUnmarshaller : IUnmarshaller<RecoveryInstanceProperties, XmlUnmarshallerContext>, IUnmarshaller<RecoveryInstanceProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecoveryInstanceProperties IUnmarshaller<RecoveryInstanceProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecoveryInstanceProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecoveryInstanceProperties unmarshalledObject = new RecoveryInstanceProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cpus", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CPU, CPUUnmarshaller>(CPUUnmarshaller.Instance);
                    unmarshalledObject.Cpus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("disks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RecoveryInstanceDisk, RecoveryInstanceDiskUnmarshaller>(RecoveryInstanceDiskUnmarshaller.Instance);
                    unmarshalledObject.Disks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("identificationHints", targetDepth))
                {
                    var unmarshaller = IdentificationHintsUnmarshaller.Instance;
                    unmarshalledObject.IdentificationHints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkInterfaces", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkInterface, NetworkInterfaceUnmarshaller>(NetworkInterfaceUnmarshaller.Instance);
                    unmarshalledObject.NetworkInterfaces = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("os", targetDepth))
                {
                    var unmarshaller = OSUnmarshaller.Instance;
                    unmarshalledObject.Os = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ramBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RamBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RecoveryInstancePropertiesUnmarshaller _instance = new RecoveryInstancePropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecoveryInstancePropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}