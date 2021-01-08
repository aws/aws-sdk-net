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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// Information about a Savings Plan rate.
    /// </summary>
    public partial class SavingsPlanRate
    {
        private CurrencyCode _currency;
        private string _operation;
        private SavingsPlanProductType _productType;
        private List<SavingsPlanRateProperty> _properties = new List<SavingsPlanRateProperty>();
        private string _rate;
        private SavingsPlanRateServiceCode _serviceCode;
        private SavingsPlanRateUnit _unit;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency.
        /// </para>
        /// </summary>
        public CurrencyCode Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The specific AWS operation for the line item in the billing report.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The product type.
        /// </para>
        /// </summary>
        public SavingsPlanProductType ProductType
        {
            get { return this._productType; }
            set { this._productType = value; }
        }

        // Check to see if ProductType property is set
        internal bool IsSetProductType()
        {
            return this._productType != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties.
        /// </para>
        /// </summary>
        public List<SavingsPlanRateProperty> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Rate. 
        /// <para>
        /// The rate.
        /// </para>
        /// </summary>
        public string Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }

        // Check to see if Rate property is set
        internal bool IsSetRate()
        {
            return this._rate != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service.
        /// </para>
        /// </summary>
        public SavingsPlanRateServiceCode ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit.
        /// </para>
        /// </summary>
        public SavingsPlanRateUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The usage details of the line item in the billing report.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

    }
}