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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceEntitlementService.Model
{
    /// <summary>
    /// The EntitlementValue represents the amount of capacity that the customer is entitled
    /// to for the product.
    /// </summary>
    public partial class EntitlementValue
    {
        private bool? _booleanValue;
        private double? _doubleValue;
        private int? _integerValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// The BooleanValue field will be populated with a boolean value when the entitlement
        /// is a boolean type. Otherwise, the field will not be set.
        /// </para>
        /// </summary>
        public bool BooleanValue
        {
            get { return this._booleanValue.GetValueOrDefault(); }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// The DoubleValue field will be populated with a double value when the entitlement is
        /// a double type. Otherwise, the field will not be set.
        /// </para>
        /// </summary>
        public double DoubleValue
        {
            get { return this._doubleValue.GetValueOrDefault(); }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// The IntegerValue field will be populated with an integer value when the entitlement
        /// is an integer type. Otherwise, the field will not be set.
        /// </para>
        /// </summary>
        public int IntegerValue
        {
            get { return this._integerValue.GetValueOrDefault(); }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The StringValue field will be populated with a string value when the entitlement is
        /// a string type. Otherwise, the field will not be set.
        /// </para>
        /// </summary>
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}