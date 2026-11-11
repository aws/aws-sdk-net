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

using Amazon.ElasticLoadBalancingV2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRule Request Marshaller
    /// </summary>
    public partial class CreateRuleRequestMarshaller : IMarshaller<IRequest, CreateRuleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRuleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateRule");
            request.Parameters.Add("Version", "2015-12-01");

            if (publicRequest.IsSetActions())
            {
                if (publicRequest.Actions.Count == 0)
                {
                    request.Parameters.Add("Actions", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Actions)
                    {
                        if (item0.IsSetAuthenticateCognitoConfig())
                        {
                            if (item0.AuthenticateCognitoConfig.IsSetAuthenticationRequestExtraParams())
                            {
                                int index2 = 1;
                                foreach (var kvp2 in item0.AuthenticateCognitoConfig.AuthenticationRequestExtraParams)
                                {
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".key", StringUtils.FromString(kvp2.Key));
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".value", StringUtils.FromString(kvp2.Value));
                                    index2++;
                                }
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".OnUnauthenticatedRequest", StringUtils.FromString(item0.AuthenticateCognitoConfig.OnUnauthenticatedRequest));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetScope())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".Scope", StringUtils.FromString(item0.AuthenticateCognitoConfig.Scope));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".SessionCookieName", StringUtils.FromString(item0.AuthenticateCognitoConfig.SessionCookieName));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".SessionTimeout", StringUtils.FromLong(item0.AuthenticateCognitoConfig.SessionTimeout.Value));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetUserPoolArn())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".UserPoolArn", StringUtils.FromString(item0.AuthenticateCognitoConfig.UserPoolArn));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetUserPoolClientId())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".UserPoolClientId", StringUtils.FromString(item0.AuthenticateCognitoConfig.UserPoolClientId));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetUserPoolDomain())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".UserPoolDomain", StringUtils.FromString(item0.AuthenticateCognitoConfig.UserPoolDomain));
                            }
                        }
                        if (item0.IsSetAuthenticateOidcConfig())
                        {
                            if (item0.AuthenticateOidcConfig.IsSetAuthenticationRequestExtraParams())
                            {
                                int index2 = 1;
                                foreach (var kvp2 in item0.AuthenticateOidcConfig.AuthenticationRequestExtraParams)
                                {
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".key", StringUtils.FromString(kvp2.Key));
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".value", StringUtils.FromString(kvp2.Value));
                                    index2++;
                                }
                            }
                            if (item0.AuthenticateOidcConfig.IsSetAuthorizationEndpoint())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".AuthorizationEndpoint", StringUtils.FromString(item0.AuthenticateOidcConfig.AuthorizationEndpoint));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetClientId())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".ClientId", StringUtils.FromString(item0.AuthenticateOidcConfig.ClientId));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetClientSecret())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".ClientSecret", StringUtils.FromString(item0.AuthenticateOidcConfig.ClientSecret));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetIssuer())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".Issuer", StringUtils.FromString(item0.AuthenticateOidcConfig.Issuer));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".OnUnauthenticatedRequest", StringUtils.FromString(item0.AuthenticateOidcConfig.OnUnauthenticatedRequest));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetScope())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".Scope", StringUtils.FromString(item0.AuthenticateOidcConfig.Scope));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".SessionCookieName", StringUtils.FromString(item0.AuthenticateOidcConfig.SessionCookieName));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".SessionTimeout", StringUtils.FromLong(item0.AuthenticateOidcConfig.SessionTimeout.Value));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetTokenEndpoint())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".TokenEndpoint", StringUtils.FromString(item0.AuthenticateOidcConfig.TokenEndpoint));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetUseExistingClientSecret())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".UseExistingClientSecret", StringUtils.FromBool(item0.AuthenticateOidcConfig.UseExistingClientSecret.Value));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetUserInfoEndpoint())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".UserInfoEndpoint", StringUtils.FromString(item0.AuthenticateOidcConfig.UserInfoEndpoint));
                            }
                        }
                        if (item0.IsSetFixedResponseConfig())
                        {
                            if (item0.FixedResponseConfig.IsSetContentType())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".FixedResponseConfig" + ".ContentType", StringUtils.FromString(item0.FixedResponseConfig.ContentType));
                            }
                            if (item0.FixedResponseConfig.IsSetMessageBody())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".FixedResponseConfig" + ".MessageBody", StringUtils.FromString(item0.FixedResponseConfig.MessageBody));
                            }
                            if (item0.FixedResponseConfig.IsSetStatusCode())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".FixedResponseConfig" + ".StatusCode", StringUtils.FromString(item0.FixedResponseConfig.StatusCode));
                            }
                        }
                        if (item0.IsSetForwardConfig())
                        {
                            if (item0.ForwardConfig.IsSetTargetGroupStickinessConfig())
                            {
                                if (item0.ForwardConfig.TargetGroupStickinessConfig.IsSetDurationSeconds())
                                {
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroupStickinessConfig" + ".DurationSeconds", StringUtils.FromInt(item0.ForwardConfig.TargetGroupStickinessConfig.DurationSeconds.Value));
                                }
                                if (item0.ForwardConfig.TargetGroupStickinessConfig.IsSetEnabled())
                                {
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroupStickinessConfig" + ".Enabled", StringUtils.FromBool(item0.ForwardConfig.TargetGroupStickinessConfig.Enabled.Value));
                                }
                            }
                            if (item0.ForwardConfig.IsSetTargetGroups())
                            {
                                if (item0.ForwardConfig.TargetGroups.Count == 0)
                                {
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroups", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.ForwardConfig.TargetGroups)
                                    {
                                        if (item2.IsSetTargetGroupArn())
                                        {
                                            request.Parameters.Add("Actions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroups" + ".member" + "." + index2 + ".TargetGroupArn", StringUtils.FromString(item2.TargetGroupArn));
                                        }
                                        if (item2.IsSetWeight())
                                        {
                                            request.Parameters.Add("Actions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroups" + ".member" + "." + index2 + ".Weight", StringUtils.FromInt(item2.Weight.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetJwtValidationConfig())
                        {
                            if (item0.JwtValidationConfig.IsSetAdditionalClaims())
                            {
                                if (item0.JwtValidationConfig.AdditionalClaims.Count == 0)
                                {
                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.JwtValidationConfig.AdditionalClaims)
                                    {
                                        if (item2.IsSetFormat())
                                        {
                                            request.Parameters.Add("Actions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Format", StringUtils.FromString(item2.Format));
                                        }
                                        if (item2.IsSetName())
                                        {
                                            request.Parameters.Add("Actions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Name", StringUtils.FromString(item2.Name));
                                        }
                                        if (item2.IsSetValues())
                                        {
                                            if (item2.Values.Count == 0)
                                            {
                                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Values", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.Values)
                                                {
                                                    request.Parameters.Add("Actions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Values" + ".member" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item0.JwtValidationConfig.IsSetIssuer())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".Issuer", StringUtils.FromString(item0.JwtValidationConfig.Issuer));
                            }
                            if (item0.JwtValidationConfig.IsSetJwksEndpoint())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".JwksEndpoint", StringUtils.FromString(item0.JwtValidationConfig.JwksEndpoint));
                            }
                        }
                        if (item0.IsSetOrder())
                        {
                            request.Parameters.Add("Actions" + ".member" + "." + index0 + ".Order", StringUtils.FromInt(item0.Order.Value));
                        }
                        if (item0.IsSetRedirectConfig())
                        {
                            if (item0.RedirectConfig.IsSetHost())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".RedirectConfig" + ".Host", StringUtils.FromString(item0.RedirectConfig.Host));
                            }
                            if (item0.RedirectConfig.IsSetPath())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".RedirectConfig" + ".Path", StringUtils.FromString(item0.RedirectConfig.Path));
                            }
                            if (item0.RedirectConfig.IsSetPort())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".RedirectConfig" + ".Port", StringUtils.FromString(item0.RedirectConfig.Port));
                            }
                            if (item0.RedirectConfig.IsSetProtocol())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".RedirectConfig" + ".Protocol", StringUtils.FromString(item0.RedirectConfig.Protocol));
                            }
                            if (item0.RedirectConfig.IsSetQuery())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".RedirectConfig" + ".Query", StringUtils.FromString(item0.RedirectConfig.Query));
                            }
                            if (item0.RedirectConfig.IsSetStatusCode())
                            {
                                request.Parameters.Add("Actions" + ".member" + "." + index0 + ".RedirectConfig" + ".StatusCode", StringUtils.FromString(item0.RedirectConfig.StatusCode));
                            }
                        }
                        if (item0.IsSetTargetGroupArn())
                        {
                            request.Parameters.Add("Actions" + ".member" + "." + index0 + ".TargetGroupArn", StringUtils.FromString(item0.TargetGroupArn));
                        }
                        if (item0.IsSetType())
                        {
                            request.Parameters.Add("Actions" + ".member" + "." + index0 + ".Type", StringUtils.FromString(item0.Type));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetConditions())
            {
                if (publicRequest.Conditions.Count == 0)
                {
                    request.Parameters.Add("Conditions", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Conditions)
                    {
                        if (item0.IsSetField())
                        {
                            request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".Field", StringUtils.FromString(item0.Field));
                        }
                        if (item0.IsSetHostHeaderConfig())
                        {
                            if (item0.HostHeaderConfig.IsSetRegexValues())
                            {
                                if (item0.HostHeaderConfig.RegexValues.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HostHeaderConfig" + ".RegexValues", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.HostHeaderConfig.RegexValues)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HostHeaderConfig" + ".RegexValues" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            if (item0.HostHeaderConfig.IsSetValues())
                            {
                                if (item0.HostHeaderConfig.Values.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HostHeaderConfig" + ".Values", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.HostHeaderConfig.Values)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HostHeaderConfig" + ".Values" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetHttpHeaderConfig())
                        {
                            if (item0.HttpHeaderConfig.IsSetHttpHeaderName())
                            {
                                request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HttpHeaderConfig" + ".HttpHeaderName", StringUtils.FromString(item0.HttpHeaderConfig.HttpHeaderName));
                            }
                            if (item0.HttpHeaderConfig.IsSetRegexValues())
                            {
                                if (item0.HttpHeaderConfig.RegexValues.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HttpHeaderConfig" + ".RegexValues", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.HttpHeaderConfig.RegexValues)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HttpHeaderConfig" + ".RegexValues" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            if (item0.HttpHeaderConfig.IsSetValues())
                            {
                                if (item0.HttpHeaderConfig.Values.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HttpHeaderConfig" + ".Values", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.HttpHeaderConfig.Values)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HttpHeaderConfig" + ".Values" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetHttpRequestMethodConfig())
                        {
                            if (item0.HttpRequestMethodConfig.IsSetValues())
                            {
                                if (item0.HttpRequestMethodConfig.Values.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HttpRequestMethodConfig" + ".Values", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.HttpRequestMethodConfig.Values)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".HttpRequestMethodConfig" + ".Values" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetPathPatternConfig())
                        {
                            if (item0.PathPatternConfig.IsSetRegexValues())
                            {
                                if (item0.PathPatternConfig.RegexValues.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".PathPatternConfig" + ".RegexValues", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.PathPatternConfig.RegexValues)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".PathPatternConfig" + ".RegexValues" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            if (item0.PathPatternConfig.IsSetValues())
                            {
                                if (item0.PathPatternConfig.Values.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".PathPatternConfig" + ".Values", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.PathPatternConfig.Values)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".PathPatternConfig" + ".Values" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetQueryStringConfig())
                        {
                            if (item0.QueryStringConfig.IsSetValues())
                            {
                                if (item0.QueryStringConfig.Values.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".QueryStringConfig" + ".Values", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.QueryStringConfig.Values)
                                    {
                                        if (item2.IsSetKey())
                                        {
                                            request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".QueryStringConfig" + ".Values" + ".member" + "." + index2 + ".Key", StringUtils.FromString(item2.Key));
                                        }
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".QueryStringConfig" + ".Values" + ".member" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetRegexValues())
                        {
                            if (item0.RegexValues.Count == 0)
                            {
                                request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".RegexValues", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.RegexValues)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".RegexValues" + ".member" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetSourceIpConfig())
                        {
                            if (item0.SourceIpConfig.IsSetIpAddressType())
                            {
                                request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".SourceIpConfig" + ".IpAddressType", StringUtils.FromString(item0.SourceIpConfig.IpAddressType));
                            }
                            if (item0.SourceIpConfig.IsSetValues())
                            {
                                if (item0.SourceIpConfig.Values.Count == 0)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".SourceIpConfig" + ".Values", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.SourceIpConfig.Values)
                                    {
                                        request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".SourceIpConfig" + ".Values" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetValues())
                        {
                            if (item0.Values.Count == 0)
                            {
                                request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".Values", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Values)
                                {
                                    request.Parameters.Add("Conditions" + ".member" + "." + index0 + ".Values" + ".member" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetListenerArn())
            {
                request.Parameters.Add("ListenerArn", StringUtils.FromString(publicRequest.ListenerArn));
            }
            if (publicRequest.IsSetPriority())
            {
                request.Parameters.Add("Priority", StringUtils.FromInt(publicRequest.Priority.Value));
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
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTransforms())
            {
                if (publicRequest.Transforms.Count == 0)
                {
                    request.Parameters.Add("Transforms", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Transforms)
                    {
                        if (item0.IsSetHostHeaderRewriteConfig())
                        {
                            if (item0.HostHeaderRewriteConfig.IsSetRewrites())
                            {
                                if (item0.HostHeaderRewriteConfig.Rewrites.Count == 0)
                                {
                                    request.Parameters.Add("Transforms" + ".member" + "." + index0 + ".HostHeaderRewriteConfig" + ".Rewrites", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.HostHeaderRewriteConfig.Rewrites)
                                    {
                                        if (item2.IsSetRegex())
                                        {
                                            request.Parameters.Add("Transforms" + ".member" + "." + index0 + ".HostHeaderRewriteConfig" + ".Rewrites" + ".member" + "." + index2 + ".Regex", StringUtils.FromString(item2.Regex));
                                        }
                                        if (item2.IsSetReplace())
                                        {
                                            request.Parameters.Add("Transforms" + ".member" + "." + index0 + ".HostHeaderRewriteConfig" + ".Rewrites" + ".member" + "." + index2 + ".Replace", StringUtils.FromString(item2.Replace));
                                        }
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetType())
                        {
                            request.Parameters.Add("Transforms" + ".member" + "." + index0 + ".Type", StringUtils.FromString(item0.Type));
                        }
                        if (item0.IsSetUrlRewriteConfig())
                        {
                            if (item0.UrlRewriteConfig.IsSetRewrites())
                            {
                                if (item0.UrlRewriteConfig.Rewrites.Count == 0)
                                {
                                    request.Parameters.Add("Transforms" + ".member" + "." + index0 + ".UrlRewriteConfig" + ".Rewrites", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.UrlRewriteConfig.Rewrites)
                                    {
                                        if (item2.IsSetRegex())
                                        {
                                            request.Parameters.Add("Transforms" + ".member" + "." + index0 + ".UrlRewriteConfig" + ".Rewrites" + ".member" + "." + index2 + ".Regex", StringUtils.FromString(item2.Regex));
                                        }
                                        if (item2.IsSetReplace())
                                        {
                                            request.Parameters.Add("Transforms" + ".member" + "." + index0 + ".UrlRewriteConfig" + ".Rewrites" + ".member" + "." + index2 + ".Replace", StringUtils.FromString(item2.Replace));
                                        }
                                        index2++;
                                    }
                                }
                            }
                        }
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

        private static readonly CreateRuleRequestMarshaller _instance = new();

        internal static CreateRuleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateRuleRequestMarshaller Instance => _instance;
    }
}
