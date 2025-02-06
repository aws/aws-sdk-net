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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipelineDeclaration Marshaller
    /// </summary>
    public class PipelineDeclarationMarshaller : IRequestMarshaller<PipelineDeclaration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipelineDeclaration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArtifactStore())
            {
                context.Writer.WritePropertyName("artifactStore");
                context.Writer.WriteStartObject();

                var marshaller = ArtifactStoreMarshaller.Instance;
                marshaller.Marshall(requestObject.ArtifactStore, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetArtifactStores())
            {
                context.Writer.WritePropertyName("artifactStores");
                context.Writer.WriteStartObject();
                foreach (var requestObjectArtifactStoresKvp in requestObject.ArtifactStores)
                {
                    context.Writer.WritePropertyName(requestObjectArtifactStoresKvp.Key);
                    var requestObjectArtifactStoresValue = requestObjectArtifactStoresKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ArtifactStoreMarshaller.Instance;
                    marshaller.Marshall(requestObjectArtifactStoresValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutionMode())
            {
                context.Writer.WritePropertyName("executionMode");
                context.Writer.WriteStringValue(requestObject.ExecutionMode);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPipelineType())
            {
                context.Writer.WritePropertyName("pipelineType");
                context.Writer.WriteStringValue(requestObject.PipelineType);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetStages())
            {
                context.Writer.WritePropertyName("stages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStagesListValue in requestObject.Stages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StageDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectStagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTriggers())
            {
                context.Writer.WritePropertyName("triggers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTriggersListValue in requestObject.Triggers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PipelineTriggerDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTriggersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVariables())
            {
                context.Writer.WritePropertyName("variables");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVariablesListValue in requestObject.Variables)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PipelineVariableDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariablesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("version");
                context.Writer.WriteNumberValue(requestObject.Version.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipelineDeclarationMarshaller Instance = new PipelineDeclarationMarshaller();

    }
}