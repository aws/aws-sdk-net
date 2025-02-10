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
    /// RuleDeclaration Marshaller
    /// </summary>
    public class RuleDeclarationMarshaller : IRequestMarshaller<RuleDeclaration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleDeclaration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommands())
            {
                context.Writer.WritePropertyName("commands");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommandsListValue in requestObject.Commands)
                {
                        context.Writer.WriteStringValue(requestObjectCommandsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteStartObject();
                foreach (var requestObjectConfigurationKvp in requestObject.Configuration)
                {
                    context.Writer.WritePropertyName(requestObjectConfigurationKvp.Key);
                    var requestObjectConfigurationValue = requestObjectConfigurationKvp.Value;

                        context.Writer.WriteStringValue(requestObjectConfigurationValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputArtifacts())
            {
                context.Writer.WritePropertyName("inputArtifacts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputArtifactsListValue in requestObject.InputArtifacts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputArtifactMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputArtifactsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetRuleTypeId())
            {
                context.Writer.WritePropertyName("ruleTypeId");
                context.Writer.WriteStartObject();

                var marshaller = RuleTypeIdMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleTypeId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeoutInMinutes())
            {
                context.Writer.WritePropertyName("timeoutInMinutes");
                context.Writer.WriteNumberValue(requestObject.TimeoutInMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleDeclarationMarshaller Instance = new RuleDeclarationMarshaller();

    }
}