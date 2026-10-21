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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Defines a renewal term that enables automatic agreement renewal.
    /// </summary>
    public partial class RenewalTerm
    {
        /// <summary>
        /// Gets and sets the property AdjustmentDeadline. 
        /// <para>
        /// The duration before the agreement end date by which the renewal price is finalized,
        /// represented in ISO 8601 format (for example, P30D). Only applicable with <c>PercentageRange</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string AdjustmentDeadline { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentDeadline property is set.
        /// </summary>
        internal bool IsSetAdjustmentDeadline() => this.AdjustmentDeadline != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the term.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LockoutPeriod. 
        /// <para>
        /// The duration before the agreement end date when the lockout window begins, in ISO
        /// 8601 format (for example, P30D). Absent means no lockout.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string LockoutPeriod { get; set; }

        /// <summary>
        /// Checks to see if the LockoutPeriod property is set.
        /// </summary>
        internal bool IsSetLockoutPeriod() => this.LockoutPeriod != null;

        /// <summary>
        /// Gets and sets the property MaxRenewals. 
        /// <para>
        /// The maximum number of renewals allowed on this offer. Absent means unlimited renewals.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxRenewals { get; set; }

        /// <summary>
        /// Checks to see if the MaxRenewals property is set.
        /// </summary>
        internal bool IsSetMaxRenewals() => this.MaxRenewals.HasValue;

        /// <summary>
        /// Gets and sets the property PriceIncrease. 
        /// <para>
        /// The price increase applied at each renewal cycle. Absent means identical pricing on
        /// renewal.
        /// </para>
        /// </summary>
        public PriceIncrease PriceIncrease { get; set; }

        /// <summary>
        /// Checks to see if the PriceIncrease property is set.
        /// </summary>
        internal bool IsSetPriceIncrease() => this.PriceIncrease != null;

        /// <summary>
        /// Gets and sets the property TermTemplates. 
        /// <para>
        /// Structural templates defining how specific terms are reshaped on each renewal cycle.
        /// Absent for upfront-only offers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<TermTemplate> TermTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<TermTemplate>() : null;

        /// <summary>
        /// Checks to see if the TermTemplates property is set.
        /// </summary>
        internal bool IsSetTermTemplates() => this.TermTemplates != null && (this.TermTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The category of the term.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TermType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
