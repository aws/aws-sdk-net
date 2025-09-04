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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListHookResults Request Marshaller
    /// </summary>       
    public class ListHookResultsRequestMarshaller : IMarshaller<IRequest, ListHookResultsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListHookResultsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListHookResultsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "ListHookResults");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetStatus())
                {
                    request.Parameters.Add("Status", StringUtils.FromString(publicRequest.Status));
                }
                if(publicRequest.IsSetTargetId())
                {
                    request.Parameters.Add("TargetId", StringUtils.FromString(publicRequest.TargetId));
                }
                if(publicRequest.IsSetTargetType())
                {
                    request.Parameters.Add("TargetType", StringUtils.FromString(publicRequest.TargetType));
                }
                if(publicRequest.IsSetTypeArn())
                {
                    request.Parameters.Add("TypeArn", StringUtils.FromString(publicRequest.TypeArn));
                }
            }
            return request;
        }
                    private static ListHookResultsRequestMarshaller _instance = new ListHookResultsRequestMarshaller();        

        internal static ListHookResultsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListHookResultsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}