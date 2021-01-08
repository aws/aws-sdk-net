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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserIdentityInfo operation.
    /// Updates the identity information for the specified user.
    /// 
    ///  <important> 
    /// <para>
    /// Someone with the ability to invoke <code>UpdateUserIndentityInfo</code> can change
    /// the login credentials of other users by changing their email address. This poses a
    /// security risk to your organization. They can change the email address of a user to
    /// the attacker's email address, and then reset the password through email. We strongly
    /// recommend limiting who has the ability to invoke <code>UpdateUserIndentityInfo</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-profile-best-practices.html">Best
    /// Practices for Security Profiles</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateUserIdentityInfoRequest : AmazonConnectRequest
    {
        private UserIdentityInfo _identityInfo;
        private string _instanceId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property IdentityInfo. 
        /// <para>
        /// The identity information for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserIdentityInfo IdentityInfo
        {
            get { return this._identityInfo; }
            set { this._identityInfo = value; }
        }

        // Check to see if IdentityInfo property is set
        internal bool IsSetIdentityInfo()
        {
            return this._identityInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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