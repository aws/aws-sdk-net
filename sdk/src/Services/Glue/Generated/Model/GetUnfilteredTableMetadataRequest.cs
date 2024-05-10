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
    /// Container for the parameters to the GetUnfilteredTableMetadata operation.
    /// Allows a third-party analytical engine to retrieve unfiltered table metadata from
    /// the Data Catalog.
    /// 
    ///  
    /// <para>
    /// For IAM authorization, the public IAM action associated with this API is <c>glue:GetTable</c>.
    /// </para>
    /// </summary>
    public partial class GetUnfilteredTableMetadataRequest : AmazonGlueRequest
    {
        private AuditContext _auditContext;
        private string _catalogId;
        private string _databaseName;
        private string _name;
        private string _parentResourceArn;
        private List<string> _permissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QuerySessionContext _querySessionContext;
        private string _region;
        private string _rootResourceArn;
        private SupportedDialect _supportedDialect;
        private List<string> _supportedPermissionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// The catalog ID where the table resides.
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
        /// (Required) Specifies the name of a database that contains the table.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// (Required) Specifies the name of a table for which you are requesting metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentResourceArn. 
        /// <para>
        /// The resource ARN of the view.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ParentResourceArn
        {
            get { return this._parentResourceArn; }
            set { this._parentResourceArn = value; }
        }

        // Check to see if ParentResourceArn property is set
        internal bool IsSetParentResourceArn()
        {
            return this._parentResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The Lake Formation data permissions of the caller on the table. Used to authorize
        /// the call when no view context is found.
        /// </para>
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
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property RootResourceArn. 
        /// <para>
        /// The resource ARN of the root view in a chain of nested views.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RootResourceArn
        {
            get { return this._rootResourceArn; }
            set { this._rootResourceArn = value; }
        }

        // Check to see if RootResourceArn property is set
        internal bool IsSetRootResourceArn()
        {
            return this._rootResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedDialect. 
        /// <para>
        /// A structure specifying the dialect and dialect version used by the query engine.
        /// </para>
        /// </summary>
        public SupportedDialect SupportedDialect
        {
            get { return this._supportedDialect; }
            set { this._supportedDialect = value; }
        }

        // Check to see if SupportedDialect property is set
        internal bool IsSetSupportedDialect()
        {
            return this._supportedDialect != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedPermissionTypes. 
        /// <para>
        /// Indicates the level of filtering a third-party analytical engine is capable of enforcing
        /// when calling the <c>GetUnfilteredTableMetadata</c> API operation. Accepted values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COLUMN_PERMISSION</c> - Column permissions ensure that users can access only specific
        /// columns in the table. If there are particular columns contain sensitive data, data
        /// lake administrators can define column filters that exclude access to specific columns.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CELL_FILTER_PERMISSION</c> - Cell-level filtering combines column filtering (include
        /// or exclude columns) and row filter expressions to restrict access to individual elements
        /// in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NESTED_PERMISSION</c> - Nested permissions combines cell-level filtering and nested
        /// column filtering to restrict access to columns and/or nested columns in specific rows
        /// based on row filter expressions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NESTED_CELL_PERMISSION</c> - Nested cell permissions combines nested permission
        /// with nested cell-level filtering. This allows different subsets of nested columns
        /// to be restricted based on an array of row filter expressions. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note: Each of these permission types follows a hierarchical order where each subsequent
        /// permission type includes all permission of the previous type.
        /// </para>
        ///  
        /// <para>
        /// Important: If you provide a supported permission type that doesn't match the user's
        /// level of permissions on the table, then Lake Formation raises an exception. For example,
        /// if the third-party engine calling the <c>GetUnfilteredTableMetadata</c> operation
        /// can enforce only column-level filtering, and the user has nested cell filtering applied
        /// on the table, Lake Formation throws an exception, and will not return unfiltered table
        /// metadata and data access credentials.
        /// </para>
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

    }
}