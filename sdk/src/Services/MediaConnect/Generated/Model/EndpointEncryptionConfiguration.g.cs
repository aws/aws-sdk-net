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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The encryption settings for an endpoint connection. This is a union type, so exactly
    /// one of its members is set: <c>secretsManager</c> when you store the encryption key
    /// or passphrase in Secrets Manager, or <c>automatic</c> when you let MediaConnect determine
    /// the encryption key when the endpoint connects.
    /// </summary>
    public partial class EndpointEncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Automatic. 
        /// <para>
        /// The configuration for automatic encryption, where MediaConnect determines the encryption
        /// key when the endpoint connects.
        /// </para>
        /// </summary>
        public AutomaticEndpointEncryptionConfiguration Automatic { get; set; }

        /// <summary>
        /// Checks to see if the Automatic property is set.
        /// </summary>
        internal bool IsSetAutomatic() => this.Automatic != null;

        /// <summary>
        /// Gets and sets the property SecretsManager. 
        /// <para>
        /// The encryption configuration for a connection that uses a key or passphrase that you
        /// store in Secrets Manager.
        /// </para>
        /// </summary>
        public SecretsManagerEndpointEncryptionConfiguration SecretsManager { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManager property is set.
        /// </summary>
        internal bool IsSetSecretsManager() => this.SecretsManager != null;
    }
}
