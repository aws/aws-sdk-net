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
    /// The status of the user group update.
    /// </summary>
    public partial class UserGroupsUpdateStatus
    {
        private List<string> _userGroupIdsToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _userGroupIdsToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property UserGroupIdsToAdd. 
        /// <para>
        /// The ID of the user group to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroupIdsToAdd
        {
            get { return this._userGroupIdsToAdd; }
            set { this._userGroupIdsToAdd = value; }
        }

        // Check to see if UserGroupIdsToAdd property is set
        internal bool IsSetUserGroupIdsToAdd()
        {
            return this._userGroupIdsToAdd != null && (this._userGroupIdsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserGroupIdsToRemove. 
        /// <para>
        /// The ID of the user group to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroupIdsToRemove
        {
            get { return this._userGroupIdsToRemove; }
            set { this._userGroupIdsToRemove = value; }
        }

        // Check to see if UserGroupIdsToRemove property is set
        internal bool IsSetUserGroupIdsToRemove()
        {
            return this._userGroupIdsToRemove != null && (this._userGroupIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}