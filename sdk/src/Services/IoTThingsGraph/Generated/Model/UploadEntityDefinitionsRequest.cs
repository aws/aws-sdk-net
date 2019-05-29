/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the UploadEntityDefinitions operation.
    /// Asynchronously uploads one or more entity definitions to the user's namespace. The
    /// <code>document</code> parameter is required if <code>syncWithPublicNamespace</code>
    /// and <code>deleteExistingEntites</code> are false. If the <code>syncWithPublicNamespace</code>
    /// parameter is set to <code>true</code>, the user's namespace will synchronize with
    /// the latest version of the public namespace. If <code>deprecateExistingEntities</code>
    /// is set to true, all entities in the latest version will be deleted before the new
    /// <code>DefinitionDocument</code> is uploaded.
    /// 
    ///  
    /// <para>
    /// When a user uploads entity definitions for the first time, the service creates a new
    /// namespace for the user. The new namespace tracks the public namespace. Currently users
    /// can have only one namespace. The namespace version increments whenever a user uploads
    /// entity definitions that are backwards-incompatible and whenever a user sets the <code>syncWithPublicNamespace</code>
    /// parameter or the <code>deprecateExistingEntities</code> parameter to <code>true</code>.
    /// </para>
    ///  
    /// <para>
    /// The IDs for all of the entities should be in URN format. Each entity must be in the
    /// user's namespace. Users can't create entities in the public namespace, but entity
    /// definitions can refer to entities in the public namespace.
    /// </para>
    ///  
    /// <para>
    /// Valid entities are <code>Device</code>, <code>DeviceModel</code>, <code>Service</code>,
    /// <code>Capability</code>, <code>State</code>, <code>Action</code>, <code>Event</code>,
    /// <code>Property</code>, <code>Mapping</code>, <code>Enum</code>. 
    /// </para>
    /// </summary>
    public partial class UploadEntityDefinitionsRequest : AmazonIoTThingsGraphRequest
    {
        private bool? _deprecateExistingEntities;
        private DefinitionDocument _document;
        private bool? _syncWithPublicNamespace;

        /// <summary>
        /// Gets and sets the property DeprecateExistingEntities. 
        /// <para>
        /// A Boolean that specifies whether to deprecate all entities in the latest version before
        /// uploading the new <code>DefinitionDocument</code>. If set to <code>true</code>, the
        /// upload will create a new namespace version.
        /// </para>
        /// </summary>
        public bool DeprecateExistingEntities
        {
            get { return this._deprecateExistingEntities.GetValueOrDefault(); }
            set { this._deprecateExistingEntities = value; }
        }

        // Check to see if DeprecateExistingEntities property is set
        internal bool IsSetDeprecateExistingEntities()
        {
            return this._deprecateExistingEntities.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The <code>DefinitionDocument</code> that defines the updated entities.
        /// </para>
        /// </summary>
        public DefinitionDocument Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property SyncWithPublicNamespace. 
        /// <para>
        /// A Boolean that specifies whether to synchronize with the latest version of the public
        /// namespace. If set to <code>true</code>, the upload will create a new namespace version.
        /// </para>
        /// </summary>
        public bool SyncWithPublicNamespace
        {
            get { return this._syncWithPublicNamespace.GetValueOrDefault(); }
            set { this._syncWithPublicNamespace = value; }
        }

        // Check to see if SyncWithPublicNamespace property is set
        internal bool IsSetSyncWithPublicNamespace()
        {
            return this._syncWithPublicNamespace.HasValue; 
        }

    }
}