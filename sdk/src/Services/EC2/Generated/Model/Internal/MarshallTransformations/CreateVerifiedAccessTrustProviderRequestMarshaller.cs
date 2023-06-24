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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVerifiedAccessTrustProvider Request Marshaller
    /// </summary>       
    public class CreateVerifiedAccessTrustProviderRequestMarshaller : IMarshaller<IRequest, CreateVerifiedAccessTrustProviderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVerifiedAccessTrustProviderRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVerifiedAccessTrustProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateVerifiedAccessTrustProvider");
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
                    if(publicRequest.DeviceOptions.IsSetTenantId())
                    {
                        request.Parameters.Add("DeviceOptions" + "." + "TenantId", StringUtils.FromString(publicRequest.DeviceOptions.TenantId));
                    }
                }
                if(publicRequest.IsSetDeviceTrustProviderType())
                {
                    request.Parameters.Add("DeviceTrustProviderType", StringUtils.FromString(publicRequest.DeviceTrustProviderType));
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
                if(publicRequest.IsSetPolicyReferenceName())
                {
                    request.Parameters.Add("PolicyReferenceName", StringUtils.FromString(publicRequest.PolicyReferenceName));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTrustProviderType())
                {
                    request.Parameters.Add("TrustProviderType", StringUtils.FromString(publicRequest.TrustProviderType));
                }
                if(publicRequest.IsSetUserTrustProviderType())
                {
                    request.Parameters.Add("UserTrustProviderType", StringUtils.FromString(publicRequest.UserTrustProviderType));
                }
            }
            return request;
        }
                    private static CreateVerifiedAccessTrustProviderRequestMarshaller _instance = new CreateVerifiedAccessTrustProviderRequestMarshaller();        

        internal static CreateVerifiedAccessTrustProviderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVerifiedAccessTrustProviderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}