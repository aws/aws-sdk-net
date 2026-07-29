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
    /// Container for the parameters to the StartMetadataModelExportToTarget operation.
    /// Queues an export of the selected converted metadata models (database objects such
    /// as tables, views, and procedures) to your target database. If other requests created
    /// by <c>Start*</c> operations are already in the migration project's queue, the export
    /// begins after they complete.
    /// 
    ///  
    /// <para>
    /// This operation requires a non-virtual target data provider.
    /// </para>
    ///  
    /// <para>
    /// The export applies only metadata models created by conversion. Metadata models imported
    /// from the database are skipped.
    /// </para>
    ///  <note> 
    /// <para>
    /// If objects with the same name already exist on the target database, the export overwrites
    /// them.
    /// </para>
    ///  </note> 
    /// <para>
    /// The operation installs the extension pack on the target database. For more information,
    /// see <a href="https://docs.aws.amazon.com/dms/latest/userguide/extension-pack.html">Using
    /// extension packs in DMS Schema Conversion</a>.
    /// </para>
    ///  
    /// <para>
    /// To check the status of the export request, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DescribeMetadataModelExportsToTarget.html">DescribeMetadataModelExportsToTarget</a>
    /// using the returned <c>RequestIdentifier</c> as a filter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions:</b> <c>dms:StartMetadataModelExportToTarget</c>. For more
    /// information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>.
    /// </para>
    /// </summary>
    public partial class StartMetadataModelExportToTargetRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _migrationProjectIdentifier;
        private bool? _overwriteExtensionPack;
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
        /// Gets and sets the property OverwriteExtensionPack. 
        /// <para>
        /// Specifies whether to overwrite the extension pack if one already exists on the target
        /// database. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? OverwriteExtensionPack
        {
            get { return this._overwriteExtensionPack; }
            set { this._overwriteExtensionPack = value; }
        }

        // Check to see if OverwriteExtensionPack property is set
        internal bool IsSetOverwriteExtensionPack()
        {
            return this._overwriteExtensionPack.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// A JSON string that identifies the metadata models to export to the target database.
        /// For the selection rule format and examples, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/sc-selection-rules.html">Selection
        /// rules in DMS Schema Conversion</a>.
        /// </para>
        ///  
        /// <para>
        /// Usage:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Accepts only target selection rules, where <c>server-name</c> in the object locator
        /// matches the target data provider.
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