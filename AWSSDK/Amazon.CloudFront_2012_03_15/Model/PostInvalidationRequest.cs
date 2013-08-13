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
    /// The PostInvalidationRequest contains the parameters used for the PostInvalidation operation.
    /// <br />Required Parameter: DistributionId, InvalidationBatch.CallerReference
    /// </summary>
    public class PostInvalidationRequest : BaseRequest
    {
        private string distributionId;
        private InvalidationBatch invalidationBatch;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PostInvalidationRequest()
        {
        }

        /// <summary>
        /// Constructs and instance of PostInvalidationRequest with an InvalidationBatch which will be 
        /// set to the InvalidationBatch property.
        /// </summary>
        /// <param name="invalidationBatch">The InvalidationBatch property that will be set to the InvalidationBatch property.</param>
        public PostInvalidationRequest(InvalidationBatch invalidationBatch)
        {
            this.invalidationBatch = invalidationBatch;
        }

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
        public PostInvalidationRequest WithDistribtionId(string distributionId)
        {
            this.distributionId = distributionId;
            return this;
        }
        #endregion

        #region InvalidationBatch
        /// <summary>
        /// Gets and Sets the InvalidationBatch which contains the list of objects to invalidated.
        /// </summary>
        public InvalidationBatch InvalidationBatch
        {
            get
            {
                if (this.invalidationBatch == null)
                {
                    this.invalidationBatch = new InvalidationBatch();
                }

                return this.invalidationBatch;
            }
            set
            {
                this.invalidationBatch = value;
            }
        }

        /// <summary>
        /// Sets the InvalidationBatch property of this request to the value passed in.
        /// </summary>
        /// <param name="invalidationBatch">An InvalidationBatch object that lists all the paths of objects to be invalidated.</param>
        /// <returns>The request with the InvalidationBatch property set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PostInvalidationRequest WithInvalidationBatch(InvalidationBatch invalidationBatch)
        {
            this.invalidationBatch = invalidationBatch;
            return this;
        }
        #endregion
    }
}
