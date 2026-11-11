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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the dimensions for a set of metrics.
    /// </summary>
    public partial class Dimensions
    {
        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// Information about the agent status assigned to the user.
        /// </para>
        /// </summary>
        public AgentStatusIdentifier AgentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentStatus property is set.
        /// </summary>
        internal bool IsSetAgentStatus() => this.AgentStatus != null;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel used for grouping and filters.
        /// </para>
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property Queue. 
        /// <para>
        /// Information about the queue for which metrics are returned.
        /// </para>
        /// </summary>
        public QueueReference Queue { get; set; }

        /// <summary>
        /// Checks to see if the Queue property is set.
        /// </summary>
        internal bool IsSetQueue() => this.Queue != null;

        /// <summary>
        /// Gets and sets the property RoutingProfile.
        /// </summary>
        public RoutingProfileReference RoutingProfile { get; set; }

        /// <summary>
        /// Checks to see if the RoutingProfile property is set.
        /// </summary>
        internal bool IsSetRoutingProfile() => this.RoutingProfile != null;

        /// <summary>
        /// Gets and sets the property RoutingStepExpression. 
        /// <para>
        /// The expression of a step in a routing criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3000)]
        public string RoutingStepExpression { get; set; }

        /// <summary>
        /// Checks to see if the RoutingStepExpression property is set.
        /// </summary>
        internal bool IsSetRoutingStepExpression() => this.RoutingStepExpression != null;

        /// <summary>
        /// Gets and sets the property Subtype. 
        /// <para>
        /// The subtype of the channel used for the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Subtype { get; set; }

        /// <summary>
        /// Checks to see if the Subtype property is set.
        /// </summary>
        internal bool IsSetSubtype() => this.Subtype != null;

        /// <summary>
        /// Gets and sets the property ValidationTestType. 
        /// <para>
        /// The testing and simulation type
        /// </para>
        /// </summary>
        public string ValidationTestType { get; set; }

        /// <summary>
        /// Checks to see if the ValidationTestType property is set.
        /// </summary>
        internal bool IsSetValidationTestType() => this.ValidationTestType != null;
    }
}
