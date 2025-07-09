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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
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
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCollaborationTrainedModelExportJobs Request Marshaller
    /// </summary>       
    public class ListCollaborationTrainedModelExportJobsRequestMarshaller : IMarshaller<IRequest, ListCollaborationTrainedModelExportJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCollaborationTrainedModelExportJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCollaborationTrainedModelExportJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRoomsML");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-06";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCollaborationIdentifier())
                throw new AmazonCleanRoomsMLException("Request object does not have required field CollaborationIdentifier set");
            request.AddPathResource("{collaborationIdentifier}", StringUtils.FromString(publicRequest.CollaborationIdentifier));
            if (!publicRequest.IsSetTrainedModelArn())
                throw new AmazonCleanRoomsMLException("Request object does not have required field TrainedModelArn set");
            request.AddPathResource("{trainedModelArn}", StringUtils.FromString(publicRequest.TrainedModelArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetTrainedModelVersionIdentifier())
                request.Parameters.Add("trainedModelVersionIdentifier", StringUtils.FromString(publicRequest.TrainedModelVersionIdentifier));
            request.ResourcePath = "/collaborations/{collaborationIdentifier}/trained-models/{trainedModelArn}/export-jobs";
            request.UseQueryString = true;

            return request;
        }
        private static ListCollaborationTrainedModelExportJobsRequestMarshaller _instance = new ListCollaborationTrainedModelExportJobsRequestMarshaller();        

        internal static ListCollaborationTrainedModelExportJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCollaborationTrainedModelExportJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}