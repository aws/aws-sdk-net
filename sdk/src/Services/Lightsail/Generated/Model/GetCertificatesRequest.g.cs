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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetCertificates operation. Returns information
    /// about one or more Amazon Lightsail SSL/TLS certificates. <note> <para> To get a summary
    /// of a certificate, omit <c>includeCertificateDetails</c> from your request. The response
    /// will include only the certificate Amazon Resource Name (ARN), certificate name, domain
    /// name, and tags. </para> </note>
    /// </summary>
    public partial class GetCertificatesRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name for the certificate for which to return information.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes all of your certificates in the Amazon Web Services
        /// Region where the request is made.
        /// </para>
        /// </summary>
        public string CertificateName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateName property is set.
        /// </summary>
        internal bool IsSetCertificateName() => this.CertificateName != null;

        /// <summary>
        /// Gets and sets the property CertificateStatuses. 
        /// <para>
        /// The status of the certificates for which to return information.
        /// </para>
        ///  
        /// <para>
        /// For example, specify <c>ISSUED</c> to return only certificates with an <c>ISSUED</c>
        /// status.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes all of your certificates in the Amazon Web Services
        /// Region where the request is made, regardless of their current status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CertificateStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CertificateStatuses property is set.
        /// </summary>
        internal bool IsSetCertificateStatuses() => this.CertificateStatuses != null && (this.CertificateStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeCertificateDetails. 
        /// <para>
        /// Indicates whether to include detailed information about the certificates in the response.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes only the certificate names, Amazon Resource Names
        /// (ARNs), domain names, and tags.
        /// </para>
        /// </summary>
        public bool? IncludeCertificateDetails { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCertificateDetails property is set.
        /// </summary>
        internal bool IsSetIncludeCertificateDetails() => this.IncludeCertificateDetails.HasValue;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetCertificates</c> request. If your results
        /// are paginated, the response will return a next page token that you can specify as
        /// the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;
    }
}
