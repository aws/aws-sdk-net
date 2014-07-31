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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DisableDomainTransferLock service
    /// </summary>
    public partial class DisableDomainTransferLockResponse : DisableDomainTransferLockResult
    {
        /// <summary>
        /// Gets and sets the DisableDomainTransferLockResult property.
        /// Represents the output of a DisableDomainTransferLock operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DisableDomainTransferLockResult class are now available on the DisableDomainTransferLockResponse class. You should use the properties on DisableDomainTransferLockResponse instead of accessing them through DisableDomainTransferLockResult.")]
        public DisableDomainTransferLockResult DisableDomainTransferLockResult
        {
            get
            {
                return this;
            }
        }
    }
}