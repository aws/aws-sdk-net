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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
        private List<CisStringFilter> _accountIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisStringFilter> _checkIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisNumberFilter> _failedChecksFilters = AWSConfigs.InitializeCollections ? new List<CisNumberFilter>() : null;
        private List<CisStringFilter> _platformFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisResultStatusFilter> _statusFilters = AWSConfigs.InitializeCollections ? new List<CisResultStatusFilter>() : null;
        private List<CisStringFilter> _targetResourceIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<TagFilter> _targetResourceTagFilters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;
        private List<CisTargetStatusFilter> _targetStatusFilters = AWSConfigs.InitializeCollections ? new List<CisTargetStatusFilter>() : null;
        private List<CisTargetStatusReasonFilter> _targetStatusReasonFilters = AWSConfigs.InitializeCollections ? new List<CisTargetStatusReasonFilter>() : null;

        /// <summary>
        /// Gets and sets the property AccountIdFilters. 
        /// <para>
        /// The criteria's account ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> AccountIdFilters
        {
            get { return this._accountIdFilters; }
            set { this._accountIdFilters = value; }
        }

        // Check to see if AccountIdFilters property is set
        internal bool IsSetAccountIdFilters()
        {
            return this._accountIdFilters != null && (this._accountIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CheckIdFilters. 
        /// <para>
        /// The criteria's check ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> CheckIdFilters
        {
            get { return this._checkIdFilters; }
            set { this._checkIdFilters = value; }
        }

        // Check to see if CheckIdFilters property is set
        internal bool IsSetCheckIdFilters()
        {
            return this._checkIdFilters != null && (this._checkIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedChecksFilters. 
        /// <para>
        /// The criteria's failed checks filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisNumberFilter> FailedChecksFilters
        {
            get { return this._failedChecksFilters; }
            set { this._failedChecksFilters = value; }
        }

        // Check to see if FailedChecksFilters property is set
        internal bool IsSetFailedChecksFilters()
        {
            return this._failedChecksFilters != null && (this._failedChecksFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformFilters. 
        /// <para>
        /// The criteria's platform filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> PlatformFilters
        {
            get { return this._platformFilters; }
            set { this._platformFilters = value; }
        }

        // Check to see if PlatformFilters property is set
        internal bool IsSetPlatformFilters()
        {
            return this._platformFilters != null && (this._platformFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatusFilters. 
        /// <para>
        /// The criteria's status filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisResultStatusFilter> StatusFilters
        {
            get { return this._statusFilters; }
            set { this._statusFilters = value; }
        }

        // Check to see if StatusFilters property is set
        internal bool IsSetStatusFilters()
        {
            return this._statusFilters != null && (this._statusFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetResourceIdFilters. 
        /// <para>
        /// The criteria's target resource ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> TargetResourceIdFilters
        {
            get { return this._targetResourceIdFilters; }
            set { this._targetResourceIdFilters = value; }
        }

        // Check to see if TargetResourceIdFilters property is set
        internal bool IsSetTargetResourceIdFilters()
        {
            return this._targetResourceIdFilters != null && (this._targetResourceIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetResourceTagFilters. 
        /// <para>
        /// The criteria's target resource tag filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<TagFilter> TargetResourceTagFilters
        {
            get { return this._targetResourceTagFilters; }
            set { this._targetResourceTagFilters = value; }
        }

        // Check to see if TargetResourceTagFilters property is set
        internal bool IsSetTargetResourceTagFilters()
        {
            return this._targetResourceTagFilters != null && (this._targetResourceTagFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetStatusFilters. 
        /// <para>
        /// The criteria's target status filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisTargetStatusFilter> TargetStatusFilters
        {
            get { return this._targetStatusFilters; }
            set { this._targetStatusFilters = value; }
        }

        // Check to see if TargetStatusFilters property is set
        internal bool IsSetTargetStatusFilters()
        {
            return this._targetStatusFilters != null && (this._targetStatusFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetStatusReasonFilters. 
        /// <para>
        /// The criteria's target status reason filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisTargetStatusReasonFilter> TargetStatusReasonFilters
        {
            get { return this._targetStatusReasonFilters; }
            set { this._targetStatusReasonFilters = value; }
        }

        // Check to see if TargetStatusReasonFilters property is set
        internal bool IsSetTargetStatusReasonFilters()
        {
            return this._targetStatusReasonFilters != null && (this._targetStatusReasonFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}