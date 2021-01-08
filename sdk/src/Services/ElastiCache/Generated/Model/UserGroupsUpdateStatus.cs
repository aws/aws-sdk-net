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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The status of the user group update.
    /// </summary>
    public partial class UserGroupsUpdateStatus
    {
        private List<string> _userGroupIdsToAdd = new List<string>();
        private List<string> _userGroupIdsToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property UserGroupIdsToAdd. 
        /// <para>
        /// The list of user group IDs to add.
        /// </para>
        /// </summary>
        public List<string> UserGroupIdsToAdd
        {
            get { return this._userGroupIdsToAdd; }
            set { this._userGroupIdsToAdd = value; }
        }

        // Check to see if UserGroupIdsToAdd property is set
        internal bool IsSetUserGroupIdsToAdd()
        {
            return this._userGroupIdsToAdd != null && this._userGroupIdsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserGroupIdsToRemove. 
        /// <para>
        /// The list of user group IDs to remove.
        /// </para>
        /// </summary>
        public List<string> UserGroupIdsToRemove
        {
            get { return this._userGroupIdsToRemove; }
            set { this._userGroupIdsToRemove = value; }
        }

        // Check to see if UserGroupIdsToRemove property is set
        internal bool IsSetUserGroupIdsToRemove()
        {
            return this._userGroupIdsToRemove != null && this._userGroupIdsToRemove.Count > 0; 
        }

    }
}