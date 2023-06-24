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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRecommendationTemplates Request Marshaller
    /// </summary>       
    public class ListRecommendationTemplatesRequestMarshaller : IMarshaller<IRequest, ListRecommendationTemplatesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRecommendationTemplatesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListRecommendationTemplatesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAssessmentArn())
                request.Parameters.Add("assessmentArn", StringUtils.FromString(publicRequest.AssessmentArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetName())
                request.Parameters.Add("name", StringUtils.FromString(publicRequest.Name));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetRecommendationTemplateArn())
                request.Parameters.Add("recommendationTemplateArn", StringUtils.FromString(publicRequest.RecommendationTemplateArn));
            
            if (publicRequest.IsSetReverseOrder())
                request.Parameters.Add("reverseOrder", StringUtils.FromBool(publicRequest.ReverseOrder));
            
            if (publicRequest.IsSetStatus())
                request.ParameterCollection.Add("status", publicRequest.Status);
            request.ResourcePath = "/list-recommendation-templates";
            request.UseQueryString = true;

            return request;
        }
        private static ListRecommendationTemplatesRequestMarshaller _instance = new ListRecommendationTemplatesRequestMarshaller();        

        internal static ListRecommendationTemplatesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListRecommendationTemplatesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}