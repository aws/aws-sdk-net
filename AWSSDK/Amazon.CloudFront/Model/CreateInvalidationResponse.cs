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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Returns information about the CreateInvalidationResult response and response metadata.
    /// </summary>
    public class CreateInvalidationResponse : AmazonWebServiceResponse
    {
        private CreateInvalidationResult _createInvalidationResult;

        /// <summary>
        /// Gets and sets the CreateInvalidationResult property.
        /// Represents the output of a CreateInvalidation operation.
        /// </summary>
        public CreateInvalidationResult CreateInvalidationResult
        {
            get
            {
                if(this._createInvalidationResult == null)
                {
                    this._createInvalidationResult = new CreateInvalidationResult();
                }
                return this._createInvalidationResult;
            }
            set { this._createInvalidationResult = value; }
        }
    }
}