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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Container for the parameters to the BatchMeterUsage operation.
    /// <important> 
    /// <para>
    ///  The <c>CustomerIdentifier</c> parameter is scheduled for deprecation. Use <c>CustomerAWSAccountID</c>
    /// instead.
    /// </para>
    ///  
    /// <para>
    /// These parameters are mutually exclusive. You can't specify both <c>CustomerIdentifier</c>
    /// and <c>CustomerAWSAccountID</c> in the same request. 
    /// </para>
    ///  </important> 
    /// <para>
    /// To post metering records for customers, SaaS applications call <c>BatchMeterUsage</c>,
    /// which is used for metering SaaS flexible consumption pricing (FCP). Identical requests
    /// are idempotent and can be retried with the same records or a subset of records. Each
    /// <c>BatchMeterUsage</c> request is for only one product. If you want to meter usage
    /// for multiple products, you must make multiple <c>BatchMeterUsage</c> calls.
    /// </para>
    ///  
    /// <para>
    /// Usage records should be submitted in quick succession following a recorded event.
    /// Usage records aren't accepted 6 hours or more after an event.
    /// </para>
    ///  
    /// <para>
    ///  <c>BatchMeterUsage</c> can process up to 25 <c>UsageRecords</c> at a time, and each
    /// request must be less than 1 MB in size. Optionally, you can have multiple usage allocations
    /// for usage data that's split into buckets according to predefined tags.
    /// </para>
    ///  
    /// <para>
    ///  <c>BatchMeterUsage</c> returns a list of <c>UsageRecordResult</c> objects, which
    /// have each <c>UsageRecord</c>. It also returns a list of <c>UnprocessedRecords</c>,
    /// which indicate errors on the service side that should be retried.
    /// </para>
    ///  
    /// <para>
    /// For Amazon Web Services Regions that support <c>BatchMeterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#batchmeterusage-region-support">BatchMeterUsage
    /// Region support</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// For an example of <c>BatchMeterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/saas-code-examples.html#saas-batchmeterusage-example">
    /// BatchMeterUsage code example</a> in the <i>Amazon Web Services Marketplace Seller
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchMeterUsageRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private string _productCode;
        private List<UsageRecord> _usageRecords = AWSConfigs.InitializeCollections ? new List<UsageRecord>() : null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// Product code is used to uniquely identify a product in Amazon Web Services Marketplace.
        /// The product code should be the same as the one used during the publishing of a new
        /// product.
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
        /// The set of <c>UsageRecords</c> to submit. <c>BatchMeterUsage</c> accepts up to 25
        /// <c>UsageRecords</c> at a time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._usageRecords != null && (this._usageRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}