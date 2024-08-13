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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Role alias description.
    /// </summary>
    public partial class RoleAliasDescription
    {
        private DateTime? _creationDate;
        private int? _credentialDurationSeconds;
        private DateTime? _lastModifiedDate;
        private string _owner;
        private string _roleAlias;
        private string _roleAliasArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UNIX timestamp of when the role alias was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CredentialDurationSeconds. 
        /// <para>
        /// The number of seconds for which the credential is valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=43200)]
        public int? CredentialDurationSeconds
        {
            get { return this._credentialDurationSeconds; }
            set { this._credentialDurationSeconds = value; }
        }

        // Check to see if CredentialDurationSeconds property is set
        internal bool IsSetCredentialDurationSeconds()
        {
            return this._credentialDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The UNIX timestamp of when the role alias was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The role alias owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RoleAlias. 
        /// <para>
        /// The role alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RoleAlias
        {
            get { return this._roleAlias; }
            set { this._roleAlias = value; }
        }

        // Check to see if RoleAlias property is set
        internal bool IsSetRoleAlias()
        {
            return this._roleAlias != null;
        }

        /// <summary>
        /// Gets and sets the property RoleAliasArn. 
        /// <para>
        /// The ARN of the role alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleAliasArn
        {
            get { return this._roleAliasArn; }
            set { this._roleAliasArn = value; }
        }

        // Check to see if RoleAliasArn property is set
        internal bool IsSetRoleAliasArn()
        {
            return this._roleAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}