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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeLoadBalancerPolicies Request Marshaller
    /// </summary>       
    public class DescribeLoadBalancerPoliciesRequestMarshaller : IMarshaller<IRequest, DescribeLoadBalancerPoliciesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeLoadBalancerPoliciesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeLoadBalancerPoliciesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.Parameters.Add("Action", "DescribeLoadBalancerPolicies");
            request.Parameters.Add("Version", "2012-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetLoadBalancerName())
                {
                    request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
                }
                if(publicRequest.IsSetPolicyNames())
                {
                    if (publicRequest.PolicyNames.Count == 0)
                        request.Parameters.Add("PolicyNames", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.PolicyNames)
                         {
                             request.Parameters.Add("PolicyNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static DescribeLoadBalancerPoliciesRequestMarshaller _instance = new DescribeLoadBalancerPoliciesRequestMarshaller();        

        internal static DescribeLoadBalancerPoliciesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeLoadBalancerPoliciesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}