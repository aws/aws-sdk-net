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
    /// Returns the updates being applied to the user group.
    /// </summary>
    public partial class UserGroupPendingChanges
    {
        private List<string> _userIdsToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _userIdsToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property UserIdsToAdd. 
        /// <para>
        /// The list of user IDs to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserIdsToAdd
        {
            get { return this._userIdsToAdd; }
            set { this._userIdsToAdd = value; }
        }

        // Check to see if UserIdsToAdd property is set
        internal bool IsSetUserIdsToAdd()
        {
            return this._userIdsToAdd != null && (this._userIdsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserIdsToRemove. 
        /// <para>
        /// The list of user IDs to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserIdsToRemove
        {
            get { return this._userIdsToRemove; }
            set { this._userIdsToRemove = value; }
        }

        // Check to see if UserIdsToRemove property is set
        internal bool IsSetUserIdsToRemove()
        {
            return this._userIdsToRemove != null && (this._userIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}