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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the streaming properties.
    /// </summary>
    public partial class StreamingProperties
    {
        private GlobalAcceleratorForDirectory _globalAccelerator;
        private List<StorageConnector> _storageConnectors = AWSConfigs.InitializeCollections ? new List<StorageConnector>() : null;
        private StreamingExperiencePreferredProtocolEnum _streamingExperiencePreferredProtocol;
        private List<UserSetting> _userSettings = AWSConfigs.InitializeCollections ? new List<UserSetting>() : null;

        /// <summary>
        /// Gets and sets the property GlobalAccelerator. 
        /// <para>
        /// Indicates the Global Accelerator properties.
        /// </para>
        /// </summary>
        public GlobalAcceleratorForDirectory GlobalAccelerator
        {
            get { return this._globalAccelerator; }
            set { this._globalAccelerator = value; }
        }

        // Check to see if GlobalAccelerator property is set
        internal bool IsSetGlobalAccelerator()
        {
            return this._globalAccelerator != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConnectors. 
        /// <para>
        /// Indicates the storage connector used 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<StorageConnector> StorageConnectors
        {
            get { return this._storageConnectors; }
            set { this._storageConnectors = value; }
        }

        // Check to see if StorageConnectors property is set
        internal bool IsSetStorageConnectors()
        {
            return this._storageConnectors != null && (this._storageConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StreamingExperiencePreferredProtocol. 
        /// <para>
        /// Indicates the type of preferred protocol for the streaming experience.
        /// </para>
        /// </summary>
        public StreamingExperiencePreferredProtocolEnum StreamingExperiencePreferredProtocol
        {
            get { return this._streamingExperiencePreferredProtocol; }
            set { this._streamingExperiencePreferredProtocol = value; }
        }

        // Check to see if StreamingExperiencePreferredProtocol property is set
        internal bool IsSetStreamingExperiencePreferredProtocol()
        {
            return this._streamingExperiencePreferredProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property UserSettings. 
        /// <para>
        /// Indicates the permission settings asscoiated with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<UserSetting> UserSettings
        {
            get { return this._userSettings; }
            set { this._userSettings = value; }
        }

        // Check to see if UserSettings property is set
        internal bool IsSetUserSettings()
        {
            return this._userSettings != null && (this._userSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}