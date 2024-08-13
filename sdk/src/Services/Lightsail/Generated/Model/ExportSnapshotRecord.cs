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
    /// Describes an export snapshot record.
    /// </summary>
    public partial class ExportSnapshotRecord
    {
        private string _arn;
        private DateTime? _createdAt;
        private DestinationInfo _destinationInfo;
        private ResourceLocation _location;
        private string _name;
        private ResourceType _resourceType;
        private ExportSnapshotRecordSourceInfo _sourceInfo;
        private RecordState _state;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the export snapshot record.
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
        /// The date when the export snapshot record was created.
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
        /// Gets and sets the property DestinationInfo. 
        /// <para>
        /// A list of objects describing the destination of the export snapshot record.
        /// </para>
        /// </summary>
        public DestinationInfo DestinationInfo
        {
            get { return this._destinationInfo; }
            set { this._destinationInfo = value; }
        }

        // Check to see if DestinationInfo property is set
        internal bool IsSetDestinationInfo()
        {
            return this._destinationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region and Availability Zone where the export snapshot record is located.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The export snapshot record name.
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
        /// The Lightsail resource type (<c>ExportSnapshotRecord</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceInfo. 
        /// <para>
        /// A list of objects describing the source of the export snapshot record.
        /// </para>
        /// </summary>
        public ExportSnapshotRecordSourceInfo SourceInfo
        {
            get { return this._sourceInfo; }
            set { this._sourceInfo = value; }
        }

        // Check to see if SourceInfo property is set
        internal bool IsSetSourceInfo()
        {
            return this._sourceInfo != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the export snapshot record.
        /// </para>
        /// </summary>
        public RecordState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}