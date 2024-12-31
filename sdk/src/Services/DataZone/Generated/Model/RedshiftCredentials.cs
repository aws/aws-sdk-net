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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Amazon Redshift credentials of a connection.
    /// </summary>
    public partial class RedshiftCredentials
    {
        private string _secretArn;
        private UsernamePassword _usernamePassword;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The secret ARN of the Amazon Redshift credentials of a connection.
        /// </para>
        /// </summary>
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property UsernamePassword. 
        /// <para>
        /// The username and password of the Amazon Redshift credentials of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public UsernamePassword UsernamePassword
        {
            get { return this._usernamePassword; }
            set { this._usernamePassword = value; }
        }

        // Check to see if UsernamePassword property is set
        internal bool IsSetUsernamePassword()
        {
            return this._usernamePassword != null;
        }

    }
}