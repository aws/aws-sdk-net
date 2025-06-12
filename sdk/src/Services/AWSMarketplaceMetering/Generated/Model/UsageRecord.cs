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
        private string _customerAWSAccountId;
        private string _customerIdentifier;
        private string _dimension;
        private int? _quantity;
        private DateTime? _timestamp;
        private List<UsageAllocation> _usageAllocations = AWSConfigs.InitializeCollections ? new List<UsageAllocation>() : null;

        /// <summary>
        /// Gets and sets the property CustomerAWSAccountId. 
        /// <para>
        ///  The <c>CustomerAWSAccountID</c> parameter specifies the AWS account ID of the buyer.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CustomerAWSAccountId
        {
            get { return this._customerAWSAccountId; }
            set { this._customerAWSAccountId = value; }
        }

        // Check to see if CustomerAWSAccountId property is set
        internal bool IsSetCustomerAWSAccountId()
        {
            return this._customerAWSAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerIdentifier. 
        /// <para>
        /// The <c>CustomerIdentifier</c> is obtained through the <c>ResolveCustomer</c> operation
        /// and represents an individual buyer in your application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string CustomerIdentifier
        {
            get { return this._customerIdentifier; }
            set { this._customerIdentifier = value; }
        }

        // Check to see if CustomerIdentifier property is set
        internal bool IsSetCustomerIdentifier()
        {
            return this._customerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// During the process of registering a product on Amazon Web Services Marketplace, dimensions
        /// are specified. These represent different units of value in your application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The quantity of usage consumed by the customer for the given dimension and time. Defaults
        /// to <c>0</c> if not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Timestamp, in UTC, for which the usage is being reported.
        /// </para>
        ///  
        /// <para>
        /// Your application can meter usage for up to one hour in the past. Make sure the <c>timestamp</c>
        /// value is not before the start of the software usage.
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
        /// The set of <c>UsageAllocations</c> to submit. The sum of all <c>UsageAllocation</c>
        /// quantities must equal the Quantity of the <c>UsageRecord</c>.
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

    }
}