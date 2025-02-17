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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCallerAccessGrants Request Marshaller
    /// </summary>       
    public class ListCallerAccessGrantsRequestMarshaller : IMarshaller<IRequest, ListCallerAccessGrantsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCallerAccessGrantsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCallerAccessGrantsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "GET";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            
            if (publicRequest.IsSetAllowedByApplication())
                request.Parameters.Add("allowedByApplication", StringUtils.FromBool(publicRequest.AllowedByApplication));
            
            if (publicRequest.IsSetGrantScope())
                request.Parameters.Add("grantscope", StringUtils.FromString(publicRequest.GrantScope));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/v20180820/accessgrantsinstance/caller/grants";


            request.UseQueryString = true;
            return request;
        }
        private static ListCallerAccessGrantsRequestMarshaller _instance = new ListCallerAccessGrantsRequestMarshaller();        

        internal static ListCallerAccessGrantsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCallerAccessGrantsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}