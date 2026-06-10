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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuntimeContext Object
    /// </summary>  
    public class RuntimeContextUnmarshaller : IJsonUnmarshaller<RuntimeContext, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RuntimeContext Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RuntimeContext unmarshalledObject = new RuntimeContext();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("addressFamily", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddressFamily = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("commandLineExample", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CommandLineExample = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fileOperation", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileOperation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("filePath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilePath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fileSystemType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileSystemType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("flags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Flags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ianaProtocolNumber", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.IanaProtocolNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ldPreloadValue", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LdPreloadValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("libraryPath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LibraryPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("memoryRegions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MemoryRegions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("modifiedAt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("modifyingProcess", targetDepth, ref reader))
                {
                    var unmarshaller = ProcessDetailsUnmarshaller.Instance;
                    unmarshalledObject.ModifyingProcess = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("moduleFilePath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModuleFilePath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("moduleName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModuleName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("moduleSha256", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModuleSha256 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mountSource", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MountSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mountTarget", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MountTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("relatedFilePaths", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RelatedFilePaths = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("releaseAgentPath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReleaseAgentPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("runcBinaryPath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuncBinaryPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scriptPath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScriptPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("shellHistoryFilePath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShellHistoryFilePath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("socketPath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SocketPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetProcess", targetDepth, ref reader))
                {
                    var unmarshaller = ProcessDetailsUnmarshaller.Instance;
                    unmarshalledObject.TargetProcess = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("threatFilePath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThreatFilePath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("toolCategory", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ToolCategory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("toolName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ToolName = unmarshaller.Unmarshall(context, ref reader);
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