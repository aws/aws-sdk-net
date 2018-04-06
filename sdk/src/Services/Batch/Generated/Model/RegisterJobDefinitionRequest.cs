/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterJobDefinition operation.
    /// Registers an AWS Batch job definition.
    /// </summary>
    public partial class RegisterJobDefinitionRequest : AmazonBatchRequest
    {
        private ContainerProperties _containerProperties;
        private string _jobDefinitionName;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private RetryStrategy _retryStrategy;
        private JobTimeout _timeout;
        private JobDefinitionType _type;

        /// <summary>
        /// Gets and sets the property ContainerProperties. 
        /// <para>
        /// An object with various properties specific for container-based jobs. This parameter
        /// is required if the <code>type</code> parameter is <code>container</code>.
        /// </para>
        /// </summary>
        public ContainerProperties ContainerProperties
        {
            get { return this._containerProperties; }
            set { this._containerProperties = value; }
        }

        // Check to see if ContainerProperties property is set
        internal bool IsSetContainerProperties()
        {
            return this._containerProperties != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the job definition to register. Up to 128 letters (uppercase and lowercase),
        /// numbers, hyphens, and underscores are allowed.
        /// </para>
        /// </summary>
        public string JobDefinitionName
        {
            get { return this._jobDefinitionName; }
            set { this._jobDefinitionName = value; }
        }

        // Check to see if JobDefinitionName property is set
        internal bool IsSetJobDefinitionName()
        {
            return this._jobDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Default parameter substitution placeholders to set in the job definition. Parameters
        /// are specified as a key-value pair mapping. Parameters in a <code>SubmitJob</code>
        /// request override any corresponding parameter defaults from the job definition.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed jobs that are submitted with this job definition.
        /// Any retry strategy that is specified during a <a>SubmitJob</a> operation overrides
        /// the retry strategy defined here. If a job is terminated due to a timeout, it is not
        /// retried. 
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
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
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout configuration for jobs that are submitted with this job definition, after
        /// which AWS Batch terminates your jobs if they have not finished. If a job is terminated
        /// due to a timeout, it is not retried. The minimum value for the timeout is 60 seconds.
        /// Any timeout configuration that is specified during a <a>SubmitJob</a> operation overrides
        /// the timeout configuration defined here. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/job_timeouts.html">Job
        /// Timeouts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public JobTimeout Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of job definition.
        /// </para>
        /// </summary>
        public JobDefinitionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}