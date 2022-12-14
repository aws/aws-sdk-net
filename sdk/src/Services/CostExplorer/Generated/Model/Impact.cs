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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The dollar value of the anomaly.
    /// </summary>
    public partial class Impact
    {
        private double? _maxImpact;
        private double? _totalActualSpend;
        private double? _totalExpectedSpend;
        private double? _totalImpact;
        private double? _totalImpactPercentage;

        /// <summary>
        /// Gets and sets the property MaxImpact. 
        /// <para>
        /// The maximum dollar value that's observed for an anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double MaxImpact
        {
            get { return this._maxImpact.GetValueOrDefault(); }
            set { this._maxImpact = value; }
        }

        // Check to see if MaxImpact property is set
        internal bool IsSetMaxImpact()
        {
            return this._maxImpact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalActualSpend. 
        /// <para>
        /// The cumulative dollar amount that was actually spent during the anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double TotalActualSpend
        {
            get { return this._totalActualSpend.GetValueOrDefault(); }
            set { this._totalActualSpend = value; }
        }

        // Check to see if TotalActualSpend property is set
        internal bool IsSetTotalActualSpend()
        {
            return this._totalActualSpend.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalExpectedSpend. 
        /// <para>
        /// The cumulative dollar amount that was expected to be spent during the anomaly. It
        /// is calculated using advanced machine learning models to determine the typical spending
        /// pattern based on historical data for a customer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double TotalExpectedSpend
        {
            get { return this._totalExpectedSpend.GetValueOrDefault(); }
            set { this._totalExpectedSpend = value; }
        }

        // Check to see if TotalExpectedSpend property is set
        internal bool IsSetTotalExpectedSpend()
        {
            return this._totalExpectedSpend.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalImpact. 
        /// <para>
        /// The cumulative dollar difference between the total actual spend and total expected
        /// spend. It is calculated as <code>TotalActualSpend - TotalExpectedSpend</code>.
        /// </para>
        /// </summary>
        public double TotalImpact
        {
            get { return this._totalImpact.GetValueOrDefault(); }
            set { this._totalImpact = value; }
        }

        // Check to see if TotalImpact property is set
        internal bool IsSetTotalImpact()
        {
            return this._totalImpact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalImpactPercentage. 
        /// <para>
        /// The cumulative percentage difference between the total actual spend and total expected
        /// spend. It is calculated as <code>(TotalImpact / TotalExpectedSpend) * 100</code>.
        /// When <code>TotalExpectedSpend</code> is zero, this field is omitted. Expected spend
        /// can be zero in situations such as when you start to use a service for the first time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double TotalImpactPercentage
        {
            get { return this._totalImpactPercentage.GetValueOrDefault(); }
            set { this._totalImpactPercentage = value; }
        }

        // Check to see if TotalImpactPercentage property is set
        internal bool IsSetTotalImpactPercentage()
        {
            return this._totalImpactPercentage.HasValue; 
        }

    }
}