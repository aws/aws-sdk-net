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
    /// Container for the parameters to the SearchCertificates operation. Retrieves a list
    /// of certificates matching search criteria. You can filter certificates by X.509 attributes
    /// and ACM specific properties like certificate status, type and renewal eligibility.
    /// This operation provides more flexible filtering than <a>ListCertificates</a> by supporting
    /// complex filter statements.
    /// </summary>
    public partial class SearchCertificatesRequest : AmazonCertificateManagerRequest
    {
        /// <summary>
        /// Gets and sets the property FilterStatement. 
        /// <para>
        /// A filter statement that defines the search criteria. You can combine multiple filters
        /// using AND, OR, and NOT logical operators to create complex queries.
        /// </para>
        /// </summary>
        public CertificateFilterStatement FilterStatement { get; set; }

        /// <summary>
        /// Checks to see if the FilterStatement property is set.
        /// </summary>
        internal bool IsSetFilterStatement() => this.FilterStatement != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. Default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        /// Specifies the field to sort results by. Valid values are CREATED_AT, NOT_AFTER, STATUS,
        /// RENEWAL_STATUS, EXPORTED, IN_USE, NOT_BEFORE, KEY_ALGORITHM, TYPE, CERTIFICATE_ARN,
        /// COMMON_NAME, REVOKED_AT, RENEWAL_ELIGIBILITY, ISSUED_AT, MANAGED_BY, EXPORT_OPTION,
        /// VALIDATION_METHOD, and IMPORTED_AT.
        /// </para>
        /// </summary>
        public SearchCertificatesSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the order of sorted results. Valid values are ASCENDING or DESCENDING.
        /// </para>
        /// </summary>
        public SearchCertificatesSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
