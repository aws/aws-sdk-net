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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Represents an event that occurred during a plan execution. These events provide a
    /// detailed timeline of the execution process.
    /// </summary>
    public partial class ExecutionEvent
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for an execution event.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Errors for an execution event.
        /// </para>
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The event ID for an execution event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property ExecutionBlockType. 
        /// <para>
        /// The execution block type for an execution event.
        /// </para>
        /// </summary>
        public ExecutionBlockType ExecutionBlockType { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionBlockType property is set.
        /// </summary>
        internal bool IsSetExecutionBlockType() => this.ExecutionBlockType != null;

        /// <summary>
        /// Gets and sets the property PreviousEventId. 
        /// <para>
        /// The event ID of the previous execution event.
        /// </para>
        /// </summary>
        public string PreviousEventId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousEventId property is set.
        /// </summary>
        internal bool IsSetPreviousEventId() => this.PreviousEventId != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources for an execution event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The step name for an execution event.
        /// </para>
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp for an execution event.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of an execution event.
        /// </para>
        /// </summary>
        public ExecutionEventType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
