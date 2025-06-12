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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
        private List<ActionInvocation> _actionInvocations = AWSConfigs.InitializeCollections ? new List<ActionInvocation>() : null;
        private string _description;
        private DeploymentEventType _eventType;
        private DateTime? _occurredAt;
        private TriggeredBy _triggeredBy;

        /// <summary>
        /// Gets and sets the property ActionInvocations. 
        /// <para>
        /// The list of extensions that were invoked as part of the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionInvocation> ActionInvocations
        {
            get { return this._actionInvocations; }
            set { this._actionInvocations = value; }
        }

        // Check to see if ActionInvocations property is set
        internal bool IsSetActionInvocations()
        {
            return this._actionInvocations != null && (this._actionInvocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of deployment event. Deployment event types include the start, stop, or completion
        /// of a deployment; a percentage update; the start or stop of a bake period; and the
        /// start or completion of a rollback.
        /// </para>
        /// </summary>
        public DeploymentEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property OccurredAt. 
        /// <para>
        /// The date and time the event occurred.
        /// </para>
        /// </summary>
        public DateTime? OccurredAt
        {
            get { return this._occurredAt; }
            set { this._occurredAt = value; }
        }

        // Check to see if OccurredAt property is set
        internal bool IsSetOccurredAt()
        {
            return this._occurredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggeredBy. 
        /// <para>
        /// The entity that triggered the deployment event. Events can be triggered by a user,
        /// AppConfig, an Amazon CloudWatch alarm, or an internal error.
        /// </para>
        /// </summary>
        public TriggeredBy TriggeredBy
        {
            get { return this._triggeredBy; }
            set { this._triggeredBy = value; }
        }

        // Check to see if TriggeredBy property is set
        internal bool IsSetTriggeredBy()
        {
            return this._triggeredBy != null;
        }

    }
}