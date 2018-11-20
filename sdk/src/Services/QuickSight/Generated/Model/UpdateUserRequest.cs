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
    /// Container for the parameters to the UpdateUser operation.
    /// Updates an Amazon QuickSight user.
    /// </summary>
    public partial class UpdateUserRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _email;
        private string _awsNamespace;
        private UserRole _role;
        private string _userName;

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
        /// The email address of the user that you want to update.
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
        /// Gets and sets the property Role. 
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
        public UserRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The Amazon QuickSight user name that you want to update.
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

    }
}