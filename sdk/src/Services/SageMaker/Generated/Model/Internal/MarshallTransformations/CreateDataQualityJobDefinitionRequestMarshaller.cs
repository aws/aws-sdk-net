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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataQualityJobDefinition Request Marshaller
    /// </summary>       
    public class CreateDataQualityJobDefinitionRequestMarshaller : IMarshaller<IRequest, CreateDataQualityJobDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataQualityJobDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataQualityJobDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateDataQualityJobDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDataQualityAppSpecification())
            {
                context.Writer.WritePropertyName("DataQualityAppSpecification");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityAppSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataQualityAppSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataQualityBaselineConfig())
            {
                context.Writer.WritePropertyName("DataQualityBaselineConfig");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityBaselineConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataQualityBaselineConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataQualityJobInput())
            {
                context.Writer.WritePropertyName("DataQualityJobInput");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityJobInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataQualityJobInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataQualityJobOutputConfig())
            {
                context.Writer.WritePropertyName("DataQualityJobOutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataQualityJobOutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobDefinitionName())
            {
                context.Writer.WritePropertyName("JobDefinitionName");
                context.Writer.WriteStringValue(publicRequest.JobDefinitionName);
            }

            if(publicRequest.IsSetJobResources())
            {
                context.Writer.WritePropertyName("JobResources");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringResourcesMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobResources, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNetworkConfig())
            {
                context.Writer.WritePropertyName("NetworkConfig");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringNetworkConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("StoppingCondition");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringStoppingConditionMarshaller.Instance;
                marshaller.Marshall(publicRequest.StoppingCondition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateDataQualityJobDefinitionRequestMarshaller _instance = new CreateDataQualityJobDefinitionRequestMarshaller();        

        internal static CreateDataQualityJobDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataQualityJobDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}