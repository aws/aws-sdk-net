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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
        private string _arn;
        private DateTime? _createdAt;
        private DiskSnapshotInfo _diskSnapshotInfo;
        private string _fromResourceArn;
        private string _fromResourceName;
        private InstanceSnapshotInfo _instanceSnapshotInfo;
        private string _name;
        private ExportSnapshotRecordSourceType _resourceType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source instance or disk snapshot.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when the source instance or disk snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskSnapshotInfo. 
        /// <para>
        /// A list of objects describing a disk snapshot.
        /// </para>
        /// </summary>
        public DiskSnapshotInfo DiskSnapshotInfo
        {
            get { return this._diskSnapshotInfo; }
            set { this._diskSnapshotInfo = value; }
        }

        // Check to see if DiskSnapshotInfo property is set
        internal bool IsSetDiskSnapshotInfo()
        {
            return this._diskSnapshotInfo != null;
        }

        /// <summary>
        /// Gets and sets the property FromResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot's source instance or disk.
        /// </para>
        /// </summary>
        public string FromResourceArn
        {
            get { return this._fromResourceArn; }
            set { this._fromResourceArn = value; }
        }

        // Check to see if FromResourceArn property is set
        internal bool IsSetFromResourceArn()
        {
            return this._fromResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property FromResourceName. 
        /// <para>
        /// The name of the snapshot's source instance or disk.
        /// </para>
        /// </summary>
        public string FromResourceName
        {
            get { return this._fromResourceName; }
            set { this._fromResourceName = value; }
        }

        // Check to see if FromResourceName property is set
        internal bool IsSetFromResourceName()
        {
            return this._fromResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceSnapshotInfo. 
        /// <para>
        /// A list of objects describing an instance snapshot.
        /// </para>
        /// </summary>
        public InstanceSnapshotInfo InstanceSnapshotInfo
        {
            get { return this._instanceSnapshotInfo; }
            set { this._instanceSnapshotInfo = value; }
        }

        // Check to see if InstanceSnapshotInfo property is set
        internal bool IsSetInstanceSnapshotInfo()
        {
            return this._instanceSnapshotInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the source instance or disk snapshot.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (<c>InstanceSnapshot</c> or <c>DiskSnapshot</c>).
        /// </para>
        /// </summary>
        public ExportSnapshotRecordSourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}