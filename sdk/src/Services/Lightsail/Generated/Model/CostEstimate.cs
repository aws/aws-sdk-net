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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the estimated cost for resources in your Lightsail for Research account.
    /// </summary>
    public partial class CostEstimate
    {
        private List<EstimateByTime> _resultsByTime = new List<EstimateByTime>();
        private string _usageType;

        /// <summary>
        /// Gets and sets the property ResultsByTime. 
        /// <para>
        /// The cost estimate result that's associated with a time period.
        /// </para>
        /// </summary>
        public List<EstimateByTime> ResultsByTime
        {
            get { return this._resultsByTime; }
            set { this._resultsByTime = value; }
        }

        // Check to see if ResultsByTime property is set
        internal bool IsSetResultsByTime()
        {
            return this._resultsByTime != null && this._resultsByTime.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The types of usage that are included in the estimate, such as costs, usage, or data
        /// transfer.
        /// </para>
        /// </summary>
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