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

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Interface for accessing AmazonSecurityTokenService.
    ///  
    ///  
    /// </summary>
    public interface AmazonSecurityTokenService : IDisposable
    {
        

         /// <summary>
         /// </summary>
         /// 
         /// <param name="getSessionTokenRequest">Container for the necessary parameters to execute the GetSessionToken service method on
         ///           AmazonSecurityTokenService.</param>
         /// 
         /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
         /// 
        GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest getSessionTokenRequest); 

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
        GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest getFederationTokenRequest); 
    }
}
    
