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
    /// Container for the parameters to the RemoveSchemaVersionMetadata operation. Removes
    /// a key value pair from the schema version metadata for the specified schema version
    /// ID.
    /// </summary>
    public partial class RemoveSchemaVersionMetadataRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property MetadataKeyValue. 
        /// <para>
        /// The value of the metadata key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetadataKeyValuePair MetadataKeyValue { get; set; }

        /// <summary>
        /// Checks to see if the MetadataKeyValue property is set.
        /// </summary>
        internal bool IsSetMetadataKeyValue() => this.MetadataKeyValue != null;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// A wrapper structure that may contain the schema name and Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public SchemaId SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId != null;

        /// <summary>
        /// Gets and sets the property SchemaVersionId. 
        /// <para>
        /// The unique version ID of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SchemaVersionId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersionId property is set.
        /// </summary>
        internal bool IsSetSchemaVersionId() => this.SchemaVersionId != null;

        /// <summary>
        /// Gets and sets the property SchemaVersionNumber. 
        /// <para>
        /// The version number of the schema.
        /// </para>
        /// </summary>
        public SchemaVersionNumber SchemaVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersionNumber property is set.
        /// </summary>
        internal bool IsSetSchemaVersionNumber() => this.SchemaVersionNumber != null;
    }
}
