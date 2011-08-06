/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Transform;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.SecurityToken
{
    /// <summary>
    /// Implemenation for accessing AmazonSecurityTokenService.
    ///  
    /// 
    /// </summary>
    public class AmazonSecurityTokenServiceClient : AmazonWebServiceClient, AmazonSecurityTokenService
    {
    
    
        AbstractAWSSigner signer = new QueryStringSigner();

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// </summary>
         /// 
         /// <param name="getSessionTokenRequest">Container for the necessary parameters to execute the GetSessionToken service method on
         ///           AmazonSecurityTokenService.</param>
         /// 
         /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
         /// 
        public GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest getSessionTokenRequest) 
        {           
            IRequest<GetSessionTokenRequest> request = new GetSessionTokenRequestMarshaller().Marshall(getSessionTokenRequest);
            GetSessionTokenResponse response = Invoke<GetSessionTokenRequest, GetSessionTokenResponse> (request, this.signer, GetSessionTokenResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// </summary>
         /// 
         /// <param name="getFederationTokenRequest">Container for the necessary parameters to execute the GetFederationToken service method on
         ///           AmazonSecurityTokenService.</param>
         /// 
         /// <returns>The response from the GetFederationToken service method, as returned by AmazonSecurityTokenService.</returns>
         /// 
         /// <exception cref="PackedPolicyTooLargeException"/>
         /// <exception cref="MalformedPolicyDocumentException"/>
        public GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest getFederationTokenRequest) 
        {           
            IRequest<GetFederationTokenRequest> request = new GetFederationTokenRequestMarshaller().Marshall(getFederationTokenRequest);
            GetFederationTokenResponse response = Invoke<GetFederationTokenRequest, GetFederationTokenResponse> (request, this.signer, GetFederationTokenResponseUnmarshaller.GetInstance());
            return response;
        }
    
    }
}   
    
