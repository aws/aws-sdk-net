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
    /// The scan results aggregated by target resource filter criteria.
    /// </summary>
    public partial class CisScanResultsAggregatedByTargetResourceFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property AccountIdFilters. 
        /// <para>
        /// The criteria's account ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> AccountIdFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the AccountIdFilters property is set.
        /// </summary>
        internal bool IsSetAccountIdFilters() => this.AccountIdFilters != null && (this.AccountIdFilters.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property FailedChecksFilters. 
        /// <para>
        /// The criteria's failed checks filters.
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
        /// Gets and sets the property PlatformFilters. 
        /// <para>
        /// The criteria's platform filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisStringFilter> PlatformFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

        /// <summary>
        /// Checks to see if the PlatformFilters property is set.
        /// </summary>
        internal bool IsSetPlatformFilters() => this.PlatformFilters != null && (this.PlatformFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatusFilters. 
        /// <para>
        /// The criteria's status filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisResultStatusFilter> StatusFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisResultStatusFilter>() : null;

        /// <summary>
        /// Checks to see if the StatusFilters property is set.
        /// </summary>
        internal bool IsSetStatusFilters() => this.StatusFilters != null && (this.StatusFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetResourceIdFilters. 
        /// <para>
        /// The criteria's target resource ID filters.
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
        /// The criteria's target resource tag filters.
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

        /// <summary>
        /// Gets and sets the property TargetStatusFilters. 
        /// <para>
        /// The criteria's target status filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisTargetStatusFilter> TargetStatusFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisTargetStatusFilter>() : null;

        /// <summary>
        /// Checks to see if the TargetStatusFilters property is set.
        /// </summary>
        internal bool IsSetTargetStatusFilters() => this.TargetStatusFilters != null && (this.TargetStatusFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetStatusReasonFilters. 
        /// <para>
        /// The criteria's target status reason filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CisTargetStatusReasonFilter> TargetStatusReasonFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CisTargetStatusReasonFilter>() : null;

        /// <summary>
        /// Checks to see if the TargetStatusReasonFilters property is set.
        /// </summary>
        internal bool IsSetTargetStatusReasonFilters() => this.TargetStatusReasonFilters != null && (this.TargetStatusReasonFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
