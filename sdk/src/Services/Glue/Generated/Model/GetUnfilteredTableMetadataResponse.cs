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
    /// This is the response object from the GetUnfilteredTableMetadata operation.
    /// </summary>
    public partial class GetUnfilteredTableMetadataResponse : AmazonWebServiceResponse
    {
        private List<string> _authorizedColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ColumnRowFilter> _cellFilters = AWSConfigs.InitializeCollections ? new List<ColumnRowFilter>() : null;
        private bool? _isMultiDialectView;
        private bool? _isProtected;
        private bool? _isRegisteredWithLakeFormation;
        private List<string> _permissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _queryAuthorizationId;
        private string _resourceArn;
        private string _rowFilter;
        private Table _table;

        /// <summary>
        /// Gets and sets the property AuthorizedColumns. 
        /// <para>
        /// A list of column names that the user has been granted access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorizedColumns
        {
            get { return this._authorizedColumns; }
            set { this._authorizedColumns = value; }
        }

        // Check to see if AuthorizedColumns property is set
        internal bool IsSetAuthorizedColumns()
        {
            return this._authorizedColumns != null && (this._authorizedColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CellFilters. 
        /// <para>
        /// A list of column row filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColumnRowFilter> CellFilters
        {
            get { return this._cellFilters; }
            set { this._cellFilters = value; }
        }

        // Check to see if CellFilters property is set
        internal bool IsSetCellFilters()
        {
            return this._cellFilters != null && (this._cellFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsMultiDialectView. 
        /// <para>
        /// Specifies whether the view supports the SQL dialects of one or more different query
        /// engines and can therefore be read by those engines.
        /// </para>
        /// </summary>
        public bool? IsMultiDialectView
        {
            get { return this._isMultiDialectView; }
            set { this._isMultiDialectView = value; }
        }

        // Check to see if IsMultiDialectView property is set
        internal bool IsSetIsMultiDialectView()
        {
            return this._isMultiDialectView.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsProtected. 
        /// <para>
        /// A flag that instructs the engine not to push user-provided operations into the logical
        /// plan of the view during query planning. However, if set this flag does not guarantee
        /// that the engine will comply. Refer to the engine's documentation to understand the
        /// guarantees provided, if any.
        /// </para>
        /// </summary>
        public bool? IsProtected
        {
            get { return this._isProtected; }
            set { this._isProtected = value; }
        }

        // Check to see if IsProtected property is set
        internal bool IsSetIsProtected()
        {
            return this._isProtected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRegisteredWithLakeFormation. 
        /// <para>
        /// A Boolean value that indicates whether the partition location is registered with Lake
        /// Formation.
        /// </para>
        /// </summary>
        public bool? IsRegisteredWithLakeFormation
        {
            get { return this._isRegisteredWithLakeFormation; }
            set { this._isRegisteredWithLakeFormation = value; }
        }

        // Check to see if IsRegisteredWithLakeFormation property is set
        internal bool IsSetIsRegisteredWithLakeFormation()
        {
            return this._isRegisteredWithLakeFormation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The Lake Formation data permissions of the caller on the table. Used to authorize
        /// the call when no view context is found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryAuthorizationId. 
        /// <para>
        /// A cryptographically generated query identifier generated by Glue or Lake Formation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string QueryAuthorizationId
        {
            get { return this._queryAuthorizationId; }
            set { this._queryAuthorizationId = value; }
        }

        // Check to see if QueryAuthorizationId property is set
        internal bool IsSetQueryAuthorizationId()
        {
            return this._queryAuthorizationId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource ARN of the parent resource extracted from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RowFilter. 
        /// <para>
        /// The filter that applies to the table. For example when applying the filter in SQL,
        /// it would go in the <c>WHERE</c> clause and can be evaluated by using an <c>AND</c>
        /// operator with any other predicates applied by the user querying the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RowFilter
        {
            get { return this._rowFilter; }
            set { this._rowFilter = value; }
        }

        // Check to see if RowFilter property is set
        internal bool IsSetRowFilter()
        {
            return this._rowFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// A Table object containing the table metadata.
        /// </para>
        /// </summary>
        public Table Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}