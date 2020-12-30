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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// For Redis engine version 6.x onwards: Creates a Redis user. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Clusters.RBAC.html">Using
    /// Role Based Access Control (RBAC)</a>.
    /// </summary>
    public partial class CreateUserRequest : AmazonElastiCacheRequest
    {
        private string _accessString;
        private string _engine;
        private bool? _noPasswordRequired;
        private List<string> _passwords = new List<string>();
        private string _userId;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AccessString. 
        /// <para>
        /// Access permissions string used for this user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessString
        {
            get { return this._accessString; }
            set { this._accessString = value; }
        }

        // Check to see if AccessString property is set
        internal bool IsSetAccessString()
        {
            return this._accessString != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The current supported value is Redis. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property NoPasswordRequired. 
        /// <para>
        /// Indicates a password is not required for this user.
        /// </para>
        /// </summary>
        public bool NoPasswordRequired
        {
            get { return this._noPasswordRequired.GetValueOrDefault(); }
            set { this._noPasswordRequired = value; }
        }

        // Check to see if NoPasswordRequired property is set
        internal bool IsSetNoPasswordRequired()
        {
            return this._noPasswordRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Passwords. 
        /// <para>
        /// Passwords used for this user. You can create up to two passwords for each user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Passwords
        {
            get { return this._passwords; }
            set { this._passwords = value; }
        }

        // Check to see if Passwords property is set
        internal bool IsSetPasswords()
        {
            return this._passwords != null && this._passwords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The username of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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