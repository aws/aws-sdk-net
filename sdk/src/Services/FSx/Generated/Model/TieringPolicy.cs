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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes the data tiering policy for an ONTAP volume. When enabled, Amazon FSx for
    /// ONTAP's intelligent tiering automatically transitions a volume's data between the
    /// file system's primary storage and capacity pool storage based on your access patterns.
    /// 
    ///  
    /// <para>
    /// Valid tiering policies are the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>SNAPSHOT_ONLY</c> - (Default value) moves cold snapshots to the capacity pool
    /// storage tier.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>AUTO</c> - moves cold user data and snapshots to the capacity pool storage tier
    /// based on your access patterns.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>ALL</c> - moves all user data blocks in both the active file system and Snapshot
    /// copies to the storage pool tier.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>NONE</c> - keeps a volume's data in the primary storage tier, preventing it from
    /// being moved to the capacity pool tier.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TieringPolicy
    {
        private int? _coolingPeriod;
        private TieringPolicyName _name;

        /// <summary>
        /// Gets and sets the property CoolingPeriod. 
        /// <para>
        /// Specifies the number of days that user data in a volume must remain inactive before
        /// it is considered "cold" and moved to the capacity pool. Used with the <c>AUTO</c>
        /// and <c>SNAPSHOT_ONLY</c> tiering policies. Enter a whole number between 2 and 183.
        /// Default values are 31 days for <c>AUTO</c> and 2 days for <c>SNAPSHOT_ONLY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=183)]
        public int? CoolingPeriod
        {
            get { return this._coolingPeriod; }
            set { this._coolingPeriod = value; }
        }

        // Check to see if CoolingPeriod property is set
        internal bool IsSetCoolingPeriod()
        {
            return this._coolingPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the tiering policy used to transition data. Default value is <c>SNAPSHOT_ONLY</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SNAPSHOT_ONLY</c> - moves cold snapshots to the capacity pool storage tier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO</c> - moves cold user data and snapshots to the capacity pool storage tier
        /// based on your access patterns.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - moves all user data blocks in both the active file system and Snapshot
        /// copies to the storage pool tier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> - keeps a volume's data in the primary storage tier, preventing it from
        /// being moved to the capacity pool tier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TieringPolicyName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}