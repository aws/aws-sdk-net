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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodeBuild.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BuildBatch Object
    /// </summary>
    public partial class BuildBatchUnmarshaller : ICborUnmarshaller<BuildBatch, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public BuildBatch Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new BuildBatch();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "artifacts":
                        context.AddPathSegment("Artifacts");
                        unmarshalledObject.Artifacts = BuildArtifactsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildBatchConfig":
                        context.AddPathSegment("BuildBatchConfig");
                        unmarshalledObject.BuildBatchConfig = ProjectBuildBatchConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildBatchNumber":
                        context.AddPathSegment("BuildBatchNumber");
                        unmarshalledObject.BuildBatchNumber = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildBatchStatus":
                        context.AddPathSegment("BuildBatchStatus");
                        unmarshalledObject.BuildBatchStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildGroups":
                        context.AddPathSegment("BuildGroups");
                        unmarshalledObject.BuildGroups = new CborListUnmarshaller<BuildGroup, BuildGroupUnmarshaller>(BuildGroupUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildTimeoutInMinutes":
                        context.AddPathSegment("BuildTimeoutInMinutes");
                        unmarshalledObject.BuildTimeoutInMinutes = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "cache":
                        context.AddPathSegment("Cache");
                        unmarshalledObject.Cache = ProjectCacheUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "complete":
                        context.AddPathSegment("Complete");
                        unmarshalledObject.Complete = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentPhase":
                        context.AddPathSegment("CurrentPhase");
                        unmarshalledObject.CurrentPhase = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "debugSessionEnabled":
                        context.AddPathSegment("DebugSessionEnabled");
                        unmarshalledObject.DebugSessionEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "encryptionKey":
                        context.AddPathSegment("EncryptionKey");
                        unmarshalledObject.EncryptionKey = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "endTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "environment":
                        context.AddPathSegment("Environment");
                        unmarshalledObject.Environment = ProjectEnvironmentUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "fileSystemLocations":
                        context.AddPathSegment("FileSystemLocations");
                        unmarshalledObject.FileSystemLocations = new CborListUnmarshaller<ProjectFileSystemLocation, ProjectFileSystemLocationUnmarshaller>(ProjectFileSystemLocationUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "initiator":
                        context.AddPathSegment("Initiator");
                        unmarshalledObject.Initiator = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "logConfig":
                        context.AddPathSegment("LogConfig");
                        unmarshalledObject.LogConfig = LogsConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "phases":
                        context.AddPathSegment("Phases");
                        unmarshalledObject.Phases = new CborListUnmarshaller<BuildBatchPhase, BuildBatchPhaseUnmarshaller>(BuildBatchPhaseUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "projectName":
                        context.AddPathSegment("ProjectName");
                        unmarshalledObject.ProjectName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "queuedTimeoutInMinutes":
                        context.AddPathSegment("QueuedTimeoutInMinutes");
                        unmarshalledObject.QueuedTimeoutInMinutes = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "reportArns":
                        context.AddPathSegment("ReportArns");
                        unmarshalledObject.ReportArns = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resolvedSourceVersion":
                        context.AddPathSegment("ResolvedSourceVersion");
                        unmarshalledObject.ResolvedSourceVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "secondaryArtifacts":
                        context.AddPathSegment("SecondaryArtifacts");
                        unmarshalledObject.SecondaryArtifacts = new CborListUnmarshaller<BuildArtifacts, BuildArtifactsUnmarshaller>(BuildArtifactsUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "secondarySourceVersions":
                        context.AddPathSegment("SecondarySourceVersions");
                        unmarshalledObject.SecondarySourceVersions = new CborListUnmarshaller<ProjectSourceVersion, ProjectSourceVersionUnmarshaller>(ProjectSourceVersionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "secondarySources":
                        context.AddPathSegment("SecondarySources");
                        unmarshalledObject.SecondarySources = new CborListUnmarshaller<ProjectSource, ProjectSourceUnmarshaller>(ProjectSourceUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "serviceRole":
                        context.AddPathSegment("ServiceRole");
                        unmarshalledObject.ServiceRole = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "source":
                        context.AddPathSegment("Source");
                        unmarshalledObject.Source = ProjectSourceUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sourceVersion":
                        context.AddPathSegment("SourceVersion");
                        unmarshalledObject.SourceVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "startTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "vpcConfig":
                        context.AddPathSegment("VpcConfig");
                        unmarshalledObject.VpcConfig = VpcConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static BuildBatchUnmarshaller _instance = new BuildBatchUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BuildBatchUnmarshaller Instance => _instance;
    }
}
