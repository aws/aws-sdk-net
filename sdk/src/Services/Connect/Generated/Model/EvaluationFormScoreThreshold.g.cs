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
    /// Information about a score threshold for a performance category.
    /// </summary>
    public partial class EvaluationFormScoreThreshold
    {
        /// <summary>
        /// Gets and sets the property MaxScorePercentage. 
        /// <para>
        /// The maximum score percentage for the performance category.
        /// </para>
        /// </summary>
        public double? MaxScorePercentage { get; set; }

        /// <summary>
        /// Checks to see if the MaxScorePercentage property is set.
        /// </summary>
        internal bool IsSetMaxScorePercentage() => this.MaxScorePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property MinScorePercentage. 
        /// <para>
        /// The minimum score percentage for the performance category.
        /// </para>
        /// </summary>
        public double? MinScorePercentage { get; set; }

        /// <summary>
        /// Checks to see if the MinScorePercentage property is set.
        /// </summary>
        internal bool IsSetMinScorePercentage() => this.MinScorePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property PerformanceCategory. 
        /// <para>
        /// The performance category name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PerformanceCategoryName PerformanceCategory { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceCategory property is set.
        /// </summary>
        internal bool IsSetPerformanceCategory() => this.PerformanceCategory != null;
    }
}
