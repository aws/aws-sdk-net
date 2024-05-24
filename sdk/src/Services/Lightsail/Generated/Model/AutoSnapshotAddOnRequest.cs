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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a request to enable or modify the automatic snapshot add-on for an Amazon
    /// Lightsail instance or disk.
    /// 
    ///  
    /// <para>
    /// When you modify the automatic snapshot time for a resource, it is typically effective
    /// immediately except under the following conditions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If an automatic snapshot has been created for the current day, and you change the
    /// snapshot time to a later time of day, then the new snapshot time will be effective
    /// the following day. This ensures that two snapshots are not created for the current
    /// day.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If an automatic snapshot has not yet been created for the current day, and you change
    /// the snapshot time to an earlier time of day, then the new snapshot time will be effective
    /// the following day and a snapshot is automatically created at the previously set time
    /// for the current day. This ensures that a snapshot is created for the current day.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If an automatic snapshot has not yet been created for the current day, and you change
    /// the snapshot time to a time that is within 30 minutes from your current time, then
    /// the new snapshot time will be effective the following day and a snapshot is automatically
    /// created at the previously set time for the current day. This ensures that a snapshot
    /// is created for the current day, because 30 minutes is required between your current
    /// time and the new snapshot time that you specify.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If an automatic snapshot is scheduled to be created within 30 minutes from your current
    /// time and you change the snapshot time, then the new snapshot time will be effective
    /// the following day and a snapshot is automatically created at the previously set time
    /// for the current day. This ensures that a snapshot is created for the current day,
    /// because 30 minutes is required between your current time and the new snapshot time
    /// that you specify.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AutoSnapshotAddOnRequest
    {
        private string _snapshotTimeOfDay;

        /// <summary>
        /// Gets and sets the property SnapshotTimeOfDay. 
        /// <para>
        /// The daily time when an automatic snapshot will be created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in <c>HH:00</c> format, and in an hourly increment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The snapshot will be automatically created between the time specified and up to 45
        /// minutes after.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SnapshotTimeOfDay
        {
            get { return this._snapshotTimeOfDay; }
            set { this._snapshotTimeOfDay = value; }
        }

        // Check to see if SnapshotTimeOfDay property is set
        internal bool IsSetSnapshotTimeOfDay()
        {
            return this._snapshotTimeOfDay != null;
        }

    }
}