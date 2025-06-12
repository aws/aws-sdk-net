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
    /// This is the response object from the UpdateUser operation.
    /// </summary>
    public partial class UpdateUserResponse : AmazonWebServiceResponse
    {
        private List<UserAlias> _userAliasesAdded = AWSConfigs.InitializeCollections ? new List<UserAlias>() : null;
        private List<UserAlias> _userAliasesDeleted = AWSConfigs.InitializeCollections ? new List<UserAlias>() : null;
        private List<UserAlias> _userAliasesUpdated = AWSConfigs.InitializeCollections ? new List<UserAlias>() : null;

        /// <summary>
        /// Gets and sets the property UserAliasesAdded. 
        /// <para>
        /// The user aliases that have been to be added to a user id.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserAlias> UserAliasesAdded
        {
            get { return this._userAliasesAdded; }
            set { this._userAliasesAdded = value; }
        }

        // Check to see if UserAliasesAdded property is set
        internal bool IsSetUserAliasesAdded()
        {
            return this._userAliasesAdded != null && (this._userAliasesAdded.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserAliasesDeleted. 
        /// <para>
        /// The user aliases that have been deleted from a user id.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserAlias> UserAliasesDeleted
        {
            get { return this._userAliasesDeleted; }
            set { this._userAliasesDeleted = value; }
        }

        // Check to see if UserAliasesDeleted property is set
        internal bool IsSetUserAliasesDeleted()
        {
            return this._userAliasesDeleted != null && (this._userAliasesDeleted.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserAliasesUpdated. 
        /// <para>
        /// The user aliases attached to a user id that have been updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserAlias> UserAliasesUpdated
        {
            get { return this._userAliasesUpdated; }
            set { this._userAliasesUpdated = value; }
        }

        // Check to see if UserAliasesUpdated property is set
        internal bool IsSetUserAliasesUpdated()
        {
            return this._userAliasesUpdated != null && (this._userAliasesUpdated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}