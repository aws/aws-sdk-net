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
    /// Container for the parameters to the ExportSnapshot operation. Exports the data of
    /// an enhanced snapshot to an Amazon S3 location. Managed Service for Apache Flink assumes
    /// the IAM role that you specify in <c>ExportDestinationConfiguration</c> to write the
    /// snapshot data. The snapshot must be in the <c>READY</c> status. <para> This operation
    /// is asynchronous. To track the progress of the export, use <c>DescribeSnapshotOperation</c>.
    /// </para> <para> A snapshot can have only one export in progress at a time. If an export
    /// of the snapshot is already in progress, <c>LimitExceededException</c> is returned.
    /// </para> <para> For more information, see <a href="https://docs.aws.amazon.com/managed-flink/latest/java/snapshots-import-export.html">Import
    /// and export</a>. </para>
    /// </summary>
    public partial class ExportSnapshotRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ExportDestinationConfiguration. 
        /// <para>
        /// Describes the location, IAM role, and encryption configuration of the export destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDestinationConfiguration ExportDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExportDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetExportDestinationConfiguration() => this.ExportDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the enhanced snapshot to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;
    }
}
