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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private DateTime? _effectiveOn;
        private Offering _offering;
        private int? _quantity;
        private OfferingTransactionType _type;

        /// <summary>
        /// Gets and sets the property EffectiveOn. 
        /// <para>
        /// The date on which the offering is effective.
        /// </para>
        /// </summary>
        public DateTime? EffectiveOn
        {
            get { return this._effectiveOn; }
            set { this._effectiveOn = value; }
        }

        // Check to see if EffectiveOn property is set
        internal bool IsSetEffectiveOn()
        {
            return this._effectiveOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Offering. 
        /// <para>
        /// Represents the metadata of an offering status.
        /// </para>
        /// </summary>
        public Offering Offering
        {
            get { return this._offering; }
            set { this._offering = value; }
        }

        // Check to see if Offering property is set
        internal bool IsSetOffering()
        {
            return this._offering != null;
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of available devices in the offering.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type specified for the offering status.
        /// </para>
        /// </summary>
        public OfferingTransactionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}