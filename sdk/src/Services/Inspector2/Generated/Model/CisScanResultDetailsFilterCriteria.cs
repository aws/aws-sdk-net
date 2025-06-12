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
    /// The CIS scan result details filter criteria.
    /// </summary>
    public partial class CisScanResultDetailsFilterCriteria
    {
        private List<CisStringFilter> _checkIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisStringFilter> _findingArnFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisFindingStatusFilter> _findingStatusFilters = AWSConfigs.InitializeCollections ? new List<CisFindingStatusFilter>() : null;
        private List<CisSecurityLevelFilter> _securityLevelFilters = AWSConfigs.InitializeCollections ? new List<CisSecurityLevelFilter>() : null;
        private List<CisStringFilter> _titleFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

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
        /// Gets and sets the property FindingArnFilters. 
        /// <para>
        /// The criteria's finding ARN filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> FindingArnFilters
        {
            get { return this._findingArnFilters; }
            set { this._findingArnFilters = value; }
        }

        // Check to see if FindingArnFilters property is set
        internal bool IsSetFindingArnFilters()
        {
            return this._findingArnFilters != null && (this._findingArnFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingStatusFilters. 
        /// <para>
        /// The criteria's finding status filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisFindingStatusFilter> FindingStatusFilters
        {
            get { return this._findingStatusFilters; }
            set { this._findingStatusFilters = value; }
        }

        // Check to see if FindingStatusFilters property is set
        internal bool IsSetFindingStatusFilters()
        {
            return this._findingStatusFilters != null && (this._findingStatusFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityLevelFilters. 
        /// <para>
        ///  The criteria's security level filters. . Security level refers to the Benchmark levels
        /// that CIS assigns to a profile. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisSecurityLevelFilter> SecurityLevelFilters
        {
            get { return this._securityLevelFilters; }
            set { this._securityLevelFilters = value; }
        }

        // Check to see if SecurityLevelFilters property is set
        internal bool IsSetSecurityLevelFilters()
        {
            return this._securityLevelFilters != null && (this._securityLevelFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TitleFilters. 
        /// <para>
        /// The criteria's title filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisStringFilter> TitleFilters
        {
            get { return this._titleFilters; }
            set { this._titleFilters = value; }
        }

        // Check to see if TitleFilters property is set
        internal bool IsSetTitleFilters()
        {
            return this._titleFilters != null && (this._titleFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}