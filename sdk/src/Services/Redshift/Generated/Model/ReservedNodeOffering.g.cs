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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a reserved node offering.
    /// </summary>
    public partial class ReservedNodeOffering
    {
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the compute nodes offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration, in seconds, for which the offering will reserve the node.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The upfront fixed charge you will pay to purchase the specific reserved node offering.
        /// </para>
        /// </summary>
        public double? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type offered by the reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The anticipated utilization of the reserved node, as defined in the reserved node
        /// offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The charge to your account regardless of whether you are creating any clusters using
        /// the node offering. Recurring charges are only in effect for heavy-utilization reserved
        /// nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecurringCharge> RecurringCharges { get; set; } = AWSConfigs.InitializeCollections ? new List<RecurringCharge>() : null;

        /// <summary>
        /// Checks to see if the RecurringCharges property is set.
        /// </summary>
        internal bool IsSetRecurringCharges() => this.RecurringCharges != null && (this.RecurringCharges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReservedNodeOfferingId. 
        /// <para>
        /// The offering identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ReservedNodeOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodeOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedNodeOfferingId() => this.ReservedNodeOfferingId != null;

        /// <summary>
        /// Gets and sets the property ReservedNodeOfferingType. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public ReservedNodeOfferingType ReservedNodeOfferingType { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodeOfferingType property is set.
        /// </summary>
        internal bool IsSetReservedNodeOfferingType() => this.ReservedNodeOfferingType != null;

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The rate you are charged for each hour the cluster that is using the offering is running.
        /// </para>
        /// </summary>
        public double? UsagePrice { get; set; }

        /// <summary>
        /// Checks to see if the UsagePrice property is set.
        /// </summary>
        internal bool IsSetUsagePrice() => this.UsagePrice.HasValue;
    }
}
