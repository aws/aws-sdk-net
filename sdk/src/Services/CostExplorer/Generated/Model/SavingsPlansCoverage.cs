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
    /// The amount of Savings Plans eligible usage that is covered by Savings Plans. All calculations
    /// consider the On-Demand equivalent of your Savings Plans usage.
    /// </summary>
    public partial class SavingsPlansCoverage
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private SavingsPlansCoverageData _coverage;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attribute that applies to a specific <code>Dimension</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Coverage. 
        /// <para>
        /// The amount of Savings Plans eligible usage that the Savings Plans covered.
        /// </para>
        /// </summary>
        public SavingsPlansCoverageData Coverage
        {
            get { return this._coverage; }
            set { this._coverage = value; }
        }

        // Check to see if Coverage property is set
        internal bool IsSetCoverage()
        {
            return this._coverage != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod.
        /// </summary>
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}