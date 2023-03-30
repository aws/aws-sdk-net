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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A metric for a particular lens in a workload.
    /// </summary>
    public partial class LensMetric
    {
        private string _lensArn;
        private List<PillarMetric> _pillars = new List<PillarMetric>();
        private Dictionary<string, int> _riskCounts = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// The lens ARN.
        /// </para>
        /// </summary>
        public string LensArn
        {
            get { return this._lensArn; }
            set { this._lensArn = value; }
        }

        // Check to see if LensArn property is set
        internal bool IsSetLensArn()
        {
            return this._lensArn != null;
        }

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The metrics for the pillars in a lens.
        /// </para>
        /// </summary>
        public List<PillarMetric> Pillars
        {
            get { return this._pillars; }
            set { this._pillars = value; }
        }

        // Check to see if Pillars property is set
        internal bool IsSetPillars()
        {
            return this._pillars != null && this._pillars.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RiskCounts.
        /// </summary>
        public Dictionary<string, int> RiskCounts
        {
            get { return this._riskCounts; }
            set { this._riskCounts = value; }
        }

        // Check to see if RiskCounts property is set
        internal bool IsSetRiskCounts()
        {
            return this._riskCounts != null && this._riskCounts.Count > 0; 
        }

    }
}