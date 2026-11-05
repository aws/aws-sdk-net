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
    /// Container for the parameters to the DeleteQueueLimitAssociation operation. Removes
    /// the association between a queue and a limit. You must use the <c>UpdateQueueLimitAssociation</c>
    /// operation to set the status to <c>STOP_LIMIT_USAGE_AND_COMPLETE_TASKS</c> or <c>STOP_LIMIT_USAGE_AND_CANCEL_TASKS</c>.
    /// The status does not change immediately. Use the <c>GetQueueLimitAssociation</c> operation
    /// to see if the status changed to <c>STOPPED</c> before deleting the association.
    /// </summary>
    public partial class DeleteQueueLimitAssociationRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property FarmId. The unique identifier of the farm that contains
        /// the queue and limit to disassociate.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property LimitId. The unique identifier of the limit to disassociate.
        /// </summary>
        [AWSProperty(Required = true)]
        public string LimitId { get; set; }

        /// <summary>
        /// Checks to see if the LimitId property is set.
        /// </summary>
        internal bool IsSetLimitId() => this.LimitId != null;

        /// <summary>
        /// Gets and sets the property QueueId. The unique identifier of the queue to disassociate.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;
    }
}
