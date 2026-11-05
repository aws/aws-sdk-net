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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// The record of a completed or failed managed action.
    /// </summary>
    public partial class ManagedActionHistoryItem
    {
        /// <summary>
        /// Gets and sets the property ActionDescription. 
        /// <para>
        /// A description of the managed action.
        /// </para>
        /// </summary>
        public string ActionDescription { get; set; }

        /// <summary>
        /// Checks to see if the ActionDescription property is set.
        /// </summary>
        internal bool IsSetActionDescription() => this.ActionDescription != null;

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// A unique identifier for the managed action.
        /// </para>
        /// </summary>
        public string ActionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionId property is set.
        /// </summary>
        internal bool IsSetActionId() => this.ActionId != null;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of the managed action.
        /// </para>
        /// </summary>
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property ExecutedTime. 
        /// <para>
        /// The date and time that the action started executing.
        /// </para>
        /// </summary>
        public DateTime? ExecutedTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutedTime property is set.
        /// </summary>
        internal bool IsSetExecutedTime() => this.ExecutedTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// If the action failed, a description of the failure.
        /// </para>
        /// </summary>
        public string FailureDescription { get; set; }

        /// <summary>
        /// Checks to see if the FailureDescription property is set.
        /// </summary>
        internal bool IsSetFailureDescription() => this.FailureDescription != null;

        /// <summary>
        /// Gets and sets the property FailureType. 
        /// <para>
        /// If the action failed, the type of failure.
        /// </para>
        /// </summary>
        public FailureType FailureType { get; set; }

        /// <summary>
        /// Checks to see if the FailureType property is set.
        /// </summary>
        internal bool IsSetFailureType() => this.FailureType != null;

        /// <summary>
        /// Gets and sets the property FinishedTime. 
        /// <para>
        /// The date and time that the action finished executing.
        /// </para>
        /// </summary>
        public DateTime? FinishedTime { get; set; }

        /// <summary>
        /// Checks to see if the FinishedTime property is set.
        /// </summary>
        internal bool IsSetFinishedTime() => this.FinishedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action.
        /// </para>
        /// </summary>
        public ActionHistoryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
