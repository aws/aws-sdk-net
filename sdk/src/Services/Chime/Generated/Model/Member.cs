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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The member details, such as email address, name, member ID, and member type.
    /// </summary>
    public partial class Member
    {
        private string _accountId;
        private string _email;
        private string _fullName;
        private string _memberId;
        private MemberType _memberType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Email. 
        /// <para>
        /// The member email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property FullName. 
        /// <para>
        /// The member name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string FullName
        {
            get { return this._fullName; }
            set { this._fullName = value; }
        }

        // Check to see if FullName property is set
        internal bool IsSetFullName()
        {
            return this._fullName != null;
        }

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The member ID (user ID or bot ID).
        /// </para>
        /// </summary>
        public string MemberId
        {
            get { return this._memberId; }
            set { this._memberId = value; }
        }

        // Check to see if MemberId property is set
        internal bool IsSetMemberId()
        {
            return this._memberId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// The member type.
        /// </para>
        /// </summary>
        public MemberType MemberType
        {
            get { return this._memberType; }
            set { this._memberType = value; }
        }

        // Check to see if MemberType property is set
        internal bool IsSetMemberType()
        {
            return this._memberType != null;
        }

    }
}