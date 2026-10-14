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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// This is the response object from the GetPlanEvaluationStatus operation.
    /// </summary>
    public partial class GetPlanEvaluationStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EvaluationState. 
        /// <para>
        /// The evaluation state for the plan.
        /// </para>
        /// </summary>
        public EvaluationStatus EvaluationState { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationState property is set.
        /// </summary>
        internal bool IsSetEvaluationState() => this.EvaluationState != null;

        /// <summary>
        /// Gets and sets the property LastEvaluatedVersion. 
        /// <para>
        /// The version of the last evaluation of the plan.
        /// </para>
        /// </summary>
        public string LastEvaluatedVersion { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedVersion property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedVersion() => this.LastEvaluatedVersion != null;

        /// <summary>
        /// Gets and sets the property LastEvaluationTime. 
        /// <para>
        /// The time of the last time that Region switch ran an evaluation of the plan.
        /// </para>
        /// </summary>
        public DateTime? LastEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastEvaluationTime() => this.LastEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>nextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>nextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PlanArn property is set.
        /// </summary>
        internal bool IsSetPlanArn() => this.PlanArn != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region for the plan.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// The current evaluation warnings for the plan. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceWarning> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceWarning>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
