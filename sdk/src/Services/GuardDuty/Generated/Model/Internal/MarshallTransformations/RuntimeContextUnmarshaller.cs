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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuntimeContext Object
    /// </summary>  
    public class RuntimeContextUnmarshaller : IUnmarshaller<RuntimeContext, XmlUnmarshallerContext>, IUnmarshaller<RuntimeContext, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RuntimeContext IUnmarshaller<RuntimeContext, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RuntimeContext Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RuntimeContext unmarshalledObject = new RuntimeContext();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addressFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddressFamily = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileSystemType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileSystemType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Flags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ianaProtocolNumber", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IanaProtocolNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ldPreloadValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LdPreloadValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("libraryPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LibraryPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memoryRegions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MemoryRegions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modifiedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modifyingProcess", targetDepth))
                {
                    var unmarshaller = ProcessDetailsUnmarshaller.Instance;
                    unmarshalledObject.ModifyingProcess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("moduleFilePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModuleFilePath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("moduleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModuleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("moduleSha256", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModuleSha256 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mountSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MountSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mountTarget", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MountTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("releaseAgentPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReleaseAgentPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runcBinaryPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuncBinaryPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scriptPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScriptPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shellHistoryFilePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShellHistoryFilePath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("socketPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SocketPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetProcess", targetDepth))
                {
                    var unmarshaller = ProcessDetailsUnmarshaller.Instance;
                    unmarshalledObject.TargetProcess = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RuntimeContextUnmarshaller _instance = new RuntimeContextUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuntimeContextUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}