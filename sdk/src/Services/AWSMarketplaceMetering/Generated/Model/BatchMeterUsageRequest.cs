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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Container for the parameters to the BatchMeterUsage operation.
    /// <code>BatchMeterUsage</code> is called from a SaaS application listed on AWS Marketplace
    /// to post metering records for a set of customers.
    /// 
    ///  
    /// <para>
    /// For identical requests, the API is idempotent; requests can be retried with the same
    /// records or a subset of the input records.
    /// </para>
    ///  
    /// <para>
    /// Every request to <code>BatchMeterUsage</code> is for one product. If you need to meter
    /// usage for multiple products, you must make multiple calls to <code>BatchMeterUsage</code>.
    /// </para>
    ///  
    /// <para>
    /// Usage records are expected to be submitted as quickly as possible after the event
    /// that is being recorded, and are not accepted more than 6 hours after the event.
    /// </para>
    ///  
    /// <para>
    ///  <code>BatchMeterUsage</code> can process up to 25 <code>UsageRecords</code> at a
    /// time.
    /// </para>
    ///  
    /// <para>
    /// A <code>UsageRecord</code> can optionally include multiple usage allocations, to provide
    /// customers with usage data split into buckets by tags that you define (or allow the
    /// customer to define).
    /// </para>
    ///  
    /// <para>
    ///  <code>BatchMeterUsage</code> returns a list of <code>UsageRecordResult</code> objects,
    /// showing the result for each <code>UsageRecord</code>, as well as a list of <code>UnprocessedRecords</code>,
    /// indicating errors in the service side that you should retry.
    /// </para>
    ///  
    /// <para>
    ///  <code>BatchMeterUsage</code> requests must be less than 1MB in size.
    /// </para>
    ///  <note> 
    /// <para>
    /// For an example of using <code>BatchMeterUsage</code>, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/saas-code-examples.html#saas-batchmeterusage-example">
    /// BatchMeterUsage code example</a> in the <i>AWS Marketplace Seller Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchMeterUsageRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private string _productCode;
        private List<UsageRecord> _usageRecords = new List<UsageRecord>();

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// Product code is used to uniquely identify a product in AWS Marketplace. The product
        /// code should be the same as the one used during the publishing of a new product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

        /// <summary>
        /// Gets and sets the property UsageRecords. 
        /// <para>
        /// The set of <code>UsageRecords</code> to submit. <code>BatchMeterUsage</code> accepts
        /// up to 25 <code>UsageRecords</code> at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<UsageRecord> UsageRecords
        {
            get { return this._usageRecords; }
            set { this._usageRecords = value; }
        }

        // Check to see if UsageRecords property is set
        internal bool IsSetUsageRecords()
        {
            return this._usageRecords != null && this._usageRecords.Count > 0; 
        }

    }
}