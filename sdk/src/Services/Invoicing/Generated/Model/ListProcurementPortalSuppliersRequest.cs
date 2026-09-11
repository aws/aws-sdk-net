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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Container for the parameters to the ListProcurementPortalSuppliers operation.
    /// Returns the suppliers configured for a specified procurement portal, including supplier
    /// identifiers and associated metadata. For faster, more reliable responses, use pagination.
    /// </summary>
    public partial class ListProcurementPortalSuppliersRequest : AmazonInvoicingRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _portalIdentifier;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned NextToken value. Default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You received this token from a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property PortalIdentifier. 
        /// <para>
        /// The unique identifier of the procurement portal for which to list suppliers. Use the
        /// <c>PortalIdentifier</c> value returned by <c>ListProcurementPortals</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string PortalIdentifier
        {
            get { return this._portalIdentifier; }
            set { this._portalIdentifier = value; }
        }

        // Check to see if PortalIdentifier property is set
        internal bool IsSetPortalIdentifier()
        {
            return this._portalIdentifier != null;
        }

    }
}