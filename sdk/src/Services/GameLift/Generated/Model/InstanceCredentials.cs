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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A set of credentials that allow remote access to an instance in an EC2 managed fleet.
    /// These credentials are returned in response to a call to <a>GetInstanceAccess</a>,
    /// which requests access for instances that are running game servers with the Amazon
    /// GameLift server SDK version 4.x or earlier.
    /// </summary>
    public partial class InstanceCredentials
    {
        private string _secret;
        private string _userName;

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// Secret string. For Windows instances, the secret is a password for use with Windows
        /// Remote Desktop. For Linux instances, it's a private key for use with SSH.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// A user name for logging in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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