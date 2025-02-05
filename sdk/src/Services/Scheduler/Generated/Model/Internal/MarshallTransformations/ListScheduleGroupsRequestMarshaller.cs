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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Scheduler.Model;
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
namespace Amazon.Scheduler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListScheduleGroups Request Marshaller
    /// </summary>       
    public class ListScheduleGroupsRequestMarshaller : IMarshaller<IRequest, ListScheduleGroupsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListScheduleGroupsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListScheduleGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Scheduler");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-30";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNamePrefix())
                request.Parameters.Add("NamePrefix", StringUtils.FromString(publicRequest.NamePrefix));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/schedule-groups";
            request.UseQueryString = true;

            return request;
        }
        private static ListScheduleGroupsRequestMarshaller _instance = new ListScheduleGroupsRequestMarshaller();        

        internal static ListScheduleGroupsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListScheduleGroupsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}