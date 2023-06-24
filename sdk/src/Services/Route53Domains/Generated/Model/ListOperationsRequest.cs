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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the ListOperations operation.
    /// Returns information about all of the operations that return an operation ID and that
    /// have ever been performed on domains that were registered by the current account. 
    /// 
    ///  
    /// <para>
    /// This command runs only in the us-east-1 Region.
    /// </para>
    /// </summary>
    public partial class ListOperationsRequest : AmazonRoute53DomainsRequest
    {
        private string _marker;
        private int? _maxItems;
        private ListOperationsSortAttributeName _sortBy;
        private SortOrder _sortOrder;
        private List<string> _status = new List<string>();
        private DateTime? _submittedSince;
        private List<string> _type = new List<string>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// For an initial request for a list of operations, omit this element. If the number
        /// of operations that are not yet complete is greater than the value that you specified
        /// for <code>MaxItems</code>, you can use <code>Marker</code> to return additional operations.
        /// Get the value of <code>NextPageMarker</code> from the previous response, and submit
        /// another request that includes the value of <code>NextPageMarker</code> in the <code>Marker</code>
        /// element.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Number of domains to be returned.
        /// </para>
        ///  
        /// <para>
        /// Default: 20
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
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
        /// Gets and sets the property SortBy. 
        /// <para>
        ///  The sort type for returned values. 
        /// </para>
        /// </summary>
        public ListOperationsSortAttributeName SortBy
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
        ///  The sort order ofr returned values, either ascending or descending. 
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the operations. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null && this._status.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubmittedSince. 
        /// <para>
        /// An optional parameter that lets you get information about all the operations that
        /// you submitted after a specified date and time. Specify the date and time in Unix time
        /// format and Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime SubmittedSince
        {
            get { return this._submittedSince.GetValueOrDefault(); }
            set { this._submittedSince = value; }
        }

        // Check to see if SubmittedSince property is set
        internal bool IsSetSubmittedSince()
        {
            return this._submittedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  An arrays of the domains operation types. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=18)]
        public List<string> Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null && this._type.Count > 0; 
        }

    }
}