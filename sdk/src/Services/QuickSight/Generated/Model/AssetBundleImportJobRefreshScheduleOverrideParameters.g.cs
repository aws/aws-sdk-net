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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A list of overrides for a specific <c>RefreshsSchedule</c> resource that is present
    /// in the asset bundle that is imported.
    /// </summary>
    public partial class AssetBundleImportJobRefreshScheduleOverrideParameters
    {
        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// A partial identifier for the specific <c>RefreshSchedule</c> resource that is being
        /// overridden. This structure is used together with the <c>ScheduleID</c> structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// A partial identifier for the specific <c>RefreshSchedule</c> resource being overridden.
        /// This structure is used together with the <c>DataSetId</c> structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleId property is set.
        /// </summary>
        internal bool IsSetScheduleId() => this.ScheduleId != null;

        /// <summary>
        /// Gets and sets the property StartAfterDateTime. 
        /// <para>
        /// An override for the <c>StartAfterDateTime</c> of a <c>RefreshSchedule</c>. Make sure
        /// that the <c>StartAfterDateTime</c> is set to a time that takes place in the future.
        /// </para>
        /// </summary>
        public DateTime? StartAfterDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartAfterDateTime property is set.
        /// </summary>
        internal bool IsSetStartAfterDateTime() => this.StartAfterDateTime.HasValue;
    }
}
