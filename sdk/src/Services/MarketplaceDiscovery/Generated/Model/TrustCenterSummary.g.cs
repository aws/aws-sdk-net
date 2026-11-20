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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A summary of trust center information associated with a listing.
    /// </summary>
    public partial class TrustCenterSummary
    {
        /// <summary>
        /// Gets and sets the property CertificationSummaries. 
        /// <para>
        /// A subset of certifications associated with the listing, selected by importance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public List<TrustCenterCertificationSummary> CertificationSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<TrustCenterCertificationSummary>() : null;

        /// <summary>
        /// Checks to see if the CertificationSummaries property is set.
        /// </summary>
        internal bool IsSetCertificationSummaries() => this.CertificationSummaries != null && (this.CertificationSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceSummaries. 
        /// <para>
        /// Trust center source summaries associated with the listing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<TrustCenterSourceSummary> SourceSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<TrustCenterSourceSummary>() : null;

        /// <summary>
        /// Checks to see if the SourceSummaries property is set.
        /// </summary>
        internal bool IsSetSourceSummaries() => this.SourceSummaries != null && (this.SourceSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalCertificationCount. 
        /// <para>
        /// The total number of distinct certifications associated with the listing, including
        /// certifications omitted from <c>certificationSummaries</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? TotalCertificationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCertificationCount property is set.
        /// </summary>
        internal bool IsSetTotalCertificationCount() => this.TotalCertificationCount.HasValue;
    }
}
