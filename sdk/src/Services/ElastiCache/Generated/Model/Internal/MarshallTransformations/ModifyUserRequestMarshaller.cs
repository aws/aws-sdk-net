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
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyUser Request Marshaller
    /// </summary>       
    public class ModifyUserRequestMarshaller : IMarshaller<IRequest, ModifyUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyUserRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "ModifyUser");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccessString())
                {
                    request.Parameters.Add("AccessString", StringUtils.FromString(publicRequest.AccessString));
                }
                if(publicRequest.IsSetAppendAccessString())
                {
                    request.Parameters.Add("AppendAccessString", StringUtils.FromString(publicRequest.AppendAccessString));
                }
                if(publicRequest.IsSetAuthenticationMode())
                {
                    if(publicRequest.AuthenticationMode.IsSetPasswords())
                    {
                        if (publicRequest.AuthenticationMode.Passwords.Count == 0)
                            request.Parameters.Add("AuthenticationMode" + "." + "Passwords", "");
                        else
                        {
                             int publicRequestAuthenticationModelistValueIndex = 1;
                             foreach(var publicRequestAuthenticationModelistValue in publicRequest.AuthenticationMode.Passwords)
                             {
                                 request.Parameters.Add("AuthenticationMode" + "." + "Passwords" + "." + "member" + "." + publicRequestAuthenticationModelistValueIndex, StringUtils.FromString(publicRequestAuthenticationModelistValue));
                                 publicRequestAuthenticationModelistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.AuthenticationMode.IsSetType())
                    {
                        request.Parameters.Add("AuthenticationMode" + "." + "Type", StringUtils.FromString(publicRequest.AuthenticationMode.Type));
                    }
                }
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
                if(publicRequest.IsSetNoPasswordRequired())
                {
                    request.Parameters.Add("NoPasswordRequired", StringUtils.FromBool(publicRequest.NoPasswordRequired));
                }
                if(publicRequest.IsSetPasswords())
                {
                    if (publicRequest.Passwords.Count == 0)
                        request.Parameters.Add("Passwords", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Passwords)
                         {
                             request.Parameters.Add("Passwords" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetUserId())
                {
                    request.Parameters.Add("UserId", StringUtils.FromString(publicRequest.UserId));
                }
            }
            return request;
        }
                    private static ModifyUserRequestMarshaller _instance = new ModifyUserRequestMarshaller();        

        internal static ModifyUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}