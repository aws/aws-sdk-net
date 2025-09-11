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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Container for the parameters to the CreateAccountSubscription operation.
    /// Creates an QuickSight account, or subscribes to QuickSight Q.
    /// 
    ///  
    /// <para>
    /// The Amazon Web Services Region for the account is derived from what is configured
    /// in the CLI or SDK.
    /// </para>
    ///  
    /// <para>
    /// Before you use this operation, make sure that you can connect to an existing Amazon
    /// Web Services account. If you don't have an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/setting-up-aws-sign-up.html">Sign
    /// up for Amazon Web Services</a> in the <i>Amazon QuickSight User Guide</i>. The person
    /// who signs up for QuickSight needs to have the correct Identity and Access Management
    /// (IAM) permissions. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/iam-policy-examples.html">IAM
    /// Policy Examples for QuickSight</a> in the <i>QuickSight User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If your IAM policy includes both the <c>Subscribe</c> and <c>CreateAccountSubscription</c>
    /// actions, make sure that both actions are set to <c>Allow</c>. If either action is
    /// set to <c>Deny</c>, the <c>Deny</c> action prevails and your API call fails.
    /// </para>
    ///  
    /// <para>
    /// You can't pass an existing IAM role to access other Amazon Web Services services using
    /// this API operation. To pass your existing IAM role to QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html#security-create-iam-role">Passing
    /// IAM roles to QuickSight</a> in the <i>QuickSight User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can't set default resource access on the new account from the QuickSight API.
    /// Instead, add default resource access from the QuickSight console. For more information
    /// about setting default resource access to Amazon Web Services services, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/scoping-policies-defaults.html">Setting
    /// default resource access to Amazon Web Services services</a> in the <i>QuickSight User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateAccountSubscriptionRequest : AmazonQuickSightRequest
    {
        private string _accountName;
        private string _activeDirectoryName;
        private List<string> _adminGroup = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _adminProGroup = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AuthenticationMethodOption _authenticationMethod;
        private List<string> _authorGroup = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _authorProGroup = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsAccountId;
        private string _contactNumber;
        private string _directoryId;
        private Edition _edition;
        private string _emailAddress;
        private string _firstName;
        private string _iamIdentityCenterInstanceArn;
        private string _lastName;
        private string _notificationEmail;
        private List<string> _readerGroup = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _readerProGroup = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _realm;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of your QuickSight account. This name is unique over all of Amazon Web Services,
        /// and it appears only when users sign in. You can't change <c>AccountName</c> value
        /// after the QuickSight account is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=62)]
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
        /// Gets and sets the property ActiveDirectoryName. 
        /// <para>
        /// The name of your Active Directory. This field is required if <c>ACTIVE_DIRECTORY</c>
        /// is the selected authentication method of the new QuickSight account.
        /// </para>
        /// </summary>
        public string ActiveDirectoryName
        {
            get { return this._activeDirectoryName; }
            set { this._activeDirectoryName = value; }
        }

        // Check to see if ActiveDirectoryName property is set
        internal bool IsSetActiveDirectoryName()
        {
            return this._activeDirectoryName != null;
        }

        /// <summary>
        /// Gets and sets the property AdminGroup. 
        /// <para>
        /// The admin group associated with your Active Directory or IAM Identity Center account.
        /// Either this field or the <c>AdminProGroup</c> field is required if <c>ACTIVE_DIRECTORY</c>
        /// or <c>IAM_IDENTITY_CENTER</c> is the selected authentication method of the new QuickSight
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with QuickSight Enterprise Edition</a> in the QuickSight User
        /// Guide. For more information about using Active Directory in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with QuickSight Enterprise Edition</a> in the QuickSight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdminGroup
        {
            get { return this._adminGroup; }
            set { this._adminGroup = value; }
        }

        // Check to see if AdminGroup property is set
        internal bool IsSetAdminGroup()
        {
            return this._adminGroup != null && (this._adminGroup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdminProGroup. 
        /// <para>
        /// The admin pro group associated with your Active Directory or IAM Identity Center account.
        /// Either this field or the <c>AdminGroup</c> field is required if <c>ACTIVE_DIRECTORY</c>
        /// or <c>IAM_IDENTITY_CENTER</c> is the selected authentication method of the new QuickSight
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with QuickSight Enterprise Edition</a> in the QuickSight User
        /// Guide. For more information about using Active Directory in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with QuickSight Enterprise Edition</a> in the QuickSight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdminProGroup
        {
            get { return this._adminProGroup; }
            set { this._adminProGroup = value; }
        }

        // Check to see if AdminProGroup property is set
        internal bool IsSetAdminProGroup()
        {
            return this._adminProGroup != null && (this._adminProGroup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// The method that you want to use to authenticate your QuickSight account.
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
        [AWSProperty(Required=true)]
        public AuthenticationMethodOption AuthenticationMethod
        {
            get { return this._authenticationMethod; }
            set { this._authenticationMethod = value; }
        }

        // Check to see if AuthenticationMethod property is set
        internal bool IsSetAuthenticationMethod()
        {
            return this._authenticationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorGroup. 
        /// <para>
        /// The author group associated with your Active Directory or IAM Identity Center account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with QuickSight Enterprise Edition</a> in the QuickSight User
        /// Guide. For more information about using Active Directory in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with QuickSight Enterprise Edition</a> in the QuickSight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorGroup
        {
            get { return this._authorGroup; }
            set { this._authorGroup = value; }
        }

        // Check to see if AuthorGroup property is set
        internal bool IsSetAuthorGroup()
        {
            return this._authorGroup != null && (this._authorGroup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthorProGroup. 
        /// <para>
        /// The author pro group associated with your Active Directory or IAM Identity Center
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with QuickSight Enterprise Edition</a> in the QuickSight User
        /// Guide. For more information about using Active Directory in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with QuickSight Enterprise Edition</a> in the QuickSight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorProGroup
        {
            get { return this._authorProGroup; }
            set { this._authorProGroup = value; }
        }

        // Check to see if AuthorProGroup property is set
        internal bool IsSetAuthorProGroup()
        {
            return this._authorProGroup != null && (this._authorProGroup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the account that you're using to create your
        /// QuickSight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactNumber. 
        /// <para>
        /// A 10-digit phone number for the author of the QuickSight account to use for future
        /// communications. This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected
        /// edition of the new QuickSight account.
        /// </para>
        /// </summary>
        public string ContactNumber
        {
            get { return this._contactNumber; }
            set { this._contactNumber = value; }
        }

        // Check to see if ContactNumber property is set
        internal bool IsSetContactNumber()
        {
            return this._contactNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The ID of the Active Directory that is associated with your QuickSight account.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition of QuickSight that you want your account to have. Currently, you can choose
        /// from <c>ENTERPRISE</c> or <c>ENTERPRISE_AND_Q</c>.
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
        public Edition Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }

        // Check to see if Edition property is set
        internal bool IsSetEdition()
        {
            return this._edition != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the author of the QuickSight account to use for future communications.
        /// This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected edition of the
        /// new QuickSight account.
        /// </para>
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the author of the QuickSight account to use for future communications.
        /// This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected edition of the
        /// new QuickSight account.
        /// </para>
        /// </summary>
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property IAMIdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string IAMIdentityCenterInstanceArn
        {
            get { return this._iamIdentityCenterInstanceArn; }
            set { this._iamIdentityCenterInstanceArn = value; }
        }

        // Check to see if IAMIdentityCenterInstanceArn property is set
        internal bool IsSetIAMIdentityCenterInstanceArn()
        {
            return this._iamIdentityCenterInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the author of the QuickSight account to use for future communications.
        /// This field is required if <c>ENTERPPRISE_AND_Q</c> is the selected edition of the
        /// new QuickSight account.
        /// </para>
        /// </summary>
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The email address that you want QuickSight to send notifications to regarding your
        /// QuickSight account or QuickSight subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotificationEmail
        {
            get { return this._notificationEmail; }
            set { this._notificationEmail = value; }
        }

        // Check to see if NotificationEmail property is set
        internal bool IsSetNotificationEmail()
        {
            return this._notificationEmail != null;
        }

        /// <summary>
        /// Gets and sets the property ReaderGroup. 
        /// <para>
        /// The reader group associated with your Active Directory or IAM Identity Center account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with QuickSight Enterprise Edition</a> in the QuickSight User
        /// Guide. For more information about using Active Directory in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with QuickSight Enterprise Edition</a> in the QuickSight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReaderGroup
        {
            get { return this._readerGroup; }
            set { this._readerGroup = value; }
        }

        // Check to see if ReaderGroup property is set
        internal bool IsSetReaderGroup()
        {
            return this._readerGroup != null && (this._readerGroup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReaderProGroup. 
        /// <para>
        /// The reader pro group associated with your Active Directory or IAM Identity Center
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information about using IAM Identity Center in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sec-identity-management-identity-center.html">Using
        /// IAM Identity Center with QuickSight Enterprise Edition</a> in the QuickSight User
        /// Guide. For more information about using Active Directory in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/aws-directory-service.html">Using
        /// Active Directory with QuickSight Enterprise Edition</a> in the QuickSight User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReaderProGroup
        {
            get { return this._readerProGroup; }
            set { this._readerProGroup = value; }
        }

        // Check to see if ReaderProGroup property is set
        internal bool IsSetReaderProGroup()
        {
            return this._readerProGroup != null && (this._readerProGroup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Realm. 
        /// <para>
        /// The realm of the Active Directory that is associated with your QuickSight account.
        /// This field is required if <c>ACTIVE_DIRECTORY</c> is the selected authentication method
        /// of the new QuickSight account.
        /// </para>
        /// </summary>
        public string Realm
        {
            get { return this._realm; }
            set { this._realm = value; }
        }

        // Check to see if Realm property is set
        internal bool IsSetRealm()
        {
            return this._realm != null;
        }

    }
}