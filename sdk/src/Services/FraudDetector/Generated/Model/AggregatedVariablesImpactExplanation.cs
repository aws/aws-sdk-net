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
    /// The details of the impact of aggregated variables on the prediction score. 
    /// 
    ///  
    /// <para>
    /// Account Takeover Insights (ATI) model uses the login data you provide to continuously
    /// calculate a set of variables (aggregated variables) based on historical events. For
    /// example, the model might calculate the number of times an user has logged in using
    /// the same IP address. In this case, event variables used to derive the aggregated variables
    /// are <c>IP address</c> and <c>user</c>.
    /// </para>
    /// </summary>
    public partial class AggregatedVariablesImpactExplanation
    {
        private List<string> _eventVariableNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _logOddsImpact;
        private string _relativeImpact;

        /// <summary>
        /// Gets and sets the property EventVariableNames. 
        /// <para>
        ///  The names of all the event variables that were used to derive the aggregated variables.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventVariableNames
        {
            get { return this._eventVariableNames; }
            set { this._eventVariableNames = value; }
        }

        // Check to see if EventVariableNames property is set
        internal bool IsSetEventVariableNames()
        {
            return this._eventVariableNames != null && (this._eventVariableNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogOddsImpact. 
        /// <para>
        ///  The raw, uninterpreted value represented as log-odds of the fraud. These values are
        /// usually between -10 to +10, but range from -infinity to +infinity.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A positive value indicates that the variables drove the risk score up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A negative value indicates that the variables drove the risk score down.
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
        ///  The relative impact of the aggregated variables in terms of magnitude on the prediction
        /// scores. 
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