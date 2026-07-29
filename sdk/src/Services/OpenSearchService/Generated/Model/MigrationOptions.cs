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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The configuration options for a saved objects migration job.
    /// </summary>
    public partial class MigrationOptions
    {
        private string _conflictResolution;
        private ExportOptions _exportOptions;
        private MigrationSource _source;
        private MigrationWorkspace _workspace;

        /// <summary>
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// The strategy for resolving conflicts when saved objects already exist in the target
        /// workspace. Valid values are <c>CREATE_NEW_COPIES</c>, which creates new objects with
        /// unique IDs, and <c>overwrite</c>, which replaces existing objects.
        /// </para>
        /// </summary>
        public string ConflictResolution
        {
            get { return this._conflictResolution; }
            set { this._conflictResolution = value; }
        }

        // Check to see if ConflictResolution property is set
        internal bool IsSetConflictResolution()
        {
            return this._conflictResolution != null;
        }

        /// <summary>
        /// Gets and sets the property ExportOptions. 
        /// <para>
        /// Options to filter the scope of saved objects to export from the source.
        /// </para>
        /// </summary>
        public ExportOptions ExportOptions
        {
            get { return this._exportOptions; }
            set { this._exportOptions = value; }
        }

        // Check to see if ExportOptions property is set
        internal bool IsSetExportOptions()
        {
            return this._exportOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The data source from which to export saved objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MigrationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Workspace. 
        /// <para>
        /// The target workspace configuration for importing saved objects. You can specify an
        /// existing workspace or request creation of a new workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MigrationWorkspace Workspace
        {
            get { return this._workspace; }
            set { this._workspace = value; }
        }

        // Check to see if Workspace property is set
        internal bool IsSetWorkspace()
        {
            return this._workspace != null;
        }

    }
}