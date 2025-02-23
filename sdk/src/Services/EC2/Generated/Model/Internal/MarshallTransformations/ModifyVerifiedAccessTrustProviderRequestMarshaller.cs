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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVerifiedAccessTrustProvider Request Marshaller
    /// </summary>       
    public class ModifyVerifiedAccessTrustProviderRequestMarshaller : IMarshaller<IRequest, ModifyVerifiedAccessTrustProviderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVerifiedAccessTrustProviderRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVerifiedAccessTrustProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVerifiedAccessTrustProvider");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDeviceOptions())
                {
                    if(publicRequest.DeviceOptions.IsSetPublicSigningKeyUrl())
                    {
                        request.Parameters.Add("DeviceOptions" + "." + "PublicSigningKeyUrl", StringUtils.FromString(publicRequest.DeviceOptions.PublicSigningKeyUrl));
                    }
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetNativeApplicationOidcOptions())
                {
                    if(publicRequest.NativeApplicationOidcOptions.IsSetAuthorizationEndpoint())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "AuthorizationEndpoint", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.AuthorizationEndpoint));
                    }
                    if(publicRequest.NativeApplicationOidcOptions.IsSetClientId())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "ClientId", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.ClientId));
                    }
                    if(publicRequest.NativeApplicationOidcOptions.IsSetClientSecret())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "ClientSecret", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.ClientSecret));
                    }
                    if(publicRequest.NativeApplicationOidcOptions.IsSetIssuer())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "Issuer", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.Issuer));
                    }
                    if(publicRequest.NativeApplicationOidcOptions.IsSetPublicSigningKeyEndpoint())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "PublicSigningKeyEndpoint", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.PublicSigningKeyEndpoint));
                    }
                    if(publicRequest.NativeApplicationOidcOptions.IsSetScope())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "Scope", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.Scope));
                    }
                    if(publicRequest.NativeApplicationOidcOptions.IsSetTokenEndpoint())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "TokenEndpoint", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.TokenEndpoint));
                    }
                    if(publicRequest.NativeApplicationOidcOptions.IsSetUserInfoEndpoint())
                    {
                        request.Parameters.Add("NativeApplicationOidcOptions" + "." + "UserInfoEndpoint", StringUtils.FromString(publicRequest.NativeApplicationOidcOptions.UserInfoEndpoint));
                    }
                }
                if(publicRequest.IsSetOidcOptions())
                {
                    if(publicRequest.OidcOptions.IsSetAuthorizationEndpoint())
                    {
                        request.Parameters.Add("OidcOptions" + "." + "AuthorizationEndpoint", StringUtils.FromString(publicRequest.OidcOptions.AuthorizationEndpoint));
                    }
                    if(publicRequest.OidcOptions.IsSetClientId())
                    {
                        request.Parameters.Add("OidcOptions" + "." + "ClientId", StringUtils.FromString(publicRequest.OidcOptions.ClientId));
                    }
                    if(publicRequest.OidcOptions.IsSetClientSecret())
                    {
                        request.Parameters.Add("OidcOptions" + "." + "ClientSecret", StringUtils.FromString(publicRequest.OidcOptions.ClientSecret));
                    }
                    if(publicRequest.OidcOptions.IsSetIssuer())
                    {
                        request.Parameters.Add("OidcOptions" + "." + "Issuer", StringUtils.FromString(publicRequest.OidcOptions.Issuer));
                    }
                    if(publicRequest.OidcOptions.IsSetScope())
                    {
                        request.Parameters.Add("OidcOptions" + "." + "Scope", StringUtils.FromString(publicRequest.OidcOptions.Scope));
                    }
                    if(publicRequest.OidcOptions.IsSetTokenEndpoint())
                    {
                        request.Parameters.Add("OidcOptions" + "." + "TokenEndpoint", StringUtils.FromString(publicRequest.OidcOptions.TokenEndpoint));
                    }
                    if(publicRequest.OidcOptions.IsSetUserInfoEndpoint())
                    {
                        request.Parameters.Add("OidcOptions" + "." + "UserInfoEndpoint", StringUtils.FromString(publicRequest.OidcOptions.UserInfoEndpoint));
                    }
                }
                if(publicRequest.IsSetSseSpecification())
                {
                    if(publicRequest.SseSpecification.IsSetCustomerManagedKeyEnabled())
                    {
                        request.Parameters.Add("SseSpecification" + "." + "CustomerManagedKeyEnabled", StringUtils.FromBool(publicRequest.SseSpecification.CustomerManagedKeyEnabled));
                    }
                    if(publicRequest.SseSpecification.IsSetKmsKeyArn())
                    {
                        request.Parameters.Add("SseSpecification" + "." + "KmsKeyArn", StringUtils.FromString(publicRequest.SseSpecification.KmsKeyArn));
                    }
                }
                if(publicRequest.IsSetVerifiedAccessTrustProviderId())
                {
                    request.Parameters.Add("VerifiedAccessTrustProviderId", StringUtils.FromString(publicRequest.VerifiedAccessTrustProviderId));
                }
            }
            return request;
        }
                    private static ModifyVerifiedAccessTrustProviderRequestMarshaller _instance = new ModifyVerifiedAccessTrustProviderRequestMarshaller();        

        internal static ModifyVerifiedAccessTrustProviderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVerifiedAccessTrustProviderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}