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
    /// Returns information about the ListMFADevicesResult response and response metadata.
    /// </summary>
    public class ListMFADevicesResponse : AmazonWebServiceResponse
    {
        private ListMFADevicesResult _listMFADevicesResult;

        /// <summary>
        /// Gets and sets the ListMFADevicesResult property.
        /// Represents the output of a ListMFADevices operation.
        /// </summary>
        public ListMFADevicesResult ListMFADevicesResult
        {
            get
            {
                if(this._listMFADevicesResult == null)
                {
                    this._listMFADevicesResult = new ListMFADevicesResult();
                }
                return this._listMFADevicesResult;
            }
            set { this._listMFADevicesResult = value; }
        }
    }
}