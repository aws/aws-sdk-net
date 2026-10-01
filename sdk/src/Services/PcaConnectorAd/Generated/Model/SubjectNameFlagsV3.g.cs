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
    /// Information to include in the subject name and alternate subject name of the certificate.
    /// The subject name can be common name, directory path, DNS as common name, or left blank.
    /// You can optionally include email to the subject name for user templates. If you leave
    /// the subject name blank then you must set a subject alternate name. The subject alternate
    /// name (SAN) can include globally unique identifier (GUID), DNS, domain DNS, email,
    /// service principal name (SPN), and user principal name (UPN). You can leave the SAN
    /// blank. If you leave the SAN blank, then you must set a subject name.
    /// </summary>
    public partial class SubjectNameFlagsV3
    {
        /// <summary>
        /// Gets and sets the property RequireCommonName. 
        /// <para>
        /// Include the common name in the subject name. 
        /// </para>
        /// </summary>
        public bool? RequireCommonName { get; set; }

        /// <summary>
        /// Checks to see if the RequireCommonName property is set.
        /// </summary>
        internal bool IsSetRequireCommonName() => this.RequireCommonName.HasValue;

        /// <summary>
        /// Gets and sets the property RequireDirectoryPath. 
        /// <para>
        /// Include the directory path in the subject name.
        /// </para>
        /// </summary>
        public bool? RequireDirectoryPath { get; set; }

        /// <summary>
        /// Checks to see if the RequireDirectoryPath property is set.
        /// </summary>
        internal bool IsSetRequireDirectoryPath() => this.RequireDirectoryPath.HasValue;

        /// <summary>
        /// Gets and sets the property RequireDnsAsCn. 
        /// <para>
        /// Include the DNS as common name in the subject name.
        /// </para>
        /// </summary>
        public bool? RequireDnsAsCn { get; set; }

        /// <summary>
        /// Checks to see if the RequireDnsAsCn property is set.
        /// </summary>
        internal bool IsSetRequireDnsAsCn() => this.RequireDnsAsCn.HasValue;

        /// <summary>
        /// Gets and sets the property RequireEmail. 
        /// <para>
        /// Include the subject's email in the subject name.
        /// </para>
        /// </summary>
        public bool? RequireEmail { get; set; }

        /// <summary>
        /// Checks to see if the RequireEmail property is set.
        /// </summary>
        internal bool IsSetRequireEmail() => this.RequireEmail.HasValue;

        /// <summary>
        /// Gets and sets the property SanRequireDirectoryGuid. 
        /// <para>
        /// Include the globally unique identifier (GUID) in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireDirectoryGuid { get; set; }

        /// <summary>
        /// Checks to see if the SanRequireDirectoryGuid property is set.
        /// </summary>
        internal bool IsSetSanRequireDirectoryGuid() => this.SanRequireDirectoryGuid.HasValue;

        /// <summary>
        /// Gets and sets the property SanRequireDns. 
        /// <para>
        /// Include the DNS in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireDns { get; set; }

        /// <summary>
        /// Checks to see if the SanRequireDns property is set.
        /// </summary>
        internal bool IsSetSanRequireDns() => this.SanRequireDns.HasValue;

        /// <summary>
        /// Gets and sets the property SanRequireDomainDns. 
        /// <para>
        /// Include the domain DNS in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireDomainDns { get; set; }

        /// <summary>
        /// Checks to see if the SanRequireDomainDns property is set.
        /// </summary>
        internal bool IsSetSanRequireDomainDns() => this.SanRequireDomainDns.HasValue;

        /// <summary>
        /// Gets and sets the property SanRequireEmail. 
        /// <para>
        /// Include the subject's email in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireEmail { get; set; }

        /// <summary>
        /// Checks to see if the SanRequireEmail property is set.
        /// </summary>
        internal bool IsSetSanRequireEmail() => this.SanRequireEmail.HasValue;

        /// <summary>
        /// Gets and sets the property SanRequireSpn. 
        /// <para>
        /// Include the service principal name (SPN) in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireSpn { get; set; }

        /// <summary>
        /// Checks to see if the SanRequireSpn property is set.
        /// </summary>
        internal bool IsSetSanRequireSpn() => this.SanRequireSpn.HasValue;

        /// <summary>
        /// Gets and sets the property SanRequireUpn. 
        /// <para>
        /// Include the user principal name (UPN) in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireUpn { get; set; }

        /// <summary>
        /// Checks to see if the SanRequireUpn property is set.
        /// </summary>
        internal bool IsSetSanRequireUpn() => this.SanRequireUpn.HasValue;
    }
}
