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
    /// Describes whether snapshots are enabled for a Managed Service for Apache Flink application.
    /// </summary>
    public partial class ApplicationSnapshotConfiguration
    {
        /// <summary>
        /// Gets and sets the property SnapshotMode. 
        /// <para>
        /// Specifies the snapshot mode for a Managed Service for Apache Flink application. To
        /// use enhanced snapshots, specify <c>ENHANCED_SNAPSHOTS</c>. If you don't specify this
        /// parameter, the application uses <c>APPLICATION_SNAPSHOTS_LEGACY</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/managed-flink/latest/java/how-snapshots.html">Enhanced
        /// Snapshots</a>.
        /// </para>
        ///  
        /// <para>
        /// To use <c>ENHANCED_SNAPSHOTS</c>, the application must use Apache Flink version 1.20
        /// or later.
        /// </para>
        /// </summary>
        public SnapshotMode SnapshotMode { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotMode property is set.
        /// </summary>
        internal bool IsSetSnapshotMode() => this.SnapshotMode != null;

        /// <summary>
        /// Gets and sets the property SnapshotsEnabled. 
        /// <para>
        /// Describes whether snapshots are enabled for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? SnapshotsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotsEnabled property is set.
        /// </summary>
        internal bool IsSetSnapshotsEnabled() => this.SnapshotsEnabled.HasValue;
    }
}
