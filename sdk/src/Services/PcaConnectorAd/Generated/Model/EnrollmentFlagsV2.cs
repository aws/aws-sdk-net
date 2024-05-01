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
    /// Template configurations for v2 template schema.
    /// </summary>
    public partial class EnrollmentFlagsV2
    {
        private bool? _enableKeyReuseOnNtTokenKeysetStorageFull;
        private bool? _includeSymmetricAlgorithms;
        private bool? _noSecurityExtension;
        private bool? _removeInvalidCertificateFromPersonalStore;
        private bool? _userInteractionRequired;

        /// <summary>
        /// Gets and sets the property EnableKeyReuseOnNtTokenKeysetStorageFull. 
        /// <para>
        /// Allow renewal using the same key.
        /// </para>
        /// </summary>
        public bool? EnableKeyReuseOnNtTokenKeysetStorageFull
        {
            get { return this._enableKeyReuseOnNtTokenKeysetStorageFull; }
            set { this._enableKeyReuseOnNtTokenKeysetStorageFull = value; }
        }

        // Check to see if EnableKeyReuseOnNtTokenKeysetStorageFull property is set
        internal bool IsSetEnableKeyReuseOnNtTokenKeysetStorageFull()
        {
            return this._enableKeyReuseOnNtTokenKeysetStorageFull.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeSymmetricAlgorithms. 
        /// <para>
        /// Include symmetric algorithms allowed by the subject.
        /// </para>
        /// </summary>
        public bool? IncludeSymmetricAlgorithms
        {
            get { return this._includeSymmetricAlgorithms; }
            set { this._includeSymmetricAlgorithms = value; }
        }

        // Check to see if IncludeSymmetricAlgorithms property is set
        internal bool IsSetIncludeSymmetricAlgorithms()
        {
            return this._includeSymmetricAlgorithms.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoSecurityExtension. 
        /// <para>
        /// This flag instructs the CA to not include the security extension szOID_NTDS_CA_SECURITY_EXT
        /// (OID:1.3.6.1.4.1.311.25.2), as specified in [MS-WCCE] sections 2.2.2.7.7.4 and 3.2.2.6.2.1.4.5.9,
        /// in the issued certificate. This addresses a Windows Kerberos elevation-of-privilege
        /// vulnerability.
        /// </para>
        /// </summary>
        public bool? NoSecurityExtension
        {
            get { return this._noSecurityExtension; }
            set { this._noSecurityExtension = value; }
        }

        // Check to see if NoSecurityExtension property is set
        internal bool IsSetNoSecurityExtension()
        {
            return this._noSecurityExtension.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveInvalidCertificateFromPersonalStore. 
        /// <para>
        /// Delete expired or revoked certificates instead of archiving them.
        /// </para>
        /// </summary>
        public bool? RemoveInvalidCertificateFromPersonalStore
        {
            get { return this._removeInvalidCertificateFromPersonalStore; }
            set { this._removeInvalidCertificateFromPersonalStore = value; }
        }

        // Check to see if RemoveInvalidCertificateFromPersonalStore property is set
        internal bool IsSetRemoveInvalidCertificateFromPersonalStore()
        {
            return this._removeInvalidCertificateFromPersonalStore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserInteractionRequired. 
        /// <para>
        /// Require user interaction when the subject is enrolled and the private key associated
        /// with the certificate is used.
        /// </para>
        /// </summary>
        public bool? UserInteractionRequired
        {
            get { return this._userInteractionRequired; }
            set { this._userInteractionRequired = value; }
        }

        // Check to see if UserInteractionRequired property is set
        internal bool IsSetUserInteractionRequired()
        {
            return this._userInteractionRequired.HasValue; 
        }

    }
}