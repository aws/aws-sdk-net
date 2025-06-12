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
    /// A list of CIS scans filter criteria.
    /// </summary>
    public partial class ListCisScansFilterCriteria
    {
        private List<CisNumberFilter> _failedChecksFilters = AWSConfigs.InitializeCollections ? new List<CisNumberFilter>() : null;
        private List<CisStringFilter> _scanArnFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisDateFilter> _scanAtFilters = AWSConfigs.InitializeCollections ? new List<CisDateFilter>() : null;
        private List<CisStringFilter> _scanConfigurationArnFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisStringFilter> _scanNameFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisScanStatusFilter> _scanStatusFilters = AWSConfigs.InitializeCollections ? new List<CisScanStatusFilter>() : null;
        private List<CisStringFilter> _scheduledByFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisStringFilter> _targetAccountIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisStringFilter> _targetResourceIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<TagFilter> _targetResourceTagFilters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

        /// <summary>
        /// Gets and sets the property FailedChecksFilters. 
        /// <para>
        /// The list of failed checks filters.
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
        /// Gets and sets the property ScanArnFilters. 
        /// <para>
        /// The list of scan ARN filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> ScanArnFilters
        {
            get { return this._scanArnFilters; }
            set { this._scanArnFilters = value; }
        }

        // Check to see if ScanArnFilters property is set
        internal bool IsSetScanArnFilters()
        {
            return this._scanArnFilters != null && (this._scanArnFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanAtFilters. 
        /// <para>
        /// The list of scan at filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<CisDateFilter> ScanAtFilters
        {
            get { return this._scanAtFilters; }
            set { this._scanAtFilters = value; }
        }

        // Check to see if ScanAtFilters property is set
        internal bool IsSetScanAtFilters()
        {
            return this._scanAtFilters != null && (this._scanAtFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanConfigurationArnFilters. 
        /// <para>
        /// The list of scan configuration ARN filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> ScanConfigurationArnFilters
        {
            get { return this._scanConfigurationArnFilters; }
            set { this._scanConfigurationArnFilters = value; }
        }

        // Check to see if ScanConfigurationArnFilters property is set
        internal bool IsSetScanConfigurationArnFilters()
        {
            return this._scanConfigurationArnFilters != null && (this._scanConfigurationArnFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanNameFilters. 
        /// <para>
        /// The list of scan name filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> ScanNameFilters
        {
            get { return this._scanNameFilters; }
            set { this._scanNameFilters = value; }
        }

        // Check to see if ScanNameFilters property is set
        internal bool IsSetScanNameFilters()
        {
            return this._scanNameFilters != null && (this._scanNameFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanStatusFilters. 
        /// <para>
        /// The list of scan status filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisScanStatusFilter> ScanStatusFilters
        {
            get { return this._scanStatusFilters; }
            set { this._scanStatusFilters = value; }
        }

        // Check to see if ScanStatusFilters property is set
        internal bool IsSetScanStatusFilters()
        {
            return this._scanStatusFilters != null && (this._scanStatusFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduledByFilters. 
        /// <para>
        /// The list of scheduled by filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> ScheduledByFilters
        {
            get { return this._scheduledByFilters; }
            set { this._scheduledByFilters = value; }
        }

        // Check to see if ScheduledByFilters property is set
        internal bool IsSetScheduledByFilters()
        {
            return this._scheduledByFilters != null && (this._scheduledByFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetAccountIdFilters. 
        /// <para>
        /// The list of target account ID filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> TargetAccountIdFilters
        {
            get { return this._targetAccountIdFilters; }
            set { this._targetAccountIdFilters = value; }
        }

        // Check to see if TargetAccountIdFilters property is set
        internal bool IsSetTargetAccountIdFilters()
        {
            return this._targetAccountIdFilters != null && (this._targetAccountIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetResourceIdFilters. 
        /// <para>
        /// The list of target resource ID filters.
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
        /// The list of target resource tag filters.
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

    }
}