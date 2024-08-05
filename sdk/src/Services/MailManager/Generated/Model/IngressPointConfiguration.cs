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
    /// The configuration of the ingress endpoint resource.
    /// </summary>
    public partial class IngressPointConfiguration
    {
        private string _secretArn;
        private string _smtpPassword;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The SecretsManager::Secret ARN of the ingress endpoint resource.
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
        /// Gets and sets the property SmtpPassword. 
        /// <para>
        /// The password of the ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8, Max=64)]
        public string SmtpPassword
        {
            get { return this._smtpPassword; }
            set { this._smtpPassword = value; }
        }

        // Check to see if SmtpPassword property is set
        internal bool IsSetSmtpPassword()
        {
            return this._smtpPassword != null;
        }

    }
}