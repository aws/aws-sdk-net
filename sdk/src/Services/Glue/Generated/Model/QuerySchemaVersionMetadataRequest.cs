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
    /// Container for the parameters to the QuerySchemaVersionMetadata operation.
    /// Queries for the schema version metadata information.
    /// </summary>
    public partial class QuerySchemaVersionMetadataRequest : AmazonGlueRequest
    {
        private int? _maxResults;
        private List<MetadataKeyValuePair> _metadataList = AWSConfigs.InitializeCollections ? new List<MetadataKeyValuePair>() : null;
        private string _nextToken;
        private SchemaId _schemaId;
        private string _schemaVersionId;
        private SchemaVersionNumber _schemaVersionNumber;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results required per page. If the value is not supplied, this will
        /// be defaulted to 25 per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataList. 
        /// <para>
        /// Search key-value pairs for metadata, if they are not provided all the metadata information
        /// will be fetched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetadataKeyValuePair> MetadataList
        {
            get { return this._metadataList; }
            set { this._metadataList = value; }
        }

        // Check to see if MetadataList property is set
        internal bool IsSetMetadataList()
        {
            return this._metadataList != null && (this._metadataList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is a continuation call.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
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