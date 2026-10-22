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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the source of an export snapshot record.
    /// </summary>
    public partial class ExportSnapshotRecordSourceInfo
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source instance or disk snapshot.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when the source instance or disk snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DiskSnapshotInfo. 
        /// <para>
        /// A list of objects describing a disk snapshot.
        /// </para>
        /// </summary>
        public DiskSnapshotInfo DiskSnapshotInfo { get; set; }

        /// <summary>
        /// Checks to see if the DiskSnapshotInfo property is set.
        /// </summary>
        internal bool IsSetDiskSnapshotInfo() => this.DiskSnapshotInfo != null;

        /// <summary>
        /// Gets and sets the property FromResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot's source instance or disk.
        /// </para>
        /// </summary>
        public string FromResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the FromResourceArn property is set.
        /// </summary>
        internal bool IsSetFromResourceArn() => this.FromResourceArn != null;

        /// <summary>
        /// Gets and sets the property FromResourceName. 
        /// <para>
        /// The name of the snapshot's source instance or disk.
        /// </para>
        /// </summary>
        public string FromResourceName { get; set; }

        /// <summary>
        /// Checks to see if the FromResourceName property is set.
        /// </summary>
        internal bool IsSetFromResourceName() => this.FromResourceName != null;

        /// <summary>
        /// Gets and sets the property InstanceSnapshotInfo. 
        /// <para>
        /// A list of objects describing an instance snapshot.
        /// </para>
        /// </summary>
        public InstanceSnapshotInfo InstanceSnapshotInfo { get; set; }

        /// <summary>
        /// Checks to see if the InstanceSnapshotInfo property is set.
        /// </summary>
        internal bool IsSetInstanceSnapshotInfo() => this.InstanceSnapshotInfo != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the source instance or disk snapshot.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (<c>InstanceSnapshot</c> or <c>DiskSnapshot</c>).
        /// </para>
        /// </summary>
        public ExportSnapshotRecordSourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
