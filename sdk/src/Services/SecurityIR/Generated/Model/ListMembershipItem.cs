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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListMembershipItem
    {
        private string _accountId;
        private string _membershipArn;
        private string _membershipId;
        private MembershipStatus _membershipStatus;
        private AwsRegion _region;

        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property MembershipArn.
        /// </summary>
        [AWSProperty(Min=12, Max=80)]
        public string MembershipArn
        {
            get { return this._membershipArn; }
            set { this._membershipArn = value; }
        }

        // Check to see if MembershipArn property is set
        internal bool IsSetMembershipArn()
        {
            return this._membershipArn != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId.
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=34)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipStatus.
        /// </summary>
        public MembershipStatus MembershipStatus
        {
            get { return this._membershipStatus; }
            set { this._membershipStatus = value; }
        }

        // Check to see if MembershipStatus property is set
        internal bool IsSetMembershipStatus()
        {
            return this._membershipStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Region.
        /// </summary>
        public AwsRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}