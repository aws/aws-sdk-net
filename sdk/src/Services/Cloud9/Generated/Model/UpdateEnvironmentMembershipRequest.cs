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
    /// Container for the parameters to the UpdateEnvironmentMembership operation.
    /// Changes the settings of an existing environment member for an Cloud9 development environment.
    /// 
    ///  <important> 
    /// <para>
    /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
    /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
    /// more"</a> 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateEnvironmentMembershipRequest : AmazonCloud9Request
    {
        private string _environmentId;
        private MemberPermissions _permissions;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment for the environment member whose settings you want to change.
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The replacement type of environment member permissions you want to associate with
        /// this environment member. Available values include:
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
        [AWSProperty(Required=true)]
        public MemberPermissions Permissions
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
        /// The Amazon Resource Name (ARN) of the environment member whose settings you want to
        /// change.
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

    }
}