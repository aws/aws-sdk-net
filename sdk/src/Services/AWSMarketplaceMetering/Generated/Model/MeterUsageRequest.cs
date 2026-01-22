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
    /// As a seller, your software hosted in the buyer's Amazon Web Services account uses
    /// this API action to emit metering records directly to Amazon Web Services Marketplace.
    /// You must use the following buyer Amazon Web Services account credentials to sign the
    /// API request.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For <b>Amazon EC2</b> deployments, your software must use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/iam-roles-for-amazon-ec2.html">IAM
    /// role for Amazon EC2</a> to sign the API call for <c>MeterUsage</c> API operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <b>Amazon EKS</b> deployments, your software must use <a href="https://docs.aws.amazon.com/eks/latest/userguide/iam-roles-for-service-accounts.html">IAM
    /// roles for service accounts (IRSA)</a> to sign the API call for the <c>MeterUsage</c>
    /// API operation. Using <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-identities.html">EKS
    /// Pod Identity</a>, the node role, or long-term access keys is not supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <b>Amazon ECS</b> deployments, your software must use <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">Amazon
    /// ECS task IAM</a> role to sign the API call for the <c>MeterUsage</c> API operation.
    /// Using the node role or long-term access keys are not supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <b>Amazon Bedrock AgentCore Runtime</b> deployments, your software must use the
    /// <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-permissions.html#runtime-permissions-execution">AgentCore
    /// Runtime execution role</a> to sign the API call for the <c>MeterUsage</c> API operation.
    /// Long-term access keys are not supported.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The handling of <c>MeterUsage</c> requests varies between Amazon Bedrock AgentCore
    /// Runtime and non-Amazon Bedrock AgentCore deployments.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <b>non-Amazon Bedrock AgentCore Runtime</b> deployments, you can only report usage
    /// once per hour for each dimension. For AMI-based products, this is per dimension and
    /// per EC2 instance. For container products, this is per dimension and per ECS task or
    /// EKS pod. You can't modify values after they're recorded. If you report usage before
    /// a current hour ends, you will be unable to report additional usage until the next
    /// hour begins. The <c>Timestamp</c> request parameter is rounded down to the hour and
    /// used to enforce this once-per-hour rule for idempotency. For requests that are identical
    /// after the <c>Timestamp</c> is rounded down, the API is idempotent and returns the
    /// metering record ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <b>Amazon Bedrock AgentCore Runtime</b> deployments, you can report usage multiple
    /// times per hour for the same dimension. You do not need to aggregate metering records
    /// by the hour. You must include an idempotency token in the <c>ClientToken</c> request
    /// parameter. If using an Amazon SDK or the Amazon Web Services CLI, you must use the
    /// latest version which automatically includes an idempotency token in the <c>ClientToken</c>
    /// request parameter so that the request is processed successfully. The <c>Timestamp</c>
    /// request parameter is not rounded down to the hour and is not used for duplicate validation.
    /// Requests with duplicate <c>Timestamps</c> are aggregated as long as the <c>ClientToken</c>
    /// is unique.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you submit records more than six hours after events occur, the records won't be
    /// accepted. The timestamp in your request determines when an event is recorded.
    /// </para>
    ///  
    /// <para>
    /// You can optionally include multiple usage allocations, to provide customers with usage
    /// data split into buckets by tags that you define or allow the customer to define.
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
        public bool? DryRun
        {
            get { return this._dryRun; }
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
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        public int? UsageQuantity
        {
            get { return this._usageQuantity; }
            set { this._usageQuantity = value; }
        }

        // Check to see if UsageQuantity property is set
        internal bool IsSetUsageQuantity()
        {
            return this._usageQuantity.HasValue; 
        }

    }
}