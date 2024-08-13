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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the UploadEntityDefinitions operation.
    /// Asynchronously uploads one or more entity definitions to the user's namespace. The
    /// <c>document</c> parameter is required if <c>syncWithPublicNamespace</c> and <c>deleteExistingEntites</c>
    /// are false. If the <c>syncWithPublicNamespace</c> parameter is set to <c>true</c>,
    /// the user's namespace will synchronize with the latest version of the public namespace.
    /// If <c>deprecateExistingEntities</c> is set to true, all entities in the latest version
    /// will be deleted before the new <c>DefinitionDocument</c> is uploaded.
    /// 
    ///  
    /// <para>
    /// When a user uploads entity definitions for the first time, the service creates a new
    /// namespace for the user. The new namespace tracks the public namespace. Currently users
    /// can have only one namespace. The namespace version increments whenever a user uploads
    /// entity definitions that are backwards-incompatible and whenever a user sets the <c>syncWithPublicNamespace</c>
    /// parameter or the <c>deprecateExistingEntities</c> parameter to <c>true</c>.
    /// </para>
    ///  
    /// <para>
    /// The IDs for all of the entities should be in URN format. Each entity must be in the
    /// user's namespace. Users can't create entities in the public namespace, but entity
    /// definitions can refer to entities in the public namespace.
    /// </para>
    ///  
    /// <para>
    /// Valid entities are <c>Device</c>, <c>DeviceModel</c>, <c>Service</c>, <c>Capability</c>,
    /// <c>State</c>, <c>Action</c>, <c>Event</c>, <c>Property</c>, <c>Mapping</c>, <c>Enum</c>.
    /// 
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
        /// uploading the new <c>DefinitionDocument</c>. If set to <c>true</c>, the upload will
        /// create a new namespace version.
        /// </para>
        /// </summary>
        public bool? DeprecateExistingEntities
        {
            get { return this._deprecateExistingEntities; }
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
        /// The <c>DefinitionDocument</c> that defines the updated entities.
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
        /// namespace. If set to <c>true</c>, the upload will create a new namespace version.
        /// </para>
        /// </summary>
        public bool? SyncWithPublicNamespace
        {
            get { return this._syncWithPublicNamespace; }
            set { this._syncWithPublicNamespace = value; }
        }

        // Check to see if SyncWithPublicNamespace property is set
        internal bool IsSetSyncWithPublicNamespace()
        {
            return this._syncWithPublicNamespace.HasValue; 
        }

    }
}