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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Private key flags for v2 templates specify the client compatibility, if the private
    /// key can be exported, and if user input is required when using a private key.
    /// </summary>
    public partial class PrivateKeyFlagsV2
    {
        private ClientCompatibilityV2 _clientVersion;
        private bool? _exportableKey;
        private bool? _strongKeyProtectionRequired;

        /// <summary>
        /// Gets and sets the property ClientVersion. 
        /// <para>
        /// Defines the minimum client compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientCompatibilityV2 ClientVersion
        {
            get { return this._clientVersion; }
            set { this._clientVersion = value; }
        }

        // Check to see if ClientVersion property is set
        internal bool IsSetClientVersion()
        {
            return this._clientVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExportableKey. 
        /// <para>
        /// Allows the private key to be exported.
        /// </para>
        /// </summary>
        public bool? ExportableKey
        {
            get { return this._exportableKey; }
            set { this._exportableKey = value; }
        }

        // Check to see if ExportableKey property is set
        internal bool IsSetExportableKey()
        {
            return this._exportableKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StrongKeyProtectionRequired. 
        /// <para>
        /// Require user input when using the private key for enrollment.
        /// </para>
        /// </summary>
        public bool? StrongKeyProtectionRequired
        {
            get { return this._strongKeyProtectionRequired; }
            set { this._strongKeyProtectionRequired = value; }
        }

        // Check to see if StrongKeyProtectionRequired property is set
        internal bool IsSetStrongKeyProtectionRequired()
        {
            return this._strongKeyProtectionRequired.HasValue; 
        }

    }
}