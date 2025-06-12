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
    /// This is the response object from the DeleteUserGroup operation.
    /// </summary>
    public partial class DeleteUserGroupResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _engine;
        private string _minimumEngineVersion;
        private UserGroupPendingChanges _pendingChanges;
        private List<string> _replicationGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _serverlessCaches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _status;
        private string _userGroupId;
        private List<string> _userIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user group.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The options are valkey or redis.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The minimum engine version required, which is Redis OSS 6.0
        /// </para>
        /// </summary>
        public string MinimumEngineVersion
        {
            get { return this._minimumEngineVersion; }
            set { this._minimumEngineVersion = value; }
        }

        // Check to see if MinimumEngineVersion property is set
        internal bool IsSetMinimumEngineVersion()
        {
            return this._minimumEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PendingChanges. 
        /// <para>
        /// A list of updates being applied to the user group.
        /// </para>
        /// </summary>
        public UserGroupPendingChanges PendingChanges
        {
            get { return this._pendingChanges; }
            set { this._pendingChanges = value; }
        }

        // Check to see if PendingChanges property is set
        internal bool IsSetPendingChanges()
        {
            return this._pendingChanges != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroups. 
        /// <para>
        /// A list of replication groups that the user group can access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationGroups
        {
            get { return this._replicationGroups; }
            set { this._replicationGroups = value; }
        }

        // Check to see if ReplicationGroups property is set
        internal bool IsSetReplicationGroups()
        {
            return this._replicationGroups != null && (this._replicationGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerlessCaches. 
        /// <para>
        /// Indicates which serverless caches the specified user group is associated with. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServerlessCaches
        {
            get { return this._serverlessCaches; }
            set { this._serverlessCaches = value; }
        }

        // Check to see if ServerlessCaches property is set
        internal bool IsSetServerlessCaches()
        {
            return this._serverlessCaches != null && (this._serverlessCaches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates user group status. Can be "creating", "active", "modifying", "deleting".
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The ID of the user group.
        /// </para>
        /// </summary>
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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