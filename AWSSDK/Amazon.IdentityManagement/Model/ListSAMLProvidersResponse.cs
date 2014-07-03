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
    /// Returns information about the ListSAMLProvidersResult response and response metadata.
    /// </summary>
    public class ListSAMLProvidersResponse : AmazonWebServiceResponse
    {
        private ListSAMLProvidersResult _listSAMLProvidersResult;

        /// <summary>
        /// Gets and sets the ListSAMLProvidersResult property.
        /// Represents the output of a ListSAMLProviders operation.
        /// </summary>
        public ListSAMLProvidersResult ListSAMLProvidersResult
        {
            get
            {
                if(this._listSAMLProvidersResult == null)
                {
                    this._listSAMLProvidersResult = new ListSAMLProvidersResult();
                }
                return this._listSAMLProvidersResult;
            }
            set { this._listSAMLProvidersResult = value; }
        }
    }
}