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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StorageVirtualMachine Object
    /// </summary>  
    public class StorageVirtualMachineUnmarshaller : IUnmarshaller<StorageVirtualMachine, XmlUnmarshallerContext>, IUnmarshaller<StorageVirtualMachine, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StorageVirtualMachine IUnmarshaller<StorageVirtualMachine, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StorageVirtualMachine Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StorageVirtualMachine unmarshalledObject = new StorageVirtualMachine();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActiveDirectoryConfiguration", targetDepth))
                {
                    var unmarshaller = SvmActiveDirectoryConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ActiveDirectoryConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoints", targetDepth))
                {
                    var unmarshaller = SvmEndpointsUnmarshaller.Instance;
                    unmarshalledObject.Endpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileSystemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileSystemId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Lifecycle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Lifecycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifecycleTransitionReason", targetDepth))
                {
                    var unmarshaller = LifecycleTransitionReasonUnmarshaller.Instance;
                    unmarshalledObject.LifecycleTransitionReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RootVolumeSecurityStyle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RootVolumeSecurityStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageVirtualMachineId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageVirtualMachineId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UUID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UUID = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StorageVirtualMachineUnmarshaller _instance = new StorageVirtualMachineUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StorageVirtualMachineUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}