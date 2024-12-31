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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Task object encapsulating task information.
    /// </summary>
    public partial class Task
    {
        private int? _progressPercent;
        private Status _status;
        private string _statusDetail;

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// Indication of the percentage completion of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? ProgressPercent
        {
            get { return this._progressPercent; }
            set { this._progressPercent = value; }
        }

        // Check to see if ProgressPercent property is set
        internal bool IsSetProgressPercent()
        {
            return this._progressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the task - Not Started, In-Progress, Complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
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
        /// Gets and sets the property StatusDetail. 
        /// <para>
        /// Details of task status as notified by a migration tool. A tool might use this field
        /// to provide clarifying information about the status that is unique to that tool or
        /// that explains an error state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2500)]
        public string StatusDetail
        {
            get { return this._statusDetail; }
            set { this._statusDetail = value; }
        }

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this._statusDetail != null;
        }

    }
}