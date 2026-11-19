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
    /// ActionDeclaration Marshaller
    /// </summary>
    public partial class ActionDeclarationMarshaller : IRequestMarshaller<ActionDeclaration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ActionDeclaration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetActionTypeId())
            {
                context.Writer.WriteTextString("actionTypeId");
                context.Writer.WriteStartMap(null);

                var marshaller = ActionTypeIdMarshaller.Instance;
                marshaller.Marshall(requestObject.ActionTypeId, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetCommands())
            {
                context.Writer.WriteTextString("commands");
                context.Writer.WriteStartArray(requestObject.Commands.Count);
                foreach (var requestObjectCommandsListValue in requestObject.Commands)
                {
                    context.Writer.WriteTextString(requestObjectCommandsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetConfiguration())
            {
                context.Writer.WriteTextString("configuration");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectConfigurationKvp in requestObject.Configuration)
                {
                    context.Writer.WriteTextString(requestObjectConfigurationKvp.Key);
                    var requestObjectConfigurationValue = requestObjectConfigurationKvp.Value;
                    context.Writer.WriteTextString(requestObjectConfigurationValue);
                }
                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetEnvironmentVariables())
            {
                context.Writer.WriteTextString("environmentVariables");
                context.Writer.WriteStartArray(requestObject.EnvironmentVariables.Count);
                foreach (var requestObjectEnvironmentVariablesListValue in requestObject.EnvironmentVariables)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = EnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentVariablesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetInputArtifacts())
            {
                context.Writer.WriteTextString("inputArtifacts");
                context.Writer.WriteStartArray(requestObject.InputArtifacts.Count);
                foreach (var requestObjectInputArtifactsListValue in requestObject.InputArtifacts)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = InputArtifactMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputArtifactsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("name");
                context.Writer.WriteTextString(requestObject.Name);
            }

            if (requestObject.IsSetNamespace())
            {
                context.Writer.WriteTextString("namespace");
                context.Writer.WriteTextString(requestObject.Namespace);
            }

            if (requestObject.IsSetOutputArtifacts())
            {
                context.Writer.WriteTextString("outputArtifacts");
                context.Writer.WriteStartArray(requestObject.OutputArtifacts.Count);
                foreach (var requestObjectOutputArtifactsListValue in requestObject.OutputArtifacts)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = OutputArtifactMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputArtifactsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetOutputVariables())
            {
                context.Writer.WriteTextString("outputVariables");
                context.Writer.WriteStartArray(requestObject.OutputVariables.Count);
                foreach (var requestObjectOutputVariablesListValue in requestObject.OutputVariables)
                {
                    context.Writer.WriteTextString(requestObjectOutputVariablesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRegion())
            {
                context.Writer.WriteTextString("region");
                context.Writer.WriteTextString(requestObject.Region);
            }

            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WriteTextString("roleArn");
                context.Writer.WriteTextString(requestObject.RoleArn);
            }

            if (requestObject.IsSetRunOrder())
            {
                context.Writer.WriteTextString("runOrder");
                context.Writer.WriteInt32(requestObject.RunOrder.Value);
            }

            if (requestObject.IsSetTimeoutInMinutes())
            {
                context.Writer.WriteTextString("timeoutInMinutes");
                context.Writer.WriteInt32(requestObject.TimeoutInMinutes.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ActionDeclarationMarshaller Instance = new ActionDeclarationMarshaller();
    }
}
