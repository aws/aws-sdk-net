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
    /// UpdateComputeQuota Request Marshaller
    /// </summary>       
    public class UpdateComputeQuotaRequestMarshaller : IMarshaller<IRequest, UpdateComputeQuotaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateComputeQuotaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateComputeQuotaRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.UpdateComputeQuota";
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
                if(publicRequest.IsSetActivationState())
                {
                    context.Writer.WritePropertyName("ActivationState");
                    context.Writer.Write(publicRequest.ActivationState);
                }

                if(publicRequest.IsSetComputeQuotaConfig())
                {
                    context.Writer.WritePropertyName("ComputeQuotaConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ComputeQuotaConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeQuotaConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetComputeQuotaId())
                {
                    context.Writer.WritePropertyName("ComputeQuotaId");
                    context.Writer.Write(publicRequest.ComputeQuotaId);
                }

                if(publicRequest.IsSetComputeQuotaTarget())
                {
                    context.Writer.WritePropertyName("ComputeQuotaTarget");
                    context.Writer.WriteObjectStart();

                    var marshaller = ComputeQuotaTargetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeQuotaTarget, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetTargetVersion())
                {
                    context.Writer.WritePropertyName("TargetVersion");
                    context.Writer.Write(publicRequest.TargetVersion);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateComputeQuotaRequestMarshaller _instance = new UpdateComputeQuotaRequestMarshaller();        

        internal static UpdateComputeQuotaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateComputeQuotaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}