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
    /// A UsageRecord indicates a quantity of usage for a given product, customer, dimension
    /// and time.
    /// 
    ///  
    /// <para>
    /// Multiple requests with the same UsageRecords as input will be deduplicated to prevent
    /// double charges.
    /// </para>
    /// </summary>
    public partial class UsageRecord
    {
        private string _customerIdentifier;
        private string _dimension;
        private int? _quantity;
        private DateTime? _timestamp;
        private List<UsageAllocation> _usageAllocations = new List<UsageAllocation>();

        /// <summary>
        /// Gets and sets the property CustomerIdentifier. 
        /// <para>
        /// The CustomerIdentifier is obtained through the ResolveCustomer operation and represents
        /// an individual buyer in your application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// During the process of registering a product on AWS Marketplace, up to eight dimensions
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
        /// to <code>0</code> if not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
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
        /// Your application can meter usage for up to one hour in the past. Make sure the timestamp
        /// value is not before the start of the software usage.
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
        /// The set of UsageAllocations to submit. The sum of all UsageAllocation quantities must
        /// equal the Quantity of the UsageRecord.
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

    }
}