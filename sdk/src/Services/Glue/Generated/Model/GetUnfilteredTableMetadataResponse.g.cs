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
    /// This is the response object from the GetUnfilteredTableMetadata operation.
    /// </summary>
    public partial class GetUnfilteredTableMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthorizedColumns. 
        /// <para>
        /// A list of column names that the user has been granted access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorizedColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorizedColumns property is set.
        /// </summary>
        internal bool IsSetAuthorizedColumns() => this.AuthorizedColumns != null && (this.AuthorizedColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CellFilters. 
        /// <para>
        /// A list of column row filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColumnRowFilter> CellFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnRowFilter>() : null;

        /// <summary>
        /// Checks to see if the CellFilters property is set.
        /// </summary>
        internal bool IsSetCellFilters() => this.CellFilters != null && (this.CellFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsMaterializedView. 
        /// <para>
        /// Indicates if a table is a materialized view.
        /// </para>
        /// </summary>
        public bool? IsMaterializedView { get; set; }

        /// <summary>
        /// Checks to see if the IsMaterializedView property is set.
        /// </summary>
        internal bool IsSetIsMaterializedView() => this.IsMaterializedView.HasValue;

        /// <summary>
        /// Gets and sets the property IsMultiDialectView. 
        /// <para>
        /// Specifies whether the view supports the SQL dialects of one or more different query
        /// engines and can therefore be read by those engines.
        /// </para>
        /// </summary>
        public bool? IsMultiDialectView { get; set; }

        /// <summary>
        /// Checks to see if the IsMultiDialectView property is set.
        /// </summary>
        internal bool IsSetIsMultiDialectView() => this.IsMultiDialectView.HasValue;

        /// <summary>
        /// Gets and sets the property IsProtected. 
        /// <para>
        /// A flag that instructs the engine not to push user-provided operations into the logical
        /// plan of the view during query planning. However, if set this flag does not guarantee
        /// that the engine will comply. Refer to the engine's documentation to understand the
        /// guarantees provided, if any.
        /// </para>
        /// </summary>
        public bool? IsProtected { get; set; }

        /// <summary>
        /// Checks to see if the IsProtected property is set.
        /// </summary>
        internal bool IsSetIsProtected() => this.IsProtected.HasValue;

        /// <summary>
        /// Gets and sets the property IsRegisteredWithLakeFormation. 
        /// <para>
        /// A Boolean value that indicates whether the partition location is registered with Lake
        /// Formation.
        /// </para>
        /// </summary>
        public bool? IsRegisteredWithLakeFormation { get; set; }

        /// <summary>
        /// Checks to see if the IsRegisteredWithLakeFormation property is set.
        /// </summary>
        internal bool IsSetIsRegisteredWithLakeFormation() => this.IsRegisteredWithLakeFormation.HasValue;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The Lake Formation data permissions of the caller on the table. Used to authorize
        /// the call when no view context is found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryAuthorizationId. 
        /// <para>
        /// A cryptographically generated query identifier generated by Glue or Lake Formation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string QueryAuthorizationId { get; set; }

        /// <summary>
        /// Checks to see if the QueryAuthorizationId property is set.
        /// </summary>
        internal bool IsSetQueryAuthorizationId() => this.QueryAuthorizationId != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource ARN of the parent resource extracted from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property RowFilter. 
        /// <para>
        /// The filter that applies to the table. For example when applying the filter in SQL,
        /// it would go in the <c>WHERE</c> clause and can be evaluated by using an <c>AND</c>
        /// operator with any other predicates applied by the user querying the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string RowFilter { get; set; }

        /// <summary>
        /// Checks to see if the RowFilter property is set.
        /// </summary>
        internal bool IsSetRowFilter() => this.RowFilter != null;

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// A Table object containing the table metadata.
        /// </para>
        /// </summary>
        public Table Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;
    }
}
