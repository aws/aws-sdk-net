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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The Amazon EC2 unit limits for a managed scaling policy. The managed scaling activity
    /// of a cluster can not be above or below these limits. The limit only applies to the
    /// core and task nodes. The master node cannot be scaled after initial configuration.
    /// </summary>
    public partial class ComputeLimits
    {
        private int? _maximumCapacityUnits;
        private int? _maximumCoreCapacityUnits;
        private int? _maximumOnDemandCapacityUnits;
        private int? _minimumCapacityUnits;
        private ComputeLimitsUnitType _unitType;

        /// <summary>
        /// Gets and sets the property MaximumCapacityUnits. 
        /// <para>
        ///  The upper boundary of Amazon EC2 units. It is measured through vCPU cores or instances
        /// for instance groups and measured through units for instance fleets. Managed scaling
        /// activities are not allowed beyond this boundary. The limit only applies to the core
        /// and task nodes. The master node cannot be scaled after initial configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaximumCapacityUnits
        {
            get { return this._maximumCapacityUnits; }
            set { this._maximumCapacityUnits = value; }
        }

        // Check to see if MaximumCapacityUnits property is set
        internal bool IsSetMaximumCapacityUnits()
        {
            return this._maximumCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumCoreCapacityUnits. 
        /// <para>
        ///  The upper boundary of Amazon EC2 units for core node type in a cluster. It is measured
        /// through vCPU cores or instances for instance groups and measured through units for
        /// instance fleets. The core units are not allowed to scale beyond this boundary. The
        /// parameter is used to split capacity allocation between core and task nodes. 
        /// </para>
        /// </summary>
        public int? MaximumCoreCapacityUnits
        {
            get { return this._maximumCoreCapacityUnits; }
            set { this._maximumCoreCapacityUnits = value; }
        }

        // Check to see if MaximumCoreCapacityUnits property is set
        internal bool IsSetMaximumCoreCapacityUnits()
        {
            return this._maximumCoreCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumOnDemandCapacityUnits. 
        /// <para>
        ///  The upper boundary of On-Demand Amazon EC2 units. It is measured through vCPU cores
        /// or instances for instance groups and measured through units for instance fleets. The
        /// On-Demand units are not allowed to scale beyond this boundary. The parameter is used
        /// to split capacity allocation between On-Demand and Spot Instances. 
        /// </para>
        /// </summary>
        public int? MaximumOnDemandCapacityUnits
        {
            get { return this._maximumOnDemandCapacityUnits; }
            set { this._maximumOnDemandCapacityUnits = value; }
        }

        // Check to see if MaximumOnDemandCapacityUnits property is set
        internal bool IsSetMaximumOnDemandCapacityUnits()
        {
            return this._maximumOnDemandCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumCapacityUnits. 
        /// <para>
        ///  The lower boundary of Amazon EC2 units. It is measured through vCPU cores or instances
        /// for instance groups and measured through units for instance fleets. Managed scaling
        /// activities are not allowed beyond this boundary. The limit only applies to the core
        /// and task nodes. The master node cannot be scaled after initial configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinimumCapacityUnits
        {
            get { return this._minimumCapacityUnits; }
            set { this._minimumCapacityUnits = value; }
        }

        // Check to see if MinimumCapacityUnits property is set
        internal bool IsSetMinimumCapacityUnits()
        {
            return this._minimumCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnitType. 
        /// <para>
        ///  The unit type used for specifying a managed scaling policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeLimitsUnitType UnitType
        {
            get { return this._unitType; }
            set { this._unitType = value; }
        }

        // Check to see if UnitType property is set
        internal bool IsSetUnitType()
        {
            return this._unitType != null;
        }

    }
}