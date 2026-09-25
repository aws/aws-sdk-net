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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Information about a scheduled configuration change for an OpenSearch Service domain.
    /// This actions can be a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
    /// software update</a> or a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
    /// Auto-Tune enhancement</a>.
    /// </summary>
    public partial class ScheduledAction
    {
        /// <summary>
        /// Gets and sets the property Cancellable. 
        /// <para>
        /// Whether or not the scheduled action is cancellable.
        /// </para>
        /// </summary>
        public bool? Cancellable { get; set; }

        /// <summary>
        /// Checks to see if the Cancellable property is set.
        /// </summary>
        internal bool IsSetCancellable() => this.Cancellable.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the action to be taken.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Mandatory. 
        /// <para>
        /// Whether the action is required or optional.
        /// </para>
        /// </summary>
        public bool? Mandatory { get; set; }

        /// <summary>
        /// Checks to see if the Mandatory property is set.
        /// </summary>
        internal bool IsSetMandatory() => this.Mandatory.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduledBy. 
        /// <para>
        /// Whether the action was scheduled manually (<c>CUSTOMER</c>, or by OpenSearch Service
        /// automatically (<c>SYSTEM</c>).
        /// </para>
        /// </summary>
        public ScheduledBy ScheduledBy { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledBy property is set.
        /// </summary>
        internal bool IsSetScheduledBy() => this.ScheduledBy != null;

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The time when the change is scheduled to happen.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ScheduledTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledTime property is set.
        /// </summary>
        internal bool IsSetScheduledTime() => this.ScheduledTime.HasValue;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the scheduled action.
        /// </para>
        /// </summary>
        public ActionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action that will be taken on the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
