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
    /// Contains the details of an analysis rule for an intermediate table.
    /// </summary>
    public partial class IntermediateTableAnalysisRule
    {
        /// <summary>
        /// Gets and sets the property AnalysisRulePolicy. 
        /// <para>
        /// The policy of the analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IntermediateTableAnalysisRulePolicy AnalysisRulePolicy { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisRulePolicy property is set.
        /// </summary>
        internal bool IsSetAnalysisRulePolicy() => this.AnalysisRulePolicy != null;

        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        /// The type of the analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IntermediateTableAnalysisRuleType AnalysisRuleType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisRuleType property is set.
        /// </summary>
        internal bool IsSetAnalysisRuleType() => this.AnalysisRuleType != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the analysis rule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property IntermediateTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the intermediate table associated with this analysis
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string IntermediateTableArn { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTableArn property is set.
        /// </summary>
        internal bool IsSetIntermediateTableArn() => this.IntermediateTableArn != null;

        /// <summary>
        /// Gets and sets the property IntermediateTableIdentifier. 
        /// <para>
        /// The unique identifier of the intermediate table associated with this analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IntermediateTableIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTableIdentifier property is set.
        /// </summary>
        internal bool IsSetIntermediateTableIdentifier() => this.IntermediateTableIdentifier != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the analysis rule was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
