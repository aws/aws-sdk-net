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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMembers operation.
    /// Sends a request to invite the specified AWS accounts to be member accounts in the
    /// behavior graph. This operation can only be called by the master account for a behavior
    /// graph. 
    /// 
    ///  
    /// <para>
    ///  <code>CreateMembers</code> verifies the accounts and then sends invitations to the
    /// verified accounts.
    /// </para>
    ///  
    /// <para>
    /// The request provides the behavior graph ARN and the list of accounts to invite.
    /// </para>
    ///  
    /// <para>
    /// The response separates the requested accounts into two lists:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The accounts that <code>CreateMembers</code> was able to start the verification for.
    /// This list includes member accounts that are being verified, that have passed verification
    /// and are being sent an invitation, and that have failed verification.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The accounts that <code>CreateMembers</code> was unable to process. This list includes
    /// accounts that were already invited to be member accounts in the behavior graph.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateMembersRequest : AmazonDetectiveRequest
    {
        private List<Account> _accounts = new List<Account>();
        private string _graphArn;
        private string _message;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The list of AWS accounts to invite to become member accounts in the behavior graph.
        /// For each invited account, the account list contains the account identifier and the
        /// AWS account root user email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<Account> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && this._accounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph to invite the member accounts to contribute their data
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GraphArn
        {
            get { return this._graphArn; }
            set { this._graphArn = value; }
        }

        // Check to see if GraphArn property is set
        internal bool IsSetGraphArn()
        {
            return this._graphArn != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Customized message text to include in the invitation email message to the invited
        /// member accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}