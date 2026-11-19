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

using Amazon.CodePipeline.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipelineDeclaration Object
    /// </summary>
    public partial class PipelineDeclarationUnmarshaller : ICborUnmarshaller<PipelineDeclaration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public PipelineDeclaration Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new PipelineDeclaration();
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
                    case "artifactStore":
                        context.AddPathSegment("ArtifactStore");
                        unmarshalledObject.ArtifactStore = ArtifactStoreUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "artifactStores":
                        context.AddPathSegment("ArtifactStores");
                        unmarshalledObject.ArtifactStores = new CborDictionaryUnmarshaller<string, ArtifactStore, CborStringUnmarshaller, ArtifactStoreUnmarshaller>(CborStringUnmarshaller.Instance, ArtifactStoreUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "executionMode":
                        context.AddPathSegment("ExecutionMode");
                        unmarshalledObject.ExecutionMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "pipelineType":
                        context.AddPathSegment("PipelineType");
                        unmarshalledObject.PipelineType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "roleArn":
                        context.AddPathSegment("RoleArn");
                        unmarshalledObject.RoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stages":
                        context.AddPathSegment("Stages");
                        unmarshalledObject.Stages = new CborListUnmarshaller<StageDeclaration, StageDeclarationUnmarshaller>(StageDeclarationUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "triggers":
                        context.AddPathSegment("Triggers");
                        unmarshalledObject.Triggers = new CborListUnmarshaller<PipelineTriggerDeclaration, PipelineTriggerDeclarationUnmarshaller>(PipelineTriggerDeclarationUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "variables":
                        context.AddPathSegment("Variables");
                        unmarshalledObject.Variables = new CborListUnmarshaller<PipelineVariableDeclaration, PipelineVariableDeclarationUnmarshaller>(PipelineVariableDeclarationUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "version":
                        context.AddPathSegment("Version");
                        unmarshalledObject.Version = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static PipelineDeclarationUnmarshaller _instance = new PipelineDeclarationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PipelineDeclarationUnmarshaller Instance => _instance;
    }
}
