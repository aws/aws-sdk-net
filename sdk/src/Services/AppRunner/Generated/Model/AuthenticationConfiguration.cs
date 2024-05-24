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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes resources needed to authenticate access to some source repositories. The
    /// specific resource depends on the repository provider.
    /// </summary>
    public partial class AuthenticationConfiguration
    {
        private string _accessRoleArn;
        private string _connectionArn;

        /// <summary>
        /// Gets and sets the property AccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants the App Runner service
        /// access to a source repository. It's required for ECR image repositories (but not for
        /// ECR Public repositories).
        /// </para>
        /// </summary>
        [AWSProperty(Min=29, Max=1024)]
        public string AccessRoleArn
        {
            get { return this._accessRoleArn; }
            set { this._accessRoleArn = value; }
        }

        // Check to see if AccessRoleArn property is set
        internal bool IsSetAccessRoleArn()
        {
            return this._accessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner connection that enables the App Runner
        /// service to connect to a source repository. It's required for GitHub code repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

    }
}