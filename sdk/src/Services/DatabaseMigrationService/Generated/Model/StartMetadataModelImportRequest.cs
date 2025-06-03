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
    /// Loads the metadata for all the dependent database objects of the parent object.
    /// 
    ///  
    /// <para>
    /// This operation uses your project's Amazon S3 bucket as a metadata cache to improve
    /// performance.
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
        /// Whether to load metadata to the source or target database.
        /// </para>
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
        /// If <c>true</c>, DMS loads metadata for the specified objects from the source database.
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
        /// A value that specifies the database objects to import.
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