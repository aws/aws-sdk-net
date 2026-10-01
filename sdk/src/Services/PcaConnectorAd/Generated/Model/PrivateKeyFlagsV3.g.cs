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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Private key flags for v3 templates specify the client compatibility, if the private
    /// key can be exported, if user input is required when using a private key, and if an
    /// alternate signature algorithm should be used.
    /// </summary>
    public partial class PrivateKeyFlagsV3
    {
        /// <summary>
        /// Gets and sets the property ClientVersion. 
        /// <para>
        /// Defines the minimum client compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientCompatibilityV3 ClientVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClientVersion property is set.
        /// </summary>
        internal bool IsSetClientVersion() => this.ClientVersion != null;

        /// <summary>
        /// Gets and sets the property ExportableKey. 
        /// <para>
        /// Allows the private key to be exported.
        /// </para>
        /// </summary>
        public bool? ExportableKey { get; set; }

        /// <summary>
        /// Checks to see if the ExportableKey property is set.
        /// </summary>
        internal bool IsSetExportableKey() => this.ExportableKey.HasValue;

        /// <summary>
        /// Gets and sets the property RequireAlternateSignatureAlgorithm. 
        /// <para>
        /// Reguires the PKCS #1 v2.1 signature format for certificates. You should verify that
        /// your CA, objects, and applications can accept this signature format.
        /// </para>
        /// </summary>
        public bool? RequireAlternateSignatureAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the RequireAlternateSignatureAlgorithm property is set.
        /// </summary>
        internal bool IsSetRequireAlternateSignatureAlgorithm() => this.RequireAlternateSignatureAlgorithm.HasValue;

        /// <summary>
        /// Gets and sets the property StrongKeyProtectionRequired. 
        /// <para>
        /// Requirer user input when using the private key for enrollment.
        /// </para>
        /// </summary>
        public bool? StrongKeyProtectionRequired { get; set; }

        /// <summary>
        /// Checks to see if the StrongKeyProtectionRequired property is set.
        /// </summary>
        internal bool IsSetStrongKeyProtectionRequired() => this.StrongKeyProtectionRequired.HasValue;
    }
}
