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

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Specifies the maintenance schedule for a DB instance or cluster, defining when maintenance
    /// operations such as patching can be performed.
    /// </summary>
    public partial class MaintenanceSchedule
    {
        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The preferred maintenance window in the format ddd:HH:MM-ddd:HH:MM (UTC). Day must
        /// be one of: Mon, Tue, Wed, Thu, Fri, Sat, Sun. For example, Sun:02:00-Sun:06:00. Provide
        /// an empty string to let the system choose a window.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 19)]
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The IANA timezone identifier for the maintenance window. Format: Region/City or UTC.
        /// For example, America/New_York or UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;
    }
}
