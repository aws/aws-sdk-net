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

/*
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A review summary from a specific source, including the average rating and total review
    /// count.
    /// </summary>
    public partial class ReviewSourceSummary
    {
        private string _averageRating;
        private ReviewSourceId _sourceId;
        private string _sourceName;
        private string _sourceUrl;
        private long? _totalReviews;

        /// <summary>
        /// Gets and sets the property AverageRating. 
        /// <para>
        /// The average rating across all reviews from this source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string AverageRating
        {
            get { return this._averageRating; }
            set { this._averageRating = value; }
        }

        // Check to see if AverageRating property is set
        internal bool IsSetAverageRating()
        {
            return this._averageRating != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The machine-readable identifier of the review source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReviewSourceId SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the review source, such as AWS Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// The URL where the reviews can be accessed at the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceUrl
        {
            get { return this._sourceUrl; }
            set { this._sourceUrl = value; }
        }

        // Check to see if SourceUrl property is set
        internal bool IsSetSourceUrl()
        {
            return this._sourceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TotalReviews. 
        /// <para>
        /// The total number of reviews available from this source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? TotalReviews
        {
            get { return this._totalReviews; }
            set { this._totalReviews = value; }
        }

        // Check to see if TotalReviews property is set
        internal bool IsSetTotalReviews()
        {
            return this._totalReviews.HasValue; 
        }

    }
}