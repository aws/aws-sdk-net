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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property GlobalAccelerator. 
        /// <para>
        /// Indicates the Global Accelerator properties.
        /// </para>
        /// </summary>
        public GlobalAcceleratorForDirectory GlobalAccelerator { get; set; }

        /// <summary>
        /// Checks to see if the GlobalAccelerator property is set.
        /// </summary>
        internal bool IsSetGlobalAccelerator() => this.GlobalAccelerator != null;

        /// <summary>
        /// Gets and sets the property StorageConnectors. 
        /// <para>
        /// Indicates the storage connector used 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<StorageConnector> StorageConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<StorageConnector>() : null;

        /// <summary>
        /// Checks to see if the StorageConnectors property is set.
        /// </summary>
        internal bool IsSetStorageConnectors() => this.StorageConnectors != null && (this.StorageConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StreamingExperiencePreferredProtocol. 
        /// <para>
        /// Indicates the type of preferred protocol for the streaming experience.
        /// </para>
        /// </summary>
        public StreamingExperiencePreferredProtocolEnum StreamingExperiencePreferredProtocol { get; set; }

        /// <summary>
        /// Checks to see if the StreamingExperiencePreferredProtocol property is set.
        /// </summary>
        internal bool IsSetStreamingExperiencePreferredProtocol() => this.StreamingExperiencePreferredProtocol != null;

        /// <summary>
        /// Gets and sets the property UserSettings. 
        /// <para>
        /// Indicates the permission settings asscoiated with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<UserSetting> UserSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<UserSetting>() : null;

        /// <summary>
        /// Checks to see if the UserSettings property is set.
        /// </summary>
        internal bool IsSetUserSettings() => this.UserSettings != null && (this.UserSettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
