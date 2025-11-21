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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
        private string _description;
        private string _error;
        private string _eventId;
        private ExecutionBlockType _executionBlockType;
        private string _previousEventId;
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stepName;
        private DateTime? _timestamp;
        private ExecutionEventType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for an execution event.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Error. 
        /// <para>
        /// Errors for an execution event.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The event ID for an execution event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionBlockType. 
        /// <para>
        /// The execution block type for an execution event.
        /// </para>
        /// </summary>
        public ExecutionBlockType ExecutionBlockType
        {
            get { return this._executionBlockType; }
            set { this._executionBlockType = value; }
        }

        // Check to see if ExecutionBlockType property is set
        internal bool IsSetExecutionBlockType()
        {
            return this._executionBlockType != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousEventId. 
        /// <para>
        /// The event ID of the previous execution event.
        /// </para>
        /// </summary>
        public string PreviousEventId
        {
            get { return this._previousEventId; }
            set { this._previousEventId = value; }
        }

        // Check to see if PreviousEventId property is set
        internal bool IsSetPreviousEventId()
        {
            return this._previousEventId != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources for an execution event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The step name for an execution event.
        /// </para>
        /// </summary>
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp for an execution event.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of an execution event.
        /// </para>
        /// </summary>
        public ExecutionEventType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}