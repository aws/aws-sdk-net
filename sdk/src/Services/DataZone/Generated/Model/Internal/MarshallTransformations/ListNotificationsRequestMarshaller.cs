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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
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
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListNotifications Request Marshaller
    /// </summary>       
    public class ListNotificationsRequestMarshaller : IMarshaller<IRequest, ListNotificationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListNotificationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListNotificationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            
            if (publicRequest.IsSetAfterTimestamp())
                request.Parameters.Add("afterTimestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.AfterTimestamp));
            
            if (publicRequest.IsSetBeforeTimestamp())
                request.Parameters.Add("beforeTimestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.BeforeTimestamp));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSubjects())
                request.ParameterCollection.Add("subjects", publicRequest.Subjects);
            
            if (publicRequest.IsSetTaskStatus())
                request.Parameters.Add("taskStatus", StringUtils.FromString(publicRequest.TaskStatus));
            
            if (publicRequest.IsSetType())
                request.Parameters.Add("type", StringUtils.FromString(publicRequest.Type));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/notifications";
            request.UseQueryString = true;

            return request;
        }
        private static ListNotificationsRequestMarshaller _instance = new ListNotificationsRequestMarshaller();        

        internal static ListNotificationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListNotificationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}