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
    /// Container for the parameters to the MeterUsage operation.
    /// API to emit metering records. For identical requests, the API is idempotent. It simply
    /// returns the metering record ID.
    /// 
    ///  
    /// <para>
    /// MeterUsage is authenticated on the buyer's AWS account using credentials from the
    /// EC2 instance, ECS task, or EKS pod.
    /// </para>
    ///  
    /// <para>
    /// MeterUsage can optionally include multiple usage allocations, to provide customers
    /// with usage data split into buckets by tags that you define (or allow the customer
    /// to define).
    /// </para>
    /// </summary>
    public partial class MeterUsageRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private bool? _dryRun;
        private string _productCode;
        private DateTime? _timestamp;
        private List<UsageAllocation> _usageAllocations = new List<UsageAllocation>();
        private string _usageDimension;
        private int? _usageQuantity;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the permissions required for the action, but does not make
        /// the request. If you have the permissions, the request returns DryRunOperation; otherwise,
        /// it returns UnauthorizedException. Defaults to <code>false</code> if not specified.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

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
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Timestamp, in UTC, for which the usage is being reported. Your application can meter
        /// usage for up to one hour in the past. Make sure the timestamp value is not before
        /// the start of the software usage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageAllocations. 
        /// <para>
        /// The set of UsageAllocations to submit.
        /// </para>
        ///  
        /// <para>
        /// The sum of all UsageAllocation quantities must equal the UsageQuantity of the MeterUsage
        /// request, and each UsageAllocation must have a unique set of tags (include no tags).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<UsageAllocation> UsageAllocations
        {
            get { return this._usageAllocations; }
            set { this._usageAllocations = value; }
        }

        // Check to see if UsageAllocations property is set
        internal bool IsSetUsageAllocations()
        {
            return this._usageAllocations != null && this._usageAllocations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsageDimension. 
        /// <para>
        /// It will be one of the fcp dimension name provided during the publishing of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string UsageDimension
        {
            get { return this._usageDimension; }
            set { this._usageDimension = value; }
        }

        // Check to see if UsageDimension property is set
        internal bool IsSetUsageDimension()
        {
            return this._usageDimension != null;
        }

        /// <summary>
        /// Gets and sets the property UsageQuantity. 
        /// <para>
        /// Consumption value for the hour. Defaults to <code>0</code> if not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int UsageQuantity
        {
            get { return this._usageQuantity.GetValueOrDefault(); }
            set { this._usageQuantity = value; }
        }

        // Check to see if UsageQuantity property is set
        internal bool IsSetUsageQuantity()
        {
            return this._usageQuantity.HasValue; 
        }

    }
}