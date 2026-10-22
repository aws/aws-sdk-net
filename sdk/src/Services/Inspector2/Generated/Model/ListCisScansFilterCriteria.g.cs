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
    /// A list of CIS scans filter criteria.
    /// </summary>
    public partial class ListCisScansFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property FailedChecksFilters. 
        /// <para>
        /// The list of failed checks filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisNumberFilter> FailedChecksFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisNumberFilter>() : null;

        /// <summary>
        /// Checks to see if the FailedChecksFilters property is set.
        /// </summary>
        internal bool IsSetFailedChecksFilters() => this.FailedChecksFilters != null && (this.FailedChecksFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanArnFilters. 
        /// <para>
        /// The list of scan ARN filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> ScanArnFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanArnFilters property is set.
        /// </summary>
        internal bool IsSetScanArnFilters() => this.ScanArnFilters != null && (this.ScanArnFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanAtFilters. 
        /// <para>
        /// The list of scan at filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<CisDateFilter> ScanAtFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisDateFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanAtFilters property is set.
        /// </summary>
        internal bool IsSetScanAtFilters() => this.ScanAtFilters != null && (this.ScanAtFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanConfigurationArnFilters. 
        /// <para>
        /// The list of scan configuration ARN filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> ScanConfigurationArnFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanConfigurationArnFilters property is set.
        /// </summary>
        internal bool IsSetScanConfigurationArnFilters() => this.ScanConfigurationArnFilters != null && (this.ScanConfigurationArnFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanNameFilters. 
        /// <para>
        /// The list of scan name filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> ScanNameFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanNameFilters property is set.
        /// </summary>
        internal bool IsSetScanNameFilters() => this.ScanNameFilters != null && (this.ScanNameFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanStatusFilters. 
        /// <para>
        /// The list of scan status filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisScanStatusFilter> ScanStatusFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisScanStatusFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanStatusFilters property is set.
        /// </summary>
        internal bool IsSetScanStatusFilters() => this.ScanStatusFilters != null && (this.ScanStatusFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduledByFilters. 
        /// <para>
        /// The list of scheduled by filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> ScheduledByFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScheduledByFilters property is set.
        /// </summary>
        internal bool IsSetScheduledByFilters() => this.ScheduledByFilters != null && (this.ScheduledByFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetAccountIdFilters. 
        /// <para>
        /// The list of target account ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> TargetAccountIdFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the TargetAccountIdFilters property is set.
        /// </summary>
        internal bool IsSetTargetAccountIdFilters() => this.TargetAccountIdFilters != null && (this.TargetAccountIdFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetResourceIdFilters. 
        /// <para>
        /// The list of target resource ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> TargetResourceIdFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the TargetResourceIdFilters property is set.
        /// </summary>
        internal bool IsSetTargetResourceIdFilters() => this.TargetResourceIdFilters != null && (this.TargetResourceIdFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetResourceTagFilters. 
        /// <para>
        /// The list of target resource tag filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<TagFilter> TargetResourceTagFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

        /// <summary>
        /// Checks to see if the TargetResourceTagFilters property is set.
        /// </summary>
        internal bool IsSetTargetResourceTagFilters() => this.TargetResourceTagFilters != null && (this.TargetResourceTagFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
