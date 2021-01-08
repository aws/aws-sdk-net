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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthorizeCacheSecurityGroupIngress Request Marshaller
    /// </summary>       
    public class AuthorizeCacheSecurityGroupIngressRequestMarshaller : IMarshaller<IRequest, AuthorizeCacheSecurityGroupIngressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AuthorizeCacheSecurityGroupIngressRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AuthorizeCacheSecurityGroupIngressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "AuthorizeCacheSecurityGroupIngress");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCacheSecurityGroupName())
                {
                    request.Parameters.Add("CacheSecurityGroupName", StringUtils.FromString(publicRequest.CacheSecurityGroupName));
                }
                if(publicRequest.IsSetEC2SecurityGroupName())
                {
                    request.Parameters.Add("EC2SecurityGroupName", StringUtils.FromString(publicRequest.EC2SecurityGroupName));
                }
                if(publicRequest.IsSetEC2SecurityGroupOwnerId())
                {
                    request.Parameters.Add("EC2SecurityGroupOwnerId", StringUtils.FromString(publicRequest.EC2SecurityGroupOwnerId));
                }
            }
            return request;
        }
                    private static AuthorizeCacheSecurityGroupIngressRequestMarshaller _instance = new AuthorizeCacheSecurityGroupIngressRequestMarshaller();        

        internal static AuthorizeCacheSecurityGroupIngressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthorizeCacheSecurityGroupIngressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}