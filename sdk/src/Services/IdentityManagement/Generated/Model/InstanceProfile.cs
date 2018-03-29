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
    /// Contains information about an instance profile.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the following operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateInstanceProfile</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetInstanceProfile</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListInstanceProfiles</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListInstanceProfilesForRole</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InstanceProfile
    {
        private string _arn;
        private DateTime? _createDate;
        private string _instanceProfileId;
        private string _instanceProfileName;
        private string _path;
        private List<Role> _roles = new List<Role>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) specifying the instance profile. For more information
        /// about ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
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
        /// The date when the instance profile was created.
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
        /// Gets and sets the property InstanceProfileId. 
        /// <para>
        ///  The stable and unique string identifying the instance profile. For more information
        /// about IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string InstanceProfileId
        {
            get { return this._instanceProfileId; }
            set { this._instanceProfileId = value; }
        }

        // Check to see if InstanceProfileId property is set
        internal bool IsSetInstanceProfileId()
        {
            return this._instanceProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// The name identifying the instance profile.
        /// </para>
        /// </summary>
        public string InstanceProfileName
        {
            get { return this._instanceProfileName; }
            set { this._instanceProfileName = value; }
        }

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this._instanceProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the instance profile. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
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
        /// Gets and sets the property Roles. 
        /// <para>
        /// The role associated with the instance profile.
        /// </para>
        /// </summary>
        public List<Role> Roles
        {
            get { return this._roles; }
            set { this._roles = value; }
        }

        // Check to see if Roles property is set
        internal bool IsSetRoles()
        {
            return this._roles != null && this._roles.Count > 0; 
        }

    }
}