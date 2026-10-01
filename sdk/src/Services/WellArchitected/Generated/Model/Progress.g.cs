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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Progress information for a recommendation generation process.
    /// </summary>
    public partial class Progress
    {
        /// <summary>
        /// Gets and sets the property CompletionPercentage. 
        /// <para>
        /// The completion percentage of the generation process (0-100).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? CompletionPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CompletionPercentage property is set.
        /// </summary>
        internal bool IsSetCompletionPercentage() => this.CompletionPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property StepsCompleted. 
        /// <para>
        /// The number of generation steps that have been completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StepsCompleted { get; set; }

        /// <summary>
        /// Checks to see if the StepsCompleted property is set.
        /// </summary>
        internal bool IsSetStepsCompleted() => this.StepsCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSteps. 
        /// <para>
        /// The total number of steps in the generation process.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalSteps { get; set; }

        /// <summary>
        /// Checks to see if the TotalSteps property is set.
        /// </summary>
        internal bool IsSetTotalSteps() => this.TotalSteps.HasValue;
    }
}
