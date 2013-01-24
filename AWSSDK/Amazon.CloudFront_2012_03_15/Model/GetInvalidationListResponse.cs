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
    /// The GetInvalidationListResponse contains the list of invalidations done on a particular distribution
    /// and any headers returned by CloudFront.
    /// </summary>
    public class GetInvalidationListResponse : CloudFrontResponse
    {
        private string marker;
        private string nextMarker;
        private int maxItems;
        private bool isTruncated;
        private List<InvalidationSummary> summaries;

        /// <summary>
        /// Gets and Sets the Marker property.
        /// </summary>
        public string Marker
        {
            get
            {
                return this.marker;
            }
            set
            {
                this.marker = value;
            }
        }

        /// <summary>
        /// Gets and Sets the NextMarker property.  If IsTruncated is true, this element is present and
        /// contains the value you can use for the Marker
        /// request parameter to continue listing your
        /// invalidations where they left off.
        /// </summary>
        public string NextMarker
        {
            get
            {
                return this.nextMarker;
            }
            set
            {
                this.nextMarker = value;
            }
        }

        /// <summary>
        /// Gets and Sets the MaxItems property.
        /// </summary>
        public int MaxItems
        {
            get
            {
                return this.maxItems;
            }
            set
            {
                this.maxItems = value;
            }
        }

        /// <summary>
        /// Gets and Sets the IsTruncated property which indicated whether all the data was returned from Cloudfront.
        /// If the value is true the NextMarker property can be used on another request to get the next page of data.
        /// </summary>
        public bool IsTruncated
        {
            get
            {
                return this.isTruncated;
            }
            set
            {
                this.isTruncated = value;
            }
        }

        /// <summary>
        /// Gets and Sets the Summaries property.
        /// </summary>
        public List<InvalidationSummary> Summaries
        {
            get
            {
                return this.summaries;
            }
            set
            {
                this.summaries = value;
            }
        }
    }
}
