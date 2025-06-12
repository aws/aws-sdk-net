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
    /// This is the response object from the GetStorageProfileForQueue operation.
    /// </summary>
    public partial class GetStorageProfileForQueueResponse : AmazonWebServiceResponse
    {
        private string _displayName;
        private List<FileSystemLocation> _fileSystemLocations = AWSConfigs.InitializeCollections ? new List<FileSystemLocation>() : null;
        private StorageProfileOperatingSystemFamily _osFamily;
        private string _storageProfileId;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the storage profile connected to a queue.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        /// The location of the files for the storage profile within the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<FileSystemLocation> FileSystemLocations
        {
            get { return this._fileSystemLocations; }
            set { this._fileSystemLocations = value; }
        }

        // Check to see if FileSystemLocations property is set
        internal bool IsSetFileSystemLocations()
        {
            return this._fileSystemLocations != null && (this._fileSystemLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OsFamily. 
        /// <para>
        /// The operating system of the storage profile in the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The storage profile ID.
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