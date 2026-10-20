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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
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
namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Information about an environment member for an Cloud9 development environment.
    /// </summary>
    public partial class EnvironmentMember
    {
        private string _environmentId;
        private DateTime? _lastAccess;
        private PermissionsType _permissions;
        private string _userArn;
        private string _userId;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment for the environment member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastAccess. 
        /// <para>
        /// The time, expressed in epoch time format, when the environment member last opened
        /// the environment.
        /// </para>
        /// </summary>
        public DateTime? LastAccess
        {
            get { return this._lastAccess; }
            set { this._lastAccess = value; }
        }

        // Check to see if LastAccess property is set
        internal bool IsSetLastAccess()
        {
            return this._lastAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The type of environment member permissions associated with this environment member.
        /// Available values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>owner</c>: Owns the environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>read-only</c>: Has read-only access to the environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>read-write</c>: Has read-write access to the environment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionsType Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null;
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID in Identity and Access Management (IAM) of the environment member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}