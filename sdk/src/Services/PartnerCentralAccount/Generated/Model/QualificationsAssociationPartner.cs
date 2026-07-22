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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Identifies a partner in a qualifications association group. Contains the partner's
    /// profile identifier and AWS account identifier. In requests, provide at least one of
    /// <c>ProfileId</c> or <c>AccountId</c>. In responses, both fields are populated.
    /// </summary>
    public partial class QualificationsAssociationPartner
    {
        private string _accountId;
        private string _profileId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit AWS account ID linked to the partner profile. Required in requests if
        /// <c>ProfileId</c> is not provided.
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
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier for the partner profile, in the format <c>pprofile-*</c>. Required
        /// in requests if <c>AccountId</c> is not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

    }
}