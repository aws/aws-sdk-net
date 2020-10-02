/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.S3;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The container element for an ownership control rule
    /// </summary>
    public class OwnershipControlsRule
    {
        private ObjectOwnership objectOwnership;

        /// <summary>
        /// The object ownership for a bucket's ownership controls
        /// </summary>
        public ObjectOwnership ObjectOwnership
        {
            get { return this.objectOwnership; }
            set { this.objectOwnership = value; }
        }

        /// <summary>
        /// Checks whether the ObjectOwnership property is set
        /// </summary>
        /// <returns>True if the ObjectOwnership property is set</returns>
        internal bool IsSetObjectOwnership()
        {
            return this.objectOwnership != null;
        }
    }
}
