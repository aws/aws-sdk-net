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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a schema in a Fleet Advisor collector inventory.
    /// </summary>
    public partial class SchemaResponse
    {
        private long? _codeLineCount;
        private long? _codeSize;
        private string _complexity;
        private DatabaseShortInfoResponse _databaseInstance;
        private SchemaShortInfoResponse _originalSchema;
        private string _schemaId;
        private string _schemaName;
        private ServerShortInfoResponse _server;
        private double? _similarity;

        /// <summary>
        /// Gets and sets the property CodeLineCount. 
        /// <para>
        /// The number of lines of code in a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeLineCount
        {
            get { return this._codeLineCount; }
            set { this._codeLineCount = value; }
        }

        // Check to see if CodeLineCount property is set
        internal bool IsSetCodeLineCount()
        {
            return this._codeLineCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size level of the code in a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeSize
        {
            get { return this._codeSize; }
            set { this._codeSize = value; }
        }

        // Check to see if CodeSize property is set
        internal bool IsSetCodeSize()
        {
            return this._codeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Complexity. 
        /// <para>
        /// The complexity level of the code in a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string Complexity
        {
            get { return this._complexity; }
            set { this._complexity = value; }
        }

        // Check to see if Complexity property is set
        internal bool IsSetComplexity()
        {
            return this._complexity != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseInstance. 
        /// <para>
        /// The database for a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public DatabaseShortInfoResponse DatabaseInstance
        {
            get { return this._databaseInstance; }
            set { this._databaseInstance = value; }
        }

        // Check to see if DatabaseInstance property is set
        internal bool IsSetDatabaseInstance()
        {
            return this._databaseInstance != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalSchema.
        /// </summary>
        public SchemaShortInfoResponse OriginalSchema
        {
            get { return this._originalSchema; }
            set { this._originalSchema = value; }
        }

        // Check to see if OriginalSchema property is set
        internal bool IsSetOriginalSchema()
        {
            return this._originalSchema != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The ID of a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string SchemaId
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
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Server. 
        /// <para>
        /// The database server for a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public ServerShortInfoResponse Server
        {
            get { return this._server; }
            set { this._server = value; }
        }

        // Check to see if Server property is set
        internal bool IsSetServer()
        {
            return this._server != null;
        }

        /// <summary>
        /// Gets and sets the property Similarity. 
        /// <para>
        /// The similarity value for a schema in a Fleet Advisor collector inventory. A higher
        /// similarity value indicates that a schema is likely to be a duplicate.
        /// </para>
        /// </summary>
        public double? Similarity
        {
            get { return this._similarity; }
            set { this._similarity = value; }
        }

        // Check to see if Similarity property is set
        internal bool IsSetSimilarity()
        {
            return this._similarity.HasValue; 
        }

    }
}