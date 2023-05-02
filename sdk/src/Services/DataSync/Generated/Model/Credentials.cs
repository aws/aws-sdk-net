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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The credentials that provide DataSync Discovery read access to your on-premises storage
    /// system's management interface.
    /// 
    ///  
    /// <para>
    /// DataSync Discovery stores these credentials in <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html">Secrets
    /// Manager</a>. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-configure-storage.html">Accessing
    /// your on-premises storage system</a>.
    /// </para>
    /// </summary>
    public partial class Credentials
    {
        private string _password;
        private string _username;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the password for your storage system's management interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=1024)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Specifies the user name for your storage system's management interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=1024)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}