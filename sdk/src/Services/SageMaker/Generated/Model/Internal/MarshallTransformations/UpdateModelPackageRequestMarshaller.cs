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
    /// UpdateModelPackage Request Marshaller
    /// </summary>       
    public class UpdateModelPackageRequestMarshaller : IMarshaller<IRequest, UpdateModelPackageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateModelPackageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateModelPackageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.UpdateModelPackage";
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
                if(publicRequest.IsSetAdditionalInferenceSpecificationsToAdd())
                {
                    context.Writer.WritePropertyName("AdditionalInferenceSpecificationsToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalInferenceSpecificationsToAddListValue in publicRequest.AdditionalInferenceSpecificationsToAdd)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AdditionalInferenceSpecificationDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestAdditionalInferenceSpecificationsToAddListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetApprovalDescription())
                {
                    context.Writer.WritePropertyName("ApprovalDescription");
                    context.Writer.Write(publicRequest.ApprovalDescription);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
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

                if(publicRequest.IsSetCustomerMetadataPropertiesToRemove())
                {
                    context.Writer.WritePropertyName("CustomerMetadataPropertiesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCustomerMetadataPropertiesToRemoveListValue in publicRequest.CustomerMetadataPropertiesToRemove)
                    {
                            context.Writer.Write(publicRequestCustomerMetadataPropertiesToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInferenceSpecification())
                {
                    context.Writer.WritePropertyName("InferenceSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InferenceSpecification, context);

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

                if(publicRequest.IsSetModelPackageArn())
                {
                    context.Writer.WritePropertyName("ModelPackageArn");
                    context.Writer.Write(publicRequest.ModelPackageArn);
                }

                if(publicRequest.IsSetModelPackageRegistrationType())
                {
                    context.Writer.WritePropertyName("ModelPackageRegistrationType");
                    context.Writer.Write(publicRequest.ModelPackageRegistrationType);
                }

                if(publicRequest.IsSetSourceUri())
                {
                    context.Writer.WritePropertyName("SourceUri");
                    context.Writer.Write(publicRequest.SourceUri);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateModelPackageRequestMarshaller _instance = new UpdateModelPackageRequestMarshaller();        

        internal static UpdateModelPackageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateModelPackageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}