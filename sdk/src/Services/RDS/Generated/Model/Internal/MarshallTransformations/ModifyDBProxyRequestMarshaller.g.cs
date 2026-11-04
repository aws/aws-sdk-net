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
    /// ModifyDBProxy Request Marshaller
    /// </summary>
    public partial class ModifyDBProxyRequestMarshaller : IMarshaller<IRequest, ModifyDBProxyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBProxyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBProxyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBProxy");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetAuth())
            {
                if (publicRequest.Auth.Count == 0)
                {
                    request.Parameters.Add("Auth", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Auth)
                    {
                        if (item0.IsSetAuthScheme())
                        {
                            request.Parameters.Add("Auth" + ".member" + "." + index0 + ".AuthScheme", StringUtils.FromString(item0.AuthScheme));
                        }
                        if (item0.IsSetClientPasswordAuthType())
                        {
                            request.Parameters.Add("Auth" + ".member" + "." + index0 + ".ClientPasswordAuthType", StringUtils.FromString(item0.ClientPasswordAuthType));
                        }
                        if (item0.IsSetDescription())
                        {
                            request.Parameters.Add("Auth" + ".member" + "." + index0 + ".Description", StringUtils.FromString(item0.Description));
                        }
                        if (item0.IsSetIAMAuth())
                        {
                            request.Parameters.Add("Auth" + ".member" + "." + index0 + ".IAMAuth", StringUtils.FromString(item0.IAMAuth));
                        }
                        if (item0.IsSetSecretArn())
                        {
                            request.Parameters.Add("Auth" + ".member" + "." + index0 + ".SecretArn", StringUtils.FromString(item0.SecretArn));
                        }
                        if (item0.IsSetUserName())
                        {
                            request.Parameters.Add("Auth" + ".member" + "." + index0 + ".UserName", StringUtils.FromString(item0.UserName));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDBProxyName())
            {
                request.Parameters.Add("DBProxyName", StringUtils.FromString(publicRequest.DBProxyName));
            }
            if (publicRequest.IsSetDebugLogging())
            {
                request.Parameters.Add("DebugLogging", StringUtils.FromBool(publicRequest.DebugLogging.Value));
            }
            if (publicRequest.IsSetDefaultAuthScheme())
            {
                request.Parameters.Add("DefaultAuthScheme", StringUtils.FromString(publicRequest.DefaultAuthScheme));
            }
            if (publicRequest.IsSetIdleClientTimeout())
            {
                request.Parameters.Add("IdleClientTimeout", StringUtils.FromInt(publicRequest.IdleClientTimeout.Value));
            }
            if (publicRequest.IsSetNewDBProxyName())
            {
                request.Parameters.Add("NewDBProxyName", StringUtils.FromString(publicRequest.NewDBProxyName));
            }
            if (publicRequest.IsSetRequireTLS())
            {
                request.Parameters.Add("RequireTLS", StringUtils.FromBool(publicRequest.RequireTLS.Value));
            }
            if (publicRequest.IsSetRoleArn())
            {
                request.Parameters.Add("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
            }
            if (publicRequest.IsSetSecurityGroups())
            {
                if (publicRequest.SecurityGroups.Count == 0)
                {
                    request.Parameters.Add("SecurityGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroups)
                    {
                        request.Parameters.Add("SecurityGroups" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyDBProxyRequestMarshaller _instance = new();

        internal static ModifyDBProxyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBProxyRequestMarshaller Instance => _instance;
    }
}
