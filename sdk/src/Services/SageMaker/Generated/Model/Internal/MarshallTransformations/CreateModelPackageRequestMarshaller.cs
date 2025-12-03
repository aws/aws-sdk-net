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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalInferenceSpecifications())
                {
                    context.Writer.WritePropertyName("AdditionalInferenceSpecifications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalInferenceSpecificationsListValue in publicRequest.AdditionalInferenceSpecifications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AdditionalInferenceSpecificationDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestAdditionalInferenceSpecificationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCertifyForMarketplace())
                {
                    context.Writer.WritePropertyName("CertifyForMarketplace");
                    context.Writer.Write(publicRequest.CertifyForMarketplace);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCustomerMetadataProperties())
                {
                    context.Writer.WritePropertyName("CustomerMetadataProperties");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestCustomerMetadataPropertiesKvp in publicRequest.CustomerMetadataProperties)
                    {
                        context.Writer.WritePropertyName(publicRequestCustomerMetadataPropertiesKvp.Key);
                        var publicRequestCustomerMetadataPropertiesValue = publicRequestCustomerMetadataPropertiesKvp.Value;

                            context.Writer.Write(publicRequestCustomerMetadataPropertiesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("Domain");
                    context.Writer.Write(publicRequest.Domain);
                }

                if(publicRequest.IsSetDriftCheckBaselines())
                {
                    context.Writer.WritePropertyName("DriftCheckBaselines");
                    context.Writer.WriteObjectStart();

                    var marshaller = DriftCheckBaselinesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DriftCheckBaselines, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInferenceSpecification())
                {
                    context.Writer.WritePropertyName("InferenceSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InferenceSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMetadataProperties())
                {
                    context.Writer.WritePropertyName("MetadataProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetadataPropertiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetadataProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelApprovalStatus())
                {
                    context.Writer.WritePropertyName("ModelApprovalStatus");
                    context.Writer.Write(publicRequest.ModelApprovalStatus);
                }

                if(publicRequest.IsSetModelCard())
                {
                    context.Writer.WritePropertyName("ModelCard");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelPackageModelCardMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelCard, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelLifeCycle())
                {
                    context.Writer.WritePropertyName("ModelLifeCycle");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelLifeCycleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelLifeCycle, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelMetrics())
                {
                    context.Writer.WritePropertyName("ModelMetrics");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelMetricsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelMetrics, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelPackageDescription())
                {
                    context.Writer.WritePropertyName("ModelPackageDescription");
                    context.Writer.Write(publicRequest.ModelPackageDescription);
                }

                if(publicRequest.IsSetModelPackageGroupName())
                {
                    context.Writer.WritePropertyName("ModelPackageGroupName");
                    context.Writer.Write(publicRequest.ModelPackageGroupName);
                }

                if(publicRequest.IsSetModelPackageName())
                {
                    context.Writer.WritePropertyName("ModelPackageName");
                    context.Writer.Write(publicRequest.ModelPackageName);
                }

                if(publicRequest.IsSetModelPackageRegistrationType())
                {
                    context.Writer.WritePropertyName("ModelPackageRegistrationType");
                    context.Writer.Write(publicRequest.ModelPackageRegistrationType);
                }

                if(publicRequest.IsSetSamplePayloadUrl())
                {
                    context.Writer.WritePropertyName("SamplePayloadUrl");
                    context.Writer.Write(publicRequest.SamplePayloadUrl);
                }

                if(publicRequest.IsSetSecurityConfig())
                {
                    context.Writer.WritePropertyName("SecurityConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelPackageSecurityConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SecurityConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSkipModelValidation())
                {
                    context.Writer.WritePropertyName("SkipModelValidation");
                    context.Writer.Write(publicRequest.SkipModelValidation);
                }

                if(publicRequest.IsSetSourceAlgorithmSpecification())
                {
                    context.Writer.WritePropertyName("SourceAlgorithmSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = SourceAlgorithmSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceAlgorithmSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceUri())
                {
                    context.Writer.WritePropertyName("SourceUri");
                    context.Writer.Write(publicRequest.SourceUri);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTask())
                {
                    context.Writer.WritePropertyName("Task");
                    context.Writer.Write(publicRequest.Task);
                }

                if(publicRequest.IsSetValidationSpecification())
                {
                    context.Writer.WritePropertyName("ValidationSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelPackageValidationSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ValidationSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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