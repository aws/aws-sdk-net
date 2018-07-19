/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateMemberAccount operation.
    /// Associates a specified AWS account with Amazon Macie as a member account.
    /// </summary>
    public partial class AssociateMemberAccountRequest : AmazonMacieRequest
    {
        private string _memberAccountId;

        /// <summary>
        /// Gets and sets the property MemberAccountId. 
        /// <para>
        /// The ID of the AWS account that you want to associate with Amazon Macie as a member
        /// account.
        /// </para>
        /// </summary>
        public string MemberAccountId
        {
            get { return this._memberAccountId; }
            set { this._memberAccountId = value; }
        }

        // Check to see if MemberAccountId property is set
        internal bool IsSetMemberAccountId()
        {
            return this._memberAccountId != null;
        }

    }
}