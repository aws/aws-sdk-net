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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TrustedAdvisor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TrustedAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateRecommendationResourceExclusion Request Marshaller
    /// </summary>       
    public class BatchUpdateRecommendationResourceExclusionRequestMarshaller : IMarshaller<IRequest, BatchUpdateRecommendationResourceExclusionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateRecommendationResourceExclusionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUpdateRecommendationResourceExclusionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TrustedAdvisor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-15";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/v1/batch-update-recommendation-resource-exclusion";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetRecommendationResourceExclusions())
                {
                    context.Writer.WritePropertyName("recommendationResourceExclusions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRecommendationResourceExclusionsListValue in publicRequest.RecommendationResourceExclusions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RecommendationResourceExclusionMarshaller.Instance;
                        marshaller.Marshall(publicRequestRecommendationResourceExclusionsListValue, context);

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
        private static BatchUpdateRecommendationResourceExclusionRequestMarshaller _instance = new BatchUpdateRecommendationResourceExclusionRequestMarshaller();        

        internal static BatchUpdateRecommendationResourceExclusionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateRecommendationResourceExclusionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}