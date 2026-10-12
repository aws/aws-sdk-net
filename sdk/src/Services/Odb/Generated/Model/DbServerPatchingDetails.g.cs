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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and system updates
    /// take place during the maintenance window.
    /// </summary>
    public partial class DbServerPatchingDetails
    {
        /// <summary>
        /// Gets and sets the property EstimatedPatchDuration. 
        /// <para>
        /// Estimated time, in minutes, to patch one database server.
        /// </para>
        /// </summary>
        public int? EstimatedPatchDuration { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedPatchDuration property is set.
        /// </summary>
        internal bool IsSetEstimatedPatchDuration() => this.EstimatedPatchDuration.HasValue;

        /// <summary>
        /// Gets and sets the property PatchingStatus. 
        /// <para>
        /// The status of the patching operation. Possible values are <c>SCHEDULED</c>, <c>MAINTENANCE_IN_PROGRESS</c>,
        /// <c>FAILED</c>, and <c>COMPLETE</c>.
        /// </para>
        /// </summary>
        public DbServerPatchingStatus PatchingStatus { get; set; }

        /// <summary>
        /// Checks to see if the PatchingStatus property is set.
        /// </summary>
        internal bool IsSetPatchingStatus() => this.PatchingStatus != null;

        /// <summary>
        /// Gets and sets the property TimePatchingEnded. 
        /// <para>
        /// The time when the patching operation ended.
        /// </para>
        /// </summary>
        public string TimePatchingEnded { get; set; }

        /// <summary>
        /// Checks to see if the TimePatchingEnded property is set.
        /// </summary>
        internal bool IsSetTimePatchingEnded() => this.TimePatchingEnded != null;

        /// <summary>
        /// Gets and sets the property TimePatchingStarted. 
        /// <para>
        /// The time when the patching operation started.
        /// </para>
        /// </summary>
        public string TimePatchingStarted { get; set; }

        /// <summary>
        /// Checks to see if the TimePatchingStarted property is set.
        /// </summary>
        internal bool IsSetTimePatchingStarted() => this.TimePatchingStarted != null;
    }
}
