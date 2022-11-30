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

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEndpointConfig Request Marshaller
    /// </summary>       
    public class CreateEndpointConfigRequestMarshaller : IMarshaller<IRequest, CreateEndpointConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEndpointConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEndpointConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateEndpointConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAsyncInferenceConfig())
                {
                    context.Writer.WritePropertyName("AsyncInferenceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AsyncInferenceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AsyncInferenceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataCaptureConfig())
                {
                    context.Writer.WritePropertyName("DataCaptureConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataCaptureConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataCaptureConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEndpointConfigName())
                {
                    context.Writer.WritePropertyName("EndpointConfigName");
                    context.Writer.Write(publicRequest.EndpointConfigName);
                }

                if(publicRequest.IsSetExplainerConfig())
                {
                    context.Writer.WritePropertyName("ExplainerConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExplainerConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExplainerConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetProductionVariants())
                {
                    context.Writer.WritePropertyName("ProductionVariants");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProductionVariantsListValue in publicRequest.ProductionVariants)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ProductionVariantMarshaller.Instance;
                        marshaller.Marshall(publicRequestProductionVariantsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetShadowProductionVariants())
                {
                    context.Writer.WritePropertyName("ShadowProductionVariants");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestShadowProductionVariantsListValue in publicRequest.ShadowProductionVariants)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ProductionVariantMarshaller.Instance;
                        marshaller.Marshall(publicRequestShadowProductionVariantsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEndpointConfigRequestMarshaller _instance = new CreateEndpointConfigRequestMarshaller();        

        internal static CreateEndpointConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEndpointConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}