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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A <c>UsageRecord</c> indicates a quantity of usage for a given product, customer,
    /// dimension and time.
    /// 
    ///  
    /// <para>
    /// Multiple requests with the same <c>UsageRecords</c> as input will be de-duplicated
    /// to prevent double charges.
    /// </para>
    /// </summary>
    public partial class UsageRecord
    {
        /// <summary>
        /// Gets and sets the property CustomerAWSAccountId. 
        /// <para>
        /// The <c>CustomerAWSAccountId</c> parameter specifies the AWS account ID of the buyer.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you have an existing integration and need the <c>CustomerAWSAccountId</c> that
        /// corresponds to a <c>CustomerIdentifier</c>, contact <a href="https://aws.amazon.com/marketplace/management/contact-us/">AWS
        /// Marketplace Seller Operations</a> to obtain the mapping. Do not request the <c>CustomerAWSAccountId</c>
        /// directly from buyers. We cannot verify that a buyer-provided account ID is authentic,
        /// which can result in incorrect metering or billing.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CustomerAWSAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAWSAccountId property is set.
        /// </summary>
        internal bool IsSetCustomerAWSAccountId() => this.CustomerAWSAccountId != null;

        /// <summary>
        /// Gets and sets the property CustomerIdentifier. 
        /// <para>
        /// The <c>CustomerIdentifier</c> is obtained through the <c>ResolveCustomer</c> operation
        /// and represents an individual buyer in your application.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>CustomerIdentifier</c> is not supported for new SaaS product integrations. Use
        /// <c>CustomerAWSAccountId</c> to identify the buyer.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string CustomerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CustomerIdentifier property is set.
        /// </summary>
        internal bool IsSetCustomerIdentifier() => this.CustomerIdentifier != null;

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// During the process of registering a product on Amazon Web Services Marketplace, dimensions
        /// are specified. These represent different units of value in your application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Dimension { get; set; }

        /// <summary>
        /// Checks to see if the Dimension property is set.
        /// </summary>
        internal bool IsSetDimension() => this.Dimension != null;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// The <c>LicenseArn</c> is a unique identifier for a specific granted license. These
        /// are used for software purchased through Amazon Web Services Marketplace.
        /// </para>
        ///  <note> 
        /// <para>
        /// To access your <c>CustomerAWSAccountId</c> and <c>LicenseArn</c> mapping, visit <a
        /// href="https://docs.aws.amazon.com/marketplace/latest/userguide/data-feed-agreements.html">Agreements
        /// Feeds</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The quantity of usage consumed by the customer for the given dimension and time. Defaults
        /// to <c>0</c> if not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Timestamp, in UTC, for which the usage is being reported.
        /// </para>
        ///  
        /// <para>
        /// Your application can meter usage for up to 24 hours in the past. Make sure the <c>timestamp</c>
        /// value is not before the start of the software usage.
        /// </para>
        ///  
        /// <para>
        /// At the end of each billing cycle, you have a 6-hour grace period to submit usage records
        /// for the previous billing month before 06:00 UTC on the first day of the next month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UsageAllocations. 
        /// <para>
        /// The set of <c>UsageAllocations</c> to submit. The sum of all <c>UsageAllocation</c>
        /// quantities must equal the Quantity of the <c>UsageRecord</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2500)]
        public List<UsageAllocation> UsageAllocations { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageAllocation>() : null;

        /// <summary>
        /// Checks to see if the UsageAllocations property is set.
        /// </summary>
        internal bool IsSetUsageAllocations() => this.UsageAllocations != null && (this.UsageAllocations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
