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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns details of a resource evaluation.
    /// </summary>
    public partial class ResourceEvaluation
    {
        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// The mode of an evaluation. The valid values are Detective or Proactive.
        /// </para>
        /// </summary>
        public EvaluationMode EvaluationMode { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMode property is set.
        /// </summary>
        internal bool IsSetEvaluationMode() => this.EvaluationMode != null;

        /// <summary>
        /// Gets and sets the property EvaluationStartTimestamp. 
        /// <para>
        /// The starting time of an execution.
        /// </para>
        /// </summary>
        public DateTime? EvaluationStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationStartTimestamp property is set.
        /// </summary>
        internal bool IsSetEvaluationStartTimestamp() => this.EvaluationStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// The ResourceEvaluationId of a evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ResourceEvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceEvaluationId property is set.
        /// </summary>
        internal bool IsSetResourceEvaluationId() => this.ResourceEvaluationId != null;
    }
}
