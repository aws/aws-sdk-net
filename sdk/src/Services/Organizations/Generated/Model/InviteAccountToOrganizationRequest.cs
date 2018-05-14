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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the InviteAccountToOrganization operation.
    /// Sends an invitation to another account to join your organization as a member account.
    /// Organizations sends email on your behalf to the email address that is associated with
    /// the other account's owner. The invitation is implemented as a <a>Handshake</a> whose
    /// details are in the response.
    /// 
    ///  <important> <ul> <li> 
    /// <para>
    /// You can invite AWS accounts only from the same seller as the master account. For example,
    /// if your organization's master account was created by Amazon Internet Services Pvt.
    /// Ltd (AISPL), an AWS seller in India, then you can only invite other AISPL accounts
    /// to your organization. You can't combine accounts from AISPL and AWS, or any other
    /// AWS seller. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/useconsolidatedbilliing-India.html">Consolidated
    /// Billing in India</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you receive an exception that indicates that you exceeded your account limits for
    /// the organization or that the operation failed because your organization is still initializing,
    /// wait one hour and then try again. If the error persists after an hour, then contact
    /// <a href="https://console.aws.amazon.com/support/home#/">AWS Customer Support</a>.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    /// </summary>
    public partial class InviteAccountToOrganizationRequest : AmazonOrganizationsRequest
    {
        private string _notes;
        private HandshakeParty _target;

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        /// Additional information that you want to include in the generated email to the recipient
        /// account owner.
        /// </para>
        /// </summary>
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The identifier (ID) of the AWS account that you want to invite to join your organization.
        /// This is a JSON object that contains the following elements: 
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "Type": "ACCOUNT", "Id": "&lt;<i> <b>account id number</b> </i>&gt;" }</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you use the AWS CLI, you can submit this as a single string, similar to the following
        /// example:
        /// </para>
        ///  
        /// <para>
        ///  <code>--target Id=123456789012,Type=ACCOUNT</code> 
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>"Type": "ACCOUNT"</code>, then you must provide the AWS account
        /// ID number as the <code>Id</code>. If you specify <code>"Type": "EMAIL"</code>, then
        /// you must specify the email address that is associated with the account.
        /// </para>
        ///  
        /// <para>
        ///  <code>--target Id=bill@example.com,Type=EMAIL</code> 
        /// </para>
        /// </summary>
        public HandshakeParty Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}