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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies a rolling deployment strategy for updating a SageMaker endpoint.
    /// </summary>
    public partial class RollingUpdatePolicy
    {
        /// <summary>
        /// Gets and sets the property MaximumBatchSize. 
        /// <para>
        /// Batch size for each rolling step to provision capacity and turn on traffic on the
        /// new endpoint fleet, and terminate capacity on the old endpoint fleet. Value must be
        /// between 5% to 50% of the variant's total instance count.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacitySize MaximumBatchSize { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBatchSize property is set.
        /// </summary>
        internal bool IsSetMaximumBatchSize() => this.MaximumBatchSize != null;

        /// <summary>
        /// Gets and sets the property MaximumExecutionTimeoutInSeconds. 
        /// <para>
        /// The time limit for the total deployment. Exceeding this limit causes a timeout.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 600, Max = 28800)]
        public int? MaximumExecutionTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaximumExecutionTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetMaximumExecutionTimeoutInSeconds() => this.MaximumExecutionTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RollbackMaximumBatchSize. 
        /// <para>
        /// Batch size for rollback to the old endpoint fleet. Each rolling step to provision
        /// capacity and turn on traffic on the old endpoint fleet, and terminate capacity on
        /// the new endpoint fleet. If this field is absent, the default value will be set to
        /// 100% of total capacity which means to bring up the whole capacity of the old fleet
        /// at once during rollback.
        /// </para>
        /// </summary>
        public CapacitySize RollbackMaximumBatchSize { get; set; }

        /// <summary>
        /// Checks to see if the RollbackMaximumBatchSize property is set.
        /// </summary>
        internal bool IsSetRollbackMaximumBatchSize() => this.RollbackMaximumBatchSize != null;

        /// <summary>
        /// Gets and sets the property WaitIntervalInSeconds. 
        /// <para>
        /// The length of the baking period, during which SageMaker monitors alarms for each batch
        /// on the new fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 3600)]
        public int? WaitIntervalInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the WaitIntervalInSeconds property is set.
        /// </summary>
        internal bool IsSetWaitIntervalInSeconds() => this.WaitIntervalInSeconds.HasValue;
    }
}
