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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Defines a filter for searching certificates by ARN, X.509 attributes, or ACM metadata.
    /// </summary>
    public partial class CertificateFilter
    {
        /// <summary>
        /// Gets and sets the property AcmCertificateMetadataFilter. 
        /// <para>
        /// Filter by ACM certificate metadata.
        /// </para>
        /// </summary>
        public AcmCertificateMetadataFilter AcmCertificateMetadataFilter { get; set; }

        /// <summary>
        /// Checks to see if the AcmCertificateMetadataFilter property is set.
        /// </summary>
        internal bool IsSetAcmCertificateMetadataFilter() => this.AcmCertificateMetadataFilter != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Filter by certificate ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property X509AttributeFilter. 
        /// <para>
        /// Filter by X.509 certificate attributes.
        /// </para>
        /// </summary>
        public X509AttributeFilter X509AttributeFilter { get; set; }

        /// <summary>
        /// Checks to see if the X509AttributeFilter property is set.
        /// </summary>
        internal bool IsSetX509AttributeFilter() => this.X509AttributeFilter != null;
    }
}
