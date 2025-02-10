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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Build Object
    /// </summary>  
    public class BuildUnmarshaller : IJsonUnmarshaller<Build, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Build Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Build unmarshalledObject = new Build();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("artifacts", targetDepth))
                {
                    var unmarshaller = BuildArtifactsUnmarshaller.Instance;
                    unmarshalledObject.Artifacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autoRetryConfig", targetDepth))
                {
                    var unmarshaller = AutoRetryConfigUnmarshaller.Instance;
                    unmarshalledObject.AutoRetryConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("buildBatchArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BuildBatchArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("buildComplete", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.BuildComplete = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("buildNumber", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BuildNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("buildStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BuildStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cache", targetDepth))
                {
                    var unmarshaller = ProjectCacheUnmarshaller.Instance;
                    unmarshalledObject.Cache = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentPhase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentPhase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("debugSession", targetDepth))
                {
                    var unmarshaller = DebugSessionUnmarshaller.Instance;
                    unmarshalledObject.DebugSession = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("encryptionKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("environment", targetDepth))
                {
                    var unmarshaller = ProjectEnvironmentUnmarshaller.Instance;
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("exportedEnvironmentVariables", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ExportedEnvironmentVariable, ExportedEnvironmentVariableUnmarshaller>(ExportedEnvironmentVariableUnmarshaller.Instance);
                    unmarshalledObject.ExportedEnvironmentVariables = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fileSystemLocations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ProjectFileSystemLocation, ProjectFileSystemLocationUnmarshaller>(ProjectFileSystemLocationUnmarshaller.Instance);
                    unmarshalledObject.FileSystemLocations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("initiator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Initiator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logs", targetDepth))
                {
                    var unmarshaller = LogsLocationUnmarshaller.Instance;
                    unmarshalledObject.Logs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkInterface", targetDepth))
                {
                    var unmarshaller = NetworkInterfaceUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterface = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("phases", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<BuildPhase, BuildPhaseUnmarshaller>(BuildPhaseUnmarshaller.Instance);
                    unmarshalledObject.Phases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("projectName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queuedTimeoutInMinutes", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.QueuedTimeoutInMinutes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reportArns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReportArns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resolvedSourceVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResolvedSourceVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("secondaryArtifacts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<BuildArtifacts, BuildArtifactsUnmarshaller>(BuildArtifactsUnmarshaller.Instance);
                    unmarshalledObject.SecondaryArtifacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("secondarySources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ProjectSource, ProjectSourceUnmarshaller>(ProjectSourceUnmarshaller.Instance);
                    unmarshalledObject.SecondarySources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("secondarySourceVersions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ProjectSourceVersion, ProjectSourceVersionUnmarshaller>(ProjectSourceVersionUnmarshaller.Instance);
                    unmarshalledObject.SecondarySourceVersions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("source", targetDepth))
                {
                    var unmarshaller = ProjectSourceUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sourceVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeoutInMinutes", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TimeoutInMinutes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BuildUnmarshaller _instance = new BuildUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BuildUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}