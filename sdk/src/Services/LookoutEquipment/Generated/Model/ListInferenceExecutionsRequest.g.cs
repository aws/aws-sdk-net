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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListInferenceExecutions operation. Lists all inference
    /// executions that have been performed by the specified inference scheduler.
    /// </summary>
    public partial class ListInferenceExecutionsRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property DataEndTimeBefore. 
        /// <para>
        /// The time reference in the inferenced dataset before which Amazon Lookout for Equipment
        /// stopped the inference execution. 
        /// </para>
        /// </summary>
        public DateTime? DataEndTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the DataEndTimeBefore property is set.
        /// </summary>
        internal bool IsSetDataEndTimeBefore() => this.DataEndTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property DataStartTimeAfter. 
        /// <para>
        /// The time reference in the inferenced dataset after which Amazon Lookout for Equipment
        /// started the inference execution. 
        /// </para>
        /// </summary>
        public DateTime? DataStartTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the DataStartTimeAfter property is set.
        /// </summary>
        internal bool IsSetDataStartTimeAfter() => this.DataStartTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler for the inference execution listed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string InferenceSchedulerName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerName property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerName() => this.InferenceSchedulerName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of inference executions to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token indicating where to continue the listing of inference executions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the inference execution. 
        /// </para>
        /// </summary>
        public InferenceExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
