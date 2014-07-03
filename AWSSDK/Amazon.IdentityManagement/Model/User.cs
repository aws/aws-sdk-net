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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// The User data type contains information about a user.
    /// 
    ///         
    /// <para>
    ///  This data type is used as a response element in the following actions:
    /// </para>
    ///         <ul>            <li>
    /// <para>
    /// <a>CreateUser</a>
    /// </para>
    /// </li>            <li>
    /// <para>
    /// <a>GetUser</a>
    /// </para>
    /// </li>            <li>
    /// <para>
    /// <a>ListUsers</a>
    /// </para>
    /// </li>        </ul>
    /// </summary>
    public partial class User
    {
        private string _arn;
        private DateTime? _createDate;
        private string _path;
        private string _userId;
        private string _userName;


        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) specifying the user. For more information about ARNs
        /// and how            to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public User WithArn(string arn)
        {
            this._arn = arn;
            return this;
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the user was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }


        /// <summary>
        /// Sets the CreateDate property
        /// </summary>
        /// <param name="createDate">The value to set for the CreateDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public User WithCreateDate(DateTime createDate)
        {
            this._createDate = createDate;
            return this;
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Path to the user. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }


        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public User WithPath(string path)
        {
            this._path = path;
            return this;
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }


        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The stable and unique string identifying the user. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }


        /// <summary>
        /// Sets the UserId property
        /// </summary>
        /// <param name="userId">The value to set for the UserId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public User WithUserId(string userId)
        {
            this._userId = userId;
            return this;
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name identifying the user.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }


        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public User WithUserName(string userName)
        {
            this._userName = userName;
            return this;
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}