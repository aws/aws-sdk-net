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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The parameters that determine the budget amount for an auto-adjusting budget.
    /// </summary>
    public partial class AutoAdjustData
    {
        private AutoAdjustType _autoAdjustType;
        private HistoricalOptions _historicalOptions;
        private DateTime? _lastAutoAdjustTime;

        /// <summary>
        /// Gets and sets the property AutoAdjustType. 
        /// <para>
        /// The string that defines whether your budget auto-adjusts based on historical or forecasted
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoAdjustType AutoAdjustType
        {
            get { return this._autoAdjustType; }
            set { this._autoAdjustType = value; }
        }

        // Check to see if AutoAdjustType property is set
        internal bool IsSetAutoAdjustType()
        {
            return this._autoAdjustType != null;
        }

        /// <summary>
        /// Gets and sets the property HistoricalOptions. 
        /// <para>
        /// The parameters that define or describe the historical data that your auto-adjusting
        /// budget is based on.
        /// </para>
        /// </summary>
        public HistoricalOptions HistoricalOptions
        {
            get { return this._historicalOptions; }
            set { this._historicalOptions = value; }
        }

        // Check to see if HistoricalOptions property is set
        internal bool IsSetHistoricalOptions()
        {
            return this._historicalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property LastAutoAdjustTime. 
        /// <para>
        /// The last time that your budget was auto-adjusted.
        /// </para>
        /// </summary>
        public DateTime? LastAutoAdjustTime
        {
            get { return this._lastAutoAdjustTime; }
            set { this._lastAutoAdjustTime = value; }
        }

        // Check to see if LastAutoAdjustTime property is set
        internal bool IsSetLastAutoAdjustTime()
        {
            return this._lastAutoAdjustTime.HasValue; 
        }

    }
}