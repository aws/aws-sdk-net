/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The GetInvalidationRequest contains the parameters used for the GetInvalidation operation.
    /// <br />Required Parameter: DistributionId, InvalidationId
    /// </summary>
    public class GetInvalidationRequest : BaseRequest
    {
        private string invalidationId;
        private string distributionId;

        #region InvalidationId
        /// <summary>
        /// Gets and Sets the InvalidationId property for the invalidation
        /// </summary>
        public string InvalidationId
        {
            get
            {
                return this.invalidationId;
            }
            set
            {
                this.invalidationId = value;
            }
        }

        /// <summary>
        /// Sets the InvalidationId property of this request to the value passed in.
        /// </summary>
        /// <param name="invalidationId">The invalidation's id</param>
        /// <returns>The request with the InvalidationId property set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetInvalidationRequest WithInvalidationId(string invalidationId)
        {
            this.invalidationId = invalidationId;
            return this;
        }
        #endregion

        #region DistributionId

        /// <summary>
        /// Gets and Sets the DistributionId property for the Distribution
        /// </summary>
        public string DistributionId
        {
            get
            {
                return this.distributionId;
            }
            set
            {
                this.distributionId = value;
            }
        }

        /// <summary>
        /// Sets the DistributionId property of this request to the value passed in.
        /// </summary>
        /// <param name="distributionId">The distribution's id</param>
        /// <returns>The request with the DistributionId property set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetInvalidationRequest WithDistributionId(string distributionId)
        {
            this.distributionId = distributionId;
            return this;
        }

        /// <summary>
        /// Sets the DistributionId property of this request to the value passed in.
        /// </summary>
        /// <param name="distributionId">The distribution's id</param>
        /// <returns>The request with the DistributionId property set</returns>
        [Obsolete("This method will be removed in a future release, clients should use WithDistributionId")]
        public GetInvalidationRequest WithDistribtionId(string distributionId)
        {
            return WithDistributionId(distributionId);
        }
        #endregion
    }
}
