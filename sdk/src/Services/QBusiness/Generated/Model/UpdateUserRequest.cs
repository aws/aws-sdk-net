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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUser operation.
    /// Updates a information associated with a user id.
    /// </summary>
    public partial class UpdateUserRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private List<UserAlias> _userAliasesToDelete = AWSConfigs.InitializeCollections ? new List<UserAlias>() : null;
        private List<UserAlias> _userAliasesToUpdate = AWSConfigs.InitializeCollections ? new List<UserAlias>() : null;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application the user is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property UserAliasesToDelete. 
        /// <para>
        /// The user aliases attached to the user id that are to be deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserAlias> UserAliasesToDelete
        {
            get { return this._userAliasesToDelete; }
            set { this._userAliasesToDelete = value; }
        }

        // Check to see if UserAliasesToDelete property is set
        internal bool IsSetUserAliasesToDelete()
        {
            return this._userAliasesToDelete != null && (this._userAliasesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserAliasesToUpdate. 
        /// <para>
        /// The user aliases attached to the user id that are to be updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserAlias> UserAliasesToUpdate
        {
            get { return this._userAliasesToUpdate; }
            set { this._userAliasesToUpdate = value; }
        }

        // Check to see if UserAliasesToUpdate property is set
        internal bool IsSetUserAliasesToUpdate()
        {
            return this._userAliasesToUpdate != null && (this._userAliasesToUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The email id attached to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}