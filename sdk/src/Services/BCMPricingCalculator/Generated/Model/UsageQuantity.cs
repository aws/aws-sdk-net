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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents a usage quantity with associated unit and time period.
    /// </summary>
    public partial class UsageQuantity
    {
        private double? _amount;
        private DateTime? _startHour;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        ///  The numeric value of the usage quantity. 
        /// </para>
        /// </summary>
        public double? Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartHour. 
        /// <para>
        ///  The start hour of the usage period. 
        /// </para>
        /// </summary>
        public DateTime? StartHour
        {
            get { return this._startHour; }
            set { this._startHour = value; }
        }

        // Check to see if StartHour property is set
        internal bool IsSetStartHour()
        {
            return this._startHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The unit of measurement for the usage quantity. 
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}