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
    /// Container for the parameters to the ListCertificates operation.
    /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
    /// that match a specific status be listed. You can also filter by specific attributes
    /// of the certificate. Default filtering returns only <c>RSA_2048</c> certificates. For
    /// more information, see <a>Filters</a>.
    /// </summary>
    public partial class ListCertificatesRequest : AmazonCertificateManagerRequest
    {
        private List<string> _certificateStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CertificateStatuses
        {
            get { return this._certificateStatuses; }
            set { this._certificateStatuses = value; }
        }

        // Check to see if CertificateStatuses property is set
        internal bool IsSetCertificateStatuses()
        {
            return this._certificateStatuses != null && (this._certificateStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// the <c>NextToken</c> element is sent in the response. Use this <c>NextToken</c> value
        /// in a subsequent request to retrieve additional items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxItems
        {
            get { return this._maxItems; }
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
        /// you receive a response with truncated results. Set it to the value of <c>NextToken</c>
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
        /// Specifies the field to sort results by. If you specify <c>SortBy</c>, you must also
        /// specify <c>SortOrder</c>.
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
        /// Specifies the order of sorted results. If you specify <c>SortOrder</c>, you must also
        /// specify <c>SortBy</c>.
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