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
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyRule Request Marshaller
    /// </summary>       
    public class ModifyRuleRequestMarshaller : IMarshaller<IRequest, ModifyRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyRuleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "ModifyRule");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetActions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Actions)
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
                                    request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                    }
                                    mapIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "OnUnauthenticatedRequest", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.OnUnauthenticatedRequest));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetScope())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "Scope", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.Scope));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "SessionCookieName", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.SessionCookieName));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "SessionTimeout", StringUtils.FromLong(publicRequestlistValue.AuthenticateCognitoConfig.SessionTimeout));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetUserPoolArn())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "UserPoolArn", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.UserPoolArn));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetUserPoolClientId())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "UserPoolClientId", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.UserPoolClientId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateCognitoConfig.IsSetUserPoolDomain())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateCognitoConfig" + "." + "UserPoolDomain", StringUtils.FromString(publicRequestlistValue.AuthenticateCognitoConfig.UserPoolDomain));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetAuthenticateOidcConfig())
                        {
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetAuthenticationRequestExtraParams())
                            {
                                int mapIndex = 1;
                                foreach(var key in publicRequestlistValue.AuthenticateOidcConfig.AuthenticationRequestExtraParams.Keys)
                                {
                                    String value;
                                    bool hasValue = publicRequestlistValue.AuthenticateOidcConfig.AuthenticationRequestExtraParams.TryGetValue(key, out value);
                                    request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "AuthenticationRequestExtraParams" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                    }
                                    mapIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetAuthorizationEndpoint())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "AuthorizationEndpoint", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.AuthorizationEndpoint));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetClientId())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "ClientId", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.ClientId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetClientSecret())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "ClientSecret", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.ClientSecret));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetIssuer())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "Issuer", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.Issuer));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "OnUnauthenticatedRequest", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.OnUnauthenticatedRequest));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetScope())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "Scope", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.Scope));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "SessionCookieName", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.SessionCookieName));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "SessionTimeout", StringUtils.FromLong(publicRequestlistValue.AuthenticateOidcConfig.SessionTimeout));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetTokenEndpoint())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "TokenEndpoint", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.TokenEndpoint));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetUseExistingClientSecret())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "UseExistingClientSecret", StringUtils.FromBool(publicRequestlistValue.AuthenticateOidcConfig.UseExistingClientSecret));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.AuthenticateOidcConfig.IsSetUserInfoEndpoint())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthenticateOidcConfig" + "." + "UserInfoEndpoint", StringUtils.FromString(publicRequestlistValue.AuthenticateOidcConfig.UserInfoEndpoint));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetFixedResponseConfig())
                        {
                            if(publicRequestlistValue.FixedResponseConfig.IsSetContentType())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "FixedResponseConfig" + "." + "ContentType", StringUtils.FromString(publicRequestlistValue.FixedResponseConfig.ContentType));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.FixedResponseConfig.IsSetMessageBody())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "FixedResponseConfig" + "." + "MessageBody", StringUtils.FromString(publicRequestlistValue.FixedResponseConfig.MessageBody));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.FixedResponseConfig.IsSetStatusCode())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "FixedResponseConfig" + "." + "StatusCode", StringUtils.FromString(publicRequestlistValue.FixedResponseConfig.StatusCode));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetForwardConfig())
                        {
                            if(publicRequestlistValue.ForwardConfig.IsSetTargetGroups())
                            {
                                int publicRequestlistValueForwardConfiglistValueIndex = 1;
                                foreach(var publicRequestlistValueForwardConfiglistValue in publicRequestlistValue.ForwardConfig.TargetGroups)
                                {
                                    if(publicRequestlistValueForwardConfiglistValue.IsSetTargetGroupArn())
                                    {
                                        request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ForwardConfig" + "." + "TargetGroups" + "." + "member" + "." + publicRequestlistValueForwardConfiglistValueIndex + "." + "TargetGroupArn", StringUtils.FromString(publicRequestlistValueForwardConfiglistValue.TargetGroupArn));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValueForwardConfiglistValue.IsSetWeight())
                                    {
                                        request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ForwardConfig" + "." + "TargetGroups" + "." + "member" + "." + publicRequestlistValueForwardConfiglistValueIndex + "." + "Weight", StringUtils.FromInt(publicRequestlistValueForwardConfiglistValue.Weight));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestlistValueForwardConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.ForwardConfig.IsSetTargetGroupStickinessConfig())
                            {
                                if(publicRequestlistValue.ForwardConfig.TargetGroupStickinessConfig.IsSetDurationSeconds())
                                {
                                    request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ForwardConfig" + "." + "TargetGroupStickinessConfig" + "." + "DurationSeconds", StringUtils.FromInt(publicRequestlistValue.ForwardConfig.TargetGroupStickinessConfig.DurationSeconds));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValue.ForwardConfig.TargetGroupStickinessConfig.IsSetEnabled())
                                {
                                    request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ForwardConfig" + "." + "TargetGroupStickinessConfig" + "." + "Enabled", StringUtils.FromBool(publicRequestlistValue.ForwardConfig.TargetGroupStickinessConfig.Enabled));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetOrder())
                        {
                            request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Order", StringUtils.FromInt(publicRequestlistValue.Order));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetRedirectConfig())
                        {
                            if(publicRequestlistValue.RedirectConfig.IsSetHost())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RedirectConfig" + "." + "Host", StringUtils.FromString(publicRequestlistValue.RedirectConfig.Host));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.RedirectConfig.IsSetPath())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RedirectConfig" + "." + "Path", StringUtils.FromString(publicRequestlistValue.RedirectConfig.Path));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.RedirectConfig.IsSetPort())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RedirectConfig" + "." + "Port", StringUtils.FromString(publicRequestlistValue.RedirectConfig.Port));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.RedirectConfig.IsSetProtocol())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RedirectConfig" + "." + "Protocol", StringUtils.FromString(publicRequestlistValue.RedirectConfig.Protocol));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.RedirectConfig.IsSetQuery())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RedirectConfig" + "." + "Query", StringUtils.FromString(publicRequestlistValue.RedirectConfig.Query));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.RedirectConfig.IsSetStatusCode())
                            {
                                request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RedirectConfig" + "." + "StatusCode", StringUtils.FromString(publicRequestlistValue.RedirectConfig.StatusCode));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetTargetGroupArn())
                        {
                            request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TargetGroupArn", StringUtils.FromString(publicRequestlistValue.TargetGroupArn));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetType())
                        {
                            request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetConditions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Conditions)
                    {
                        if(publicRequestlistValue.IsSetField())
                        {
                            request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Field", StringUtils.FromString(publicRequestlistValue.Field));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetHostHeaderConfig())
                        {
                            if(publicRequestlistValue.HostHeaderConfig.IsSetValues())
                            {
                                int publicRequestlistValueHostHeaderConfiglistValueIndex = 1;
                                foreach(var publicRequestlistValueHostHeaderConfiglistValue in publicRequestlistValue.HostHeaderConfig.Values)
                                {
                                    request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "HostHeaderConfig" + "." + "Values" + "." + "member" + "." + publicRequestlistValueHostHeaderConfiglistValueIndex, StringUtils.FromString(publicRequestlistValueHostHeaderConfiglistValue));
                                    publicRequestlistValueHostHeaderConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetHttpHeaderConfig())
                        {
                            if(publicRequestlistValue.HttpHeaderConfig.IsSetHttpHeaderName())
                            {
                                request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "HttpHeaderConfig" + "." + "HttpHeaderName", StringUtils.FromString(publicRequestlistValue.HttpHeaderConfig.HttpHeaderName));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.HttpHeaderConfig.IsSetValues())
                            {
                                int publicRequestlistValueHttpHeaderConfiglistValueIndex = 1;
                                foreach(var publicRequestlistValueHttpHeaderConfiglistValue in publicRequestlistValue.HttpHeaderConfig.Values)
                                {
                                    request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "HttpHeaderConfig" + "." + "Values" + "." + "member" + "." + publicRequestlistValueHttpHeaderConfiglistValueIndex, StringUtils.FromString(publicRequestlistValueHttpHeaderConfiglistValue));
                                    publicRequestlistValueHttpHeaderConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetHttpRequestMethodConfig())
                        {
                            if(publicRequestlistValue.HttpRequestMethodConfig.IsSetValues())
                            {
                                int publicRequestlistValueHttpRequestMethodConfiglistValueIndex = 1;
                                foreach(var publicRequestlistValueHttpRequestMethodConfiglistValue in publicRequestlistValue.HttpRequestMethodConfig.Values)
                                {
                                    request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "HttpRequestMethodConfig" + "." + "Values" + "." + "member" + "." + publicRequestlistValueHttpRequestMethodConfiglistValueIndex, StringUtils.FromString(publicRequestlistValueHttpRequestMethodConfiglistValue));
                                    publicRequestlistValueHttpRequestMethodConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetPathPatternConfig())
                        {
                            if(publicRequestlistValue.PathPatternConfig.IsSetValues())
                            {
                                int publicRequestlistValuePathPatternConfiglistValueIndex = 1;
                                foreach(var publicRequestlistValuePathPatternConfiglistValue in publicRequestlistValue.PathPatternConfig.Values)
                                {
                                    request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "PathPatternConfig" + "." + "Values" + "." + "member" + "." + publicRequestlistValuePathPatternConfiglistValueIndex, StringUtils.FromString(publicRequestlistValuePathPatternConfiglistValue));
                                    publicRequestlistValuePathPatternConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetQueryStringConfig())
                        {
                            if(publicRequestlistValue.QueryStringConfig.IsSetValues())
                            {
                                int publicRequestlistValueQueryStringConfiglistValueIndex = 1;
                                foreach(var publicRequestlistValueQueryStringConfiglistValue in publicRequestlistValue.QueryStringConfig.Values)
                                {
                                    if(publicRequestlistValueQueryStringConfiglistValue.IsSetKey())
                                    {
                                        request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "QueryStringConfig" + "." + "Values" + "." + "member" + "." + publicRequestlistValueQueryStringConfiglistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValueQueryStringConfiglistValue.Key));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValueQueryStringConfiglistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "QueryStringConfig" + "." + "Values" + "." + "member" + "." + publicRequestlistValueQueryStringConfiglistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValueQueryStringConfiglistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestlistValueQueryStringConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetSourceIpConfig())
                        {
                            if(publicRequestlistValue.SourceIpConfig.IsSetValues())
                            {
                                int publicRequestlistValueSourceIpConfiglistValueIndex = 1;
                                foreach(var publicRequestlistValueSourceIpConfiglistValue in publicRequestlistValue.SourceIpConfig.Values)
                                {
                                    request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "SourceIpConfig" + "." + "Values" + "." + "member" + "." + publicRequestlistValueSourceIpConfiglistValueIndex, StringUtils.FromString(publicRequestlistValueSourceIpConfiglistValue));
                                    publicRequestlistValueSourceIpConfiglistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetValues())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                            {
                                request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Values" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRuleArn())
                {
                    request.Parameters.Add("RuleArn", StringUtils.FromString(publicRequest.RuleArn));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ModifyRuleRequestMarshaller _instance = new ModifyRuleRequestMarshaller();        

        internal static ModifyRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}