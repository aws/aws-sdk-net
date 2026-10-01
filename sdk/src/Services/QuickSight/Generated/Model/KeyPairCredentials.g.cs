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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The combination of username, private key and passphrase that are used as credentials.
    /// </summary>
    public partial class KeyPairCredentials
    {
        /// <summary>
        /// Gets and sets the property KeyPairUsername. 
        /// <para>
        /// Username
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string KeyPairUsername { get; set; }

        /// <summary>
        /// Checks to see if the KeyPairUsername property is set.
        /// </summary>
        internal bool IsSetKeyPairUsername() => this.KeyPairUsername != null;

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// PrivateKey
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1600, Max = 8000)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKey property is set.
        /// </summary>
        internal bool IsSetPrivateKey() => this.PrivateKey != null;

        /// <summary>
        /// Gets and sets the property PrivateKeyPassphrase. 
        /// <para>
        /// PrivateKeyPassphrase
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string PrivateKeyPassphrase { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKeyPassphrase property is set.
        /// </summary>
        internal bool IsSetPrivateKeyPassphrase() => this.PrivateKeyPassphrase != null;
    }
}
