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

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Information about an environment member for an Cloud9 development environment.
    /// </summary>
    public partial class EnvironmentMember
    {
        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment for the environment member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property LastAccess. 
        /// <para>
        /// The time, expressed in epoch time format, when the environment member last opened
        /// the environment.
        /// </para>
        /// </summary>
        public DateTime? LastAccess { get; set; }

        /// <summary>
        /// Checks to see if the LastAccess property is set.
        /// </summary>
        internal bool IsSetLastAccess() => this.LastAccess.HasValue;

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
        [AWSProperty(Required = true)]
        public PermissionsType Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserArn { get; set; }

        /// <summary>
        /// Checks to see if the UserArn property is set.
        /// </summary>
        internal bool IsSetUserArn() => this.UserArn != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID in Identity and Access Management (IAM) of the environment member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
