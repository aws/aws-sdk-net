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
    /// Container for the parameters to the GetEntityRecords operation.
    /// This API is used to query preview data from a given connection type or from a native
    /// Amazon S3 based Glue Data Catalog.
    /// 
    ///  
    /// <para>
    /// Returns records as an array of JSON blobs. Each record is formatted using Jackson
    /// JsonNode based on the field type defined by the <c>DescribeEntity</c> API.
    /// </para>
    ///  
    /// <para>
    /// Spark connectors generate schemas according to the same data type mapping as in the
    /// <c>DescribeEntity</c> API. Spark connectors convert data to the appropriate data types
    /// matching the schema when returning rows.
    /// </para>
    /// </summary>
    public partial class GetEntityRecordsRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _connectionName;
        private Dictionary<string, string> _connectionOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _dataStoreApiVersion;
        private string _entityName;
        private string _filterPredicate;
        private long? _limit;
        private string _nextToken;
        private string _orderBy;
        private List<string> _selectedFields = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog ID of the catalog that contains the connection. This can be null, By default,
        /// the Amazon Web Services Account ID is the catalog ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection that contains the connection type credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionOptions. 
        /// <para>
        /// Connector options that are required to query the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> ConnectionOptions
        {
            get { return this._connectionOptions; }
            set { this._connectionOptions = value; }
        }

        // Check to see if ConnectionOptions property is set
        internal bool IsSetConnectionOptions()
        {
            return this._connectionOptions != null && (this._connectionOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataStoreApiVersion. 
        /// <para>
        /// The API version of the SaaS connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataStoreApiVersion
        {
            get { return this._dataStoreApiVersion; }
            set { this._dataStoreApiVersion = value; }
        }

        // Check to see if DataStoreApiVersion property is set
        internal bool IsSetDataStoreApiVersion()
        {
            return this._dataStoreApiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// Name of the entity that we want to query the preview data from the given connection
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }

        // Check to see if EntityName property is set
        internal bool IsSetEntityName()
        {
            return this._entityName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterPredicate. 
        /// <para>
        /// A filter predicate that you can apply in the query request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string FilterPredicate
        {
            get { return this._filterPredicate; }
            set { this._filterPredicate = value; }
        }

        // Check to see if FilterPredicate property is set
        internal bool IsSetFilterPredicate()
        {
            return this._filterPredicate != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Limits the number of records fetched with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public long? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, included if this is a continuation call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// A parameter that orders the response preview data.
        /// </para>
        /// </summary>
        public string OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedFields. 
        /// <para>
        ///  List of fields that we want to fetch as part of preview data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<string> SelectedFields
        {
            get { return this._selectedFields; }
            set { this._selectedFields = value; }
        }

        // Check to see if SelectedFields property is set
        internal bool IsSetSelectedFields()
        {
            return this._selectedFields != null && (this._selectedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}