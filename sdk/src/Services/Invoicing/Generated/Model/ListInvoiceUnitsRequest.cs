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
    /// Container for the parameters to the ListInvoiceUnits operation.
    /// This fetches a list of all invoice unit definitions for a given account, as of the
    /// provided <c>AsOf</c> date.
    /// </summary>
    public partial class ListInvoiceUnitsRequest : AmazonInvoicingRequest
    {
        private DateTime? _asOf;
        private Filters _filters;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AsOf. 
        /// <para>
        ///  The state of an invoice unit at a specified time. You can see legacy invoice units
        /// that are currently deleted if the <c>AsOf</c> time is set to before it was deleted.
        /// If an <c>AsOf</c> is not provided, the default value is the current time. 
        /// </para>
        /// </summary>
        public DateTime? AsOf
        {
            get { return this._asOf; }
            set { this._asOf = value; }
        }

        // Check to see if AsOf property is set
        internal bool IsSetAsOf()
        {
            return this._asOf.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  An optional input to the list API. If multiple filters are specified, the returned
        /// list will be a configuration that match all of the provided filters. Supported filter
        /// types are <c>InvoiceReceivers</c>, <c>Names</c>, and <c>Accounts</c>. 
        /// </para>
        /// </summary>
        public Filters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of invoice units that can be returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// The next token used to indicate where the returned list should start from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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

    }
}