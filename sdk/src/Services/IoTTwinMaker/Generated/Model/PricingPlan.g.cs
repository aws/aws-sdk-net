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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The pricing plan.
    /// </summary>
    public partial class PricingPlan
    {
        /// <summary>
        /// Gets and sets the property BillableEntityCount. 
        /// <para>
        /// The billable entity count.
        /// </para>
        /// </summary>
        public long? BillableEntityCount { get; set; }

        /// <summary>
        /// Checks to see if the BillableEntityCount property is set.
        /// </summary>
        internal bool IsSetBillableEntityCount() => this.BillableEntityCount.HasValue;

        /// <summary>
        /// Gets and sets the property BundleInformation. 
        /// <para>
        /// The pricing plan's bundle information.
        /// </para>
        /// </summary>
        public BundleInformation BundleInformation { get; set; }

        /// <summary>
        /// Checks to see if the BundleInformation property is set.
        /// </summary>
        internal bool IsSetBundleInformation() => this.BundleInformation != null;

        /// <summary>
        /// Gets and sets the property EffectiveDateTime. 
        /// <para>
        /// The effective date and time of the pricing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDateTime property is set.
        /// </summary>
        internal bool IsSetEffectiveDateTime() => this.EffectiveDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property PricingMode. 
        /// <para>
        /// The pricing mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PricingMode PricingMode { get; set; }

        /// <summary>
        /// Checks to see if the PricingMode property is set.
        /// </summary>
        internal bool IsSetPricingMode() => this.PricingMode != null;

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The set date and time for updating a pricing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDateTime property is set.
        /// </summary>
        internal bool IsSetUpdateDateTime() => this.UpdateDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// The update reason for changing a pricing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateReason UpdateReason { get; set; }

        /// <summary>
        /// Checks to see if the UpdateReason property is set.
        /// </summary>
        internal bool IsSetUpdateReason() => this.UpdateReason != null;
    }
}
