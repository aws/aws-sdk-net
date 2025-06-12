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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the CreateSchema operation.
    /// </summary>
    public partial class CreateSchemaResponse : AmazonWebServiceResponse
    {
        private Compatibility _compatibility;
        private DataFormat _dataFormat;
        private string _description;
        private long? _latestSchemaVersion;
        private long? _nextSchemaVersion;
        private string _registryArn;
        private string _registryName;
        private string _schemaArn;
        private long? _schemaCheckpoint;
        private string _schemaName;
        private SchemaStatus _schemaStatus;
        private string _schemaVersionId;
        private SchemaVersionStatus _schemaVersionStatus;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Compatibility. 
        /// <para>
        /// The schema compatibility mode.
        /// </para>
        /// </summary>
        public Compatibility Compatibility
        {
            get { return this._compatibility; }
            set { this._compatibility = value; }
        }

        // Check to see if Compatibility property is set
        internal bool IsSetCompatibility()
        {
            return this._compatibility != null;
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The data format of the schema definition. Currently <c>AVRO</c>, <c>JSON</c> and <c>PROTOBUF</c>
        /// are supported.
        /// </para>
        /// </summary>
        public DataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema if specified when created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LatestSchemaVersion. 
        /// <para>
        /// The latest version of the schema associated with the returned schema definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public long? LatestSchemaVersion
        {
            get { return this._latestSchemaVersion; }
            set { this._latestSchemaVersion = value; }
        }

        // Check to see if LatestSchemaVersion property is set
        internal bool IsSetLatestSchemaVersion()
        {
            return this._latestSchemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextSchemaVersion. 
        /// <para>
        /// The next version of the schema associated with the returned schema definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public long? NextSchemaVersion
        {
            get { return this._nextSchemaVersion; }
            set { this._nextSchemaVersion = value; }
        }

        // Check to see if NextSchemaVersion property is set
        internal bool IsSetNextSchemaVersion()
        {
            return this._nextSchemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string RegistryArn
        {
            get { return this._registryArn; }
            set { this._registryArn = value; }
        }

        // Check to see if RegistryArn property is set
        internal bool IsSetRegistryArn()
        {
            return this._registryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// The name of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RegistryName
        {
            get { return this._registryName; }
            set { this._registryName = value; }
        }

        // Check to see if RegistryName property is set
        internal bool IsSetRegistryName()
        {
            return this._registryName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string SchemaArn
        {
            get { return this._schemaArn; }
            set { this._schemaArn = value; }
        }

        // Check to see if SchemaArn property is set
        internal bool IsSetSchemaArn()
        {
            return this._schemaArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaCheckpoint. 
        /// <para>
        /// The version number of the checkpoint (the last time the compatibility mode was changed).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public long? SchemaCheckpoint
        {
            get { return this._schemaCheckpoint; }
            set { this._schemaCheckpoint = value; }
        }

        // Check to see if SchemaCheckpoint property is set
        internal bool IsSetSchemaCheckpoint()
        {
            return this._schemaCheckpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }

        // Check to see if SchemaName property is set
        internal bool IsSetSchemaName()
        {
            return this._schemaName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaStatus. 
        /// <para>
        /// The status of the schema. 
        /// </para>
        /// </summary>
        public SchemaStatus SchemaStatus
        {
            get { return this._schemaStatus; }
            set { this._schemaStatus = value; }
        }

        // Check to see if SchemaStatus property is set
        internal bool IsSetSchemaStatus()
        {
            return this._schemaStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersionId. 
        /// <para>
        /// The unique identifier of the first schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SchemaVersionId
        {
            get { return this._schemaVersionId; }
            set { this._schemaVersionId = value; }
        }

        // Check to see if SchemaVersionId property is set
        internal bool IsSetSchemaVersionId()
        {
            return this._schemaVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersionStatus. 
        /// <para>
        /// The status of the first schema version created.
        /// </para>
        /// </summary>
        public SchemaVersionStatus SchemaVersionStatus
        {
            get { return this._schemaVersionStatus; }
            set { this._schemaVersionStatus = value; }
        }

        // Check to see if SchemaVersionStatus property is set
        internal bool IsSetSchemaVersionStatus()
        {
            return this._schemaVersionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
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