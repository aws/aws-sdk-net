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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
    /// Container for the parameters to the SubmitServiceJob operation.
    /// Submits a service job to a specified job queue to run on SageMaker AI. A service job
    /// is a unit of work that you submit to Batch for execution on SageMaker AI.
    /// </summary>
    public partial class SubmitServiceJobRequest : AmazonBatchRequest
    {
        private string _clientToken;
        private string _jobName;
        private string _jobQueue;
        private ServiceJobRetryStrategy _retryStrategy;
        private int? _schedulingPriority;
        private ServiceJobType _serviceJobType;
        private string _serviceRequestPayload;
        private string _shareIdentifier;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ServiceJobTimeout _timeoutConfig;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. This token is used to ensure idempotency of requests.
        /// If this parameter is specified and two submit requests with identical payloads and
        /// <c>clientToken</c>s are received, these requests are considered the same request and
        /// the second request is rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the service job. It can be up to 128 characters long. It can contain uppercase
        /// and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The job queue into which the service job is submitted. You can specify either the
        /// name or the ARN of the queue. The job queue must have the type <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed service jobs that are submitted with this service
        /// job request. 
        /// </para>
        /// </summary>
        public ServiceJobRetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling priority of the service job. Valid values are integers between 0 and
        /// 9999.
        /// </para>
        /// </summary>
        public int? SchedulingPriority
        {
            get { return this._schedulingPriority; }
            set { this._schedulingPriority = value; }
        }

        // Check to see if SchedulingPriority property is set
        internal bool IsSetSchedulingPriority()
        {
            return this._schedulingPriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceJobType. 
        /// <para>
        /// The type of service job. For SageMaker Training jobs, specify <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceJobType ServiceJobType
        {
            get { return this._serviceJobType; }
            set { this._serviceJobType = value; }
        }

        // Check to see if ServiceJobType property is set
        internal bool IsSetServiceJobType()
        {
            return this._serviceJobType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRequestPayload. 
        /// <para>
        /// The request, in JSON, for the service that the SubmitServiceJob operation is queueing.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceRequestPayload
        {
            get { return this._serviceRequestPayload; }
            set { this._serviceRequestPayload = value; }
        }

        // Check to see if ServiceRequestPayload property is set
        internal bool IsSetServiceRequestPayload()
        {
            return this._serviceRequestPayload != null;
        }

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the service job. Don't specify this parameter if the job
        /// queue doesn't have a fair-share scheduling policy. If the job queue has a fair-share
        /// scheduling policy, then this parameter must be specified.
        /// </para>
        /// </summary>
        public string ShareIdentifier
        {
            get { return this._shareIdentifier; }
            set { this._shareIdentifier = value; }
        }

        // Check to see if ShareIdentifier property is set
        internal bool IsSetShareIdentifier()
        {
            return this._shareIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the service job request. Each tag consists of a key and
        /// an optional value. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// The timeout configuration for the service job. If none is specified, Batch defers
        /// to the default timeout of the underlying service handling the job.
        /// </para>
        /// </summary>
        public ServiceJobTimeout TimeoutConfig
        {
            get { return this._timeoutConfig; }
            set { this._timeoutConfig = value; }
        }

        // Check to see if TimeoutConfig property is set
        internal bool IsSetTimeoutConfig()
        {
            return this._timeoutConfig != null;
        }

    }
}