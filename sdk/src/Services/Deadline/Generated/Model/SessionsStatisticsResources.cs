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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Specifies the fleet IDs or queue IDs to return statistics. You can specify only fleet
    /// IDs or queue IDS, not both.
    /// </summary>
    public partial class SessionsStatisticsResources
    {
        private List<string> _fleetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _queueIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// One to 10 fleet IDs that specify the fleets to return statistics for. If you specify
        /// the <c>fleetIds</c> field, you can't specify the <c>queueIds</c> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> FleetIds
        {
            get { return this._fleetIds; }
            set { this._fleetIds = value; }
        }

        // Check to see if FleetIds property is set
        internal bool IsSetFleetIds()
        {
            return this._fleetIds != null && (this._fleetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueIds. 
        /// <para>
        /// One to 10 queue IDs that specify the queues to return statistics for. If you specify
        /// the <c>queueIds</c> field, you can't specify the <c>fleetIds</c> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> QueueIds
        {
            get { return this._queueIds; }
            set { this._queueIds = value; }
        }

        // Check to see if QueueIds property is set
        internal bool IsSetQueueIds()
        {
            return this._queueIds != null && (this._queueIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}