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
    /// ModifyDBProxyTargetGroup Request Marshaller
    /// </summary>       
    public class ModifyDBProxyTargetGroupRequestMarshaller : IMarshaller<IRequest, ModifyDBProxyTargetGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBProxyTargetGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyDBProxyTargetGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ModifyDBProxyTargetGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConnectionPoolConfig())
                {
                    if(publicRequest.ConnectionPoolConfig.IsSetConnectionBorrowTimeout())
                    {
                        request.Parameters.Add("ConnectionPoolConfig" + "." + "ConnectionBorrowTimeout", StringUtils.FromInt(publicRequest.ConnectionPoolConfig.ConnectionBorrowTimeout));
                    }
                    if(publicRequest.ConnectionPoolConfig.IsSetInitQuery())
                    {
                        request.Parameters.Add("ConnectionPoolConfig" + "." + "InitQuery", StringUtils.FromString(publicRequest.ConnectionPoolConfig.InitQuery));
                    }
                    if(publicRequest.ConnectionPoolConfig.IsSetMaxConnectionsPercent())
                    {
                        request.Parameters.Add("ConnectionPoolConfig" + "." + "MaxConnectionsPercent", StringUtils.FromInt(publicRequest.ConnectionPoolConfig.MaxConnectionsPercent));
                    }
                    if(publicRequest.ConnectionPoolConfig.IsSetMaxIdleConnectionsPercent())
                    {
                        request.Parameters.Add("ConnectionPoolConfig" + "." + "MaxIdleConnectionsPercent", StringUtils.FromInt(publicRequest.ConnectionPoolConfig.MaxIdleConnectionsPercent));
                    }
                    if(publicRequest.ConnectionPoolConfig.IsSetSessionPinningFilters())
                    {
                        if (publicRequest.ConnectionPoolConfig.SessionPinningFilters.Count == 0)
                            request.Parameters.Add("ConnectionPoolConfig" + "." + "SessionPinningFilters", "");
                        else
                        {
                             int publicRequestConnectionPoolConfiglistValueIndex = 1;
                             foreach(var publicRequestConnectionPoolConfiglistValue in publicRequest.ConnectionPoolConfig.SessionPinningFilters)
                             {
                                 request.Parameters.Add("ConnectionPoolConfig" + "." + "SessionPinningFilters" + "." + "member" + "." + publicRequestConnectionPoolConfiglistValueIndex, StringUtils.FromString(publicRequestConnectionPoolConfiglistValue));
                                 publicRequestConnectionPoolConfiglistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetDBProxyName())
                {
                    request.Parameters.Add("DBProxyName", StringUtils.FromString(publicRequest.DBProxyName));
                }
                if(publicRequest.IsSetNewName())
                {
                    request.Parameters.Add("NewName", StringUtils.FromString(publicRequest.NewName));
                }
                if(publicRequest.IsSetTargetGroupName())
                {
                    request.Parameters.Add("TargetGroupName", StringUtils.FromString(publicRequest.TargetGroupName));
                }
            }
            return request;
        }
                    private static ModifyDBProxyTargetGroupRequestMarshaller _instance = new ModifyDBProxyTargetGroupRequestMarshaller();        

        internal static ModifyDBProxyTargetGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBProxyTargetGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}