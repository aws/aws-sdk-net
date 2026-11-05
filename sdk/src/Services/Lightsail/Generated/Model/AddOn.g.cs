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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an add-on that is enabled for an Amazon Lightsail resource.
    /// </summary>
    public partial class AddOn
    {
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
        public string Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the add-on.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextSnapshotTimeOfDay. 
        /// <para>
        /// The next daily time an automatic snapshot will be created.
        /// </para>
        ///  
        /// <para>
        /// The time shown is in <c>HH:00</c> format, and in Coordinated Universal Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// The snapshot is automatically created between the time shown and up to 45 minutes
        /// after.
        /// </para>
        /// </summary>
        public string NextSnapshotTimeOfDay { get; set; }

        /// <summary>
        /// Checks to see if the NextSnapshotTimeOfDay property is set.
        /// </summary>
        internal bool IsSetNextSnapshotTimeOfDay() => this.NextSnapshotTimeOfDay != null;

        /// <summary>
        /// Gets and sets the property SnapshotTimeOfDay. 
        /// <para>
        /// The daily time when an automatic snapshot is created.
        /// </para>
        ///  
        /// <para>
        /// The time shown is in <c>HH:00</c> format, and in Coordinated Universal Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// The snapshot is automatically created between the time shown and up to 45 minutes
        /// after.
        /// </para>
        /// </summary>
        public string SnapshotTimeOfDay { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotTimeOfDay property is set.
        /// </summary>
        internal bool IsSetSnapshotTimeOfDay() => this.SnapshotTimeOfDay != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the add-on.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        public string Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold != null;
    }
}
