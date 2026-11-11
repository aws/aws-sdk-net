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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBProxyTargetGroup Request Marshaller
    /// </summary>
    public partial class ModifyDBProxyTargetGroupRequestMarshaller : IMarshaller<IRequest, ModifyDBProxyTargetGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBProxyTargetGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBProxyTargetGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBProxyTargetGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetConnectionPoolConfig())
            {
                if (publicRequest.ConnectionPoolConfig.IsSetConnectionBorrowTimeout())
                {
                    request.Parameters.Add("ConnectionPoolConfig" + ".ConnectionBorrowTimeout", StringUtils.FromInt(publicRequest.ConnectionPoolConfig.ConnectionBorrowTimeout.Value));
                }
                if (publicRequest.ConnectionPoolConfig.IsSetInitQuery())
                {
                    request.Parameters.Add("ConnectionPoolConfig" + ".InitQuery", StringUtils.FromString(publicRequest.ConnectionPoolConfig.InitQuery));
                }
                if (publicRequest.ConnectionPoolConfig.IsSetMaxConnectionsPercent())
                {
                    request.Parameters.Add("ConnectionPoolConfig" + ".MaxConnectionsPercent", StringUtils.FromInt(publicRequest.ConnectionPoolConfig.MaxConnectionsPercent.Value));
                }
                if (publicRequest.ConnectionPoolConfig.IsSetMaxIdleConnectionsPercent())
                {
                    request.Parameters.Add("ConnectionPoolConfig" + ".MaxIdleConnectionsPercent", StringUtils.FromInt(publicRequest.ConnectionPoolConfig.MaxIdleConnectionsPercent.Value));
                }
                if (publicRequest.ConnectionPoolConfig.IsSetSessionPinningFilters())
                {
                    if (publicRequest.ConnectionPoolConfig.SessionPinningFilters.Count == 0)
                    {
                        request.Parameters.Add("ConnectionPoolConfig" + ".SessionPinningFilters", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.ConnectionPoolConfig.SessionPinningFilters)
                        {
                            request.Parameters.Add("ConnectionPoolConfig" + ".SessionPinningFilters" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetDBProxyName())
            {
                request.Parameters.Add("DBProxyName", StringUtils.FromString(publicRequest.DBProxyName));
            }
            if (publicRequest.IsSetNewName())
            {
                request.Parameters.Add("NewName", StringUtils.FromString(publicRequest.NewName));
            }
            if (publicRequest.IsSetTargetGroupName())
            {
                request.Parameters.Add("TargetGroupName", StringUtils.FromString(publicRequest.TargetGroupName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyDBProxyTargetGroupRequestMarshaller _instance = new();

        internal static ModifyDBProxyTargetGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBProxyTargetGroupRequestMarshaller Instance => _instance;
    }
}
