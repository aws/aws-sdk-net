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
    /// Container for the parameters to the ListCertificates operation. Retrieves a list of
    /// certificate ARNs and domain names. You can request that only certificates that match
    /// a specific status be listed. You can also filter by specific attributes of the certificate.
    /// Default filtering returns only <c>RSA_2048</c> certificates. For more information,
    /// see <a>Filters</a>. <note> <para> By default, this action does not return certificates
    /// with a <c>CertificateKeyPairOrigin</c> of <c>ACME</c>. To include ACME certificates,
    /// specify <c>ACME</c> in the <c>CertificateKeyPairOrigins</c> filter. </para> </note>
    /// </summary>
    public partial class ListCertificatesRequest : AmazonCertificateManagerRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateKeyPairOrigins. 
        /// <para>
        /// Filter the certificate list by certificate key pair origin. Specify one or more <c>CertificateKeyPairOrigin</c>
        /// values. Default filtering returns only certificates with key pair origin of <c>AWS_MANAGED</c>
        /// and <c>CUSTOMER_PROVIDED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> CertificateKeyPairOrigins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CertificateKeyPairOrigins property is set.
        /// </summary>
        internal bool IsSetCertificateKeyPairOrigins() => this.CertificateKeyPairOrigins != null && (this.CertificateKeyPairOrigins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CertificateStatuses. 
        /// <para>
        /// Filter the certificate list by status value.
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
        /// Gets and sets the property Includes. 
        /// <para>
        /// Filter the certificate list. For more information, see the <a>Filters</a> structure.
        /// </para>
        /// </summary>
        public Filters Includes { get; set; }

        /// <summary>
        /// Checks to see if the Includes property is set.
        /// </summary>
        internal bool IsSetIncludes() => this.Includes != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this parameter when paginating results to specify the maximum number of items
        /// to return in the response. If additional items exist beyond the number you specify,
        /// the <c>NextToken</c> element is sent in the response. Use this <c>NextToken</c> value
        /// in a subsequent request to retrieve additional items.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use this parameter only when paginating results and only in a subsequent request after
        /// you receive a response with truncated results. Set it to the value of <c>NextToken</c>
        /// from the response you just received.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies the field to sort results by. If you specify <c>SortBy</c>, you must also
        /// specify <c>SortOrder</c>.
        /// </para>
        /// </summary>
        public SortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the order of sorted results. If you specify <c>SortOrder</c>, you must also
        /// specify <c>SortBy</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
