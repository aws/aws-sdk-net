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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Returns information about the CreateGroupResult response and response metadata.
    /// </summary>
    public class CreateGroupResponse : AmazonWebServiceResponse
    {
        private CreateGroupResult _createGroupResult;

        /// <summary>
        /// Gets and sets the CreateGroupResult property.
        /// Represents the output of a CreateGroup operation.
        /// </summary>
        public CreateGroupResult CreateGroupResult
        {
            get
            {
                if(this._createGroupResult == null)
                {
                    this._createGroupResult = new CreateGroupResult();
                }
                return this._createGroupResult;
            }
            set { this._createGroupResult = value; }
        }
    }
}