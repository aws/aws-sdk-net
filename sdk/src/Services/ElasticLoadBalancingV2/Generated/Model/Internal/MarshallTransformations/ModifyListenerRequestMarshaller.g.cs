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
    /// ModifyListener Request Marshaller
    /// </summary>
    public partial class ModifyListenerRequestMarshaller : IMarshaller<IRequest, ModifyListenerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyListenerRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyListenerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyListener");
            request.Parameters.Add("Version", "2015-12-01");

            if (publicRequest.IsSetAlpnPolicy())
            {
                if (publicRequest.AlpnPolicy.Count == 0)
                {
                    request.Parameters.Add("AlpnPolicy", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AlpnPolicy)
                    {
                        request.Parameters.Add("AlpnPolicy" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetCertificates())
            {
                if (publicRequest.Certificates.Count == 0)
                {
                    request.Parameters.Add("Certificates", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Certificates)
                    {
                        if (item0.IsSetCertificateArn())
                        {
                            request.Parameters.Add("Certificates" + ".member" + "." + index0 + ".CertificateArn", StringUtils.FromString(item0.CertificateArn));
                        }
                        if (item0.IsSetIsDefault())
                        {
                            request.Parameters.Add("Certificates" + ".member" + "." + index0 + ".IsDefault", StringUtils.FromBool(item0.IsDefault.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDefaultActions())
            {
                if (publicRequest.DefaultActions.Count == 0)
                {
                    request.Parameters.Add("DefaultActions", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DefaultActions)
                    {
                        if (item0.IsSetAuthenticateCognitoConfig())
                        {
                            if (item0.AuthenticateCognitoConfig.IsSetAuthenticationRequestExtraParams())
                            {
                                int index2 = 1;
                                foreach (var kvp2 in item0.AuthenticateCognitoConfig.AuthenticationRequestExtraParams)
                                {
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".key", StringUtils.FromString(kvp2.Key));
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".value", StringUtils.FromString(kvp2.Value));
                                    index2++;
                                }
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".OnUnauthenticatedRequest", StringUtils.FromString(item0.AuthenticateCognitoConfig.OnUnauthenticatedRequest));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetScope())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".Scope", StringUtils.FromString(item0.AuthenticateCognitoConfig.Scope));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".SessionCookieName", StringUtils.FromString(item0.AuthenticateCognitoConfig.SessionCookieName));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".SessionTimeout", StringUtils.FromLong(item0.AuthenticateCognitoConfig.SessionTimeout.Value));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetUserPoolArn())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".UserPoolArn", StringUtils.FromString(item0.AuthenticateCognitoConfig.UserPoolArn));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetUserPoolClientId())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".UserPoolClientId", StringUtils.FromString(item0.AuthenticateCognitoConfig.UserPoolClientId));
                            }
                            if (item0.AuthenticateCognitoConfig.IsSetUserPoolDomain())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateCognitoConfig" + ".UserPoolDomain", StringUtils.FromString(item0.AuthenticateCognitoConfig.UserPoolDomain));
                            }
                        }
                        if (item0.IsSetAuthenticateOidcConfig())
                        {
                            if (item0.AuthenticateOidcConfig.IsSetAuthenticationRequestExtraParams())
                            {
                                int index2 = 1;
                                foreach (var kvp2 in item0.AuthenticateOidcConfig.AuthenticationRequestExtraParams)
                                {
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".key", StringUtils.FromString(kvp2.Key));
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".AuthenticationRequestExtraParams" + ".entry" + "." + index2 + ".value", StringUtils.FromString(kvp2.Value));
                                    index2++;
                                }
                            }
                            if (item0.AuthenticateOidcConfig.IsSetAuthorizationEndpoint())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".AuthorizationEndpoint", StringUtils.FromString(item0.AuthenticateOidcConfig.AuthorizationEndpoint));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetClientId())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".ClientId", StringUtils.FromString(item0.AuthenticateOidcConfig.ClientId));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetClientSecret())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".ClientSecret", StringUtils.FromString(item0.AuthenticateOidcConfig.ClientSecret));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetIssuer())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".Issuer", StringUtils.FromString(item0.AuthenticateOidcConfig.Issuer));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetOnUnauthenticatedRequest())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".OnUnauthenticatedRequest", StringUtils.FromString(item0.AuthenticateOidcConfig.OnUnauthenticatedRequest));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetScope())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".Scope", StringUtils.FromString(item0.AuthenticateOidcConfig.Scope));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetSessionCookieName())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".SessionCookieName", StringUtils.FromString(item0.AuthenticateOidcConfig.SessionCookieName));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetSessionTimeout())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".SessionTimeout", StringUtils.FromLong(item0.AuthenticateOidcConfig.SessionTimeout.Value));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetTokenEndpoint())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".TokenEndpoint", StringUtils.FromString(item0.AuthenticateOidcConfig.TokenEndpoint));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetUseExistingClientSecret())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".UseExistingClientSecret", StringUtils.FromBool(item0.AuthenticateOidcConfig.UseExistingClientSecret.Value));
                            }
                            if (item0.AuthenticateOidcConfig.IsSetUserInfoEndpoint())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".AuthenticateOidcConfig" + ".UserInfoEndpoint", StringUtils.FromString(item0.AuthenticateOidcConfig.UserInfoEndpoint));
                            }
                        }
                        if (item0.IsSetFixedResponseConfig())
                        {
                            if (item0.FixedResponseConfig.IsSetContentType())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".FixedResponseConfig" + ".ContentType", StringUtils.FromString(item0.FixedResponseConfig.ContentType));
                            }
                            if (item0.FixedResponseConfig.IsSetMessageBody())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".FixedResponseConfig" + ".MessageBody", StringUtils.FromString(item0.FixedResponseConfig.MessageBody));
                            }
                            if (item0.FixedResponseConfig.IsSetStatusCode())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".FixedResponseConfig" + ".StatusCode", StringUtils.FromString(item0.FixedResponseConfig.StatusCode));
                            }
                        }
                        if (item0.IsSetForwardConfig())
                        {
                            if (item0.ForwardConfig.IsSetTargetGroupStickinessConfig())
                            {
                                if (item0.ForwardConfig.TargetGroupStickinessConfig.IsSetDurationSeconds())
                                {
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroupStickinessConfig" + ".DurationSeconds", StringUtils.FromInt(item0.ForwardConfig.TargetGroupStickinessConfig.DurationSeconds.Value));
                                }
                                if (item0.ForwardConfig.TargetGroupStickinessConfig.IsSetEnabled())
                                {
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroupStickinessConfig" + ".Enabled", StringUtils.FromBool(item0.ForwardConfig.TargetGroupStickinessConfig.Enabled.Value));
                                }
                            }
                            if (item0.ForwardConfig.IsSetTargetGroups())
                            {
                                if (item0.ForwardConfig.TargetGroups.Count == 0)
                                {
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroups", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.ForwardConfig.TargetGroups)
                                    {
                                        if (item2.IsSetTargetGroupArn())
                                        {
                                            request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroups" + ".member" + "." + index2 + ".TargetGroupArn", StringUtils.FromString(item2.TargetGroupArn));
                                        }
                                        if (item2.IsSetWeight())
                                        {
                                            request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".ForwardConfig" + ".TargetGroups" + ".member" + "." + index2 + ".Weight", StringUtils.FromInt(item2.Weight.Value));
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
                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.JwtValidationConfig.AdditionalClaims)
                                    {
                                        if (item2.IsSetFormat())
                                        {
                                            request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Format", StringUtils.FromString(item2.Format));
                                        }
                                        if (item2.IsSetName())
                                        {
                                            request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Name", StringUtils.FromString(item2.Name));
                                        }
                                        if (item2.IsSetValues())
                                        {
                                            if (item2.Values.Count == 0)
                                            {
                                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Values", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item2.Values)
                                                {
                                                    request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".AdditionalClaims" + ".member" + "." + index2 + ".Values" + ".member" + "." + index3, StringUtils.FromString(item3));
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
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".Issuer", StringUtils.FromString(item0.JwtValidationConfig.Issuer));
                            }
                            if (item0.JwtValidationConfig.IsSetJwksEndpoint())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".JwtValidationConfig" + ".JwksEndpoint", StringUtils.FromString(item0.JwtValidationConfig.JwksEndpoint));
                            }
                        }
                        if (item0.IsSetOrder())
                        {
                            request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".Order", StringUtils.FromInt(item0.Order.Value));
                        }
                        if (item0.IsSetRedirectConfig())
                        {
                            if (item0.RedirectConfig.IsSetHost())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".RedirectConfig" + ".Host", StringUtils.FromString(item0.RedirectConfig.Host));
                            }
                            if (item0.RedirectConfig.IsSetPath())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".RedirectConfig" + ".Path", StringUtils.FromString(item0.RedirectConfig.Path));
                            }
                            if (item0.RedirectConfig.IsSetPort())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".RedirectConfig" + ".Port", StringUtils.FromString(item0.RedirectConfig.Port));
                            }
                            if (item0.RedirectConfig.IsSetProtocol())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".RedirectConfig" + ".Protocol", StringUtils.FromString(item0.RedirectConfig.Protocol));
                            }
                            if (item0.RedirectConfig.IsSetQuery())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".RedirectConfig" + ".Query", StringUtils.FromString(item0.RedirectConfig.Query));
                            }
                            if (item0.RedirectConfig.IsSetStatusCode())
                            {
                                request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".RedirectConfig" + ".StatusCode", StringUtils.FromString(item0.RedirectConfig.StatusCode));
                            }
                        }
                        if (item0.IsSetTargetGroupArn())
                        {
                            request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".TargetGroupArn", StringUtils.FromString(item0.TargetGroupArn));
                        }
                        if (item0.IsSetType())
                        {
                            request.Parameters.Add("DefaultActions" + ".member" + "." + index0 + ".Type", StringUtils.FromString(item0.Type));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetListenerArn())
            {
                request.Parameters.Add("ListenerArn", StringUtils.FromString(publicRequest.ListenerArn));
            }
            if (publicRequest.IsSetMutualAuthentication())
            {
                if (publicRequest.MutualAuthentication.IsSetAdvertiseTrustStoreCaNames())
                {
                    request.Parameters.Add("MutualAuthentication" + ".AdvertiseTrustStoreCaNames", StringUtils.FromString(publicRequest.MutualAuthentication.AdvertiseTrustStoreCaNames));
                }
                if (publicRequest.MutualAuthentication.IsSetIgnoreClientCertificateExpiry())
                {
                    request.Parameters.Add("MutualAuthentication" + ".IgnoreClientCertificateExpiry", StringUtils.FromBool(publicRequest.MutualAuthentication.IgnoreClientCertificateExpiry.Value));
                }
                if (publicRequest.MutualAuthentication.IsSetMode())
                {
                    request.Parameters.Add("MutualAuthentication" + ".Mode", StringUtils.FromString(publicRequest.MutualAuthentication.Mode));
                }
                if (publicRequest.MutualAuthentication.IsSetTrustStoreArn())
                {
                    request.Parameters.Add("MutualAuthentication" + ".TrustStoreArn", StringUtils.FromString(publicRequest.MutualAuthentication.TrustStoreArn));
                }
                if (publicRequest.MutualAuthentication.IsSetTrustStoreAssociationStatus())
                {
                    request.Parameters.Add("MutualAuthentication" + ".TrustStoreAssociationStatus", StringUtils.FromString(publicRequest.MutualAuthentication.TrustStoreAssociationStatus));
                }
            }
            if (publicRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port.Value));
            }
            if (publicRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
            }
            if (publicRequest.IsSetSslPolicy())
            {
                request.Parameters.Add("SslPolicy", StringUtils.FromString(publicRequest.SslPolicy));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyListenerRequestMarshaller _instance = new();

        internal static ModifyListenerRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyListenerRequestMarshaller Instance => _instance;
    }
}
