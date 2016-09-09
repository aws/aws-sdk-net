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
    /// The ViewBilling response includes the following elements.
    /// </summary>
    public partial class ViewBillingResponse : AmazonWebServiceResponse
    {
        private List<BillingRecord> _billingRecords = new List<BillingRecord>();
        private string _nextPageMarker;

        /// <summary>
        /// Gets and sets the property BillingRecords. 
        /// <para>
        /// A summary of billing records.
        /// </para>
        ///  
        /// <para>
        /// Type: Complex type containing a list of billing record summaries.
        /// </para>
        ///  
        /// <para>
        /// Children: <code>DomainName</code>, <code>Operation</code>, <code>InvoiceId</code>,
        /// <code>BillDate</code> and <code>Price</code>
        /// </para>
        /// </summary>
        public List<BillingRecord> BillingRecords
        {
            get { return this._billingRecords; }
            set { this._billingRecords = value; }
        }

        // Check to see if BillingRecords property is set
        internal bool IsSetBillingRecords()
        {
            return this._billingRecords != null && this._billingRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageMarker. 
        /// <para>
        /// If there are more billing records than you specified for <code>MaxItems</code> in
        /// the request, submit another request and include the value of <code>NextPageMarker</code>
        /// in the value of <code>Marker</code>.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Parent: <code>BillingRecords</code>
        /// </para>
        /// </summary>
        public string NextPageMarker
        {
            get { return this._nextPageMarker; }
            set { this._nextPageMarker = value; }
        }

        // Check to see if NextPageMarker property is set
        internal bool IsSetNextPageMarker()
        {
            return this._nextPageMarker != null;
        }

    }
}