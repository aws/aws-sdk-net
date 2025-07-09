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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about analysis rules for the internal access analyzer. Analysis
    /// rules determine which entities will generate findings based on the criteria you define
    /// when you create the rule.
    /// </summary>
    public partial class InternalAccessAnalysisRule
    {
        private List<InternalAccessAnalysisRuleCriteria> _inclusions = AWSConfigs.InitializeCollections ? new List<InternalAccessAnalysisRuleCriteria>() : null;

        /// <summary>
        /// Gets and sets the property Inclusions. 
        /// <para>
        /// A list of rules for the internal access analyzer containing criteria to include in
        /// analysis. Only resources that meet the rule criteria will generate findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InternalAccessAnalysisRuleCriteria> Inclusions
        {
            get { return this._inclusions; }
            set { this._inclusions = value; }
        }

        // Check to see if Inclusions property is set
        internal bool IsSetInclusions()
        {
            return this._inclusions != null && (this._inclusions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}