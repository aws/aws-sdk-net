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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUserGroup operation.
    /// For Redis engine version 6.0 onwards: Creates a Redis user group. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Clusters.RBAC.html">Using
    /// Role Based Access Control (RBAC)</a>
    /// </summary>
    public partial class CreateUserGroupRequest : AmazonElastiCacheRequest
    {
        private string _engine;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userGroupId;
        private List<string> _userIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The current supported value is Redis. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted. Available for Redis
        /// only.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The ID of the user group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserGroupId
        {
            get { return this._userGroupId; }
            set { this._userGroupId = value; }
        }

        // Check to see if UserGroupId property is set
        internal bool IsSetUserGroupId()
        {
            return this._userGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The list of user IDs that belong to the user group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && (this._userIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}