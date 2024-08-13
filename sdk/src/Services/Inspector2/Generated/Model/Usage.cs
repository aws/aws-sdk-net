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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains usage information about the cost of Amazon Inspector operation.
    /// </summary>
    public partial class Usage
    {
        private Currency _currency;
        private double? _estimatedMonthlyCost;
        private double? _total;
        private UsageType _type;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency type used when calculating usage data.
        /// </para>
        /// </summary>
        public Currency Currency
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
        /// Gets and sets the property EstimatedMonthlyCost. 
        /// <para>
        /// The estimated monthly cost of Amazon Inspector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? EstimatedMonthlyCost
        {
            get { return this._estimatedMonthlyCost; }
            set { this._estimatedMonthlyCost = value; }
        }

        // Check to see if EstimatedMonthlyCost property is set
        internal bool IsSetEstimatedMonthlyCost()
        {
            return this._estimatedMonthlyCost.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total of usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type scan.
        /// </para>
        /// </summary>
        public UsageType Type
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