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
    /// Container for the parameters to the GetEntityRecords operation. This API is used to
    /// query preview data from a given connection type or from a native Amazon S3 based Glue
    /// Data Catalog. <para> Returns records as an array of JSON blobs. Each record is formatted
    /// using Jackson JsonNode based on the field type defined by the <c>DescribeEntity</c>
    /// API. </para> <para> Spark connectors generate schemas according to the same data type
    /// mapping as in the <c>DescribeEntity</c> API. Spark connectors convert data to the
    /// appropriate data types matching the schema when returning rows. </para>
    /// </summary>
    public partial class GetEntityRecordsRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog ID of the catalog that contains the connection. This can be null, By default,
        /// the Amazon Web Services Account ID is the catalog ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection that contains the connection type credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property ConnectionOptions. 
        /// <para>
        /// Connector options that are required to query the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> ConnectionOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionOptions property is set.
        /// </summary>
        internal bool IsSetConnectionOptions() => this.ConnectionOptions != null && (this.ConnectionOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataStoreApiVersion. 
        /// <para>
        /// The API version of the SaaS connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DataStoreApiVersion { get; set; }

        /// <summary>
        /// Checks to see if the DataStoreApiVersion property is set.
        /// </summary>
        internal bool IsSetDataStoreApiVersion() => this.DataStoreApiVersion != null;

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// Name of the entity that we want to query the preview data from the given connection
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EntityName { get; set; }

        /// <summary>
        /// Checks to see if the EntityName property is set.
        /// </summary>
        internal bool IsSetEntityName() => this.EntityName != null;

        /// <summary>
        /// Gets and sets the property FilterPredicate. 
        /// <para>
        /// A filter predicate that you can apply in the query request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public string FilterPredicate { get; set; }

        /// <summary>
        /// Checks to see if the FilterPredicate property is set.
        /// </summary>
        internal bool IsSetFilterPredicate() => this.FilterPredicate != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Limits the number of records fetched with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public long? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, included if this is a continuation call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// A parameter that orders the response preview data.
        /// </para>
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Checks to see if the OrderBy property is set.
        /// </summary>
        internal bool IsSetOrderBy() => this.OrderBy != null;

        /// <summary>
        /// Gets and sets the property SelectedFields. 
        /// <para>
        ///  List of fields that we want to fetch as part of preview data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public List<string> SelectedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SelectedFields property is set.
        /// </summary>
        internal bool IsSetSelectedFields() => this.SelectedFields != null && (this.SelectedFields.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
