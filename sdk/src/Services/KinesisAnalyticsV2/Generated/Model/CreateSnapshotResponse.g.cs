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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// This is the response object from the CreateSnapshot operation.
    /// </summary>
    public partial class CreateSnapshotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The ARN of the enhanced snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotArn property is set.
        /// </summary>
        internal bool IsSetSnapshotArn() => this.SnapshotArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotOperationId. 
        /// <para>
        /// The ID of the snapshot operation. You can use this value with <c>DescribeSnapshotOperation</c>
        /// to track the progress of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SnapshotOperationId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOperationId property is set.
        /// </summary>
        internal bool IsSetSnapshotOperationId() => this.SnapshotOperationId != null;

        /// <summary>
        /// Gets and sets the property SnapshotOperationStatus. 
        /// <para>
        /// The status of the snapshot operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotOperationStatus SnapshotOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotOperationStatus property is set.
        /// </summary>
        internal bool IsSetSnapshotOperationStatus() => this.SnapshotOperationStatus != null;

        /// <summary>
        /// Gets and sets the property SnapshotStatus. 
        /// <para>
        /// The status of the snapshot. When Managed Service for Apache Flink accepts the request,
        /// the status is <c>CREATING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotStatus SnapshotStatus { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotStatus property is set.
        /// </summary>
        internal bool IsSetSnapshotStatus() => this.SnapshotStatus != null;
    }
}
