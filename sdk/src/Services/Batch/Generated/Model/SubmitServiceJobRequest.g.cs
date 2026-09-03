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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the SubmitServiceJob operation. Submits a service
    /// job to a specified job queue to run on SageMaker AI. A service job is a unit of work
    /// that you submit to Batch for execution on SageMaker AI.
    /// </summary>
    public partial class SubmitServiceJobRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. This token is used to ensure idempotency of requests.
        /// If this parameter is specified and two submit requests with identical payloads and
        /// <c>clientToken</c>s are received, these requests are considered the same request and
        /// the second request is rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the service job. It can be up to 128 characters long. It can contain uppercase
        /// and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The job queue into which the service job is submitted. You can specify either the
        /// name or the ARN of the queue. The job queue must have the type <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueue { get; set; }

        /// <summary>
        /// Checks to see if the JobQueue property is set.
        /// </summary>
        internal bool IsSetJobQueue() => this.JobQueue != null;

        /// <summary>
        /// Gets and sets the property PreemptionConfiguration. 
        /// <para>
        /// Specifies the service job behavior when preempted.
        /// </para>
        /// </summary>
        public ServiceJobPreemptionConfiguration PreemptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PreemptionConfiguration property is set.
        /// </summary>
        internal bool IsSetPreemptionConfiguration() => this.PreemptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property QuotaShareName. 
        /// <para>
        /// The quota share for the service job. Don't specify this parameter if the job queue
        /// doesn't have a quota share scheduling policy. If the job queue has a quota share scheduling
        /// policy, then this parameter must be specified.
        /// </para>
        /// </summary>
        public string QuotaShareName { get; set; }

        /// <summary>
        /// Checks to see if the QuotaShareName property is set.
        /// </summary>
        internal bool IsSetQuotaShareName() => this.QuotaShareName != null;

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed service jobs that are submitted with this service
        /// job request. 
        /// </para>
        /// </summary>
        public ServiceJobRetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling priority of the service job. Valid values are integers between 0 and
        /// 9999.
        /// </para>
        /// </summary>
        public int? SchedulingPriority { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingPriority property is set.
        /// </summary>
        internal bool IsSetSchedulingPriority() => this.SchedulingPriority.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceJobType. 
        /// <para>
        /// The type of service job. For SageMaker Training jobs, specify <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceJobType ServiceJobType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceJobType property is set.
        /// </summary>
        internal bool IsSetServiceJobType() => this.ServiceJobType != null;

        /// <summary>
        /// Gets and sets the property ServiceRequestPayload. 
        /// <para>
        /// The request, in JSON, for the service that the SubmitServiceJob operation is queueing.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceRequestPayload { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRequestPayload property is set.
        /// </summary>
        internal bool IsSetServiceRequestPayload() => this.ServiceRequestPayload != null;

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the service job. Don't specify this parameter if the job
        /// queue doesn't have a fair-share scheduling policy. If the job queue has a fair-share
        /// scheduling policy, then this parameter must be specified.
        /// </para>
        /// </summary>
        public string ShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ShareIdentifier property is set.
        /// </summary>
        internal bool IsSetShareIdentifier() => this.ShareIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the service job request. Each tag consists of a key and
        /// an optional value. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// The timeout configuration for the service job. If none is specified, Batch defers
        /// to the default timeout of the underlying service handling the job.
        /// </para>
        /// </summary>
        public ServiceJobTimeout TimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfig property is set.
        /// </summary>
        internal bool IsSetTimeoutConfig() => this.TimeoutConfig != null;
    }
}
