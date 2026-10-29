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
    /// Uniquely identifies an evaluation result.
    /// </summary>
    public partial class EvaluationResultIdentifier
    {
        /// <summary>
        /// Gets and sets the property EvaluationResultQualifier. 
        /// <para>
        /// Identifies an Config rule used to evaluate an Amazon Web Services resource, and provides
        /// the type and ID of the evaluated resource.
        /// </para>
        /// </summary>
        public EvaluationResultQualifier EvaluationResultQualifier { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationResultQualifier property is set.
        /// </summary>
        internal bool IsSetEvaluationResultQualifier() => this.EvaluationResultQualifier != null;

        /// <summary>
        /// Gets and sets the property OrderingTimestamp. 
        /// <para>
        /// The time of the event that triggered the evaluation of your Amazon Web Services resources.
        /// The time can indicate when Config delivered a configuration item change notification,
        /// or it can indicate when Config delivered the configuration snapshot, depending on
        /// which event triggered the evaluation.
        /// </para>
        /// </summary>
        public DateTime? OrderingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the OrderingTimestamp property is set.
        /// </summary>
        internal bool IsSetOrderingTimestamp() => this.OrderingTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// A Unique ID for an evaluation result.
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
