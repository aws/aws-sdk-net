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
    /// AwsLambdaFunctionDetails Marshaller
    /// </summary>
    public class AwsLambdaFunctionDetailsMarshaller : IRequestMarshaller<AwsLambdaFunctionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsLambdaFunctionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArchitectures())
            {
                context.Writer.WritePropertyName("Architectures");
                context.Writer.WriteStartArray();
                foreach(var requestObjectArchitecturesListValue in requestObject.Architectures)
                {
                        context.Writer.WriteStringValue(requestObjectArchitecturesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCode())
            {
                context.Writer.WritePropertyName("Code");
                context.Writer.WriteStartObject();

                var marshaller = AwsLambdaFunctionCodeMarshaller.Instance;
                marshaller.Marshall(requestObject.Code, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCodeSha256())
            {
                context.Writer.WritePropertyName("CodeSha256");
                context.Writer.WriteStringValue(requestObject.CodeSha256);
            }

            if(requestObject.IsSetDeadLetterConfig())
            {
                context.Writer.WritePropertyName("DeadLetterConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsLambdaFunctionDeadLetterConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DeadLetterConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();

                var marshaller = AwsLambdaFunctionEnvironmentMarshaller.Instance;
                marshaller.Marshall(requestObject.Environment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFunctionName())
            {
                context.Writer.WritePropertyName("FunctionName");
                context.Writer.WriteStringValue(requestObject.FunctionName);
            }

            if(requestObject.IsSetHandler())
            {
                context.Writer.WritePropertyName("Handler");
                context.Writer.WriteStringValue(requestObject.Handler);
            }

            if(requestObject.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("KmsKeyArn");
                context.Writer.WriteStringValue(requestObject.KmsKeyArn);
            }

            if(requestObject.IsSetLastModified())
            {
                context.Writer.WritePropertyName("LastModified");
                context.Writer.WriteStringValue(requestObject.LastModified);
            }

            if(requestObject.IsSetLayers())
            {
                context.Writer.WritePropertyName("Layers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLayersListValue in requestObject.Layers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsLambdaFunctionLayerMarshaller.Instance;
                    marshaller.Marshall(requestObjectLayersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMasterArn())
            {
                context.Writer.WritePropertyName("MasterArn");
                context.Writer.WriteStringValue(requestObject.MasterArn);
            }

            if(requestObject.IsSetMemorySize())
            {
                context.Writer.WritePropertyName("MemorySize");
                context.Writer.WriteNumberValue(requestObject.MemorySize.Value);
            }

            if(requestObject.IsSetPackageType())
            {
                context.Writer.WritePropertyName("PackageType");
                context.Writer.WriteStringValue(requestObject.PackageType);
            }

            if(requestObject.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("RevisionId");
                context.Writer.WriteStringValue(requestObject.RevisionId);
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(requestObject.Role);
            }

            if(requestObject.IsSetRuntime())
            {
                context.Writer.WritePropertyName("Runtime");
                context.Writer.WriteStringValue(requestObject.Runtime);
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(requestObject.Timeout.Value);
            }

            if(requestObject.IsSetTracingConfig())
            {
                context.Writer.WritePropertyName("TracingConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsLambdaFunctionTracingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TracingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsLambdaFunctionVpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsLambdaFunctionDetailsMarshaller Instance = new AwsLambdaFunctionDetailsMarshaller();

    }
}