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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Defines the configuration settings for transit encryption keys.
    /// </summary>
    public partial class RouterInputTransitEncryptionKeyConfiguration
    {
        private AutomaticEncryptionKeyConfiguration _automatic;
        private SecretsManagerEncryptionKeyConfiguration _secretsManager;

        /// <summary>
        /// Gets and sets the property Automatic.
        /// </summary>
        public AutomaticEncryptionKeyConfiguration Automatic
        {
            get { return this._automatic; }
            set { this._automatic = value; }
        }

        // Check to see if Automatic property is set
        internal bool IsSetAutomatic()
        {
            return this._automatic != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManager.
        /// </summary>
        public SecretsManagerEncryptionKeyConfiguration SecretsManager
        {
            get { return this._secretsManager; }
            set { this._secretsManager = value; }
        }

        // Check to see if SecretsManager property is set
        internal bool IsSetSecretsManager()
        {
            return this._secretsManager != null;
        }

    }
}