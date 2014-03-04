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
    /// The GetInvalidationListRequest contains the parameters used for the GetInvalidationList operation.
    /// <br />Required Parameter: DistributionId
    /// </summary>
    public class GetInvalidationListRequest : BaseRequest
    {
        private string reqMarker;
        private int reqMaxItems;
        private string distributionId;

        #region Marker

        /// <summary>
        /// Gets and sets the Marker property.
        /// All keys returned will be lexiographically after the marker.
        /// </summary>
        public string Marker
        {
            get { return this.reqMarker; }
            set { this.reqMarker = value; }
        }

        /// <summary>
        /// Sets the Marker property for this request.
        /// All keys returned will be lexiographically after the marker.
        /// </summary>
        /// <param name="marker">the value that Marker is set to</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetInvalidationListRequest WithMarker(string marker)
        {
            this.reqMarker = marker;
            return this;
        }

        #endregion

        #region MaxItems

        /// <summary>
        /// Gets and sets the MaxItems property.
        /// Limits the result set of keys to MaxItems.
        /// </summary>
        public int MaxItems
        {
            get { return this.reqMaxItems; }
            set { this.reqMaxItems = value; }
        }

        /// <summary>
        /// Sets the MaxItems property for this request.
        /// Limits the result set of keys to MaxItems.
        /// </summary>
        /// <param name="maxItems">the value that MaxItems is set to</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetInvalidationListRequest WithMaxItems(int maxItems)
        {
            this.reqMaxItems = maxItems;
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
        public GetInvalidationListRequest WithDistributionId(string distributionId)
        {
            this.distributionId = distributionId;
            return this;
        }
        #endregion

    }
}
