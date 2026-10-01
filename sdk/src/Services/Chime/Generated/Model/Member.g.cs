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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The member details, such as email address, name, member ID, and member type.
    /// </summary>
    public partial class Member
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The member email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property FullName. 
        /// <para>
        /// The member name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Checks to see if the FullName property is set.
        /// </summary>
        internal bool IsSetFullName() => this.FullName != null;

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The member ID (user ID or bot ID).
        /// </para>
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// Checks to see if the MemberId property is set.
        /// </summary>
        internal bool IsSetMemberId() => this.MemberId != null;

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// The member type.
        /// </para>
        /// </summary>
        public MemberType MemberType { get; set; }

        /// <summary>
        /// Checks to see if the MemberType property is set.
        /// </summary>
        internal bool IsSetMemberType() => this.MemberType != null;
    }
}
