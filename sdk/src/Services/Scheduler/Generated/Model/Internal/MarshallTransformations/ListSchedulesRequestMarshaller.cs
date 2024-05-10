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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Scheduler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSchedules Request Marshaller
    /// </summary>       
    public class ListSchedulesRequestMarshaller : IMarshaller<IRequest, ListSchedulesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSchedulesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListSchedulesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Scheduler");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-30";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetGroupName())
                request.Parameters.Add("ScheduleGroup", StringUtils.FromString(publicRequest.GroupName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNamePrefix())
                request.Parameters.Add("NamePrefix", StringUtils.FromString(publicRequest.NamePrefix));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetState())
                request.Parameters.Add("State", StringUtils.FromString(publicRequest.State));
            request.ResourcePath = "/schedules";
            request.UseQueryString = true;

            return request;
        }
        private static ListSchedulesRequestMarshaller _instance = new ListSchedulesRequestMarshaller();        

        internal static ListSchedulesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSchedulesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}