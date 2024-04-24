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
    /// Container for the parameters to the RemoveSchemaVersionMetadata operation.
    /// Removes a key value pair from the schema version metadata for the specified schema
    /// version ID.
    /// </summary>
    public partial class RemoveSchemaVersionMetadataRequest : AmazonGlueRequest
    {
        private MetadataKeyValuePair _metadataKeyValue;
        private SchemaId _schemaId;
        private string _schemaVersionId;
        private SchemaVersionNumber _schemaVersionNumber;

        /// <summary>
        /// Gets and sets the property MetadataKeyValue. 
        /// <para>
        /// The value of the metadata key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataKeyValuePair MetadataKeyValue
        {
            get { return this._metadataKeyValue; }
            set { this._metadataKeyValue = value; }
        }

        // Check to see if MetadataKeyValue property is set
        internal bool IsSetMetadataKeyValue()
        {
            return this._metadataKeyValue != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// A wrapper structure that may contain the schema name and Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public SchemaId SchemaId
        {
            get { return this._schemaId; }
            set { this._schemaId = value; }
        }

        // Check to see if SchemaId property is set
        internal bool IsSetSchemaId()
        {
            return this._schemaId != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersionId. 
        /// <para>
        /// The unique version ID of the schema version.
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
        /// Gets and sets the property SchemaVersionNumber. 
        /// <para>
        /// The version number of the schema.
        /// </para>
        /// </summary>
        public SchemaVersionNumber SchemaVersionNumber
        {
            get { return this._schemaVersionNumber; }
            set { this._schemaVersionNumber = value; }
        }

        // Check to see if SchemaVersionNumber property is set
        internal bool IsSetSchemaVersionNumber()
        {
            return this._schemaVersionNumber != null;
        }

    }
}