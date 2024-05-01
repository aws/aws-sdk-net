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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The details of the event variable's impact on the prediction score.
    /// </summary>
    public partial class VariableImpactExplanation
    {
        private string _eventVariableName;
        private float? _logOddsImpact;
        private string _relativeImpact;

        /// <summary>
        /// Gets and sets the property EventVariableName. 
        /// <para>
        ///  The event variable name. 
        /// </para>
        /// </summary>
        public string EventVariableName
        {
            get { return this._eventVariableName; }
            set { this._eventVariableName = value; }
        }

        // Check to see if EventVariableName property is set
        internal bool IsSetEventVariableName()
        {
            return this._eventVariableName != null;
        }

        /// <summary>
        /// Gets and sets the property LogOddsImpact. 
        /// <para>
        ///  The raw, uninterpreted value represented as log-odds of the fraud. These values are
        /// usually between -10 to +10, but range from - infinity to + infinity.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A positive value indicates that the variable drove the risk score up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A negative value indicates that the variable drove the risk score down.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public float? LogOddsImpact
        {
            get { return this._logOddsImpact; }
            set { this._logOddsImpact = value; }
        }

        // Check to see if LogOddsImpact property is set
        internal bool IsSetLogOddsImpact()
        {
            return this._logOddsImpact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelativeImpact. 
        /// <para>
        ///  The event variable's relative impact in terms of magnitude on the prediction scores.
        /// The relative impact values consist of a numerical rating (0-5, 5 being the highest)
        /// and direction (increased/decreased) impact of the fraud risk. 
        /// </para>
        /// </summary>
        public string RelativeImpact
        {
            get { return this._relativeImpact; }
            set { this._relativeImpact = value; }
        }

        // Check to see if RelativeImpact property is set
        internal bool IsSetRelativeImpact()
        {
            return this._relativeImpact != null;
        }

    }
}