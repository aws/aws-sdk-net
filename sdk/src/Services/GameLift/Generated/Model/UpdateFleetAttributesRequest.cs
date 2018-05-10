/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFleetAttributes operation.
    /// Updates fleet properties, including name and description, for a fleet. To update metadata,
    /// specify the fleet ID and the property values that you want to change. If successful,
    /// the fleet ID for the updated fleet is returned.
    /// 
    ///  
    /// <para>
    /// Fleet-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Describe fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetUtilization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeRuntimeConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetEvents</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Update fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRuntimeConfiguration</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Manage fleet actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class UpdateFleetAttributesRequest : AmazonGameLiftRequest
    {
        private string _description;
        private string _fleetId;
        private List<string> _metricGroups = new List<string>();
        private string _name;
        private ProtectionPolicy _newGameSessionProtectionPolicy;
        private ResourceCreationLimitPolicy _resourceCreationLimitPolicy;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description of a fleet.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet to update attribute metadata for.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// Names of metric groups to include this fleet in. Amazon CloudWatch uses a fleet metric
        /// group is to aggregate metrics from multiple fleets. Use an existing metric group name
        /// to add this fleet to the group. Or use a new name to create a new metric group. A
        /// fleet can only be included in one metric group at a time.
        /// </para>
        /// </summary>
        public List<string> MetricGroups
        {
            get { return this._metricGroups; }
            set { this._metricGroups = value; }
        }

        // Check to see if MetricGroups property is set
        internal bool IsSetMetricGroups()
        {
            return this._metricGroups != null && this._metricGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label that is associated with a fleet. Fleet names do not need to be unique.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NewGameSessionProtectionPolicy. 
        /// <para>
        /// Game session protection policy to apply to all new instances created in this fleet.
        /// Instances that already exist are not affected. You can set protection for individual
        /// instances using <a>UpdateGameSession</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> -- The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> -- If the game session is in an <code>ACTIVE</code> status,
        /// it cannot be terminated during a scale-down event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProtectionPolicy NewGameSessionProtectionPolicy
        {
            get { return this._newGameSessionProtectionPolicy; }
            set { this._newGameSessionProtectionPolicy = value; }
        }

        // Check to see if NewGameSessionProtectionPolicy property is set
        internal bool IsSetNewGameSessionProtectionPolicy()
        {
            return this._newGameSessionProtectionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCreationLimitPolicy. 
        /// <para>
        /// Policy that limits the number of game sessions an individual player can create over
        /// a span of time. 
        /// </para>
        /// </summary>
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy
        {
            get { return this._resourceCreationLimitPolicy; }
            set { this._resourceCreationLimitPolicy = value; }
        }

        // Check to see if ResourceCreationLimitPolicy property is set
        internal bool IsSetResourceCreationLimitPolicy()
        {
            return this._resourceCreationLimitPolicy != null;
        }

    }
}