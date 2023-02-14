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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfiguredTableAnalysisRule operation.
    /// Updates a configured table analysis rule.
    /// </summary>
    public partial class UpdateConfiguredTableAnalysisRuleRequest : AmazonCleanRoomsRequest
    {
        private ConfiguredTableAnalysisRulePolicy _analysisRulePolicy;
        private ConfiguredTableAnalysisRuleType _analysisRuleType;
        private string _configuredTableIdentifier;

        /// <summary>
        /// Gets and sets the property AnalysisRulePolicy. 
        /// <para>
        /// The new analysis rule policy for the configured table analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAnalysisRulePolicy AnalysisRulePolicy
        {
            get { return this._analysisRulePolicy; }
            set { this._analysisRulePolicy = value; }
        }

        // Check to see if AnalysisRulePolicy property is set
        internal bool IsSetAnalysisRulePolicy()
        {
            return this._analysisRulePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        /// The analysis rule type to be updated. Configured table analysis rules are uniquely
        /// identified by their configured table identifier and analysis rule type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAnalysisRuleType AnalysisRuleType
        {
            get { return this._analysisRuleType; }
            set { this._analysisRuleType = value; }
        }

        // Check to see if AnalysisRuleType property is set
        internal bool IsSetAnalysisRuleType()
        {
            return this._analysisRuleType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredTableIdentifier. 
        /// <para>
        /// The unique identifier for the configured table that the analysis rule applies to.
        /// Currently accepts the configured table ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ConfiguredTableIdentifier
        {
            get { return this._configuredTableIdentifier; }
            set { this._configuredTableIdentifier = value; }
        }

        // Check to see if ConfiguredTableIdentifier property is set
        internal bool IsSetConfiguredTableIdentifier()
        {
            return this._configuredTableIdentifier != null;
        }

    }
}