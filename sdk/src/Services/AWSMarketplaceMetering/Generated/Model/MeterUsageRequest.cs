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
    /// Container for the parameters to the MeterUsage operation.
    /// API to emit metering records. For identical requests, the API is idempotent and returns
    /// the metering record ID. This is used for metering flexible consumption pricing (FCP)
    /// Amazon Machine Images (AMI) and container products.
    /// 
    ///  
    /// <para>
    ///  <c>MeterUsage</c> is authenticated on the buyer's Amazon Web Services account using
    /// credentials from the Amazon EC2 instance, Amazon ECS task, or Amazon EKS pod.
    /// </para>
    ///  
    /// <para>
    ///  <c>MeterUsage</c> can optionally include multiple usage allocations, to provide customers
    /// with usage data split into buckets by tags that you define (or allow the customer
    /// to define).
    /// </para>
    ///  
    /// <para>
    /// Submit usage records to report events from the previous hour. If you submit records
    /// that are greater than six hours after events occur, the records won’t be accepted.
    /// The timestamp in your request determines when an event is recorded. You can only report
    /// usage once per hour for each dimension. For AMI-based products, this is per dimension
    /// and per EC2 instance. For container products, this is per dimension and per ECS task
    /// or EKS pod. You can’t modify values after they’re recorded. If you report usage before
    /// the current hour ends, you will be unable to report additional usage until the next
    /// hour begins.
    /// </para>
    ///  
    /// <para>
    /// For Amazon Web Services Regions that support <c>MeterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#meterusage-region-support-ec2">MeterUsage
    /// Region support for Amazon EC2</a> and <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#meterusage-region-support-ecs-eks">MeterUsage
    /// Region support for Amazon ECS and Amazon EKS</a>. 
    /// </para>
    /// </summary>
    public partial class MeterUsageRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private string _clientToken;
        private bool? _dryRun;
        private string _productCode;
        private DateTime? _timestamp;
        private List<UsageAllocation> _usageAllocations = AWSConfigs.InitializeCollections ? new List<UsageAllocation>() : null;
        private string _usageDimension;
        private int? _usageQuantity;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotencyConflictException</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the permissions required for the action, but does not make
        /// the request. If you have the permissions, the request returns <c>DryRunOperation</c>;
        /// otherwise, it returns <c>UnauthorizedException</c>. Defaults to <c>false</c> if not
        /// specified.
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
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Timestamp, in UTC, for which the usage is being reported. Your application can meter
        /// usage for up to six hours in the past. Make sure the <c>timestamp</c> value is not
        /// before the start of the software usage.
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
        /// The set of <c>UsageAllocations</c> to submit.
        /// </para>
        ///  
        /// <para>
        /// The sum of all <c>UsageAllocation</c> quantities must equal the <c>UsageQuantity</c>
        /// of the <c>MeterUsage</c> request, and each <c>UsageAllocation</c> must have a unique
        /// set of tags (include no tags).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2500)]
        public List<UsageAllocation> UsageAllocations
        {
            get { return this._usageAllocations; }
            set { this._usageAllocations = value; }
        }

        // Check to see if UsageAllocations property is set
        internal bool IsSetUsageAllocations()
        {
            return this._usageAllocations != null && (this._usageAllocations.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Consumption value for the hour. Defaults to <c>0</c> if not specified.
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