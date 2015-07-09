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

/*
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */

using System;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DeleteRepository service
    /// </summary>
    public partial class DeleteRepositoryResponse : DeleteRepositoryResult
    {
        /// <summary>
        /// Gets and sets the DeleteRepositoryResult property.
        /// Represents the output of a DeleteRepository operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DeleteRepositoryResult class are now available on the DeleteRepositoryResponse class. You should use the properties on DeleteRepositoryResponse instead of accessing them through DeleteRepositoryResult.")]
        public DeleteRepositoryResult DeleteRepositoryResult
        {
            get
            {
                return this;
            }
        }
    }
}