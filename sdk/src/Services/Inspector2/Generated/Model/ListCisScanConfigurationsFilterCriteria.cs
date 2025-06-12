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
    /// A list of CIS scan configurations filter criteria.
    /// </summary>
    public partial class ListCisScanConfigurationsFilterCriteria
    {
        private List<CisStringFilter> _scanConfigurationArnFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisStringFilter> _scanNameFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<TagFilter> _targetResourceTagFilters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

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