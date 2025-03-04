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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies a rolling deployment strategy for updating a SageMaker AI inference component.
    /// </summary>
    public partial class InferenceComponentRollingUpdatePolicy
    {
        private InferenceComponentCapacitySize _maximumBatchSize;
        private int? _maximumExecutionTimeoutInSeconds;
        private InferenceComponentCapacitySize _rollbackMaximumBatchSize;
        private int? _waitIntervalInSeconds;

        /// <summary>
        /// Gets and sets the property MaximumBatchSize. 
        /// <para>
        /// The batch size for each rolling step in the deployment process. For each step, SageMaker
        /// AI provisions capacity on the new endpoint fleet, routes traffic to that fleet, and
        /// terminates capacity on the old endpoint fleet. The value must be between 5% to 50%
        /// of the copy count of the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceComponentCapacitySize MaximumBatchSize
        {
            get { return this._maximumBatchSize; }
            set { this._maximumBatchSize = value; }
        }

        // Check to see if MaximumBatchSize property is set
        internal bool IsSetMaximumBatchSize()
        {
            return this._maximumBatchSize != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumExecutionTimeoutInSeconds. 
        /// <para>
        /// The time limit for the total deployment. Exceeding this limit causes a timeout.
        /// </para>
        /// </summary>
        [AWSProperty(Min=600, Max=28800)]
        public int? MaximumExecutionTimeoutInSeconds
        {
            get { return this._maximumExecutionTimeoutInSeconds; }
            set { this._maximumExecutionTimeoutInSeconds = value; }
        }

        // Check to see if MaximumExecutionTimeoutInSeconds property is set
        internal bool IsSetMaximumExecutionTimeoutInSeconds()
        {
            return this._maximumExecutionTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RollbackMaximumBatchSize. 
        /// <para>
        /// The batch size for a rollback to the old endpoint fleet. If this field is absent,
        /// the value is set to the default, which is 100% of the total capacity. When the default
        /// is used, SageMaker AI provisions the entire capacity of the old fleet at once during
        /// rollback.
        /// </para>
        /// </summary>
        public InferenceComponentCapacitySize RollbackMaximumBatchSize
        {
            get { return this._rollbackMaximumBatchSize; }
            set { this._rollbackMaximumBatchSize = value; }
        }

        // Check to see if RollbackMaximumBatchSize property is set
        internal bool IsSetRollbackMaximumBatchSize()
        {
            return this._rollbackMaximumBatchSize != null;
        }

        /// <summary>
        /// Gets and sets the property WaitIntervalInSeconds. 
        /// <para>
        /// The length of the baking period, during which SageMaker AI monitors alarms for each
        /// batch on the new fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3600)]
        public int? WaitIntervalInSeconds
        {
            get { return this._waitIntervalInSeconds; }
            set { this._waitIntervalInSeconds = value; }
        }

        // Check to see if WaitIntervalInSeconds property is set
        internal bool IsSetWaitIntervalInSeconds()
        {
            return this._waitIntervalInSeconds.HasValue; 
        }

    }
}