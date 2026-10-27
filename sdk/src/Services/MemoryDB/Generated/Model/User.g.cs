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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// You create users and assign them specific permissions by using an access string. You
    /// assign the users to Access Control Lists aligned with a specific role (administrators,
    /// human resources) that are then deployed to one or more MemoryDB clusters.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property ACLNames. 
        /// <para>
        /// The names of the Access Control Lists to which the user belongs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ACLNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ACLNames property is set.
        /// </summary>
        internal bool IsSetACLNames() => this.ACLNames != null && (this.ACLNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user. 
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property AccessString. 
        /// <para>
        /// Access permissions string used for this user.
        /// </para>
        /// </summary>
        public string AccessString { get; set; }

        /// <summary>
        /// Checks to see if the AccessString property is set.
        /// </summary>
        internal bool IsSetAccessString() => this.AccessString != null;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// Denotes whether the user requires a password to authenticate.
        /// </para>
        /// </summary>
        public Authentication Authentication { get; set; }

        /// <summary>
        /// Checks to see if the Authentication property is set.
        /// </summary>
        internal bool IsSetAuthentication() => this.Authentication != null;

        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The minimum engine version supported for the user
        /// </para>
        /// </summary>
        public string MinimumEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinimumEngineVersion property is set.
        /// </summary>
        internal bool IsSetMinimumEngineVersion() => this.MinimumEngineVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the user
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the user status. Can be "active", "modifying" or "deleting".
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
