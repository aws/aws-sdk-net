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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccount operation.
    /// Creates an Amazon Web Services account that is automatically a member of the organization
    /// whose credentials made the request. This is an asynchronous request that Amazon Web
    /// Services performs in the background. Because <code>CreateAccount</code> operates asynchronously,
    /// it can return a successful completion message even though account initialization might
    /// still be in progress. You might need to wait a few minutes before you can successfully
    /// access the account. To check the status of the request, do one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Use the <code>Id</code> value of the <code>CreateAccountStatus</code> response element
    /// from this operation to provide as a parameter to the <a>DescribeCreateAccountStatus</a>
    /// operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Check the CloudTrail log for the <code>CreateAccountResult</code> event. For information
    /// on using CloudTrail with Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_security_incident-response.html#orgs_cloudtrail-integration">Logging
    /// and monitoring in Organizations</a> in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The user who calls the API to create an account must have the <code>organizations:CreateAccount</code>
    /// permission. If you enabled all features in the organization, Organizations creates
    /// the required service-linked role named <code>AWSServiceRoleForOrganizations</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_integrate_services-using_slrs">Organizations
    /// and Service-Linked Roles</a> in the <i>Organizations User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
    /// permission.
    /// </para>
    ///  
    /// <para>
    /// Organizations preconfigures the new member account with a role (named <code>OrganizationAccountAccessRole</code>
    /// by default) that grants users in the management account administrator permissions
    /// in the new member account. Principals in the management account can assume the role.
    /// Organizations clones the company name and address information for the new account
    /// from the organization's management account.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account.
    /// </para>
    ///  
    /// <para>
    /// For more information about creating accounts, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_create.html">Creating
    /// an Amazon Web Services account in Your Organization</a> in the <i>Organizations User
    /// Guide.</i> 
    /// </para>
    ///  <important> <ul> <li> 
    /// <para>
    /// When you create an account in an organization using the Organizations console, API,
    /// or CLI commands, the information required for the account to operate as a standalone
    /// account, such as a payment method and signing the end user license agreement (EULA)
    /// is <i>not</i> automatically collected. If you must remove an account from your organization
    /// later, you can do so only after you provide the missing information. Follow the steps
    /// at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
    /// To leave an organization as a member account</a> in the <i>Organizations User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you get an exception that indicates that you exceeded your account limits for the
    /// organization, contact <a href="https://console.aws.amazon.com/support/home#/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you get an exception that indicates that the operation failed because your organization
    /// is still initializing, wait one hour and then try again. If the error persists, contact
    /// <a href="https://console.aws.amazon.com/support/home#/">Amazon Web Services Support</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Using <code>CreateAccount</code> to create multiple temporary accounts isn't recommended.
    /// You can only close an account from the Billing and Cost Management console, and you
    /// must be signed in as the root user. For information on the requirements and process
    /// for closing an account, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_close.html">Closing
    /// an Amazon Web Services account</a> in the <i>Organizations User Guide</i>.
    /// </para>
    ///  </li> </ul> </important> <note> 
    /// <para>
    /// When you create a member account with this operation, you can choose whether to create
    /// the account with the <b>IAM User and Role Access to Billing Information</b> switch
    /// enabled. If you enable it, IAM users and roles that have appropriate permissions can
    /// view billing information for the account. If you disable it, only the account root
    /// user can access billing information. For information about how to disable this switch
    /// for an account, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html">Granting
    /// Access to Your Billing Information and Tools</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateAccountRequest : AmazonOrganizationsRequest
    {
        private string _accountName;
        private string _email;
        private IAMUserAccessToBilling _iamUserAccessToBilling;
        private string _roleName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The friendly name of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=50)]
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the owner to assign to the new member account. This email address
        /// must not already be associated with another Amazon Web Services account. You must
        /// use a valid email address to complete account creation.
        /// </para>
        ///  
        /// <para>
        /// The rules for a valid email address:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The address must be a minimum of 6 and a maximum of 64 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All characters must be 7-bit ASCII characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There must be one and only one @ symbol, which separates the local name from the domain
        /// name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The local name can't contain any of the following characters:
        /// </para>
        ///  
        /// <para>
        /// whitespace, " ' ( ) &lt; &gt; [ ] : ; , \ | % &amp;
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The local name can't begin with a dot (.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain name can consist of only the characters [a-z],[A-Z],[0-9], hyphen (-),
        /// or dot (.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain name can't begin or end with a hyphen (-) or dot (.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain name must contain at least one dot
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't access the root user of the account or remove an account that was created
        /// with an invalid email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=6, Max=64)]
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
        /// Gets and sets the property IamUserAccessToBilling. 
        /// <para>
        /// If set to <code>ALLOW</code>, the new account enables IAM users to access account
        /// billing information <i>if</i> they have the required permissions. If set to <code>DENY</code>,
        /// only the root user of the new account can access account billing information. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate">Activating
        /// Access to the Billing and Cost Management Console</a> in the <i>Amazon Web Services
        /// Billing and Cost Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, the value defaults to <code>ALLOW</code>, and
        /// IAM users and roles with the required permissions can access billing information for
        /// the new account.
        /// </para>
        /// </summary>
        public IAMUserAccessToBilling IamUserAccessToBilling
        {
            get { return this._iamUserAccessToBilling; }
            set { this._iamUserAccessToBilling = value; }
        }

        // Check to see if IamUserAccessToBilling property is set
        internal bool IsSetIamUserAccessToBilling()
        {
            return this._iamUserAccessToBilling != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of an IAM role that Organizations automatically preconfigures in the new
        /// member account. This role trusts the management account, allowing users in the management
        /// account to assume the role, as permitted by the management account administrator.
        /// The role has administrator permissions in the new member account.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, the role name defaults to <code>OrganizationAccountAccessRole</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use this role to access the member account, see
        /// the following links:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_access.html#orgs_manage_accounts_create-cross-account-role">Accessing
        /// and Administering the Member Accounts in Your Organization</a> in the <i>Organizations
        /// User Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Steps 2 and 3 in <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_cross-account-with-roles.html">Tutorial:
        /// Delegate Access Across Amazon Web Services accounts Using IAM Roles</a> in the <i>IAM
        /// User Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter. The pattern can include uppercase letters, lowercase letters, digits
        /// with no spaces, and any of the following characters: =,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the newly created account. For each tag
        /// in the list, you must specify both a tag key and a value. You can set the value to
        /// an empty string, but you can't set it to <code>null</code>. For more information about
        /// tagging, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tagging.html">Tagging
        /// Organizations resources</a> in the Organizations User Guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the maximum allowed number of tags
        /// for an account, then the entire request fails and the account is not created.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}