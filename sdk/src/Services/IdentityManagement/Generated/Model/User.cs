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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// Contains information about an IAM user entity.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the following operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateUser</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetUser</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListUsers</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class User
    {
        private string _arn;
        private DateTime? _createDate;
        private DateTime? _passwordLastUsed;
        private string _path;
        private string _userId;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public User() { }

        /// <summary>
        /// Instantiates User with the parameterized properties
        /// </summary>
        /// <param name="path">The path to the user. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide.</param>
        /// <param name="userName">The friendly name identifying the user.</param>
        /// <param name="userId">The stable and unique string identifying the user. For more information about IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide.</param>
        /// <param name="arn">The Amazon Resource Name (ARN) that identifies the user. For more information about ARNs and how to use ARNs in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide. </param>
        /// <param name="createDate">The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time format</a>, when the user was created.</param>
        public User(string path, string userName, string userId, string arn, DateTime createDate)
        {
            _path = path;
            _userName = userName;
            _userId = userId;
            _arn = arn;
            _createDate = createDate;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the user. For more information about
        /// ARNs and how to use ARNs in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the user was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordLastUsed. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the user's password was last used to sign in to an AWS website. For
        /// a list of AWS websites that capture a user's last sign-in time, see the <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Credential
        /// Reports</a> topic in the <i>Using IAM</i> guide. If a password is used more than once
        /// in a five-minute span, only the first use is returned in this field. If the field
        /// is null (no value) then it indicates that they never signed in with a password. This
        /// can be because:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user never had a password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A password exists but has not been used since IAM started tracking this information
        /// on October 20th, 2014.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A null does not mean that the user <i>never</i> had a password. Also, if the user
        /// does not currently have a password, but had one in the past, then this field contains
        /// the date and time the most recent password was used.
        /// </para>
        ///  
        /// <para>
        /// This value is returned only in the <a>GetUser</a> and <a>ListUsers</a> operations.
        /// 
        /// </para>
        /// </summary>
        public DateTime PasswordLastUsed
        {
            get { return this._passwordLastUsed.GetValueOrDefault(); }
            set { this._passwordLastUsed = value; }
        }

        // Check to see if PasswordLastUsed property is set
        internal bool IsSetPasswordLastUsed()
        {
            return this._passwordLastUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the user. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
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
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The friendly name identifying the user.
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