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
    /// Response Unmarshaller for ProjectSource Object
    /// </summary>
    public partial class ProjectSourceUnmarshaller : ICborUnmarshaller<ProjectSource, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ProjectSource Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ProjectSource();
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
                    case "auth":
                        context.AddPathSegment("Auth");
                        unmarshalledObject.Auth = SourceAuthUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildStatusConfig":
                        context.AddPathSegment("BuildStatusConfig");
                        unmarshalledObject.BuildStatusConfig = BuildStatusConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "buildspec":
                        context.AddPathSegment("Buildspec");
                        unmarshalledObject.Buildspec = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "gitCloneDepth":
                        context.AddPathSegment("GitCloneDepth");
                        unmarshalledObject.GitCloneDepth = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "gitSubmodulesConfig":
                        context.AddPathSegment("GitSubmodulesConfig");
                        unmarshalledObject.GitSubmodulesConfig = GitSubmodulesConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "insecureSsl":
                        context.AddPathSegment("InsecureSsl");
                        unmarshalledObject.InsecureSsl = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "location":
                        context.AddPathSegment("Location");
                        unmarshalledObject.Location = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "reportBuildStatus":
                        context.AddPathSegment("ReportBuildStatus");
                        unmarshalledObject.ReportBuildStatus = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sourceIdentifier":
                        context.AddPathSegment("SourceIdentifier");
                        unmarshalledObject.SourceIdentifier = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ProjectSourceUnmarshaller _instance = new ProjectSourceUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProjectSourceUnmarshaller Instance => _instance;
    }
}
