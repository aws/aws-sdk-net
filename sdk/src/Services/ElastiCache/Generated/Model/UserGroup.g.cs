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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// </summary>
    public partial class UserGroup
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user group.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The options are valkey or redis.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The minimum engine version required, which is Redis OSS 6.0
        /// </para>
        /// </summary>
        public string MinimumEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinimumEngineVersion property is set.
        /// </summary>
        internal bool IsSetMinimumEngineVersion() => this.MinimumEngineVersion != null;

        /// <summary>
        /// Gets and sets the property PendingChanges. 
        /// <para>
        /// A list of updates being applied to the user group.
        /// </para>
        /// </summary>
        public UserGroupPendingChanges PendingChanges { get; set; }

        /// <summary>
        /// Checks to see if the PendingChanges property is set.
        /// </summary>
        internal bool IsSetPendingChanges() => this.PendingChanges != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroups. 
        /// <para>
        /// A list of replication groups that the user group can access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationGroups property is set.
        /// </summary>
        internal bool IsSetReplicationGroups() => this.ReplicationGroups != null && (this.ReplicationGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServerlessCaches. 
        /// <para>
        /// Indicates which serverless caches the specified user group is associated with. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServerlessCaches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ServerlessCaches property is set.
        /// </summary>
        internal bool IsSetServerlessCaches() => this.ServerlessCaches != null && (this.ServerlessCaches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates user group status. Can be "creating", "active", "modifying", "deleting".
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The ID of the user group.
        /// </para>
        /// </summary>
        public string UserGroupId { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupId property is set.
        /// </summary>
        internal bool IsSetUserGroupId() => this.UserGroupId != null;

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The list of user IDs that belong to the user group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserIds property is set.
        /// </summary>
        internal bool IsSetUserIds() => this.UserIds != null && (this.UserIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
