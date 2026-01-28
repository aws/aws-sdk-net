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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about a test case execution record.
    /// </summary>
    public partial class ExecutionRecord
    {
        private string _observationId;
        private string _record;
        private ExecutionRecordStatus _status;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ObservationId. 
        /// <para>
        /// The identifier of the execution record.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ObservationId
        {
            get { return this._observationId; }
            set { this._observationId = value; }
        }

        // Check to see if ObservationId property is set
        internal bool IsSetObservationId()
        {
            return this._observationId != null;
        }

        /// <summary>
        /// Gets and sets the property Record. 
        /// <para>
        /// The details of the executed record.
        /// </para>
        /// </summary>
        public string Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action execution.
        /// </para>
        /// </summary>
        public ExecutionRecordStatus Status
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
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp when the action was executed.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}