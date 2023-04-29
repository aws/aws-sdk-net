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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an add-on that is enabled for an Amazon Lightsail resource.
    /// </summary>
    public partial class AddOn
    {
        private string _duration;
        private string _name;
        private string _nextSnapshotTimeOfDay;
        private string _snapshotTimeOfDay;
        private string _status;
        private string _threshold;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The amount of idle time in minutes after which your virtual computer will automatically
        /// stop.
        /// </para>
        ///  <important> 
        /// <para>
        /// This add-on only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the add-on.
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
        /// Gets and sets the property NextSnapshotTimeOfDay. 
        /// <para>
        /// The next daily time an automatic snapshot will be created.
        /// </para>
        ///  
        /// <para>
        /// The time shown is in <code>HH:00</code> format, and in Coordinated Universal Time
        /// (UTC).
        /// </para>
        ///  
        /// <para>
        /// The snapshot is automatically created between the time shown and up to 45 minutes
        /// after.
        /// </para>
        /// </summary>
        public string NextSnapshotTimeOfDay
        {
            get { return this._nextSnapshotTimeOfDay; }
            set { this._nextSnapshotTimeOfDay = value; }
        }

        // Check to see if NextSnapshotTimeOfDay property is set
        internal bool IsSetNextSnapshotTimeOfDay()
        {
            return this._nextSnapshotTimeOfDay != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotTimeOfDay. 
        /// <para>
        /// The daily time when an automatic snapshot is created.
        /// </para>
        ///  
        /// <para>
        /// The time shown is in <code>HH:00</code> format, and in Coordinated Universal Time
        /// (UTC).
        /// </para>
        ///  
        /// <para>
        /// The snapshot is automatically created between the time shown and up to 45 minutes
        /// after.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the add-on.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The trigger threshold of the action.
        /// </para>
        ///  <important> 
        /// <para>
        /// This add-on only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// </summary>
        public string Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold != null;
        }

    }
}