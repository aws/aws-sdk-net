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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
    /// Information about the coverage statistics for a resource.
    /// </summary>
    public partial class CoverageStatistics
    {
        private Dictionary<string, long> _countByCoverageStatus = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;
        private Dictionary<string, long> _countByResourceType = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Gets and sets the property CountByCoverageStatus. 
        /// <para>
        /// Represents coverage statistics for EKS clusters aggregated by coverage status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> CountByCoverageStatus
        {
            get { return this._countByCoverageStatus; }
            set { this._countByCoverageStatus = value; }
        }

        // Check to see if CountByCoverageStatus property is set
        internal bool IsSetCountByCoverageStatus()
        {
            return this._countByCoverageStatus != null && (this._countByCoverageStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CountByResourceType. 
        /// <para>
        /// Represents coverage statistics for EKS clusters aggregated by resource type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> CountByResourceType
        {
            get { return this._countByResourceType; }
            set { this._countByResourceType = value; }
        }

        // Check to see if CountByResourceType property is set
        internal bool IsSetCountByResourceType()
        {
            return this._countByResourceType != null && (this._countByResourceType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}