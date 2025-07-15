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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// Container for the parameters to the BatchAddChannelRoleToAccessors operation.
    /// Add role to multiple users or groups in a private re:Post channel.
    /// </summary>
    public partial class BatchAddChannelRoleToAccessorsRequest : AmazonRepostspaceRequest
    {
        private List<string> _accessorIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _channelId;
        private ChannelRole _channelRole;
        private string _spaceId;

        /// <summary>
        /// Gets and sets the property AccessorIds. 
        /// <para>
        /// The user or group identifiers to add the role to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<string> AccessorIds
        {
            get { return this._accessorIds; }
            set { this._accessorIds = value; }
        }

        // Check to see if AccessorIds property is set
        internal bool IsSetAccessorIds()
        {
            return this._accessorIds != null && (this._accessorIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The unique ID of the private re:Post channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelRole. 
        /// <para>
        /// The channel role to add to the users or groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelRole ChannelRole
        {
            get { return this._channelRole; }
            set { this._channelRole = value; }
        }

        // Check to see if ChannelRole property is set
        internal bool IsSetChannelRole()
        {
            return this._channelRole != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpaceId
        {
            get { return this._spaceId; }
            set { this._spaceId = value; }
        }

        // Check to see if SpaceId property is set
        internal bool IsSetSpaceId()
        {
            return this._spaceId != null;
        }

    }
}