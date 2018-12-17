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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterUser operation.
    /// Creates an Amazon QuickSight user, whose identity is associated with the AWS Identity
    /// and Access Management (IAM) identity or role specified in the request. 
    /// 
    ///  
    /// <para>
    /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
    /// </code>.
    /// </para>
    ///  
    /// <para>
    /// The condition resource is the Amazon Resource Name (ARN) for the IAM user or role,
    /// and the session name. 
    /// </para>
    ///  
    /// <para>
    /// The condition keys are <code>quicksight:IamArn</code> and <code>quicksight:SessionName</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>CLI Sample:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight register-user -\-aws-account-id=111122223333 -\-namespace=default
    /// -\-email=pat@example.com -\-identity-type=IAM -\-user-role=AUTHOR -\-iam-arn=arn:aws:iam::111122223333:user/Pat
    /// </code> 
    /// </para>
    /// </summary>
    public partial class RegisterUserRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _email;
        private string _iamArn;
        private IdentityType _identityType;
        private string _awsNamespace;
        private string _sessionName;
        private string _userName;
        private UserRole _userRole;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the AWS account that the user is in. Currently, you use the ID for the
        /// AWS account that contains your Amazon QuickSight account.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the user that you want to register.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IamArn. 
        /// <para>
        /// The ARN of the IAM user or role that you are registering with Amazon QuickSight. 
        /// </para>
        /// </summary>
        public string IamArn
        {
            get { return this._iamArn; }
            set { this._iamArn = value; }
        }

        // Check to see if IamArn property is set
        internal bool IsSetIamArn()
        {
            return this._iamArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// Amazon QuickSight supports several ways of managing the identity of users. This parameter
        /// accepts two values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IAM</code>: A user whose identity maps to an existing IAM user or role. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QUICKSIGHT</code>: A user whose identity is owned and managed internally by
        /// Amazon QuickSight. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace. Currently, you should set this to <code>default</code>.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The name of the session with the assumed IAM role. By using this parameter, you can
        /// register multiple users with the same IAM role, provided that each has a different
        /// session name. For more information on assuming IAM roles, see <a href="https://docs.aws.amazon.com/cli/latest/reference/sts/assume-role.html">
        /// <code>assume-role</code> </a> in the <i>AWS CLI Reference.</i> 
        /// </para>
        /// </summary>
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The Amazon QuickSight user name that you want to create for the user you are registering.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

        /// <summary>
        /// Gets and sets the property UserRole. 
        /// <para>
        /// The Amazon QuickSight role of the user. The user role can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>READER</code>: A user who has read-only access to dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AUTHOR</code>: A user who can create data sources, data sets, analyses, and
        /// dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ADMIN</code>: A user who is an author, who can also manage Amazon QuickSight
        /// settings.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserRole UserRole
        {
            get { return this._userRole; }
            set { this._userRole = value; }
        }

        // Check to see if UserRole property is set
        internal bool IsSetUserRole()
        {
            return this._userRole != null;
        }

    }
}