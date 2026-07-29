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
    /// Options to filter the scope of saved objects to export during a migration.
    /// </summary>
    public partial class ExportOptions
    {
        private bool? _includeReferencesDeep;
        private List<SavedObjectIdentifier> _objects = AWSConfigs.InitializeCollections ? new List<SavedObjectIdentifier>() : null;
        private List<string> _types = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IncludeReferencesDeep. 
        /// <para>
        /// Specifies whether to include all objects referenced by the exported objects, recursively.
        /// </para>
        /// </summary>
        public bool? IncludeReferencesDeep
        {
            get { return this._includeReferencesDeep; }
            set { this._includeReferencesDeep = value; }
        }

        // Check to see if IncludeReferencesDeep property is set
        internal bool IsSetIncludeReferencesDeep()
        {
            return this._includeReferencesDeep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Objects. 
        /// <para>
        /// A list of specific saved objects to include in the migration, identified by type and
        /// ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SavedObjectIdentifier> Objects
        {
            get { return this._objects; }
            set { this._objects = value; }
        }

        // Check to see if Objects property is set
        internal bool IsSetObjects()
        {
            return this._objects != null && (this._objects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// A list of saved object types to include in the migration. Valid values include <c>dashboard</c>,
        /// <c>visualization</c>, <c>index-pattern</c>, <c>search</c>, and <c>query</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && (this._types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}