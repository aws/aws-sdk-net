/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Returns information about the  AssumeRoleWithWebIdentityResult response and response metadata.
    /// </summary>
    public class AssumeRoleWithWebIdentityResponse : AmazonWebServiceResponse
    {
        private AssumeRoleWithWebIdentityResult assumeRoleWithWebIdentityResult;

        /// <summary>
        /// Gets and sets the AssumeRoleWithWebIdentityResult property.
        /// Contains the result of a successful invocation of the AssumeRoleWithWebIdentity action, including temporary AWS credentials that can be used
        /// to make AWS requests.
        /// </summary>
        public AssumeRoleWithWebIdentityResult AssumeRoleWithWebIdentityResult
        {
            get
            {
                if(this.assumeRoleWithWebIdentityResult == null)
                {
                    this.assumeRoleWithWebIdentityResult = new AssumeRoleWithWebIdentityResult();
                }

                return this.assumeRoleWithWebIdentityResult;
            }
            set { this.assumeRoleWithWebIdentityResult = value; }
        }
    }
}
    
