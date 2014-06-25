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
    /// Returns information about the GetIdentityDkimAttributesResult response and response metadata.
    /// </summary>
    public class GetIdentityDkimAttributesResponse : AmazonWebServiceResponse
    {
        private GetIdentityDkimAttributesResult _getIdentityDkimAttributesResult;

        /// <summary>
        /// Gets and sets the GetIdentityDkimAttributesResult property.
        /// Represents the output of a GetIdentityDkimAttributes operation.
        /// </summary>
        public GetIdentityDkimAttributesResult GetIdentityDkimAttributesResult
        {
            get
            {
                if(this._getIdentityDkimAttributesResult == null)
                {
                    this._getIdentityDkimAttributesResult = new GetIdentityDkimAttributesResult();
                }
                return this._getIdentityDkimAttributesResult;
            }
            set { this._getIdentityDkimAttributesResult = value; }
        }
    }
}