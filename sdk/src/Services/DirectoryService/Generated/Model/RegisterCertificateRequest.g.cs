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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterCertificate operation. Registers a certificate
    /// for a secure LDAP or client certificate authentication.
    /// </summary>
    public partial class RegisterCertificateRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateData. 
        /// <para>
        /// The certificate PEM string that needs to be registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string CertificateData { get; set; }

        /// <summary>
        /// Checks to see if the CertificateData property is set.
        /// </summary>
        internal bool IsSetCertificateData() => this.CertificateData != null;

        /// <summary>
        /// Gets and sets the property ClientCertAuthSettings. 
        /// <para>
        /// A <c>ClientCertAuthSettings</c> object that contains client certificate authentication
        /// settings.
        /// </para>
        /// </summary>
        public ClientCertAuthSettings ClientCertAuthSettings { get; set; }

        /// <summary>
        /// Checks to see if the ClientCertAuthSettings property is set.
        /// </summary>
        internal bool IsSetClientCertAuthSettings() => this.ClientCertAuthSettings != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The function that the registered certificate performs. Valid values include <c>ClientLDAPS</c>
        /// or <c>ClientCertAuth</c>. The default value is <c>ClientLDAPS</c>.
        /// </para>
        /// </summary>
        public CertificateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
