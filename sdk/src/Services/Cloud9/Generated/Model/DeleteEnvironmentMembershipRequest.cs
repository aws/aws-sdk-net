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

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEnvironmentMembership operation.
    /// Deletes an environment member from an AWS Cloud9 development environment.
    /// </summary>
    public partial class DeleteEnvironmentMembershipRequest : AmazonCloud9Request
    {
        private string _environmentId;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment to delete the environment member from.
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
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment member to delete from the environment.
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