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
    /// Container for the parameters to the UpdateQueueEnvironment operation. Updates the
    /// queue environment.
    /// </summary>
    public partial class UpdateQueueEnvironmentRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. The unique token which the server uses to
        /// recognize retries of the same request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the queue environment to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property Priority. The priority to update.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property QueueEnvironmentId. The queue environment ID to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueEnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the QueueEnvironmentId property is set.
        /// </summary>
        internal bool IsSetQueueEnvironmentId() => this.QueueEnvironmentId != null;

        /// <summary>
        /// Gets and sets the property QueueId. The queue ID of the queue environment to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property Template. The template to update.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 15000)]
        public string Template { get; set; }

        /// <summary>
        /// Checks to see if the Template property is set.
        /// </summary>
        internal bool IsSetTemplate() => this.Template != null;

        /// <summary>
        /// Gets and sets the property TemplateType. The template type to update.
        /// </summary>
        public EnvironmentTemplateType TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;
    }
}
