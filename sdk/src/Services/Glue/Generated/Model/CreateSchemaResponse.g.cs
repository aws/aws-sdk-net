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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the CreateSchema operation.
    /// </summary>
    public partial class CreateSchemaResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Compatibility. 
        /// <para>
        /// The schema compatibility mode.
        /// </para>
        /// </summary>
        public Compatibility Compatibility { get; set; }

        /// <summary>
        /// Checks to see if the Compatibility property is set.
        /// </summary>
        internal bool IsSetCompatibility() => this.Compatibility != null;

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The data format of the schema definition. Currently <c>AVRO</c>, <c>JSON</c> and <c>PROTOBUF</c>
        /// are supported.
        /// </para>
        /// </summary>
        public DataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema if specified when created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LatestSchemaVersion. 
        /// <para>
        /// The latest version of the schema associated with the returned schema definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public long? LatestSchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestSchemaVersion property is set.
        /// </summary>
        internal bool IsSetLatestSchemaVersion() => this.LatestSchemaVersion.HasValue;

        /// <summary>
        /// Gets and sets the property NextSchemaVersion. 
        /// <para>
        /// The next version of the schema associated with the returned schema definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public long? NextSchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the NextSchemaVersion property is set.
        /// </summary>
        internal bool IsSetNextSchemaVersion() => this.NextSchemaVersion.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// The name of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RegistryName { get; set; }

        /// <summary>
        /// Checks to see if the RegistryName property is set.
        /// </summary>
        internal bool IsSetRegistryName() => this.RegistryName != null;

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string SchemaArn { get; set; }

        /// <summary>
        /// Checks to see if the SchemaArn property is set.
        /// </summary>
        internal bool IsSetSchemaArn() => this.SchemaArn != null;

        /// <summary>
        /// Gets and sets the property SchemaCheckpoint. 
        /// <para>
        /// The version number of the checkpoint (the last time the compatibility mode was changed).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public long? SchemaCheckpoint { get; set; }

        /// <summary>
        /// Checks to see if the SchemaCheckpoint property is set.
        /// </summary>
        internal bool IsSetSchemaCheckpoint() => this.SchemaCheckpoint.HasValue;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property SchemaStatus. 
        /// <para>
        /// The status of the schema. 
        /// </para>
        /// </summary>
        public SchemaStatus SchemaStatus { get; set; }

        /// <summary>
        /// Checks to see if the SchemaStatus property is set.
        /// </summary>
        internal bool IsSetSchemaStatus() => this.SchemaStatus != null;

        /// <summary>
        /// Gets and sets the property SchemaVersionId. 
        /// <para>
        /// The unique identifier of the first schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SchemaVersionId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersionId property is set.
        /// </summary>
        internal bool IsSetSchemaVersionId() => this.SchemaVersionId != null;

        /// <summary>
        /// Gets and sets the property SchemaVersionStatus. 
        /// <para>
        /// The status of the first schema version created.
        /// </para>
        /// </summary>
        public SchemaVersionStatus SchemaVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersionStatus property is set.
        /// </summary>
        internal bool IsSetSchemaVersionStatus() => this.SchemaVersionStatus != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
