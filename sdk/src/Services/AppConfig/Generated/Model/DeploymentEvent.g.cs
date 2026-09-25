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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// An object that describes a deployment event.
    /// </summary>
    public partial class DeploymentEvent
    {
        /// <summary>
        /// Gets and sets the property ActionInvocations. 
        /// <para>
        /// The list of extensions that were invoked as part of the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionInvocation> ActionInvocations { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionInvocation>() : null;

        /// <summary>
        /// Checks to see if the ActionInvocations property is set.
        /// </summary>
        internal bool IsSetActionInvocations() => this.ActionInvocations != null && (this.ActionInvocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the deployment event. Descriptions include, but are not limited to,
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account or the Amazon CloudWatch alarm ARN that initiated
        /// a rollback.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The percentage of hosts that received the deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A recommendation to attempt a new deployment (in the case of an internal error).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of deployment event. Deployment event types include the start, stop, or completion
        /// of a deployment; a percentage update; the start or stop of a bake period; and the
        /// start or completion of a rollback.
        /// </para>
        /// </summary>
        public DeploymentEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property OccurredAt. 
        /// <para>
        /// The date and time the event occurred.
        /// </para>
        /// </summary>
        public DateTime? OccurredAt { get; set; }

        /// <summary>
        /// Checks to see if the OccurredAt property is set.
        /// </summary>
        internal bool IsSetOccurredAt() => this.OccurredAt.HasValue;

        /// <summary>
        /// Gets and sets the property TriggeredBy. 
        /// <para>
        /// The entity that triggered the deployment event. Events can be triggered by a user,
        /// AppConfig, an Amazon CloudWatch alarm, or an internal error.
        /// </para>
        /// </summary>
        public TriggeredBy TriggeredBy { get; set; }

        /// <summary>
        /// Checks to see if the TriggeredBy property is set.
        /// </summary>
        internal bool IsSetTriggeredBy() => this.TriggeredBy != null;
    }
}
