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
        /// <summary>
        /// Gets and sets the property FailureDescription.
        /// </summary>
        public FailureDescription FailureDescription { get; set; }

        /// <summary>
        /// Checks to see if the FailureDescription property is set.
        /// </summary>
        internal bool IsSetFailureDescription() => this.FailureDescription != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        [AWSProperty(Required = true)]
        public DateTime? RequestTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RequestTimestamp property is set.
        /// </summary>
        internal bool IsSetRequestTimestamp() => this.RequestTimestamp.HasValue;

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
        [AWSProperty(Required = true)]
        public SnapshotRequestedBy RequestedBy { get; set; }

        /// <summary>
        /// Checks to see if the RequestedBy property is set.
        /// </summary>
        internal bool IsSetRequestedBy() => this.RequestedBy != null;

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
        [AWSProperty(Required = true)]
        public SnapshotStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 129)]
        public string Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;
    }
}
