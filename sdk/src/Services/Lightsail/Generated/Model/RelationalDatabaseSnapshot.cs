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
    /// Describes a database snapshot.
    /// </summary>
    public partial class RelationalDatabaseSnapshot
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _engine;
        private string _engineVersion;
        private string _fromRelationalDatabaseArn;
        private string _fromRelationalDatabaseBlueprintId;
        private string _fromRelationalDatabaseBundleId;
        private string _fromRelationalDatabaseName;
        private ResourceLocation _location;
        private string _name;
        private ResourceType _resourceType;
        private int? _sizeInGb;
        private string _state;
        private string _supportCode;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database snapshot.
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
        /// The timestamp when the database snapshot was created.
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The software of the database snapshot (for example, <c>MySQL</c>)
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version for the database snapshot (for example, <c>5.7.23</c>).
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database from which the database snapshot was
        /// created.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseArn
        {
            get { return this._fromRelationalDatabaseArn; }
            set { this._fromRelationalDatabaseArn = value; }
        }

        // Check to see if FromRelationalDatabaseArn property is set
        internal bool IsSetFromRelationalDatabaseArn()
        {
            return this._fromRelationalDatabaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseBlueprintId. 
        /// <para>
        /// The blueprint ID of the database from which the database snapshot was created. A blueprint
        /// describes the major engine version of a database.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseBlueprintId
        {
            get { return this._fromRelationalDatabaseBlueprintId; }
            set { this._fromRelationalDatabaseBlueprintId = value; }
        }

        // Check to see if FromRelationalDatabaseBlueprintId property is set
        internal bool IsSetFromRelationalDatabaseBlueprintId()
        {
            return this._fromRelationalDatabaseBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseBundleId. 
        /// <para>
        /// The bundle ID of the database from which the database snapshot was created.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseBundleId
        {
            get { return this._fromRelationalDatabaseBundleId; }
            set { this._fromRelationalDatabaseBundleId = value; }
        }

        // Check to see if FromRelationalDatabaseBundleId property is set
        internal bool IsSetFromRelationalDatabaseBundleId()
        {
            return this._fromRelationalDatabaseBundleId != null;
        }

        /// <summary>
        /// Gets and sets the property FromRelationalDatabaseName. 
        /// <para>
        /// The name of the source database from which the database snapshot was created.
        /// </para>
        /// </summary>
        public string FromRelationalDatabaseName
        {
            get { return this._fromRelationalDatabaseName; }
            set { this._fromRelationalDatabaseName = value; }
        }

        // Check to see if FromRelationalDatabaseName property is set
        internal bool IsSetFromRelationalDatabaseName()
        {
            return this._fromRelationalDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Region name and Availability Zone where the database snapshot is located.
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
        /// The name of the database snapshot.
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
        /// The Lightsail resource type.
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
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB (for example, <c>32</c>) for the database snapshot.
        /// </para>
        /// </summary>
        public int? SizeInGb
        {
            get { return this._sizeInGb; }
            set { this._sizeInGb = value; }
        }

        // Check to see if SizeInGb property is set
        internal bool IsSetSizeInGb()
        {
            return this._sizeInGb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the database snapshot.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code for the database snapshot. Include this code in your email to support
        /// when you have questions about a database snapshot in Lightsail. This code enables
        /// our support team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}