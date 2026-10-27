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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStorageProfile operation. Creates a storage
    /// profile that specifies the operating system, file type, and file location of resources
    /// used on a farm.
    /// </summary>
    public partial class CreateStorageProfileRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. The unique token which the server uses to
        /// recognize retries of the same request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the storage profile.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the farm to connect to the storage
        /// profile.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FileSystemLocations. File system paths to include in the
        /// storage profile.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<FileSystemLocation> FileSystemLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<FileSystemLocation>() : null;

        /// <summary>
        /// Checks to see if the FileSystemLocations property is set.
        /// </summary>
        internal bool IsSetFileSystemLocations() => this.FileSystemLocations != null && (this.FileSystemLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OsFamily. The type of operating system (OS) for the storage
        /// profile.
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageProfileOperatingSystemFamily OsFamily { get; set; }

        /// <summary>
        /// Checks to see if the OsFamily property is set.
        /// </summary>
        internal bool IsSetOsFamily() => this.OsFamily != null;
    }
}
