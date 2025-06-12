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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
    /// Container for the parameters to the UpdateStorageProfile operation.
    /// Updates a storage profile.
    /// </summary>
    public partial class UpdateStorageProfileRequest : AmazonDeadlineRequest
    {
        private string _clientToken;
        private string _displayName;
        private string _farmId;
        private List<FileSystemLocation> _fileSystemLocationsToAdd = AWSConfigs.InitializeCollections ? new List<FileSystemLocation>() : null;
        private List<FileSystemLocation> _fileSystemLocationsToRemove = AWSConfigs.InitializeCollections ? new List<FileSystemLocation>() : null;
        private StorageProfileOperatingSystemFamily _osFamily;
        private string _storageProfileId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the storage profile to update.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemLocationsToAdd. 
        /// <para>
        /// The file system location names to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<FileSystemLocation> FileSystemLocationsToAdd
        {
            get { return this._fileSystemLocationsToAdd; }
            set { this._fileSystemLocationsToAdd = value; }
        }

        // Check to see if FileSystemLocationsToAdd property is set
        internal bool IsSetFileSystemLocationsToAdd()
        {
            return this._fileSystemLocationsToAdd != null && (this._fileSystemLocationsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FileSystemLocationsToRemove. 
        /// <para>
        /// The file system location names to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<FileSystemLocation> FileSystemLocationsToRemove
        {
            get { return this._fileSystemLocationsToRemove; }
            set { this._fileSystemLocationsToRemove = value; }
        }

        // Check to see if FileSystemLocationsToRemove property is set
        internal bool IsSetFileSystemLocationsToRemove()
        {
            return this._fileSystemLocationsToRemove != null && (this._fileSystemLocationsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OsFamily. 
        /// <para>
        /// The OS system to update.
        /// </para>
        /// </summary>
        public StorageProfileOperatingSystemFamily OsFamily
        {
            get { return this._osFamily; }
            set { this._osFamily = value; }
        }

        // Check to see if OsFamily property is set
        internal bool IsSetOsFamily()
        {
            return this._osFamily != null;
        }

        /// <summary>
        /// Gets and sets the property StorageProfileId. 
        /// <para>
        /// The storage profile ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StorageProfileId
        {
            get { return this._storageProfileId; }
            set { this._storageProfileId = value; }
        }

        // Check to see if StorageProfileId property is set
        internal bool IsSetStorageProfileId()
        {
            return this._storageProfileId != null;
        }

    }
}