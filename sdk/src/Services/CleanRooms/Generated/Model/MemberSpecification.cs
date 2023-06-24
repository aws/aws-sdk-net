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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Basic metadata used to construct a new member.
    /// </summary>
    public partial class MemberSpecification
    {
        private string _accountId;
        private string _displayName;
        private List<string> _memberAbilities = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The identifier used to reference members of the collaboration. Currently only supports
        /// AWS Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The member's display name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property MemberAbilities. 
        /// <para>
        /// The abilities granted to the collaboration member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MemberAbilities
        {
            get { return this._memberAbilities; }
            set { this._memberAbilities = value; }
        }

        // Check to see if MemberAbilities property is set
        internal bool IsSetMemberAbilities()
        {
            return this._memberAbilities != null && this._memberAbilities.Count > 0; 
        }

    }
}