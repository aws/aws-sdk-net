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
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeStacks Request Marshaller
    /// </summary>       
    public class DescribeStacksRequestMarshaller : IMarshaller<IRequest, DescribeStacksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeStacksRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeStacksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "DescribeStacks");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetStackName())
                {
                    request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
                }
            }
            return request;
        }
                    private static DescribeStacksRequestMarshaller _instance = new DescribeStacksRequestMarshaller();        

        internal static DescribeStacksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeStacksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}