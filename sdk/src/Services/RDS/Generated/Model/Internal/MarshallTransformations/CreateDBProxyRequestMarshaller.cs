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
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDBProxy Request Marshaller
    /// </summary>       
    public class CreateDBProxyRequestMarshaller : IMarshaller<IRequest, CreateDBProxyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDBProxyRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDBProxyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "CreateDBProxy");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAuth())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Auth)
                    {
                        if(publicRequestlistValue.IsSetAuthScheme())
                        {
                            request.Parameters.Add("Auth" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthScheme", StringUtils.FromString(publicRequestlistValue.AuthScheme));
                        }
                        if(publicRequestlistValue.IsSetClientPasswordAuthType())
                        {
                            request.Parameters.Add("Auth" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ClientPasswordAuthType", StringUtils.FromString(publicRequestlistValue.ClientPasswordAuthType));
                        }
                        if(publicRequestlistValue.IsSetDescription())
                        {
                            request.Parameters.Add("Auth" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                        }
                        if(publicRequestlistValue.IsSetIAMAuth())
                        {
                            request.Parameters.Add("Auth" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IAMAuth", StringUtils.FromString(publicRequestlistValue.IAMAuth));
                        }
                        if(publicRequestlistValue.IsSetSecretArn())
                        {
                            request.Parameters.Add("Auth" + "." + "member" + "." + publicRequestlistValueIndex + "." + "SecretArn", StringUtils.FromString(publicRequestlistValue.SecretArn));
                        }
                        if(publicRequestlistValue.IsSetUserName())
                        {
                            request.Parameters.Add("Auth" + "." + "member" + "." + publicRequestlistValueIndex + "." + "UserName", StringUtils.FromString(publicRequestlistValue.UserName));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetDBProxyName())
                {
                    request.Parameters.Add("DBProxyName", StringUtils.FromString(publicRequest.DBProxyName));
                }
                if(publicRequest.IsSetDebugLogging())
                {
                    request.Parameters.Add("DebugLogging", StringUtils.FromBool(publicRequest.DebugLogging));
                }
                if(publicRequest.IsSetEngineFamily())
                {
                    request.Parameters.Add("EngineFamily", StringUtils.FromString(publicRequest.EngineFamily));
                }
                if(publicRequest.IsSetIdleClientTimeout())
                {
                    request.Parameters.Add("IdleClientTimeout", StringUtils.FromInt(publicRequest.IdleClientTimeout));
                }
                if(publicRequest.IsSetRequireTLS())
                {
                    request.Parameters.Add("RequireTLS", StringUtils.FromBool(publicRequest.RequireTLS));
                }
                if(publicRequest.IsSetRoleArn())
                {
                    request.Parameters.Add("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
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
                if(publicRequest.IsSetVpcSubnetIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSubnetIds)
                    {
                        request.Parameters.Add("VpcSubnetIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static CreateDBProxyRequestMarshaller _instance = new CreateDBProxyRequestMarshaller();        

        internal static CreateDBProxyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDBProxyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}