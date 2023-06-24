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
    /// Container for the parameters to the CreateGovCloudAccount operation.
    /// This action is available if all of the following are true:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You're authorized to create accounts in the Amazon Web Services GovCloud (US) Region.
    /// For more information on the Amazon Web Services GovCloud (US) Region, see the <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/welcome.html">
    /// <i>Amazon Web Services GovCloud User Guide</i>.</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You already have an account in the Amazon Web Services GovCloud (US) Region that is
    /// paired with a management account of an organization in the commercial Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You call this action from the management account of your organization in the commercial
    /// Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You have the <code>organizations:CreateGovCloudAccount</code> permission. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Organizations automatically creates the required service-linked role named <code>AWSServiceRoleForOrganizations</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_integrate_services-using_slrs">Organizations
    /// and Service-Linked Roles</a> in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services automatically enables CloudTrail for Amazon Web Services GovCloud
    /// (US) accounts, but you should also do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Verify that CloudTrail is enabled to store logs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create an Amazon S3 bucket for CloudTrail log storage.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/verifying-cloudtrail.html">Verifying
    /// CloudTrail Is Enabled</a> in the <i>Amazon Web Services GovCloud User Guide</i>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
    /// permission. The tags are attached to the commercial account associated with the GovCloud
    /// account, rather than the GovCloud account itself. To add tags to the GovCloud account,
    /// call the <a>TagResource</a> operation in the GovCloud Region after the new GovCloud
    /// account exists.
    /// </para>
    ///  
    /// <para>
    /// You call this action from the management account of your organization in the commercial
    /// Region to create a standalone Amazon Web Services account in the Amazon Web Services
    /// GovCloud (US) Region. After the account is created, the management account of an organization
    /// in the Amazon Web Services GovCloud (US) Region can invite it to that organization.
    /// For more information on inviting standalone accounts in the Amazon Web Services GovCloud
    /// (US) to join an organization, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
    /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// Calling <code>CreateGovCloudAccount</code> is an asynchronous request that Amazon
    /// Web Services performs in the background. Because <code>CreateGovCloudAccount</code>
    /// operates asynchronously, it can return a successful completion message even though
    /// account initialization might still be in progress. You might need to wait a few minutes
    /// before you can successfully access the account. To check the status of the request,
    /// do one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <code>OperationId</code> response element from this operation to provide as
    /// a parameter to the <a>DescribeCreateAccountStatus</a> operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Check the CloudTrail log for the <code>CreateAccountResult</code> event. For information
    /// on using CloudTrail with Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_monitoring.html">Monitoring
    /// the Activity in Your Organization</a> in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  </li> </ul>  
    /// <para>
    /// When you call the <code>CreateGovCloudAccount</code> action, you create two accounts:
    /// a standalone account in the Amazon Web Services GovCloud (US) Region and an associated
    /// account in the commercial Region for billing and support purposes. The account in
    /// the commercial Region is automatically a member of the organization whose credentials
    /// made the request. Both accounts are associated with the same email address.
    /// </para>
    ///  
    /// <para>
    /// A role is created in the new account in the commercial Region that allows the management
    /// account in the organization in the commercial Region to assume it. An Amazon Web Services
    /// GovCloud (US) account is then created and associated with the commercial account that
    /// you just created. A role is also created in the new Amazon Web Services GovCloud (US)
    /// account that can be assumed by the Amazon Web Services GovCloud (US) account that
    /// is associated with the management account of the commercial organization. For more
    /// information and to view a diagram that explains how account access works, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
    /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
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
    /// account is <i>not</i> automatically collected. This includes a payment method and
    /// signing the end user license agreement (EULA). If you must remove an account from
    /// your organization later, you can do so only after you provide the missing information.
    /// Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
    /// To leave an organization as a member account</a> in the <i>Organizations User Guide.</i>
    /// 
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
    /// Using <code>CreateGovCloudAccount</code> to create multiple temporary accounts isn't
    /// recommended. You can only close an account from the Amazon Web Services Billing and
    /// Cost Management console, and you must be signed in as the root user. For information
    /// on the requirements and process for closing an account, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_close.html">Closing
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
    public partial class CreateGovCloudAccountRequest : AmazonOrganizationsRequest
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
        ///  
        /// <para>
        /// The account name can consist of only the characters [a-z],[A-Z],[0-9], hyphen (-),
        /// or dot (.) You can't separate characters with a dash (–).
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
        /// Specifies the email address of the owner to assign to the new member account in the
        /// commercial Region. This email address must not already be associated with another
        /// Amazon Web Services account. You must use a valid email address to complete account
        /// creation.
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
        /// with an invalid email address. Like all request parameters for <code>CreateGovCloudAccount</code>,
        /// the request for the email address for the Amazon Web Services GovCloud (US) account
        /// originates from the commercial Region, not from the Amazon Web Services GovCloud (US)
        /// Region.
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
        /// If set to <code>ALLOW</code>, the new linked account in the commercial Region enables
        /// IAM users to access account billing information <i>if</i> they have the required permissions.
        /// If set to <code>DENY</code>, only the root user of the new account can access account
        /// billing information. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate">Activating
        /// Access to the Billing and Cost Management Console</a> in the <i>Amazon Web Services
        /// Billing and Cost Management User Guide.</i> 
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
        /// (Optional)
        /// </para>
        ///  
        /// <para>
        /// The name of an IAM role that Organizations automatically preconfigures in the new
        /// member accounts in both the Amazon Web Services GovCloud (US) Region and in the commercial
        /// Region. This role trusts the management account, allowing users in the management
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
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_access.html#orgs_manage_accounts_create-cross-account-role">Accessing
        /// and Administering the Member Accounts in Your Organization</a> in the <i>Organizations
        /// User Guide</i> and steps 2 and 3 in <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_cross-account-with-roles.html">Tutorial:
        /// Delegate Access Across Amazon Web Services accounts Using IAM Roles</a> in the <i>IAM
        /// User Guide.</i> 
        /// </para>
        ///  
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
        /// A list of tags that you want to attach to the newly created account. These tags are
        /// attached to the commercial account associated with the GovCloud account, and not to
        /// the GovCloud account itself. To add tags to the actual GovCloud account, call the
        /// <a>TagResource</a> operation in the GovCloud region after the new GovCloud account
        /// exists.
        /// </para>
        ///  
        /// <para>
        /// For each tag in the list, you must specify both a tag key and a value. You can set
        /// the value to an empty string, but you can't set it to <code>null</code>. For more
        /// information about tagging, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tagging.html">Tagging
        /// Organizations resources</a> in the Organizations User Guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is not valid or if you exceed the maximum allowed number of
        /// tags for an account, then the entire request fails and the account is not created.
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