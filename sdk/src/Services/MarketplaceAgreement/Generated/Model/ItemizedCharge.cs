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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
        private string _chargeReference;
        private string _dimensionKey;
        private string _incrementalChargeAmount;
        private int? _newQuantity;
        private int? _oldQuantity;

        /// <summary>
        /// Gets and sets the property ChargeReference. 
        /// <para>
        /// The identifier of the expected charge that this itemized charge contributes to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ChargeReference
        {
            get { return this._chargeReference; }
            set { this._chargeReference = value; }
        }

        // Check to see if ChargeReference property is set
        internal bool IsSetChargeReference()
        {
            return this._chargeReference != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionKey. 
        /// <para>
        /// The dimension key as specified in the accepted term.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string DimensionKey
        {
            get { return this._dimensionKey; }
            set { this._dimensionKey = value; }
        }

        // Check to see if DimensionKey property is set
        internal bool IsSetDimensionKey()
        {
            return this._dimensionKey != null;
        }

        /// <summary>
        /// Gets and sets the property IncrementalChargeAmount. 
        /// <para>
        /// The total incremental charge amount for this dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string IncrementalChargeAmount
        {
            get { return this._incrementalChargeAmount; }
            set { this._incrementalChargeAmount = value; }
        }

        // Check to see if IncrementalChargeAmount property is set
        internal bool IsSetIncrementalChargeAmount()
        {
            return this._incrementalChargeAmount != null;
        }

        /// <summary>
        /// Gets and sets the property NewQuantity. 
        /// <para>
        /// The requested quantity for this dimension.
        /// </para>
        /// </summary>
        public int? NewQuantity
        {
            get { return this._newQuantity; }
            set { this._newQuantity = value; }
        }

        // Check to see if NewQuantity property is set
        internal bool IsSetNewQuantity()
        {
            return this._newQuantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OldQuantity. 
        /// <para>
        /// The existing quantity for this dimension from the source agreement. This value is
        /// <c>0</c> for NEW intent.
        /// </para>
        /// </summary>
        public int? OldQuantity
        {
            get { return this._oldQuantity; }
            set { this._oldQuantity = value; }
        }

        // Check to see if OldQuantity property is set
        internal bool IsSetOldQuantity()
        {
            return this._oldQuantity.HasValue; 
        }

    }
}