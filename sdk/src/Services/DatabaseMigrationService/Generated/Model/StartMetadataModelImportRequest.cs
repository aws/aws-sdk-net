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
    /// Container for the parameters to the StartMetadataModelImport operation.
    /// Queues an import of metadata models (database objects such as tables, views, and procedures)
    /// from your data provider into the metadata tree. If other requests created by <c>Start*</c>
    /// operations are already in the migration project's queue, the import begins after they
    /// complete.
    /// 
    ///  
    /// <para>
    /// To check the status of the import request, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DescribeMetadataModelImports.html">DescribeMetadataModelImports</a>
    /// using the returned <c>RequestIdentifier</c> as a filter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions:</b> <c>dms:StartMetadataModelImport</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>.
    /// </para>
    /// </summary>
    public partial class StartMetadataModelImportRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _migrationProjectIdentifier;
        private OriginTypeValue _origin;
        private bool? _refresh;
        private string _selectionRules;

        /// <summary>
        /// Gets and sets the property MigrationProjectIdentifier. 
        /// <para>
        /// The migration project name or Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string MigrationProjectIdentifier
        {
            get { return this._migrationProjectIdentifier; }
            set { this._migrationProjectIdentifier = value; }
        }

        // Check to see if MigrationProjectIdentifier property is set
        internal bool IsSetMigrationProjectIdentifier()
        {
            return this._migrationProjectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// Specifies the metadata tree to import into.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot import from a virtual target data provider.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginTypeValue Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property Refresh. 
        /// <para>
        /// Specifies whether to refresh the selected metadata models from the data provider.
        /// </para>
        ///  
        /// <para>
        /// When <c>true</c>, the import reloads the selected metadata models with current definitions
        /// and removes their existing subtree.
        /// </para>
        ///  
        /// <para>
        /// When <c>false</c> (default), the import loads the full subtree that has not yet been
        /// loaded into the metadata tree.
        /// </para>
        /// </summary>
        public bool? Refresh
        {
            get { return this._refresh; }
            set { this._refresh = value; }
        }

        // Check to see if Refresh property is set
        internal bool IsSetRefresh()
        {
            return this._refresh.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// A JSON string that identifies the metadata models to import from the data provider.
        /// For the selection rule format and examples, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/sc-selection-rules.html">Selection
        /// rules in DMS Schema Conversion</a>.
        /// </para>
        ///  
        /// <para>
        /// Usage:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Accepts source or target selection rules depending on the <c>Origin</c> parameter.
        /// The <c>server-name</c> in the object locator must match the corresponding data provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Supports <c>explicit</c>, <c>include</c>, and <c>exclude</c> rule actions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SelectionRules
        {
            get { return this._selectionRules; }
            set { this._selectionRules = value; }
        }

        // Check to see if SelectionRules property is set
        internal bool IsSetSelectionRules()
        {
            return this._selectionRules != null;
        }

    }
}