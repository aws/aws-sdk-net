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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyListener Request Marshaller
    /// </summary>       
    public class ModifyListenerRequestMarshaller : IMarshaller<IRequest, ModifyListenerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyListenerRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyListenerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "ModifyListener");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCertificates())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Certificates)
                    {
                        if(publicRequestlistValue.IsSetCertificateArn())
                        {
                            request.Parameters.Add("Certificates" + "." + "member" + "." + publicRequestlistValueIndex + "." + "CertificateArn", StringUtils.FromString(publicRequestlistValue.CertificateArn));
                        }
                        if(publicRequestlistValue.IsSetIsDefault())
                        {
                            request.Parameters.Add("Certificates" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IsDefault", StringUtils.FromBool(publicRequestlistValue.IsDefault));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetDefaultActions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.DefaultActions)
                    {
                        if(publicRequestlistValue.IsSetAuthenticateCognitoConfig())
                        {
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetAuthenticationRequestExtraParams())
                            {
                                int mapIndex = 1;
                                foreach(var key in publicRequestlistValue.AuthenticateCognitoConfig.AuthenticationRequestExtraParams.Keys)
                                {
                                    String value;
                                    bool hasValue = publicRequestlistValue.AuthenticateCognitoConfig.AuthenticationRequestExtraParams.TryGetValue(key, out value);
                                    request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                    }
                                    mapIndex++;
                                }
                            }
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "OnUnauthenticatedRequest", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.OnUnauthenticatedRequest));
                            }
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetScope())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "Scope", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.Scope));
                            }
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "SessionCookieName", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.SessionCookieName));
                            }
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "SessionTimeout", StringUtils.FromLong(publicRequestlistValue.AuthenticateCognitoConfig.SessionTimeout));
                            }
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetUserPoolArn())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "UserPoolArn", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.UserPoolArn));
                            }
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetUserPoolClientId())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "UserPoolClientId", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.UserPoolClientId));
                            }
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetUserPoolDomain())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "UserPoolDomain", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.UserPoolDomain));
                            }
                        }
                        if(publicRequestlistValue.IsSetAuthenticateOidcConfig())
                        {
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetAuthenticationRequestExtraParams())
                            {
                                int mapIndex = 1;
                                foreach(var key in publicRequestlistValue.AuthenticateOidcConfig.AuthenticationRequestExtraParams.Keys)
                                {
                                    String value;
                                    bool hasValue = publicRequestlistValue.AuthenticateOidcConfig.AuthenticationRequestExtraParams.TryGetValue(key, out value);
                                    request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                    }
                                    mapIndex++;
                                }
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetAuthorizationEndpoint())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "AuthorizationEndpoint", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.AuthorizationEndpoint));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetClientId())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "ClientId", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.ClientId));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetClientSecret())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "ClientSecret", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.ClientSecret));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetIssuer())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "Issuer", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.Issuer));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "OnUnauthenticatedRequest", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.OnUnauthenticatedRequest));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetScope())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "Scope", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.Scope));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "SessionCookieName", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.SessionCookieName));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "SessionTimeout", StringUtils.FromLong(publicRequestlistValue.AuthenticateOidcConfig.SessionTimeout));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetTokenEndpoint())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "TokenEndpoint", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.TokenEndpoint));
                            }
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetUserInfoEndpoint())
                            {
                                request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "UserInfoEndpoint", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.UserInfoEndpoint));
                            }
                        }
                        if(publicRequestlistValue.IsSetOrder())
                        {
                            request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Order", StringUtils.FromInt(publicRequestlistValue.Order));
                        }
                        if(publicRequestlistValue.IsSetTargetGroupArn())
                        {
                            request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TargetGroupArn", StringUtils.FromString(publicRequestlistValue.TargetGroupArn));
                        }
                        if(publicRequestlistValue.IsSetType())
                        {
                            request.Parameters.Add("DefaultActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetListenerArn())
                {
                    request.Parameters.Add("ListenerArn", StringUtils.FromString(publicRequest.ListenerArn));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetProtocol())
                {
                    request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
                }
                if(publicRequest.IsSetSslPolicy())
                {
                    request.Parameters.Add("SslPolicy", StringUtils.FromString(publicRequest.SslPolicy));
                }
            }
            return request;
        }
                    private static ModifyListenerRequestMarshaller _instance = new ModifyListenerRequestMarshaller();        

        internal static ModifyListenerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyListenerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}