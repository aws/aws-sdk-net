/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the ViewBilling operation.
    /// Returns all the domain-related billing records for the current AWS account for a specified
    /// period
    /// </summary>
    public partial class ViewBillingRequest : AmazonRoute53DomainsRequest
    {
        private DateTime? _end;
        private string _marker;
        private int? _maxItems;
        private DateTime? _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end date and time for the time period for which you want a list of billing records.
        /// Specify the date and time in Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime End
        {
            get { return this._end.GetValueOrDefault(); }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// For an initial request for a list of billing records, omit this element. If the number
        /// of billing records that are associated with the current AWS account during the specified
        /// period is greater than the value that you specified for <code>MaxItems</code>, you
        /// can use <code>Marker</code> to return additional billing records. Get the value of
        /// <code>NextPageMarker</code> from the previous response, and submit another request
        /// that includes the value of <code>NextPageMarker</code> in the <code>Marker</code>
        /// element. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: The marker must match the value of <code>NextPageMarker</code> that was
        /// returned in the previous response.
        /// </para>
        /// </summary>
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
        /// The number of billing records to be returned.
        /// </para>
        ///  
        /// <para>
        /// Default: 20
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Start. 
        /// <para>
        /// The beginning date and time for the time period for which you want a list of billing
        /// records. Specify the date and time in Coordinated Universal time (UTC).
        /// </para>
        /// </summary>
        public DateTime Start
        {
            get { return this._start.GetValueOrDefault(); }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}