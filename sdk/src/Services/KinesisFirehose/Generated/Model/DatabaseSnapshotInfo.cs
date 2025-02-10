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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The structure that describes the snapshot information of a table in source database
    /// endpoint that Firehose reads. 
    /// 
    ///  
    /// <para>
    /// Amazon Data Firehose is in preview release and is subject to change.
    /// </para>
    /// </summary>
    public partial class DatabaseSnapshotInfo
    {
        private FailureDescription _failureDescription;
        private string _id;
        private SnapshotRequestedBy _requestedBy;
        private DateTime? _requestTimestamp;
        private SnapshotStatus _status;
        private string _table;

        /// <summary>
        /// Gets and sets the property FailureDescription.
        /// </summary>
        public FailureDescription FailureDescription
        {
            get { return this._failureDescription; }
            set { this._failureDescription = value; }
        }

        // Check to see if FailureDescription property is set
        internal bool IsSetFailureDescription()
        {
            return this._failureDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the current snapshot of the table in source database endpoint.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        ///  The principal that sent the request to take the current snapshot on the table. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotRequestedBy RequestedBy
        {
            get { return this._requestedBy; }
            set { this._requestedBy = value; }
        }

        // Check to see if RequestedBy property is set
        internal bool IsSetRequestedBy()
        {
            return this._requestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RequestTimestamp. 
        /// <para>
        ///  The timestamp when the current snapshot is taken on the table. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? RequestTimestamp
        {
            get { return this._requestTimestamp; }
            set { this._requestTimestamp = value; }
        }

        // Check to see if RequestTimestamp property is set
        internal bool IsSetRequestTimestamp()
        {
            return this._requestTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the current snapshot of the table. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotStatus Status
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
        /// Gets and sets the property Table. 
        /// <para>
        ///  The fully qualified name of the table in source database endpoint that Firehose reads.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=129)]
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}