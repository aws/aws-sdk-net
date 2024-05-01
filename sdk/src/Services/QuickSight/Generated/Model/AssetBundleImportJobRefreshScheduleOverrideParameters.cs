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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _dataSetId;
        private string _scheduleId;
        private DateTime? _startAfterDateTime;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// A partial identifier for the specific <c>RefreshSchedule</c> resource that is being
        /// overridden. This structure is used together with the <c>ScheduleID</c> structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// A partial identifier for the specific <c>RefreshSchedule</c> resource being overridden.
        /// This structure is used together with the <c>DataSetId</c> structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }

        // Check to see if ScheduleId property is set
        internal bool IsSetScheduleId()
        {
            return this._scheduleId != null;
        }

        /// <summary>
        /// Gets and sets the property StartAfterDateTime. 
        /// <para>
        /// An override for the <c>StartAfterDateTime</c> of a <c>RefreshSchedule</c>. Make sure
        /// that the <c>StartAfterDateTime</c> is set to a time that takes place in the future.
        /// </para>
        /// </summary>
        public DateTime? StartAfterDateTime
        {
            get { return this._startAfterDateTime; }
            set { this._startAfterDateTime = value; }
        }

        // Check to see if StartAfterDateTime property is set
        internal bool IsSetStartAfterDateTime()
        {
            return this._startAfterDateTime.HasValue; 
        }

    }
}