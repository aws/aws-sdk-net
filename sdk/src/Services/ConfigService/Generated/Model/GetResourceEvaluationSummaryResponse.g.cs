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
    /// This is the response object from the GetResourceEvaluationSummary operation.
    /// </summary>
    public partial class GetResourceEvaluationSummaryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// The compliance status of the resource evaluation summary.
        /// </para>
        /// </summary>
        public ComplianceType Compliance { get; set; }

        /// <summary>
        /// Checks to see if the Compliance property is set.
        /// </summary>
        internal bool IsSetCompliance() => this.Compliance != null;

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// Returns an <c>EvaluationContext</c> object.
        /// </para>
        /// </summary>
        public EvaluationContext EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// Lists results of the mode that you requested to retrieve the resource evaluation summary.
        /// The valid values are Detective or Proactive.
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
        /// The start timestamp when Config rule starts evaluating compliance for the provided
        /// resource details.
        /// </para>
        /// </summary>
        public DateTime? EvaluationStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationStartTimestamp property is set.
        /// </summary>
        internal bool IsSetEvaluationStartTimestamp() => this.EvaluationStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationStatus. 
        /// <para>
        /// Returns an <c>EvaluationStatus</c> object.
        /// </para>
        /// </summary>
        public EvaluationStatus EvaluationStatus { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationStatus property is set.
        /// </summary>
        internal bool IsSetEvaluationStatus() => this.EvaluationStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Returns a <c>ResourceDetails</c> object.
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDetails property is set.
        /// </summary>
        internal bool IsSetResourceDetails() => this.ResourceDetails != null;

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// The unique <c>ResourceEvaluationId</c> of Amazon Web Services resource execution for
        /// which you want to retrieve the evaluation summary.
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
