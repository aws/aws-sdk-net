/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// CreateAlgorithm Request Marshaller
    /// </summary>       
    public class CreateAlgorithmRequestMarshaller : IMarshaller<IRequest, CreateAlgorithmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAlgorithmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAlgorithmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateAlgorithm";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlgorithmDescription())
                {
                    context.Writer.WritePropertyName("AlgorithmDescription");
                    context.Writer.Write(publicRequest.AlgorithmDescription);
                }

                if(publicRequest.IsSetAlgorithmName())
                {
                    context.Writer.WritePropertyName("AlgorithmName");
                    context.Writer.Write(publicRequest.AlgorithmName);
                }

                if(publicRequest.IsSetCertifyForMarketplace())
                {
                    context.Writer.WritePropertyName("CertifyForMarketplace");
                    context.Writer.Write(publicRequest.CertifyForMarketplace);
                }

                if(publicRequest.IsSetInferenceSpecification())
                {
                    context.Writer.WritePropertyName("InferenceSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InferenceSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTrainingSpecification())
                {
                    context.Writer.WritePropertyName("TrainingSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = TrainingSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TrainingSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetValidationSpecification())
                {
                    context.Writer.WritePropertyName("ValidationSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlgorithmValidationSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ValidationSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAlgorithmRequestMarshaller _instance = new CreateAlgorithmRequestMarshaller();        

        internal static CreateAlgorithmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAlgorithmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}