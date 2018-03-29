/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthorizeDBSecurityGroupIngress Request Marshaller
    /// </summary>       
    public class AuthorizeDBSecurityGroupIngressRequestMarshaller : IMarshaller<IRequest, AuthorizeDBSecurityGroupIngressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AuthorizeDBSecurityGroupIngressRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AuthorizeDBSecurityGroupIngressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "AuthorizeDBSecurityGroupIngress");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCIDRIP())
                {
                    request.Parameters.Add("CIDRIP", StringUtils.FromString(publicRequest.CIDRIP));
                }
                if(publicRequest.IsSetDBSecurityGroupName())
                {
                    request.Parameters.Add("DBSecurityGroupName", StringUtils.FromString(publicRequest.DBSecurityGroupName));
                }
                if(publicRequest.IsSetEC2SecurityGroupId())
                {
                    request.Parameters.Add("EC2SecurityGroupId", StringUtils.FromString(publicRequest.EC2SecurityGroupId));
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
                    private static AuthorizeDBSecurityGroupIngressRequestMarshaller _instance = new AuthorizeDBSecurityGroupIngressRequestMarshaller();        

        internal static AuthorizeDBSecurityGroupIngressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthorizeDBSecurityGroupIngressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}