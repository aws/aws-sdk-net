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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateUser.html">CreateUser</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListUsers.html">ListUsers</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class User
    {
        private string _arn;
        private DateTime? _createDate;
        private DateTime? _passwordLastUsed;
        private string _path;
        private AttachedPermissionsBoundary _permissionsBoundary;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userId;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public User() { }

        /// <summary>
        /// Instantiates User with the parameterized properties
        /// </summary>
        /// <param name="path">The path to the user. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM identifiers</a> in the <i>IAM User Guide</i>. The ARN of the policy used to set the permissions boundary for the user.</param>
        /// <param name="userName">The friendly name identifying the user.</param>
        /// <param name="userId">The stable and unique string identifying the user. For more information about IDs, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM identifiers</a> in the <i>IAM User Guide</i>.</param>
        /// <param name="arn">The Amazon Resource Name (ARN) that identifies the user. For more information about ARNs and how to use ARNs in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>IAM User Guide</i>. </param>
        /// <param name="createDate">The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time format</a>, when the user was created.</param>
        public User(string path, string userName, string userId, string arn, DateTime? createDate)
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
        /// ARNs and how to use ARNs in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        [AWSProperty(Required=true)]
        public DateTime? CreateDate
        {
            get { return this._createDate; }
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
        /// format</a>, when the user's password was last used to sign in to an Amazon Web Services
        /// website. For a list of Amazon Web Services websites that capture a user's last sign-in
        /// time, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Credential
        /// reports</a> topic in the <i>IAM User Guide</i>. If a password is used more than once
        /// in a five-minute span, only the first use is returned in this field. If the field
        /// is null (no value), then it indicates that they never signed in with a password. This
        /// can be because:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user never had a password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A password exists but has not been used since IAM started tracking this information
        /// on October 20, 2014.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A null value does not mean that the user <i>never</i> had a password. Also, if the
        /// user does not currently have a password but had one in the past, then this field contains
        /// the date and time the most recent password was used.
        /// </para>
        ///  
        /// <para>
        /// This value is returned only in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>
        /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListUsers.html">ListUsers</a>
        /// operations. 
        /// </para>
        /// </summary>
        public DateTime? PasswordLastUsed
        {
            get { return this._passwordLastUsed; }
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
        /// The path to the user. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The ARN of the policy used to set the permissions boundary for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Gets and sets the property PermissionsBoundary. 
        /// <para>
        /// For more information about permissions boundaries, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
        /// boundaries for IAM identities </a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public AttachedPermissionsBoundary PermissionsBoundary
        {
            get { return this._permissionsBoundary; }
            set { this._permissionsBoundary = value; }
        }

        // Check to see if PermissionsBoundary property is set
        internal bool IsSetPermissionsBoundary()
        {
            return this._permissionsBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that are associated with the user. For more information about tagging,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The stable and unique string identifying the user. For more information about IDs,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=128)]
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
        [AWSProperty(Required=true, Min=1, Max=64)]
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