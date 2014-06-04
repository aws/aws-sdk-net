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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Returns information about the GetFederationTokenResult response and response metadata.
    /// </summary>
    public class GetFederationTokenResponse : AmazonWebServiceResponse
    {
        private GetFederationTokenResult _getFederationTokenResult;

        /// <summary>
        /// Gets and sets the GetFederationTokenResult property.
        /// Represents the output of a GetFederationToken operation.
        /// </summary>
        public GetFederationTokenResult GetFederationTokenResult
        {
            get
            {
                if(this._getFederationTokenResult == null)
                {
                    this._getFederationTokenResult = new GetFederationTokenResult();
                }
                return this._getFederationTokenResult;
            }
            set { this._getFederationTokenResult = value; }
        }
    }
}