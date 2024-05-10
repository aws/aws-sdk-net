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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCertificates operation.
    /// Override the system-default Secure Sockets Layer/Transport Layer Security (SSL/TLS)
    /// certificate for Amazon RDS for new DB instances, or remove the override.
    /// 
    ///  
    /// <para>
    /// By using this operation, you can specify an RDS-approved SSL/TLS certificate for new
    /// DB instances that is different from the default certificate provided by RDS. You can
    /// also use this operation to remove the override, so that new DB instances use the default
    /// certificate provided by RDS.
    /// </para>
    ///  
    /// <para>
    /// You might need to override the default certificate in the following situations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You already migrated your applications to support the latest certificate authority
    /// (CA) certificate, but the new CA certificate is not yet the RDS default CA certificate
    /// for the specified Amazon Web Services Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// RDS has already moved to a new default CA certificate for the specified Amazon Web
    /// Services Region, but you are still in the process of supporting the new CA certificate.
    /// In this case, you temporarily need additional time to finish your application changes.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about rotating your SSL/TLS certificate for RDS DB engines, see
    /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL-certificate-rotation.html">
    /// Rotating Your SSL/TLS Certificate</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about rotating your SSL/TLS certificate for Aurora DB engines,
    /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL-certificate-rotation.html">
    /// Rotating Your SSL/TLS Certificate</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyCertificatesRequest : AmazonRDSRequest
    {
        private string _certificateIdentifier;
        private bool? _removeCustomerOverride;

        /// <summary>
        /// Gets and sets the property CertificateIdentifier. 
        /// <para>
        /// The new default certificate identifier to override the current one with.
        /// </para>
        ///  
        /// <para>
        /// To determine the valid values, use the <c>describe-certificates</c> CLI command or
        /// the <c>DescribeCertificates</c> API operation.
        /// </para>
        /// </summary>
        public string CertificateIdentifier
        {
            get { return this._certificateIdentifier; }
            set { this._certificateIdentifier = value; }
        }

        // Check to see if CertificateIdentifier property is set
        internal bool IsSetCertificateIdentifier()
        {
            return this._certificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveCustomerOverride. 
        /// <para>
        /// Specifies whether to remove the override for the default certificate. If the override
        /// is removed, the default certificate is the system default.
        /// </para>
        /// </summary>
        public bool? RemoveCustomerOverride
        {
            get { return this._removeCustomerOverride; }
            set { this._removeCustomerOverride = value; }
        }

        // Check to see if RemoveCustomerOverride property is set
        internal bool IsSetRemoveCustomerOverride()
        {
            return this._removeCustomerOverride.HasValue; 
        }

    }
}