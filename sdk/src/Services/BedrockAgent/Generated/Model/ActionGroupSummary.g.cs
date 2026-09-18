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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about an action group.
    /// </summary>
    public partial class ActionGroupSummary
    {
        /// <summary>
        /// Gets and sets the property ActionGroupId. 
        /// <para>
        /// The unique identifier of the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActionGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ActionGroupId property is set.
        /// </summary>
        internal bool IsSetActionGroupId() => this.ActionGroupId != null;

        /// <summary>
        /// Gets and sets the property ActionGroupName. 
        /// <para>
        /// The name of the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ActionGroupName property is set.
        /// </summary>
        internal bool IsSetActionGroupName() => this.ActionGroupName != null;

        /// <summary>
        /// Gets and sets the property ActionGroupState. 
        /// <para>
        /// Specifies whether the action group is available for the agent to invoke or not when
        /// sending an <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html">InvokeAgent</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionGroupState ActionGroupState { get; set; }

        /// <summary>
        /// Checks to see if the ActionGroupState property is set.
        /// </summary>
        internal bool IsSetActionGroupState() => this.ActionGroupState != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the action group was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
