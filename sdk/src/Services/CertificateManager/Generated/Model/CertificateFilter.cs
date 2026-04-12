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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
        private AcmCertificateMetadataFilter _acmCertificateMetadataFilter;
        private string _certificateArn;
        private X509AttributeFilter _x509AttributeFilter;

        /// <summary>
        /// Gets and sets the property AcmCertificateMetadataFilter. 
        /// <para>
        /// Filter by ACM certificate metadata.
        /// </para>
        /// </summary>
        public AcmCertificateMetadataFilter AcmCertificateMetadataFilter
        {
            get { return this._acmCertificateMetadataFilter; }
            set { this._acmCertificateMetadataFilter = value; }
        }

        // Check to see if AcmCertificateMetadataFilter property is set
        internal bool IsSetAcmCertificateMetadataFilter()
        {
            return this._acmCertificateMetadataFilter != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Filter by certificate ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property X509AttributeFilter. 
        /// <para>
        /// Filter by X.509 certificate attributes.
        /// </para>
        /// </summary>
        public X509AttributeFilter X509AttributeFilter
        {
            get { return this._x509AttributeFilter; }
            set { this._x509AttributeFilter = value; }
        }

        // Check to see if X509AttributeFilter property is set
        internal bool IsSetX509AttributeFilter()
        {
            return this._x509AttributeFilter != null;
        }

    }
}