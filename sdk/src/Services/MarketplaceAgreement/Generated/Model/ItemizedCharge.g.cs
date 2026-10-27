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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// A breakdown of individual charges or line items within a billing or pricing context.
    /// </summary>
    public partial class ItemizedCharge
    {
        /// <summary>
        /// Gets and sets the property ChargeReference. 
        /// <para>
        /// The identifier of the expected charge that this itemized charge contributes to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ChargeReference { get; set; }

        /// <summary>
        /// Checks to see if the ChargeReference property is set.
        /// </summary>
        internal bool IsSetChargeReference() => this.ChargeReference != null;

        /// <summary>
        /// Gets and sets the property DimensionKey. 
        /// <para>
        /// The dimension key as specified in the accepted term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string DimensionKey { get; set; }

        /// <summary>
        /// Checks to see if the DimensionKey property is set.
        /// </summary>
        internal bool IsSetDimensionKey() => this.DimensionKey != null;

        /// <summary>
        /// Gets and sets the property IncrementalChargeAmount. 
        /// <para>
        /// The total incremental charge amount for this dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string IncrementalChargeAmount { get; set; }

        /// <summary>
        /// Checks to see if the IncrementalChargeAmount property is set.
        /// </summary>
        internal bool IsSetIncrementalChargeAmount() => this.IncrementalChargeAmount != null;

        /// <summary>
        /// Gets and sets the property NewQuantity. 
        /// <para>
        /// The requested quantity for this dimension.
        /// </para>
        /// </summary>
        public int? NewQuantity { get; set; }

        /// <summary>
        /// Checks to see if the NewQuantity property is set.
        /// </summary>
        internal bool IsSetNewQuantity() => this.NewQuantity.HasValue;

        /// <summary>
        /// Gets and sets the property OldQuantity. 
        /// <para>
        /// The existing quantity for this dimension from the source agreement. This value is
        /// <c>0</c> for NEW intent.
        /// </para>
        /// </summary>
        public int? OldQuantity { get; set; }

        /// <summary>
        /// Checks to see if the OldQuantity property is set.
        /// </summary>
        internal bool IsSetOldQuantity() => this.OldQuantity.HasValue;
    }
}
