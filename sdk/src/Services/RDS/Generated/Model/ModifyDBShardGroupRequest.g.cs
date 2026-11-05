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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBShardGroup operation. Modifies the settings
    /// of an Aurora Limitless Database DB shard group. You can change one or more settings
    /// by specifying these parameters and the new values in the request.
    /// </summary>
    public partial class ModifyDBShardGroupRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeRedundancy. 
        /// <para>
        /// Specifies whether to create standby DB shard groups for the DB shard group. Valid
        /// values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0 - Creates a DB shard group without a standby DB shard group. This is the default
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1 - Creates a DB shard group with a standby DB shard group in a different Availability
        /// Zone (AZ).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2 - Creates a DB shard group with two standby DB shard groups in two different AZs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? ComputeRedundancy { get; set; }

        /// <summary>
        /// Checks to see if the ComputeRedundancy property is set.
        /// </summary>
        internal bool IsSetComputeRedundancy() => this.ComputeRedundancy.HasValue;

        /// <summary>
        /// Gets and sets the property DBShardGroupIdentifier. 
        /// <para>
        /// The name of the DB shard group to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DBShardGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBShardGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetDBShardGroupIdentifier() => this.DBShardGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxACU. 
        /// <para>
        /// The maximum capacity of the DB shard group in Aurora capacity units (ACUs).
        /// </para>
        /// </summary>
        public double? MaxACU { get; set; }

        /// <summary>
        /// Checks to see if the MaxACU property is set.
        /// </summary>
        internal bool IsSetMaxACU() => this.MaxACU.HasValue;

        /// <summary>
        /// Gets and sets the property MinACU. 
        /// <para>
        /// The minimum capacity of the DB shard group in Aurora capacity units (ACUs).
        /// </para>
        /// </summary>
        public double? MinACU { get; set; }

        /// <summary>
        /// Checks to see if the MinACU property is set.
        /// </summary>
        internal bool IsSetMinACU() => this.MinACU.HasValue;
    }
}
