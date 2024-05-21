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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Authentication for the relay destination server—specify the secretARN where the SMTP
    /// credentials are stored, or specify an empty NoAuthentication structure if the relay
    /// destination server does not require SMTP credential authentication.
    /// </summary>
    public partial class RelayAuthentication
    {
        private NoAuthentication _noAuthentication;
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property NoAuthentication. 
        /// <para>
        /// Keep an empty structure if the relay destination server does not require SMTP credential
        /// authentication.
        /// </para>
        /// </summary>
        public NoAuthentication NoAuthentication
        {
            get { return this._noAuthentication; }
            set { this._noAuthentication = value; }
        }

        // Check to see if NoAuthentication property is set
        internal bool IsSetNoAuthentication()
        {
            return this._noAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The ARN of the secret created in secrets manager where the relay server's SMTP credentials
        /// are stored.
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

    }
}