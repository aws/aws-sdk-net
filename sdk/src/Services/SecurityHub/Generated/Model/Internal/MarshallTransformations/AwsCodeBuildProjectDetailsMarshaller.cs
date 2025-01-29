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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsCodeBuildProjectDetails Marshaller
    /// </summary>
    public class AwsCodeBuildProjectDetailsMarshaller : IRequestMarshaller<AwsCodeBuildProjectDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCodeBuildProjectDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArtifacts())
            {
                context.Writer.WritePropertyName("Artifacts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectArtifactsListValue in requestObject.Artifacts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCodeBuildProjectArtifactsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectArtifactsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEncryptionKey())
            {
                context.Writer.WritePropertyName("EncryptionKey");
                context.Writer.WriteStringValue(requestObject.EncryptionKey);
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();

                var marshaller = AwsCodeBuildProjectEnvironmentMarshaller.Instance;
                marshaller.Marshall(requestObject.Environment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogsConfig())
            {
                context.Writer.WritePropertyName("LogsConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsCodeBuildProjectLogsConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LogsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetSecondaryArtifacts())
            {
                context.Writer.WritePropertyName("SecondaryArtifacts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecondaryArtifactsListValue in requestObject.SecondaryArtifacts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCodeBuildProjectArtifactsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecondaryArtifactsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("ServiceRole");
                context.Writer.WriteStringValue(requestObject.ServiceRole);
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStartObject();

                var marshaller = AwsCodeBuildProjectSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsCodeBuildProjectVpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCodeBuildProjectDetailsMarshaller Instance = new AwsCodeBuildProjectDetailsMarshaller();

    }
}