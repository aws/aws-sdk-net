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
    /// Container for the parameters to the GetUnfilteredPartitionsMetadata operation.
    /// Retrieves partition metadata from the Data Catalog that contains unfiltered metadata.
    /// 
    ///  
    /// <para>
    /// For IAM authorization, the public IAM action associated with this API is <c>glue:GetPartitions</c>.
    /// </para>
    /// </summary>
    public partial class GetUnfilteredPartitionsMetadataRequest : AmazonGlueRequest
    {
        private AuditContext _auditContext;
        private string _catalogId;
        private string _databaseName;
        private string _expression;
        private int? _maxResults;
        private string _nextToken;
        private QuerySessionContext _querySessionContext;
        private string _region;
        private Segment _segment;
        private List<string> _supportedPermissionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property AuditContext. 
        /// <para>
        /// A structure containing Lake Formation audit context information.
        /// </para>
        /// </summary>
        public AuditContext AuditContext
        {
            get { return this._auditContext; }
            set { this._auditContext = value; }
        }

        // Check to see if AuditContext property is set
        internal bool IsSetAuditContext()
        {
            return this._auditContext != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the partitions in question reside. If none is provided,
        /// the AWS account ID is used by default. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database where the partitions reside.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// An expression that filters the partitions to be returned.
        /// </para>
        ///  
        /// <para>
        /// The expression uses SQL syntax similar to the SQL <c>WHERE</c> filter clause. The
        /// SQL statement parser <a href="http://jsqlparser.sourceforge.net/home.php">JSQLParser</a>
        /// parses the expression. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Operators</i>: The following are the operators that you can use in the <c>Expression</c>
        /// API call:
        /// </para>
        ///  <dl> <dt>=</dt> <dd> 
        /// <para>
        /// Checks whether the values of the two operands are equal; if yes, then the condition
        /// becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: Assume 'variable a' holds 10 and 'variable b' holds 20. 
        /// </para>
        ///  
        /// <para>
        /// (a = b) is not true.
        /// </para>
        ///  </dd> <dt>&lt; &gt;</dt> <dd> 
        /// <para>
        /// Checks whether the values of two operands are equal; if the values are not equal,
        /// then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &lt; &gt; b) is true.
        /// </para>
        ///  </dd> <dt>&gt;</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is greater than the value of the right
        /// operand; if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &gt; b) is not true.
        /// </para>
        ///  </dd> <dt>&lt;</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is less than the value of the right operand;
        /// if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &lt; b) is true.
        /// </para>
        ///  </dd> <dt>&gt;=</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is greater than or equal to the value
        /// of the right operand; if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &gt;= b) is not true.
        /// </para>
        ///  </dd> <dt>&lt;=</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is less than or equal to the value of
        /// the right operand; if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &lt;= b) is true.
        /// </para>
        ///  </dd> <dt>AND, OR, IN, BETWEEN, LIKE, NOT, IS NULL</dt> <dd> 
        /// <para>
        /// Logical operators.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        ///  <i>Supported Partition Key Types</i>: The following are the supported partition keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>string</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>date</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>timestamp</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>int</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bigint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>long</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tinyint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>smallint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>decimal</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If an type is encountered that is not valid, an exception is thrown. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of partitions to return in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is not the first call to retrieve these partitions.
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
        /// Gets and sets the property QuerySessionContext. 
        /// <para>
        /// A structure used as a protocol between query engines and Lake Formation or Glue. Contains
        /// both a Lake Formation generated authorization identifier and information from the
        /// request's authorization context.
        /// </para>
        /// </summary>
        public QuerySessionContext QuerySessionContext
        {
            get { return this._querySessionContext; }
            set { this._querySessionContext = value; }
        }

        // Check to see if QuerySessionContext property is set
        internal bool IsSetQuerySessionContext()
        {
            return this._querySessionContext != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Specified only if the base tables belong to a different Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The segment of the table's partitions to scan in this request.
        /// </para>
        /// </summary>
        public Segment Segment
        {
            get { return this._segment; }
            set { this._segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this._segment != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedPermissionTypes. 
        /// <para>
        /// A list of supported permission types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public List<string> SupportedPermissionTypes
        {
            get { return this._supportedPermissionTypes; }
            set { this._supportedPermissionTypes = value; }
        }

        // Check to see if SupportedPermissionTypes property is set
        internal bool IsSetSupportedPermissionTypes()
        {
            return this._supportedPermissionTypes != null && (this._supportedPermissionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table that contains the partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}