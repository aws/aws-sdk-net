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
    /// Container for the parameters to the GetTables operation. Retrieves the definitions
    /// of some or all of the tables in a given <c>Database</c>.
    /// </summary>
    public partial class GetTablesRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        ///  Specifies the table fields returned by the <c>GetTables</c> call. This parameter
        /// doesn’t accept an empty list. The request must include <c>NAME</c>.
        /// </para>
        ///  
        /// <para>
        /// The following are the valid combinations of values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NAME</c> - Names of all tables in the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NAME</c>, <c>TABLE_TYPE</c> - Names of all tables and the table types.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributesToGet { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributesToGet property is set.
        /// </summary>
        internal bool IsSetAttributesToGet() => this.AttributesToGet != null && (this.AttributesToGet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuditContext. 
        /// <para>
        /// A structure containing the Lake Formation <a href="https://docs.aws.amazon.com/glue/latest/webapi/API_AuditContext.html">audit
        /// context</a>.
        /// </para>
        /// </summary>
        public AuditContext AuditContext { get; set; }

        /// <summary>
        /// Checks to see if the AuditContext property is set.
        /// </summary>
        internal bool IsSetAuditContext() => this.AuditContext != null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the tables reside. If none is provided, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database in the catalog whose tables to list. For Hive compatibility, this name
        /// is entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// A regular expression pattern. If present, only those tables whose names match the
        /// pattern are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property IncludeStatusDetails. 
        /// <para>
        /// Specifies whether to include status details related to a request to create or update
        /// an Glue Data Catalog view.
        /// </para>
        /// </summary>
        public bool? IncludeStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the IncludeStatusDetails property is set.
        /// </summary>
        internal bool IsSetIncludeStatusDetails() => this.IncludeStatusDetails.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tables to return in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, included if this is a continuation call.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryAsOfTime. 
        /// <para>
        /// The time as of when to read the table contents. If not set, the most recent transaction
        /// commit time will be used. Cannot be specified along with <c>TransactionId</c>.
        /// </para>
        /// </summary>
        public DateTime? QueryAsOfTime { get; set; }

        /// <summary>
        /// Checks to see if the QueryAsOfTime property is set.
        /// </summary>
        internal bool IsSetQueryAsOfTime() => this.QueryAsOfTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceShareType. 
        /// <para>
        /// Specifies which tables the <c>GetTables</c> call returns. The allowable values are
        /// <c>FEDERATED</c> or <c>ALL</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If set to <c>FEDERATED</c>, returns only federated tables, which reference an entity
        /// outside the Glue Data Catalog.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <c>ALL</c>, returns all tables in the database, both federated and non-federated.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TableResourceShareType ResourceShareType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareType property is set.
        /// </summary>
        internal bool IsSetResourceShareType() => this.ResourceShareType != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to read the table contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
