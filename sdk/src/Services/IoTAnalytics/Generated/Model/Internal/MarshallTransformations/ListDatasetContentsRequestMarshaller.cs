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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
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
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListDatasetContents Request Marshaller
    /// </summary>       
    public class ListDatasetContentsRequestMarshaller : IMarshaller<IRequest, ListDatasetContentsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDatasetContentsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListDatasetContentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTAnalytics");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDatasetName())
                throw new AmazonIoTAnalyticsException("Request object does not have required field DatasetName set");
            request.AddPathResource("{datasetName}", StringUtils.FromString(publicRequest.DatasetName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetScheduledBefore())
                request.Parameters.Add("scheduledBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ScheduledBefore));
            
            if (publicRequest.IsSetScheduledOnOrAfter())
                request.Parameters.Add("scheduledOnOrAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ScheduledOnOrAfter));
            request.ResourcePath = "/datasets/{datasetName}/contents";
            request.UseQueryString = true;

            return request;
        }
        private static ListDatasetContentsRequestMarshaller _instance = new ListDatasetContentsRequestMarshaller();        

        internal static ListDatasetContentsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListDatasetContentsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}