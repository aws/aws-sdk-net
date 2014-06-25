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

using System;
using Amazon.Runtime;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Returns information about the GetIdentityVerificationAttributesResult response and response metadata.
    /// </summary>
    public class GetIdentityVerificationAttributesResponse : AmazonWebServiceResponse
    {
        private GetIdentityVerificationAttributesResult _getIdentityVerificationAttributesResult;

        /// <summary>
        /// Gets and sets the GetIdentityVerificationAttributesResult property.
        /// Represents the output of a GetIdentityVerificationAttributes operation.
        /// </summary>
        public GetIdentityVerificationAttributesResult GetIdentityVerificationAttributesResult
        {
            get
            {
                if(this._getIdentityVerificationAttributesResult == null)
                {
                    this._getIdentityVerificationAttributesResult = new GetIdentityVerificationAttributesResult();
                }
                return this._getIdentityVerificationAttributesResult;
            }
            set { this._getIdentityVerificationAttributesResult = value; }
        }
    }
}