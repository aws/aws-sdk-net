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
    /// The log odds metric details.
    /// 
    ///  
    /// <para>
    /// Account Takeover Insights (ATI) model uses event variables from the login data you
    /// provide to continuously calculate a set of variables (aggregated variables) based
    /// on historical events. For example, your ATI model might calculate the number of times
    /// an user has logged in using the same IP address. In this case, event variables used
    /// to derive the aggregated variables are <c>IP address</c> and <c>user</c>.
    /// </para>
    /// </summary>
    public partial class AggregatedLogOddsMetric
    {
        private float? _aggregatedVariablesImportance;
        private List<string> _variableNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AggregatedVariablesImportance. 
        /// <para>
        ///  The relative importance of the variables in the list to the other event variable.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float? AggregatedVariablesImportance
        {
            get { return this._aggregatedVariablesImportance; }
            set { this._aggregatedVariablesImportance = value; }
        }

        // Check to see if AggregatedVariablesImportance property is set
        internal bool IsSetAggregatedVariablesImportance()
        {
            return this._aggregatedVariablesImportance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VariableNames. 
        /// <para>
        ///  The names of all the variables. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VariableNames
        {
            get { return this._variableNames; }
            set { this._variableNames = value; }
        }

        // Check to see if VariableNames property is set
        internal bool IsSetVariableNames()
        {
            return this._variableNames != null && (this._variableNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}