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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// The status of the offering.
    /// </summary>
    public partial class OfferingStatus
    {
        /// <summary>
        /// Gets and sets the property EffectiveOn. 
        /// <para>
        /// The date on which the offering is effective.
        /// </para>
        /// </summary>
        public DateTime? EffectiveOn { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveOn property is set.
        /// </summary>
        internal bool IsSetEffectiveOn() => this.EffectiveOn.HasValue;

        /// <summary>
        /// Gets and sets the property Offering. 
        /// <para>
        /// Represents the metadata of an offering status.
        /// </para>
        /// </summary>
        public Offering Offering { get; set; }

        /// <summary>
        /// Checks to see if the Offering property is set.
        /// </summary>
        internal bool IsSetOffering() => this.Offering != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of available devices in the offering.
        /// </para>
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type specified for the offering status.
        /// </para>
        /// </summary>
        public OfferingTransactionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
