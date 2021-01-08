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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAnswers Request Marshaller
    /// </summary>       
    public class ListAnswersRequestMarshaller : IMarshaller<IRequest, ListAnswersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAnswersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAnswersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetLensAlias())
                throw new AmazonWellArchitectedException("Request object does not have required field LensAlias set");
            request.AddPathResource("{LensAlias}", StringUtils.FromString(publicRequest.LensAlias));
            if (!publicRequest.IsSetWorkloadId())
                throw new AmazonWellArchitectedException("Request object does not have required field WorkloadId set");
            request.AddPathResource("{WorkloadId}", StringUtils.FromString(publicRequest.WorkloadId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetMilestoneNumber())
                request.Parameters.Add("MilestoneNumber", StringUtils.FromInt(publicRequest.MilestoneNumber));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetPillarId())
                request.Parameters.Add("PillarId", StringUtils.FromString(publicRequest.PillarId));
            request.ResourcePath = "/workloads/{WorkloadId}/lensReviews/{LensAlias}/answers";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static ListAnswersRequestMarshaller _instance = new ListAnswersRequestMarshaller();        

        internal static ListAnswersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAnswersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}