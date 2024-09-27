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
    /// DeleteLoadBalancerListeners Request Marshaller
    /// </summary>       
    public class DeleteLoadBalancerListenersRequestMarshaller : IMarshaller<IRequest, DeleteLoadBalancerListenersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteLoadBalancerListenersRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteLoadBalancerListenersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.Parameters.Add("Action", "DeleteLoadBalancerListeners");
            request.Parameters.Add("Version", "2012-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetLoadBalancerName())
                {
                    request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
                }
                if(publicRequest.IsSetLoadBalancerPorts())
                {
                    if (publicRequest.LoadBalancerPorts.Count == 0)
                        request.Parameters.Add("LoadBalancerPorts", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.LoadBalancerPorts)
                         {
                             request.Parameters.Add("LoadBalancerPorts" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromInt(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static DeleteLoadBalancerListenersRequestMarshaller _instance = new DeleteLoadBalancerListenersRequestMarshaller();        

        internal static DeleteLoadBalancerListenersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteLoadBalancerListenersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}