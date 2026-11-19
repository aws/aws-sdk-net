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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the data that GuardDuty received in response to a request during an investigation.
    /// The members that are set depend on the <c>FetchType</c> of the record.
    /// </summary>
    public partial class FetchResult
    {
        /// <summary>
        /// Gets and sets the property Documentation. 
        /// <para>
        /// The documentation for the finding type that GuardDuty retrieved.
        /// </para>
        /// </summary>
        public FindingTypeDocumentation Documentation { get; set; }

        /// <summary>
        /// Checks to see if the Documentation property is set.
        /// </summary>
        internal bool IsSetDocumentation() => this.Documentation != null;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// The configuration of the detector features that GuardDuty retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<InvestigationDetectorFeatureConfiguration> Features { get; set; } = AWSConfigs.InitializeCollections ? new List<InvestigationDetectorFeatureConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null && (this.Features.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ItemIds. 
        /// <para>
        /// The identifiers of the items that were returned, such as finding IDs, event IDs, signal
        /// IDs, or account IDs, depending on <c>FetchType</c>. The list contains at most 50 identifiers;
        /// <c>TotalCount</c> can be larger.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> ItemIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ItemIds property is set.
        /// </summary>
        internal bool IsSetItemIds() => this.ItemIds != null && (this.ItemIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of items that were returned. This value can be greater than the number
        /// of identifiers in <c>ItemIds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;

        /// <summary>
        /// Gets and sets the property Verdict. 
        /// <para>
        /// The reputation verdict for the threat indicator. Possible values are <c>THREAT</c>,
        /// <c>BENIGN</c>, and <c>NEUTRAL</c>. If the lookup returned more than one result, the
        /// verdict describes the first result.
        /// </para>
        /// </summary>
        public FetchVerdict Verdict { get; set; }

        /// <summary>
        /// Checks to see if the Verdict property is set.
        /// </summary>
        internal bool IsSetVerdict() => this.Verdict != null;
    }
}
