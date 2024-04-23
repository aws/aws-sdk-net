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
    /// GetScalingConfigurationRecommendation Request Marshaller
    /// </summary>       
    public class GetScalingConfigurationRecommendationRequestMarshaller : IMarshaller<IRequest, GetScalingConfigurationRecommendationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetScalingConfigurationRecommendationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetScalingConfigurationRecommendationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.GetScalingConfigurationRecommendation";
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
                if(publicRequest.IsSetEndpointName())
                {
                    context.Writer.WritePropertyName("EndpointName");
                    context.Writer.Write(publicRequest.EndpointName);
                }

                if(publicRequest.IsSetInferenceRecommendationsJobName())
                {
                    context.Writer.WritePropertyName("InferenceRecommendationsJobName");
                    context.Writer.Write(publicRequest.InferenceRecommendationsJobName);
                }

                if(publicRequest.IsSetRecommendationId())
                {
                    context.Writer.WritePropertyName("RecommendationId");
                    context.Writer.Write(publicRequest.RecommendationId);
                }

                if(publicRequest.IsSetScalingPolicyObjective())
                {
                    context.Writer.WritePropertyName("ScalingPolicyObjective");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScalingPolicyObjectiveMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScalingPolicyObjective, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTargetCpuUtilizationPerCore())
                {
                    context.Writer.WritePropertyName("TargetCpuUtilizationPerCore");
                    context.Writer.Write(publicRequest.TargetCpuUtilizationPerCore);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetScalingConfigurationRecommendationRequestMarshaller _instance = new GetScalingConfigurationRecommendationRequestMarshaller();        

        internal static GetScalingConfigurationRecommendationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetScalingConfigurationRecommendationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618