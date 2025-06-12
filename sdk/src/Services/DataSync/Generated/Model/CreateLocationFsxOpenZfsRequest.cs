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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLocationFsxOpenZfs operation.
    /// Creates a transfer <i>location</i> for an Amazon FSx for OpenZFS file system. DataSync
    /// can use this location as a source or destination for transferring data.
    /// 
    ///  
    /// <para>
    /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-openzfs-location.html#create-openzfs-access">accesses
    /// FSx for OpenZFS file systems</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Request parameters related to <c>SMB</c> aren't supported with the <c>CreateLocationFsxOpenZfs</c>
    /// operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateLocationFsxOpenZfsRequest : AmazonDataSyncRequest
    {
        private string _fsxFilesystemArn;
        private FsxProtocol _protocol;
        private List<string> _securityGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subdirectory;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;

        /// <summary>
        /// Gets and sets the property FsxFilesystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the FSx for OpenZFS file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FsxFilesystemArn
        {
            get { return this._fsxFilesystemArn; }
            set { this._fsxFilesystemArn = value; }
        }

        // Check to see if FsxFilesystemArn property is set
        internal bool IsSetFsxFilesystemArn()
        {
            return this._fsxFilesystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The type of protocol that DataSync uses to access your file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FsxProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// The ARNs of the security groups that are used to configure the FSx for OpenZFS file
        /// system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && (this._securityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the location's path that must begin with <c>/fsx</c>. DataSync uses
        /// this subdirectory to read or write data (depending on whether the file system is a
        /// source or destination location).
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents a tag that you want to add to the resource. The
        /// value can be an empty string. This value helps you manage, filter, and search for
        /// your resources. We recommend that you create a name tag for your location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}