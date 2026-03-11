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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a security group in a Wickr network, containing membership statistics,
    /// configuration, and all permission settings that apply to its members.
    /// </summary>
    public partial class SecurityGroup
    {
        private string _activeDirectoryGuid;
        private int? _activeMembers;
        private int? _botMembers;
        private string _id;
        private bool? _isDefault;
        private int? _modified;
        private string _name;
        private SecurityGroupSettings _securityGroupSettings;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryGuid. 
        /// <para>
        /// The GUID of the Active Directory group associated with this security group, if synchronized
        /// with LDAP.
        /// </para>
        /// </summary>
        public string ActiveDirectoryGuid
        {
            get { return this._activeDirectoryGuid; }
            set { this._activeDirectoryGuid = value; }
        }

        // Check to see if ActiveDirectoryGuid property is set
        internal bool IsSetActiveDirectoryGuid()
        {
            return this._activeDirectoryGuid != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveMembers. 
        /// <para>
        /// The number of active user members currently in the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ActiveMembers
        {
            get { return this._activeMembers; }
            set { this._activeMembers = value; }
        }

        // Check to see if ActiveMembers property is set
        internal bool IsSetActiveMembers()
        {
            return this._activeMembers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BotMembers. 
        /// <para>
        /// The number of bot members currently in the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? BotMembers
        {
            get { return this._botMembers; }
            set { this._botMembers = value; }
        }

        // Check to see if BotMembers property is set
        internal bool IsSetBotMembers()
        {
            return this._botMembers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether this is the default security group for the network. Each network
        /// has only one default group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The timestamp when the security group was last modified, specified in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Modified
        {
            get { return this._modified; }
            set { this._modified = value; }
        }

        // Check to see if Modified property is set
        internal bool IsSetModified()
        {
            return this._modified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupSettings. 
        /// <para>
        /// The comprehensive configuration settings that define capabilities and restrictions
        /// for members of this security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SecurityGroupSettings SecurityGroupSettings
        {
            get { return this._securityGroupSettings; }
            set { this._securityGroupSettings = value; }
        }

        // Check to see if SecurityGroupSettings property is set
        internal bool IsSetSecurityGroupSettings()
        {
            return this._securityGroupSettings != null;
        }

    }
}