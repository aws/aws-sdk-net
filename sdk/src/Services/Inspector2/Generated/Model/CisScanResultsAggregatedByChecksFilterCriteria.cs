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
    /// The scan results aggregated by checks filter criteria.
    /// </summary>
    public partial class CisScanResultsAggregatedByChecksFilterCriteria
    {
        private List<CisStringFilter> _accountIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisStringFilter> _checkIdFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisNumberFilter> _failedResourcesFilters = AWSConfigs.InitializeCollections ? new List<CisNumberFilter>() : null;
        private List<CisStringFilter> _platformFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;
        private List<CisSecurityLevelFilter> _securityLevelFilters = AWSConfigs.InitializeCollections ? new List<CisSecurityLevelFilter>() : null;
        private List<CisStringFilter> _titleFilters = AWSConfigs.InitializeCollections ? new List<CisStringFilter>() : null;

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
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property FailedResourcesFilters. 
        /// <para>
        /// The criteria's failed resources filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CisNumberFilter> FailedResourcesFilters
        {
            get { return this._failedResourcesFilters; }
            set { this._failedResourcesFilters = value; }
        }

        // Check to see if FailedResourcesFilters property is set
        internal bool IsSetFailedResourcesFilters()
        {
            return this._failedResourcesFilters != null && (this._failedResourcesFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property SecurityLevelFilters. 
        /// <para>
        /// The criteria's security level filters.
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