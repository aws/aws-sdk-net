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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the InviteUsers operation.
    /// Sends email to a maximum of 50 users, inviting them to the specified Amazon Chime
    /// <c>Team</c> account. Only <c>Team</c> account types are currently supported for this
    /// action.
    /// </summary>
    public partial class InviteUsersRequest : AmazonChimeRequest
    {
        private string _accountId;
        private List<string> _userEmailList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UserType _userType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property UserEmailList. 
        /// <para>
        /// The user email addresses to which to send the email invitation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public List<string> UserEmailList
        {
            get { return this._userEmailList; }
            set { this._userEmailList = value; }
        }

        // Check to see if UserEmailList property is set
        internal bool IsSetUserEmailList()
        {
            return this._userEmailList != null && (this._userEmailList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserType. 
        /// <para>
        /// The user type.
        /// </para>
        /// </summary>
        public UserType UserType
        {
            get { return this._userType; }
            set { this._userType = value; }
        }

        // Check to see if UserType property is set
        internal bool IsSetUserType()
        {
            return this._userType != null;
        }

    }
}