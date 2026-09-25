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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfiguredTableAnalysisRule operation. Creates
    /// a new analysis rule for a configured table. Currently, only one analysis rule can
    /// be created for a given configured table.
    /// </summary>
    public partial class CreateConfiguredTableAnalysisRuleRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property AnalysisRulePolicy. 
        /// <para>
        /// The analysis rule policy that was created for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfiguredTableAnalysisRulePolicy AnalysisRulePolicy { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisRulePolicy property is set.
        /// </summary>
        internal bool IsSetAnalysisRulePolicy() => this.AnalysisRulePolicy != null;

        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        /// The type of analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfiguredTableAnalysisRuleType AnalysisRuleType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisRuleType property is set.
        /// </summary>
        internal bool IsSetAnalysisRuleType() => this.AnalysisRuleType != null;

        /// <summary>
        /// Gets and sets the property ConfiguredTableIdentifier. 
        /// <para>
        /// The identifier for the configured table to create the analysis rule for. Currently
        /// accepts the configured table ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ConfiguredTableIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredTableIdentifier property is set.
        /// </summary>
        internal bool IsSetConfiguredTableIdentifier() => this.ConfiguredTableIdentifier != null;
    }
}
