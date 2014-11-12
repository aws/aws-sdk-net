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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Returns information about the DeleteLifecycleHookResult response and response metadata.
    /// </summary>
    public class DeleteLifecycleHookResponse : AmazonWebServiceResponse
    {
        private DeleteLifecycleHookResult _deleteLifecycleHookResult;

        /// <summary>
        /// Gets and sets the DeleteLifecycleHookResult property.
        /// Represents the output of a DeleteLifecycleHook operation.
        /// </summary>
        public DeleteLifecycleHookResult DeleteLifecycleHookResult
        {
            get
            {
                if(this._deleteLifecycleHookResult == null)
                {
                    this._deleteLifecycleHookResult = new DeleteLifecycleHookResult();
                }
                return this._deleteLifecycleHookResult;
            }
            set { this._deleteLifecycleHookResult = value; }
        }
    }
}