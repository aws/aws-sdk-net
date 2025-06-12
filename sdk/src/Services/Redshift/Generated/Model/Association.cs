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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Contains information about the custom domain name association.
    /// </summary>
    public partial class Association
    {
        private List<CertificateAssociation> _certificateAssociations = AWSConfigs.InitializeCollections ? new List<CertificateAssociation>() : null;
        private string _customDomainCertificateArn;
        private DateTime? _customDomainCertificateExpiryDate;

        /// <summary>
        /// Gets and sets the property CertificateAssociations. 
        /// <para>
        /// A list of all associated clusters and domain names tied to a specific certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CertificateAssociation> CertificateAssociations
        {
            get { return this._certificateAssociations; }
            set { this._certificateAssociations = value; }
        }

        // Check to see if CertificateAssociations property is set
        internal bool IsSetCertificateAssociations()
        {
            return this._certificateAssociations != null && (this._certificateAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate associated with the custom domain.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string CustomDomainCertificateArn
        {
            get { return this._customDomainCertificateArn; }
            set { this._customDomainCertificateArn = value; }
        }

        // Check to see if CustomDomainCertificateArn property is set
        internal bool IsSetCustomDomainCertificateArn()
        {
            return this._customDomainCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateExpiryDate. 
        /// <para>
        /// The expiration date for the certificate.
        /// </para>
        /// </summary>
        public DateTime? CustomDomainCertificateExpiryDate
        {
            get { return this._customDomainCertificateExpiryDate; }
            set { this._customDomainCertificateExpiryDate = value; }
        }

        // Check to see if CustomDomainCertificateExpiryDate property is set
        internal bool IsSetCustomDomainCertificateExpiryDate()
        {
            return this._customDomainCertificateExpiryDate.HasValue; 
        }

    }
}