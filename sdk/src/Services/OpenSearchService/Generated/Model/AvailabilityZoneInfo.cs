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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Information about an Availability Zone on a domain.
    /// </summary>
    public partial class AvailabilityZoneInfo
    {
        private string _availabilityZoneName;
        private string _availableDataNodeCount;
        private string _configuredDataNodeCount;
        private string _totalShards;
        private string _totalUnAssignedShards;
        private ZoneStatus _zoneStatus;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. 
        /// <para>
        /// The name of the Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string AvailabilityZoneName
        {
            get { return this._availabilityZoneName; }
            set { this._availabilityZoneName = value; }
        }

        // Check to see if AvailabilityZoneName property is set
        internal bool IsSetAvailabilityZoneName()
        {
            return this._availabilityZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property AvailableDataNodeCount. 
        /// <para>
        /// The number of data nodes active in the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailableDataNodeCount
        {
            get { return this._availableDataNodeCount; }
            set { this._availableDataNodeCount = value; }
        }

        // Check to see if AvailableDataNodeCount property is set
        internal bool IsSetAvailableDataNodeCount()
        {
            return this._availableDataNodeCount != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredDataNodeCount. 
        /// <para>
        /// The total number of data nodes configured in the Availability Zone.
        /// </para>
        /// </summary>
        public string ConfiguredDataNodeCount
        {
            get { return this._configuredDataNodeCount; }
            set { this._configuredDataNodeCount = value; }
        }

        // Check to see if ConfiguredDataNodeCount property is set
        internal bool IsSetConfiguredDataNodeCount()
        {
            return this._configuredDataNodeCount != null;
        }

        /// <summary>
        /// Gets and sets the property TotalShards. 
        /// <para>
        /// The total number of primary and replica shards in the Availability Zone.
        /// </para>
        /// </summary>
        public string TotalShards
        {
            get { return this._totalShards; }
            set { this._totalShards = value; }
        }

        // Check to see if TotalShards property is set
        internal bool IsSetTotalShards()
        {
            return this._totalShards != null;
        }

        /// <summary>
        /// Gets and sets the property TotalUnAssignedShards. 
        /// <para>
        /// The total number of primary and replica shards that aren't allocated to any of the
        /// nodes in the Availability Zone.
        /// </para>
        /// </summary>
        public string TotalUnAssignedShards
        {
            get { return this._totalUnAssignedShards; }
            set { this._totalUnAssignedShards = value; }
        }

        // Check to see if TotalUnAssignedShards property is set
        internal bool IsSetTotalUnAssignedShards()
        {
            return this._totalUnAssignedShards != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneStatus. 
        /// <para>
        /// The current state of the Availability Zone. Current options are <c>Active</c> and
        /// <c>StandBy</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c> - Data nodes in the Availability Zone are in use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StandBy</c> - Data nodes in the Availability Zone are in a standby state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NotAvailable</c> - Unable to retrieve information.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ZoneStatus ZoneStatus
        {
            get { return this._zoneStatus; }
            set { this._zoneStatus = value; }
        }

        // Check to see if ZoneStatus property is set
        internal bool IsSetZoneStatus()
        {
            return this._zoneStatus != null;
        }

    }
}