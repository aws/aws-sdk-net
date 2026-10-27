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
    /// Container for the parameters to the CreateEnvironmentMembership operation. Adds an
    /// environment member to an Cloud9 development environment. <important> <para> Cloud9
    /// is no longer available to new customers. Existing customers of Cloud9 can continue
    /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
    /// more"</a> </para> </important>
    /// </summary>
    public partial class CreateEnvironmentMembershipRequest : AmazonCloud9Request
    {
        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment that contains the environment member you want to add.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The type of environment member permissions you want to associate with this environment
        /// member. Available values include:
        /// </para>
        ///  <ul> <li> 
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
        public MemberPermissions Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment member you want to add.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserArn { get; set; }

        /// <summary>
        /// Checks to see if the UserArn property is set.
        /// </summary>
        internal bool IsSetUserArn() => this.UserArn != null;
    }
}
