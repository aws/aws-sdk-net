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
    /// Private key flags for v4 templates specify the client compatibility, if the private
    /// key can be exported, if user input is required when using a private key, if an alternate
    /// signature algorithm should be used, and if certificates are renewed using the same
    /// private key.
    /// </summary>
    public partial class PrivateKeyFlagsV4
    {
        private ClientCompatibilityV4 _clientVersion;
        private bool? _exportableKey;
        private bool? _requireAlternateSignatureAlgorithm;
        private bool? _requireSameKeyRenewal;
        private bool? _strongKeyProtectionRequired;
        private bool? _useLegacyProvider;

        /// <summary>
        /// Gets and sets the property ClientVersion. 
        /// <para>
        /// Defines the minimum client compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientCompatibilityV4 ClientVersion
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
        /// Gets and sets the property RequireAlternateSignatureAlgorithm. 
        /// <para>
        /// Requires the PKCS #1 v2.1 signature format for certificates. You should verify that
        /// your CA, objects, and applications can accept this signature format.
        /// </para>
        /// </summary>
        public bool? RequireAlternateSignatureAlgorithm
        {
            get { return this._requireAlternateSignatureAlgorithm; }
            set { this._requireAlternateSignatureAlgorithm = value; }
        }

        // Check to see if RequireAlternateSignatureAlgorithm property is set
        internal bool IsSetRequireAlternateSignatureAlgorithm()
        {
            return this._requireAlternateSignatureAlgorithm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireSameKeyRenewal. 
        /// <para>
        /// Renew certificate using the same private key.
        /// </para>
        /// </summary>
        public bool? RequireSameKeyRenewal
        {
            get { return this._requireSameKeyRenewal; }
            set { this._requireSameKeyRenewal = value; }
        }

        // Check to see if RequireSameKeyRenewal property is set
        internal bool IsSetRequireSameKeyRenewal()
        {
            return this._requireSameKeyRenewal.HasValue; 
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

        /// <summary>
        /// Gets and sets the property UseLegacyProvider. 
        /// <para>
        /// Specifies the cryptographic service provider category used to generate private keys.
        /// Set to TRUE to use Legacy Cryptographic Service Providers and FALSE to use Key Storage
        /// Providers.
        /// </para>
        /// </summary>
        public bool? UseLegacyProvider
        {
            get { return this._useLegacyProvider; }
            set { this._useLegacyProvider = value; }
        }

        // Check to see if UseLegacyProvider property is set
        internal bool IsSetUseLegacyProvider()
        {
            return this._useLegacyProvider.HasValue; 
        }

    }
}