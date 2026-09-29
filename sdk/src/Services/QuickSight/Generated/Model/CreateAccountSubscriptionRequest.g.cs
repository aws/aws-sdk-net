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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccountSubscription operation. Creates an
    /// Amazon Quick Sight account, or subscribes to Amazon Quick Sight Q. <para> The Amazon
    /// Web Services Region for the account is derived from what is configured in the CLI
    /// or SDK. </para> <para> Before you use this operation, make sure that you can connect
    /// to an existing Amazon Web Services account. If you don't have an Amazon Web Services
    /// account, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/setting-up-aws-sign-up.html">Sign
    /// up for Amazon Web Services</a> in the <i>Amazon Quick Sight User Guide</i>. The person
    /// who signs up for Amazon Quick Sight needs to have the correct Identity and Access
    /// Management (IAM) permissions. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/iam-policy-examples.html">IAM
    /// Policy Examples for Amazon Quick Sight</a> in the <i>Amazon Quick Sight User Guide</i>.
    /// </para> <para> If your IAM policy includes both the <c>Subscribe</c> and <c>CreateAccountSubscription</c>
    /// actions, make sure that both actions are set to <c>Allow</c>. If either action is
    /// set to <c>Deny</c>, the <c>Deny</c> action prevails and your API call fails. </para>
    /// <para> You can't pass an existing IAM role to access other Amazon Web Services services
    /// using this API operation. To pass your existing IAM role to Amazon Quick Sight, see
    /// <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html#security-create-iam-role">Passing
    /// IAM roles to Amazon Quick Sight</a> in the <i>Amazon Quick Sight User Guide</i>. </para>
    /// <para> You can't set default resource access on the new account from the Amazon Quick
    /// Sight API. Instead, add default resource access from the Amazon Quick Sight console.
    /// For more information about setting default resource access to Amazon Web Services
    /// services, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/scoping-policies-defaults.html">Setting
    /// default resource access to Amazon Web Services services</a> in the <i>Amazon Quick
    /// Sight User Guide</i>. </para>
    /// </summary>
    public partial class CreateAccountSubscriptionRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of your Amazon Quick Sight account. This name is unique over all of Amazon
        /// Web Services, and it appears only when users sign in. You can't change <c>AccountName</c>
        /// value after the Amazon Quick Sight account is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 62)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryName. 
        /// <para>
        /// The name of your Active Directory. This field is required if <c>ACTIVE_DIRECTORY</c>
        /// is the selected authentication method of the new Quick Sight account.
        /// </para>
        /// </summary>
        public string ActiveDirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectoryName property is set.
        /// </summary>
        internal bool IsSetActiveDirectoryName() => this.ActiveDirectoryName != null;

        /// <summary>
        /// Gets and sets the property AdminGroup. 
        /// <para>
        /// The admin group associated with your Active Directory or IAM Identity Center account.
        /// Either this field or the <c>AdminProGroup</c> field is required if <c>ACTIVE_DIRECTORY</c>
        /// or <c>IAM_IDENTITY_CENTER</c> is the selected authentication method of the new Quick
        /// Sight account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in Amazon Quick Sight, see <a
        /// href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide. For more information about using Active Directory in Amazon Quick
        /// Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdminGroup { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdminGroup property is set.
        /// </summary>
        internal bool IsSetAdminGroup() => this.AdminGroup != null && (this.AdminGroup.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdminProGroup. 
        /// <para>
        /// The admin pro group associated with your Active Directory or IAM Identity Center account.
        /// Either this field or the <c>AdminGroup</c> field is required if <c>ACTIVE_DIRECTORY</c>
        /// or <c>IAM_IDENTITY_CENTER</c> is the selected authentication method of the new Quick
        /// Sight account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in Amazon Quick Sight, see <a
        /// href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide. For more information about using Active Directory in Amazon Quick
        /// Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdminProGroup { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdminProGroup property is set.
        /// </summary>
        internal bool IsSetAdminProGroup() => this.AdminProGroup != null && (this.AdminProGroup.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// The method that you want to use to authenticate your Quick Sight account.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>ACTIVE_DIRECTORY</c>, provide an <c>ActiveDirectoryName</c> and an
        /// <c>AdminGroup</c> associated with your Active Directory.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>IAM_IDENTITY_CENTER</c>, provide an <c>AdminGroup</c> associated
        /// with your IAM Identity Center account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationMethodOption AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property AuthorGroup. 
        /// <para>
        /// The author group associated with your Active Directory or IAM Identity Center account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in Amazon Quick Sight, see <a
        /// href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide. For more information about using Active Directory in Amazon Quick
        /// Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorGroup { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorGroup property is set.
        /// </summary>
        internal bool IsSetAuthorGroup() => this.AuthorGroup != null && (this.AuthorGroup.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorProGroup. 
        /// <para>
        /// The author pro group associated with your Active Directory or IAM Identity Center
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in Amazon Quick Sight, see <a
        /// href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide. For more information about using Active Directory in Amazon Quick
        /// Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorProGroup { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorProGroup property is set.
        /// </summary>
        internal bool IsSetAuthorProGroup() => this.AuthorProGroup != null && (this.AuthorProGroup.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the account that you're using to create your
        /// Quick Sight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ContactNumber. 
        /// <para>
        /// A 10-digit phone number for the author of the Amazon Quick Sight account to use for
        /// future communications. This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected
        /// edition of the new Amazon Quick Sight account.
        /// </para>
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Checks to see if the ContactNumber property is set.
        /// </summary>
        internal bool IsSetContactNumber() => this.ContactNumber != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The ID of the Active Directory that is associated with your Quick Sight account.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition of Amazon Quick Sight that you want your account to have. Currently, you
        /// can choose from <c>ENTERPRISE</c> or <c>ENTERPRISE_AND_Q</c>.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>ENTERPRISE_AND_Q</c>, the following parameters are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FirstName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LastName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EmailAddress</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ContactNumber</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Edition Edition { get; set; }

        /// <summary>
        /// Checks to see if the Edition property is set.
        /// </summary>
        internal bool IsSetEdition() => this.Edition != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the author of the Amazon Quick Sight account to use for future
        /// communications. This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected
        /// edition of the new Amazon Quick Sight account.
        /// </para>
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the author of the Amazon Quick Sight account to use for future communications.
        /// This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected edition of the
        /// new Amazon Quick Sight account.
        /// </para>
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property IAMIdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string IAMIdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IAMIdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIAMIdentityCenterInstanceArn() => this.IAMIdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the author of the Amazon Quick Sight account to use for future communications.
        /// This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected edition of the
        /// new Amazon Quick Sight account.
        /// </para>
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The email address that you want Quick Sight to send notifications to regarding your
        /// Quick Sight account or Quick Sight subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationEmail { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEmail property is set.
        /// </summary>
        internal bool IsSetNotificationEmail() => this.NotificationEmail != null;

        /// <summary>
        /// Gets and sets the property ReaderGroup. 
        /// <para>
        /// The reader group associated with your Active Directory or IAM Identity Center account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in Amazon Quick Sight, see <a
        /// href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide. For more information about using Active Directory in Amazon Quick
        /// Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReaderGroup { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReaderGroup property is set.
        /// </summary>
        internal bool IsSetReaderGroup() => this.ReaderGroup != null && (this.ReaderGroup.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReaderProGroup. 
        /// <para>
        /// The reader pro group associated with your Active Directory or IAM Identity Center
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in Amazon Quick Sight, see <a
        /// href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide. For more information about using Active Directory in Amazon Quick
        /// Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with Amazon Quick Sight Enterprise Edition</a> in the Amazon Quick
        /// Sight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReaderProGroup { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReaderProGroup property is set.
        /// </summary>
        internal bool IsSetReaderProGroup() => this.ReaderProGroup != null && (this.ReaderProGroup.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Realm. 
        /// <para>
        /// The realm of the Active Directory that is associated with your Quick Sight account.
        /// This field is required if <c>ACTIVE_DIRECTORY</c> is the selected authentication method
        /// of the new Quick Sight account.
        /// </para>
        /// </summary>
        public string Realm { get; set; }

        /// <summary>
        /// Checks to see if the Realm property is set.
        /// </summary>
        internal bool IsSetRealm() => this.Realm != null;
    }
}
