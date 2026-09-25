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
    /// Parameters that control the generation of synthetic data for machine learning, including
    /// privacy settings and column classification details.
    /// </summary>
    public partial class MLSyntheticDataParameters
    {
        /// <summary>
        /// Gets and sets the property ColumnClassification. 
        /// <para>
        /// Classification details for data columns that specify how each column should be treated
        /// during synthetic data generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnClassificationDetails ColumnClassification { get; set; }

        /// <summary>
        /// Checks to see if the ColumnClassification property is set.
        /// </summary>
        internal bool IsSetColumnClassification() => this.ColumnClassification != null;

        /// <summary>
        /// Gets and sets the property Epsilon. 
        /// <para>
        /// The epsilon value for differential privacy when generating synthetic data. Lower values
        /// provide stronger privacy guarantees but may reduce data utility.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public double? Epsilon { get; set; }

        /// <summary>
        /// Checks to see if the Epsilon property is set.
        /// </summary>
        internal bool IsSetEpsilon() => this.Epsilon.HasValue;

        /// <summary>
        /// Gets and sets the property MaxMembershipInferenceAttackScore. 
        /// <para>
        /// The maximum acceptable score for membership inference attack vulnerability. Synthetic
        /// data generation fails if the score for the resulting data exceeds this threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1)]
        public double? MaxMembershipInferenceAttackScore { get; set; }

        /// <summary>
        /// Checks to see if the MaxMembershipInferenceAttackScore property is set.
        /// </summary>
        internal bool IsSetMaxMembershipInferenceAttackScore() => this.MaxMembershipInferenceAttackScore.HasValue;
    }
}
