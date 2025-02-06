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
    /// ListEnvironments Request Marshaller
    /// </summary>       
    public class ListEnvironmentsRequestMarshaller : IMarshaller<IRequest, ListEnvironmentsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListEnvironmentsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListEnvironmentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            
            if (publicRequest.IsSetAwsAccountId())
                request.Parameters.Add("awsAccountId", StringUtils.FromString(publicRequest.AwsAccountId));
            
            if (publicRequest.IsSetAwsAccountRegion())
                request.Parameters.Add("awsAccountRegion", StringUtils.FromString(publicRequest.AwsAccountRegion));
            
            if (publicRequest.IsSetEnvironmentBlueprintIdentifier())
                request.Parameters.Add("environmentBlueprintIdentifier", StringUtils.FromString(publicRequest.EnvironmentBlueprintIdentifier));
            
            if (publicRequest.IsSetEnvironmentProfileIdentifier())
                request.Parameters.Add("environmentProfileIdentifier", StringUtils.FromString(publicRequest.EnvironmentProfileIdentifier));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetName())
                request.Parameters.Add("name", StringUtils.FromString(publicRequest.Name));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetProjectIdentifier())
                request.Parameters.Add("projectIdentifier", StringUtils.FromString(publicRequest.ProjectIdentifier));
            
            if (publicRequest.IsSetProvider())
                request.Parameters.Add("provider", StringUtils.FromString(publicRequest.Provider));
            
            if (publicRequest.IsSetStatus())
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/environments";
            request.UseQueryString = true;

            return request;
        }
        private static ListEnvironmentsRequestMarshaller _instance = new ListEnvironmentsRequestMarshaller();        

        internal static ListEnvironmentsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListEnvironmentsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}