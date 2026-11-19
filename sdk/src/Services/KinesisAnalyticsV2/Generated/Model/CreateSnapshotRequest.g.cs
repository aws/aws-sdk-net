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
    /// Container for the parameters to the CreateSnapshot operation. Creates an enhanced
    /// snapshot of the state data of a running Managed Service for Apache Flink application.
    /// The application must be in the <c>RUNNING</c> status, use Apache Flink version 1.20
    /// or later, and use the <c>ENHANCED_SNAPSHOTS</c> snapshot mode. <para> This operation
    /// is asynchronous. The response returns the snapshot ARN with the <c>CREATING</c> status.
    /// To check the status of the snapshot, use <c>DescribeSnapshot</c>. To track the progress
    /// of the operation, use <c>DescribeSnapshotOperation</c>. </para> <para> An application
    /// can have only one <c>CreateSnapshot</c> operation in progress at a time. For information
    /// about limits, see <a href="https://docs.aws.amazon.com/managed-flink/latest/java/limits.html">Managed
    /// Service for Apache Flink Quotas</a>. For more information about snapshots, see <a
    /// href="https://docs.aws.amazon.com/managed-flink/latest/java/how-snapshots.html">Enhanced
    /// Snapshots</a>. </para>
    /// </summary>
    public partial class CreateSnapshotRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationName.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property SnapshotDescription. 
        /// <para>
        /// A summary description of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SnapshotDescription { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotDescription property is set.
        /// </summary>
        internal bool IsSetSnapshotDescription() => this.SnapshotDescription != null;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the enhanced snapshot. The name must be unique among the snapshots in
        /// your account and Region. You can't reuse the name of an existing snapshot, including
        /// a snapshot in the <c>FAILED</c> status, until you delete that snapshot. Names that
        /// begin with <c>SYSTEMSNAPSHOT</c> are reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of one or more tags to assign to the snapshot. A tag is a key-value pair that
        /// identifies a snapshot. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/how-tagging.html">Using
        /// Tagging</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
