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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS scan result details filter criteria.
    /// </summary>
    public partial class CisScanResultDetailsFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property CheckIdFilters. 
        /// <para>
        /// The criteria's check ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> CheckIdFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CheckIdFilters property is set.
        /// </summary>
        internal bool IsSetCheckIdFilters() => this.CheckIdFilters != null && (this.CheckIdFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingArnFilters. 
        /// <para>
        /// The criteria's finding ARN filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> FindingArnFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingArnFilters property is set.
        /// </summary>
        internal bool IsSetFindingArnFilters() => this.FindingArnFilters != null && (this.FindingArnFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingStatusFilters. 
        /// <para>
        /// The criteria's finding status filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisFindingStatusFilter> FindingStatusFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisFindingStatusFilter>() : null;

        /// <summary>
        /// Checks to see if the FindingStatusFilters property is set.
        /// </summary>
        internal bool IsSetFindingStatusFilters() => this.FindingStatusFilters != null && (this.FindingStatusFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityLevelFilters. 
        /// <para>
        ///  The criteria's security level filters. . Security level refers to the Benchmark levels
        /// that CIS assigns to a profile. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisSecurityLevelFilter> SecurityLevelFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisSecurityLevelFilter>() : null;

        /// <summary>
        /// Checks to see if the SecurityLevelFilters property is set.
        /// </summary>
        internal bool IsSetSecurityLevelFilters() => this.SecurityLevelFilters != null && (this.SecurityLevelFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TitleFilters. 
        /// <para>
        /// The criteria's title filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> TitleFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the TitleFilters property is set.
        /// </summary>
        internal bool IsSetTitleFilters() => this.TitleFilters != null && (this.TitleFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
