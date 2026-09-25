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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one execution summary.
    /// </summary>
    public partial class OtaTaskExecutionSummaries
    {
        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The id of a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ManagedThingId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedThingId property is set.
        /// </summary>
        internal bool IsSetManagedThingId() => this.ManagedThingId != null;

        /// <summary>
        /// Gets and sets the property TaskExecutionSummary. 
        /// <para>
        /// Structure representing one over-the-air (OTA) task execution summary
        /// </para>
        /// </summary>
        public OtaTaskExecutionSummary TaskExecutionSummary { get; set; }

        /// <summary>
        /// Checks to see if the TaskExecutionSummary property is set.
        /// </summary>
        internal bool IsSetTaskExecutionSummary() => this.TaskExecutionSummary != null;
    }
}
