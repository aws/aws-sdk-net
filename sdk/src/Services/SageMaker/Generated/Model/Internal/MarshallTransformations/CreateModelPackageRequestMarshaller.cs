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
    /// CreateModelPackage Request Marshaller
    /// </summary>       
    public class CreateModelPackageRequestMarshaller : IMarshaller<IRequest, CreateModelPackageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateModelPackageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateModelPackageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateModelPackage";
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
            if(publicRequest.IsSetAdditionalInferenceSpecifications())
            {
                context.Writer.WritePropertyName("AdditionalInferenceSpecifications");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalInferenceSpecificationsListValue in publicRequest.AdditionalInferenceSpecifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdditionalInferenceSpecificationDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdditionalInferenceSpecificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCertifyForMarketplace())
            {
                context.Writer.WritePropertyName("CertifyForMarketplace");
                context.Writer.WriteBooleanValue(publicRequest.CertifyForMarketplace.Value);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCustomerMetadataProperties())
            {
                context.Writer.WritePropertyName("CustomerMetadataProperties");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCustomerMetadataPropertiesKvp in publicRequest.CustomerMetadataProperties)
                {
                    context.Writer.WritePropertyName(publicRequestCustomerMetadataPropertiesKvp.Key);
                    var publicRequestCustomerMetadataPropertiesValue = publicRequestCustomerMetadataPropertiesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestCustomerMetadataPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.WriteStringValue(publicRequest.Domain);
            }

            if(publicRequest.IsSetDriftCheckBaselines())
            {
                context.Writer.WritePropertyName("DriftCheckBaselines");
                context.Writer.WriteStartObject();

                var marshaller = DriftCheckBaselinesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DriftCheckBaselines, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInferenceSpecification())
            {
                context.Writer.WritePropertyName("InferenceSpecification");
                context.Writer.WriteStartObject();

                var marshaller = InferenceSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InferenceSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMetadataProperties())
            {
                context.Writer.WritePropertyName("MetadataProperties");
                context.Writer.WriteStartObject();

                var marshaller = MetadataPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.MetadataProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetModelApprovalStatus())
            {
                context.Writer.WritePropertyName("ModelApprovalStatus");
                context.Writer.WriteStringValue(publicRequest.ModelApprovalStatus);
            }

            if(publicRequest.IsSetModelCard())
            {
                context.Writer.WritePropertyName("ModelCard");
                context.Writer.WriteStartObject();

                var marshaller = ModelPackageModelCardMarshaller.Instance;
                marshaller.Marshall(publicRequest.ModelCard, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetModelLifeCycle())
            {
                context.Writer.WritePropertyName("ModelLifeCycle");
                context.Writer.WriteStartObject();

                var marshaller = ModelLifeCycleMarshaller.Instance;
                marshaller.Marshall(publicRequest.ModelLifeCycle, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetModelMetrics())
            {
                context.Writer.WritePropertyName("ModelMetrics");
                context.Writer.WriteStartObject();

                var marshaller = ModelMetricsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ModelMetrics, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetModelPackageDescription())
            {
                context.Writer.WritePropertyName("ModelPackageDescription");
                context.Writer.WriteStringValue(publicRequest.ModelPackageDescription);
            }

            if(publicRequest.IsSetModelPackageGroupName())
            {
                context.Writer.WritePropertyName("ModelPackageGroupName");
                context.Writer.WriteStringValue(publicRequest.ModelPackageGroupName);
            }

            if(publicRequest.IsSetModelPackageName())
            {
                context.Writer.WritePropertyName("ModelPackageName");
                context.Writer.WriteStringValue(publicRequest.ModelPackageName);
            }

            if(publicRequest.IsSetSamplePayloadUrl())
            {
                context.Writer.WritePropertyName("SamplePayloadUrl");
                context.Writer.WriteStringValue(publicRequest.SamplePayloadUrl);
            }

            if(publicRequest.IsSetSecurityConfig())
            {
                context.Writer.WritePropertyName("SecurityConfig");
                context.Writer.WriteStartObject();

                var marshaller = ModelPackageSecurityConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SecurityConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSkipModelValidation())
            {
                context.Writer.WritePropertyName("SkipModelValidation");
                context.Writer.WriteStringValue(publicRequest.SkipModelValidation);
            }

            if(publicRequest.IsSetSourceAlgorithmSpecification())
            {
                context.Writer.WritePropertyName("SourceAlgorithmSpecification");
                context.Writer.WriteStartObject();

                var marshaller = SourceAlgorithmSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceAlgorithmSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceUri())
            {
                context.Writer.WritePropertyName("SourceUri");
                context.Writer.WriteStringValue(publicRequest.SourceUri);
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

            if(publicRequest.IsSetTask())
            {
                context.Writer.WritePropertyName("Task");
                context.Writer.WriteStringValue(publicRequest.Task);
            }

            if(publicRequest.IsSetValidationSpecification())
            {
                context.Writer.WritePropertyName("ValidationSpecification");
                context.Writer.WriteStartObject();

                var marshaller = ModelPackageValidationSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ValidationSpecification, context);

                context.Writer.WriteEndObject();
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
        private static CreateModelPackageRequestMarshaller _instance = new CreateModelPackageRequestMarshaller();        

        internal static CreateModelPackageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateModelPackageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}