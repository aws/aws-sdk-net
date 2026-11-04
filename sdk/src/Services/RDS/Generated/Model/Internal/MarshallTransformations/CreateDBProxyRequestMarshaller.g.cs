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
    /// CreateDBProxy Request Marshaller
    /// </summary>
    public partial class CreateDBProxyRequestMarshaller : IMarshaller<IRequest, CreateDBProxyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDBProxyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDBProxyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateDBProxy");
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
            if (publicRequest.IsSetEndpointNetworkType())
            {
                request.Parameters.Add("EndpointNetworkType", StringUtils.FromString(publicRequest.EndpointNetworkType));
            }
            if (publicRequest.IsSetEngineFamily())
            {
                request.Parameters.Add("EngineFamily", StringUtils.FromString(publicRequest.EngineFamily));
            }
            if (publicRequest.IsSetIdleClientTimeout())
            {
                request.Parameters.Add("IdleClientTimeout", StringUtils.FromInt(publicRequest.IdleClientTimeout.Value));
            }
            if (publicRequest.IsSetRequireTLS())
            {
                request.Parameters.Add("RequireTLS", StringUtils.FromBool(publicRequest.RequireTLS.Value));
            }
            if (publicRequest.IsSetRoleArn())
            {
                request.Parameters.Add("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetConnectionNetworkType())
            {
                request.Parameters.Add("TargetConnectionNetworkType", StringUtils.FromString(publicRequest.TargetConnectionNetworkType));
            }
            if (publicRequest.IsSetVpcSecurityGroupIds())
            {
                if (publicRequest.VpcSecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("VpcSecurityGroupIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetVpcSubnetIds())
            {
                if (publicRequest.VpcSubnetIds.Count == 0)
                {
                    request.Parameters.Add("VpcSubnetIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.VpcSubnetIds)
                    {
                        request.Parameters.Add("VpcSubnetIds" + ".member" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly CreateDBProxyRequestMarshaller _instance = new();

        internal static CreateDBProxyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDBProxyRequestMarshaller Instance => _instance;
    }
}
