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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListEnrichmentJobs Request Marshaller
    /// </summary>       
    public class ListEnrichmentJobsRequestMarshaller : IMarshaller<IRequest, ListEnrichmentJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListEnrichmentJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListEnrichmentJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetWorkspaceName())
                throw new AmazonIoTSiteWiseException("Request object does not have required field WorkspaceName set");
            request.AddPathResource("{workspaceName}", StringUtils.FromString(publicRequest.WorkspaceName));
            
            if (publicRequest.IsSetDatasetId())
                request.Parameters.Add("datasetId", StringUtils.FromString(publicRequest.DatasetId));
            
            if (publicRequest.IsSetEndDate())
                request.Parameters.Add("endDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate));
            
            if (publicRequest.IsSetJobType())
                request.Parameters.Add("jobType", StringUtils.FromString(publicRequest.JobType));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetPropertyAlias())
                request.Parameters.Add("propertyAlias", StringUtils.FromString(publicRequest.PropertyAlias));
            
            if (publicRequest.IsSetStartDate())
                request.Parameters.Add("startDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartDate));
            
            if (publicRequest.IsSetStatus())
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            
            if (publicRequest.IsSetTimeSeriesId())
                request.Parameters.Add("timeSeriesId", StringUtils.FromString(publicRequest.TimeSeriesId));
            request.ResourcePath = "/workspaces/{workspaceName}/enrichment-jobs";
            request.UseQueryString = true;
            
            request.HostPrefix = $"data.";

            return request;
        }
        private static ListEnrichmentJobsRequestMarshaller _instance = new ListEnrichmentJobsRequestMarshaller();        

        internal static ListEnrichmentJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListEnrichmentJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}