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
    /// Container for the parameters to the BatchAddRole operation.
    /// Add role to multiple users or groups in a private re:Post.
    /// </summary>
    public partial class BatchAddRoleRequest : AmazonRepostspaceRequest
    {
        private List<string> _accessorIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Role _role;
        private string _spaceId;

        /// <summary>
        /// Gets and sets the property AccessorIds. 
        /// <para>
        /// The user or group accessor identifiers to add the role to.
        /// </para>
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The role to add to the users or groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Role Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
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