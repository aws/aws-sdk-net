/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentity;
using Amazon.IdentityManagement;

namespace Amazon.Extensions.CognitoAuthentication.IntegrationTests
{
    /// <summary>
    /// Base class to be used for authentication integrations tests
    /// Allows for child classes to create, sign up, or confirm users
    /// </summary>
    public partial class BaseAuthenticationTestClass : IDisposable
    {
        protected RegionEndpoint clientRegion = FallbackRegionFactory.GetRegionEndpoint();
        
        public AmazonCognitoIdentityProviderClient GetAmazonCognitoIdentityProviderClient()
        {
            return  new AmazonCognitoIdentityProviderClient();
        }    
        
        public AmazonCognitoIdentityClient GetAmazonCognitoIdentityClient()
        {
            return new AmazonCognitoIdentityClient();
        }
        
        public AmazonIdentityManagementServiceClient GetAmazonIdentityManagementServiceClient()
        {
            return new AmazonIdentityManagementServiceClient();
        }
    
    }
}
