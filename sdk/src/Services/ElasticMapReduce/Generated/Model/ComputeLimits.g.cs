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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property MaximumCapacityUnits. 
        /// <para>
        ///  The upper boundary of Amazon EC2 units. It is measured through vCPU cores or instances
        /// for instance groups and measured through units for instance fleets. Managed scaling
        /// activities are not allowed beyond this boundary. The limit only applies to the core
        /// and task nodes. The master node cannot be scaled after initial configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaximumCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaximumCapacityUnits property is set.
        /// </summary>
        internal bool IsSetMaximumCapacityUnits() => this.MaximumCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumCoreCapacityUnits. 
        /// <para>
        ///  The upper boundary of Amazon EC2 units for core node type in a cluster. It is measured
        /// through vCPU cores or instances for instance groups and measured through units for
        /// instance fleets. The core units are not allowed to scale beyond this boundary. The
        /// parameter is used to split capacity allocation between core and task nodes. 
        /// </para>
        /// </summary>
        public int? MaximumCoreCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaximumCoreCapacityUnits property is set.
        /// </summary>
        internal bool IsSetMaximumCoreCapacityUnits() => this.MaximumCoreCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumOnDemandCapacityUnits. 
        /// <para>
        ///  The upper boundary of On-Demand Amazon EC2 units. It is measured through vCPU cores
        /// or instances for instance groups and measured through units for instance fleets. The
        /// On-Demand units are not allowed to scale beyond this boundary. The parameter is used
        /// to split capacity allocation between On-Demand and Spot Instances. 
        /// </para>
        /// </summary>
        public int? MaximumOnDemandCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaximumOnDemandCapacityUnits property is set.
        /// </summary>
        internal bool IsSetMaximumOnDemandCapacityUnits() => this.MaximumOnDemandCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumCapacityUnits. 
        /// <para>
        ///  The lower boundary of Amazon EC2 units. It is measured through vCPU cores or instances
        /// for instance groups and measured through units for instance fleets. Managed scaling
        /// activities are not allowed beyond this boundary. The limit only applies to the core
        /// and task nodes. The master node cannot be scaled after initial configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinimumCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the MinimumCapacityUnits property is set.
        /// </summary>
        internal bool IsSetMinimumCapacityUnits() => this.MinimumCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property UnitType. 
        /// <para>
        ///  The unit type used for specifying a managed scaling policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeLimitsUnitType UnitType { get; set; }

        /// <summary>
        /// Checks to see if the UnitType property is set.
        /// </summary>
        internal bool IsSetUnitType() => this.UnitType != null;
    }
}
