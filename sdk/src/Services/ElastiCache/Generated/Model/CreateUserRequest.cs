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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 to 7.1: Creates a user. For
    /// more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
    /// Role Based Access Control (RBAC)</a>.
    /// </summary>
    public partial class CreateUserRequest : AmazonElastiCacheRequest
    {
        private string _accessString;
        private AuthenticationMode _authenticationMode;
        private string _engine;
        private bool? _noPasswordRequired;
        private List<string> _passwords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
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
        /// Gets and sets the property AuthenticationMode. 
        /// <para>
        /// Specifies how to authenticate the user.
        /// </para>
        /// </summary>
        public AuthenticationMode AuthenticationMode
        {
            get { return this._authenticationMode; }
            set { this._authenticationMode = value; }
        }

        // Check to see if AuthenticationMode property is set
        internal bool IsSetAuthenticationMode()
        {
            return this._authenticationMode != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The options are valkey or redis. 
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
        public bool? NoPasswordRequired
        {
            get { return this._noPasswordRequired; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._passwords != null && (this._passwords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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