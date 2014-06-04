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
    /// Returns information about the DecodeAuthorizationMessageResult response and response metadata.
    /// </summary>
    public class DecodeAuthorizationMessageResponse : AmazonWebServiceResponse
    {
        private DecodeAuthorizationMessageResult _decodeAuthorizationMessageResult;

        /// <summary>
        /// Gets and sets the DecodeAuthorizationMessageResult property.
        /// Represents the output of a DecodeAuthorizationMessage operation.
        /// </summary>
        public DecodeAuthorizationMessageResult DecodeAuthorizationMessageResult
        {
            get
            {
                if(this._decodeAuthorizationMessageResult == null)
                {
                    this._decodeAuthorizationMessageResult = new DecodeAuthorizationMessageResult();
                }
                return this._decodeAuthorizationMessageResult;
            }
            set { this._decodeAuthorizationMessageResult = value; }
        }
    }
}