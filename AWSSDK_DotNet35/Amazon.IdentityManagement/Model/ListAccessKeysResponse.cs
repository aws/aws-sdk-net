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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Configuration for accessing Amazon ListAccessKeys service
    /// </summary>
    public partial class ListAccessKeysResponse : ListAccessKeysResult
    {
        /// <summary>
        /// Gets and sets the ListAccessKeysResult property.
        /// Represents the output of a ListAccessKeys operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListAccessKeysResult class are now available on the ListAccessKeysResponse class. You should use the properties on ListAccessKeysResponse instead of accessing them through ListAccessKeysResult.")]
        public ListAccessKeysResult ListAccessKeysResult
        {
            get
            {
                return this;
            }
        }
    }
}