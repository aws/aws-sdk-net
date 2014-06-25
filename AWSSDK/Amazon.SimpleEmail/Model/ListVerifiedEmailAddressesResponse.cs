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
    /// Returns information about the ListVerifiedEmailAddressesResult response and response metadata.
    /// </summary>
    public class ListVerifiedEmailAddressesResponse : AmazonWebServiceResponse
    {
        private ListVerifiedEmailAddressesResult _listVerifiedEmailAddressesResult;

        /// <summary>
        /// Gets and sets the ListVerifiedEmailAddressesResult property.
        /// Represents the output of a ListVerifiedEmailAddresses operation.
        /// </summary>
        public ListVerifiedEmailAddressesResult ListVerifiedEmailAddressesResult
        {
            get
            {
                if(this._listVerifiedEmailAddressesResult == null)
                {
                    this._listVerifiedEmailAddressesResult = new ListVerifiedEmailAddressesResult();
                }
                return this._listVerifiedEmailAddressesResult;
            }
            set { this._listVerifiedEmailAddressesResult = value; }
        }
    }
}