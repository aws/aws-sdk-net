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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a schema in a Fleet Advisor collector inventory.
    /// </summary>
    public partial class SchemaResponse
    {
        /// <summary>
        /// Gets and sets the property CodeLineCount. 
        /// <para>
        /// The number of lines of code in a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeLineCount { get; set; }

        /// <summary>
        /// Checks to see if the CodeLineCount property is set.
        /// </summary>
        internal bool IsSetCodeLineCount() => this.CodeLineCount.HasValue;

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size level of the code in a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeSize { get; set; }

        /// <summary>
        /// Checks to see if the CodeSize property is set.
        /// </summary>
        internal bool IsSetCodeSize() => this.CodeSize.HasValue;

        /// <summary>
        /// Gets and sets the property Complexity. 
        /// <para>
        /// The complexity level of the code in a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string Complexity { get; set; }

        /// <summary>
        /// Checks to see if the Complexity property is set.
        /// </summary>
        internal bool IsSetComplexity() => this.Complexity != null;

        /// <summary>
        /// Gets and sets the property DatabaseInstance. 
        /// <para>
        /// The database for a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public DatabaseShortInfoResponse DatabaseInstance { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInstance property is set.
        /// </summary>
        internal bool IsSetDatabaseInstance() => this.DatabaseInstance != null;

        /// <summary>
        /// Gets and sets the property OriginalSchema.
        /// </summary>
        public SchemaShortInfoResponse OriginalSchema { get; set; }

        /// <summary>
        /// Checks to see if the OriginalSchema property is set.
        /// </summary>
        internal bool IsSetOriginalSchema() => this.OriginalSchema != null;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The ID of a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId != null;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property Server. 
        /// <para>
        /// The database server for a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public ServerShortInfoResponse Server { get; set; }

        /// <summary>
        /// Checks to see if the Server property is set.
        /// </summary>
        internal bool IsSetServer() => this.Server != null;

        /// <summary>
        /// Gets and sets the property Similarity. 
        /// <para>
        /// The similarity value for a schema in a Fleet Advisor collector inventory. A higher
        /// similarity value indicates that a schema is likely to be a duplicate.
        /// </para>
        /// </summary>
        public double? Similarity { get; set; }

        /// <summary>
        /// Checks to see if the Similarity property is set.
        /// </summary>
        internal bool IsSetSimilarity() => this.Similarity.HasValue;
    }
}
