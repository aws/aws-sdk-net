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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ActiveDirectoryGuid. 
        /// <para>
        /// The GUID of the Active Directory group associated with this security group, if synchronized
        /// with LDAP.
        /// </para>
        /// </summary>
        public string ActiveDirectoryGuid { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectoryGuid property is set.
        /// </summary>
        internal bool IsSetActiveDirectoryGuid() => this.ActiveDirectoryGuid != null;

        /// <summary>
        /// Gets and sets the property ActiveMembers. 
        /// <para>
        /// The number of active user members currently in the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ActiveMembers { get; set; }

        /// <summary>
        /// Checks to see if the ActiveMembers property is set.
        /// </summary>
        internal bool IsSetActiveMembers() => this.ActiveMembers.HasValue;

        /// <summary>
        /// Gets and sets the property BotMembers. 
        /// <para>
        /// The number of bot members currently in the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? BotMembers { get; set; }

        /// <summary>
        /// Checks to see if the BotMembers property is set.
        /// </summary>
        internal bool IsSetBotMembers() => this.BotMembers.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether this is the default security group for the network. Each network
        /// has only one default group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The timestamp when the security group was last modified, specified in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Modified { get; set; }

        /// <summary>
        /// Checks to see if the Modified property is set.
        /// </summary>
        internal bool IsSetModified() => this.Modified.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupSettings. 
        /// <para>
        /// The comprehensive configuration settings that define capabilities and restrictions
        /// for members of this security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SecurityGroupSettings SecurityGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupSettings property is set.
        /// </summary>
        internal bool IsSetSecurityGroupSettings() => this.SecurityGroupSettings != null;
    }
}
