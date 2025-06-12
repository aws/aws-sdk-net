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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// The ViewBilling response includes the following elements.
    /// </summary>
    public partial class ViewBillingResponse : AmazonWebServiceResponse
    {
        private List<BillingRecord> _billingRecords = AWSConfigs.InitializeCollections ? new List<BillingRecord>() : null;
        private string _nextPageMarker;

        /// <summary>
        /// Gets and sets the property BillingRecords. 
        /// <para>
        /// A summary of billing records.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BillingRecord> BillingRecords
        {
            get { return this._billingRecords; }
            set { this._billingRecords = value; }
        }

        // Check to see if BillingRecords property is set
        internal bool IsSetBillingRecords()
        {
            return this._billingRecords != null && (this._billingRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextPageMarker. 
        /// <para>
        /// If there are more billing records than you specified for <c>MaxItems</c> in the request,
        /// submit another request and include the value of <c>NextPageMarker</c> in the value
        /// of <c>Marker</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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