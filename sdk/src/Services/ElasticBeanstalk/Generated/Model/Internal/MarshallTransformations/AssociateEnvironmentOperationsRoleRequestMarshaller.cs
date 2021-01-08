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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateEnvironmentOperationsRole Request Marshaller
    /// </summary>       
    public class AssociateEnvironmentOperationsRoleRequestMarshaller : IMarshaller<IRequest, AssociateEnvironmentOperationsRoleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateEnvironmentOperationsRoleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateEnvironmentOperationsRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "AssociateEnvironmentOperationsRole");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEnvironmentName())
                {
                    request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
                }
                if(publicRequest.IsSetOperationsRole())
                {
                    request.Parameters.Add("OperationsRole", StringUtils.FromString(publicRequest.OperationsRole));
                }
            }
            return request;
        }
                    private static AssociateEnvironmentOperationsRoleRequestMarshaller _instance = new AssociateEnvironmentOperationsRoleRequestMarshaller();        

        internal static AssociateEnvironmentOperationsRoleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateEnvironmentOperationsRoleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}