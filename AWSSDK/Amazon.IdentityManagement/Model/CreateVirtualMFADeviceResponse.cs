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
    /// Returns information about the CreateVirtualMFADeviceResult response and response metadata.
    /// </summary>
    public class CreateVirtualMFADeviceResponse : AmazonWebServiceResponse
    {
        private CreateVirtualMFADeviceResult _createVirtualMFADeviceResult;

        /// <summary>
        /// Gets and sets the CreateVirtualMFADeviceResult property.
        /// Represents the output of a CreateVirtualMFADevice operation.
        /// </summary>
        public CreateVirtualMFADeviceResult CreateVirtualMFADeviceResult
        {
            get
            {
                if(this._createVirtualMFADeviceResult == null)
                {
                    this._createVirtualMFADeviceResult = new CreateVirtualMFADeviceResult();
                }
                return this._createVirtualMFADeviceResult;
            }
            set { this._createVirtualMFADeviceResult = value; }
        }
    }
}