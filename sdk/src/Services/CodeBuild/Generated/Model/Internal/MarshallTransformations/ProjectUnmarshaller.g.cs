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
    /// Response Unmarshaller for Project Object
    /// </summary>
    public partial class ProjectUnmarshaller : ICborUnmarshaller<Project, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Project Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Project();
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
                        unmarshalledObject.Artifacts = ProjectArtifactsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "autoRetryLimit":
                        context.AddPathSegment("AutoRetryLimit");
                        unmarshalledObject.AutoRetryLimit = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "badge":
                        context.AddPathSegment("Badge");
                        unmarshalledObject.Badge = ProjectBadgeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildBatchConfig":
                        context.AddPathSegment("BuildBatchConfig");
                        unmarshalledObject.BuildBatchConfig = ProjectBuildBatchConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "cache":
                        context.AddPathSegment("Cache");
                        unmarshalledObject.Cache = ProjectCacheUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "concurrentBuildLimit":
                        context.AddPathSegment("ConcurrentBuildLimit");
                        unmarshalledObject.ConcurrentBuildLimit = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "created":
                        context.AddPathSegment("Created");
                        unmarshalledObject.Created = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "encryptionKey":
                        context.AddPathSegment("EncryptionKey");
                        unmarshalledObject.EncryptionKey = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "lastModified":
                        context.AddPathSegment("LastModified");
                        unmarshalledObject.LastModified = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "logsConfig":
                        context.AddPathSegment("LogsConfig");
                        unmarshalledObject.LogsConfig = LogsConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "projectVisibility":
                        context.AddPathSegment("ProjectVisibility");
                        unmarshalledObject.ProjectVisibility = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "publicProjectAlias":
                        context.AddPathSegment("PublicProjectAlias");
                        unmarshalledObject.PublicProjectAlias = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "queuedTimeoutInMinutes":
                        context.AddPathSegment("QueuedTimeoutInMinutes");
                        unmarshalledObject.QueuedTimeoutInMinutes = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceAccessRole":
                        context.AddPathSegment("ResourceAccessRole");
                        unmarshalledObject.ResourceAccessRole = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "secondaryArtifacts":
                        context.AddPathSegment("SecondaryArtifacts");
                        unmarshalledObject.SecondaryArtifacts = new CborListUnmarshaller<ProjectArtifacts, ProjectArtifactsUnmarshaller>(ProjectArtifactsUnmarshaller.Instance).Unmarshall(context);
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

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "timeoutInMinutes":
                        context.AddPathSegment("TimeoutInMinutes");
                        unmarshalledObject.TimeoutInMinutes = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "vpcConfig":
                        context.AddPathSegment("VpcConfig");
                        unmarshalledObject.VpcConfig = VpcConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "webhook":
                        context.AddPathSegment("Webhook");
                        unmarshalledObject.Webhook = WebhookUnmarshaller.Instance.Unmarshall(context);
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

        private static ProjectUnmarshaller _instance = new ProjectUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProjectUnmarshaller Instance => _instance;
    }
}
