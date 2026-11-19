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
    /// RuleDeclaration Marshaller
    /// </summary>
    public partial class RuleDeclarationMarshaller : IRequestMarshaller<RuleDeclaration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RuleDeclaration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

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

            if (requestObject.IsSetRuleTypeId())
            {
                context.Writer.WriteTextString("ruleTypeId");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleTypeIdMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleTypeId, context);

                context.Writer.WriteEndMap();
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
        public readonly static RuleDeclarationMarshaller Instance = new RuleDeclarationMarshaller();
    }
}
