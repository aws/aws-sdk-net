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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteQueueEnvironment operation. Deletes a queue
    /// environment.
    /// </summary>
    public partial class DeleteQueueEnvironmentRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the farm from which to remove the
        /// queue environment.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property QueueEnvironmentId. The queue environment ID of the queue
        /// environment to delete.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueEnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the QueueEnvironmentId property is set.
        /// </summary>
        internal bool IsSetQueueEnvironmentId() => this.QueueEnvironmentId != null;

        /// <summary>
        /// Gets and sets the property QueueId. The queue ID of the queue environment to delete.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;
    }
}
