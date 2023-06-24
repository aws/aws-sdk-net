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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListCertificates operation.
    /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
    /// that match a specific status be listed. You can also filter by specific attributes
    /// of the certificate. Default filtering returns only <code>RSA_2048</code> certificates.
    /// For more information, see <a>Filters</a>.
    /// </summary>
    public partial class ListCertificatesRequest : AmazonCertificateManagerRequest
    {
        private List<string> _certificateStatuses = new List<string>();
        private Filters _includes;
        private int? _maxItems;
        private string _nextToken;
        private SortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property CertificateStatuses. 
        /// <para>
        /// Filter the certificate list by status value.
        /// </para>
        /// </summary>
        public List<string> CertificateStatuses
        {
            get { return this._certificateStatuses; }
            set { this._certificateStatuses = value; }
        }

        // Check to see if CertificateStatuses property is set
        internal bool IsSetCertificateStatuses()
        {
            return this._certificateStatuses != null && this._certificateStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// Filter the certificate list. For more information, see the <a>Filters</a> structure.
        /// </para>
        /// </summary>
        public Filters Includes
        {
            get { return this._includes; }
            set { this._includes = value; }
        }

        // Check to see if Includes property is set
        internal bool IsSetIncludes()
        {
            return this._includes != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this parameter when paginating results to specify the maximum number of items
        /// to return in the response. If additional items exist beyond the number you specify,
        /// the <code>NextToken</code> element is sent in the response. Use this <code>NextToken</code>
        /// value in a subsequent request to retrieve additional items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use this parameter only when paginating results and only in a subsequent request after
        /// you receive a response with truncated results. Set it to the value of <code>NextToken</code>
        /// from the response you just received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies the field to sort results by. If you specify <code>SortBy</code>, you must
        /// also specify <code>SortOrder</code>.
        /// </para>
        /// </summary>
        public SortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the order of sorted results. If you specify <code>SortOrder</code>, you
        /// must also specify <code>SortBy</code>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}