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
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBProxyEndpoint Request Marshaller
    /// </summary>       
    public class ModifyDBProxyEndpointRequestMarshaller : IMarshaller<IRequest, ModifyDBProxyEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBProxyEndpointRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyDBProxyEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ModifyDBProxyEndpoint");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBProxyEndpointName())
                {
                    request.Parameters.Add("DBProxyEndpointName", StringUtils.FromString(publicRequest.DBProxyEndpointName));
                }
                if(publicRequest.IsSetNewDBProxyEndpointName())
                {
                    request.Parameters.Add("NewDBProxyEndpointName", StringUtils.FromString(publicRequest.NewDBProxyEndpointName));
                }
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static ModifyDBProxyEndpointRequestMarshaller _instance = new ModifyDBProxyEndpointRequestMarshaller();        

        internal static ModifyDBProxyEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBProxyEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}