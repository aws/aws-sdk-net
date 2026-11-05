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
    /// Container for the parameters to the ModifyUserGroup operation. Changes the list of
    /// users that belong to the user group.
    /// </summary>
    public partial class ModifyUserGroupRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Modifies the engine listed in a user group. The options are valkey or redis.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The ID of the user group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupId property is set.
        /// </summary>
        internal bool IsSetUserGroupId() => this.UserGroupId != null;

        /// <summary>
        /// Gets and sets the property UserIdsToAdd. 
        /// <para>
        /// The list of user IDs to add to the user group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> UserIdsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserIdsToAdd property is set.
        /// </summary>
        internal bool IsSetUserIdsToAdd() => this.UserIdsToAdd != null && (this.UserIdsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserIdsToRemove. 
        /// <para>
        /// The list of user IDs to remove from the user group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> UserIdsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserIdsToRemove property is set.
        /// </summary>
        internal bool IsSetUserIdsToRemove() => this.UserIdsToRemove != null && (this.UserIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
