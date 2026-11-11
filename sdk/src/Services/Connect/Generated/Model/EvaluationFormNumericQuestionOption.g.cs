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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the option range used for scoring in numeric questions.
    /// </summary>
    public partial class EvaluationFormNumericQuestionOption
    {
        /// <summary>
        /// Gets and sets the property AutomaticFail. 
        /// <para>
        /// The flag to mark the option as automatic fail. If an automatic fail answer is provided,
        /// the overall evaluation gets a score of 0.
        /// </para>
        /// </summary>
        public bool? AutomaticFail { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticFail property is set.
        /// </summary>
        internal bool IsSetAutomaticFail() => this.AutomaticFail.HasValue;

        /// <summary>
        /// Gets and sets the property AutomaticFailConfiguration. 
        /// <para>
        /// A configuration for automatic fail.
        /// </para>
        /// </summary>
        public AutomaticFailConfiguration AutomaticFailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticFailConfiguration property is set.
        /// </summary>
        internal bool IsSetAutomaticFailConfiguration() => this.AutomaticFailConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum answer value of the range option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum answer value of the range option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;

        /// <summary>
        /// Gets and sets the property PointsConfiguration. 
        /// <para>
        /// The points configuration for point-based scoring.
        /// </para>
        /// </summary>
        public QuestionOptionPointsConfiguration PointsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PointsConfiguration property is set.
        /// </summary>
        internal bool IsSetPointsConfiguration() => this.PointsConfiguration != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The score assigned to answer values within the range option.
        /// </para>
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;
    }
}
