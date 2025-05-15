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
    /// Applies converted database objects to your target database.
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
        /// Whether to overwrite the migration project extension pack. An extension pack is an
        /// add-on module that emulates functions present in a source database that are required
        /// when converting objects to the target database.
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
        /// A value that specifies the database objects to export.
        /// </para>
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