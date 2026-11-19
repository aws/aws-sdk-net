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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipelineDeclaration Marshaller
    /// </summary>
    public partial class PipelineDeclarationMarshaller : IRequestMarshaller<PipelineDeclaration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(PipelineDeclaration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetArtifactStore())
            {
                context.Writer.WriteTextString("artifactStore");
                context.Writer.WriteStartMap(null);

                var marshaller = ArtifactStoreMarshaller.Instance;
                marshaller.Marshall(requestObject.ArtifactStore, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetArtifactStores())
            {
                context.Writer.WriteTextString("artifactStores");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectArtifactStoresKvp in requestObject.ArtifactStores)
                {
                    context.Writer.WriteTextString(requestObjectArtifactStoresKvp.Key);
                    var requestObjectArtifactStoresValue = requestObjectArtifactStoresKvp.Value;
                    context.Writer.WriteStartMap(null);

                    var marshaller = ArtifactStoreMarshaller.Instance;
                    marshaller.Marshall(requestObjectArtifactStoresValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetExecutionMode())
            {
                context.Writer.WriteTextString("executionMode");
                context.Writer.WriteTextString(requestObject.ExecutionMode);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("name");
                context.Writer.WriteTextString(requestObject.Name);
            }

            if (requestObject.IsSetPipelineType())
            {
                context.Writer.WriteTextString("pipelineType");
                context.Writer.WriteTextString(requestObject.PipelineType);
            }

            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WriteTextString("roleArn");
                context.Writer.WriteTextString(requestObject.RoleArn);
            }

            if (requestObject.IsSetStages())
            {
                context.Writer.WriteTextString("stages");
                context.Writer.WriteStartArray(requestObject.Stages.Count);
                foreach (var requestObjectStagesListValue in requestObject.Stages)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = StageDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectStagesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTriggers())
            {
                context.Writer.WriteTextString("triggers");
                context.Writer.WriteStartArray(requestObject.Triggers.Count);
                foreach (var requestObjectTriggersListValue in requestObject.Triggers)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = PipelineTriggerDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTriggersListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetVariables())
            {
                context.Writer.WriteTextString("variables");
                context.Writer.WriteStartArray(requestObject.Variables.Count);
                foreach (var requestObjectVariablesListValue in requestObject.Variables)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = PipelineVariableDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariablesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetVersion())
            {
                context.Writer.WriteTextString("version");
                context.Writer.WriteInt32(requestObject.Version.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PipelineDeclarationMarshaller Instance = new PipelineDeclarationMarshaller();
    }
}
