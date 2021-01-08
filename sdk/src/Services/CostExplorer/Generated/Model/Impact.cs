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
    /// The anomaly's dollar value.
    /// </summary>
    public partial class Impact
    {
        private double? _maxImpact;
        private double? _totalImpact;

        /// <summary>
        /// Gets and sets the property MaxImpact. 
        /// <para>
        ///  The maximum dollar value observed for an anomaly. 
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
        /// Gets and sets the property TotalImpact. 
        /// <para>
        ///  The cumulative dollar value observed for an anomaly. 
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

    }
}