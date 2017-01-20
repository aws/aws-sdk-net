/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// A structure holds the actual and forecasted spend for a budget.
    /// </summary>
    public partial class CalculatedSpend
    {
        private Spend _actualSpend;
        private Spend _forecastedSpend;

        /// <summary>
        /// Gets and sets the property ActualSpend.
        /// </summary>
        public Spend ActualSpend
        {
            get { return this._actualSpend; }
            set { this._actualSpend = value; }
        }

        // Check to see if ActualSpend property is set
        internal bool IsSetActualSpend()
        {
            return this._actualSpend != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastedSpend.
        /// </summary>
        public Spend ForecastedSpend
        {
            get { return this._forecastedSpend; }
            set { this._forecastedSpend = value; }
        }

        // Check to see if ForecastedSpend property is set
        internal bool IsSetForecastedSpend()
        {
            return this._forecastedSpend != null;
        }

    }
}