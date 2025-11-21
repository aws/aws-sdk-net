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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Notifications.Model;
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
namespace Amazon.Notifications.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListNotificationEvents Request Marshaller
    /// </summary>       
    public class ListNotificationEventsRequestMarshaller : IMarshaller<IRequest, ListNotificationEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListNotificationEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListNotificationEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Notifications");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAggregateNotificationEventArn())
                request.Parameters.Add("aggregateNotificationEventArn", StringUtils.FromString(publicRequest.AggregateNotificationEventArn));
            
            if (publicRequest.IsSetEndTime())
                request.Parameters.Add("endTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            
            if (publicRequest.IsSetIncludeChildEvents())
                request.Parameters.Add("includeChildEvents", StringUtils.FromBool(publicRequest.IncludeChildEvents));
            
            if (publicRequest.IsSetLocale())
                request.Parameters.Add("locale", StringUtils.FromString(publicRequest.Locale));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetOrganizationalUnitId())
                request.Parameters.Add("organizationalUnitId", StringUtils.FromString(publicRequest.OrganizationalUnitId));
            
            if (publicRequest.IsSetSource())
                request.Parameters.Add("source", StringUtils.FromString(publicRequest.Source));
            
            if (publicRequest.IsSetStartTime())
                request.Parameters.Add("startTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            request.ResourcePath = "/notification-events";
            request.UseQueryString = true;

            return request;
        }
        private static ListNotificationEventsRequestMarshaller _instance = new ListNotificationEventsRequestMarshaller();        

        internal static ListNotificationEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListNotificationEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}