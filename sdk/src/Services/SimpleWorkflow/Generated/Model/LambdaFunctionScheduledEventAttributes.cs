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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <c>LambdaFunctionScheduled</c> event. It isn't set for
    /// other event types.
    /// </summary>
    public partial class LambdaFunctionScheduledEventAttributes
    {
        private string _control;
        private long? _decisionTaskCompletedEventId;
        private string _id;
        private string _input;
        private string _name;
        private string _startToCloseTimeout;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// Data attached to the event that the decider can use in subsequent workflow tasks.
        /// This data isn't sent to the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>LambdaFunctionCompleted</c> event corresponding to the decision that
        /// resulted in scheduling this activity task. To help diagnose issues, use this information
        /// to trace back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId; }
            set { this._decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this._decisionTaskCompletedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input provided to the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32768)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StartToCloseTimeout. 
        /// <para>
        /// The maximum amount of time a worker can take to process the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
        public string StartToCloseTimeout
        {
            get { return this._startToCloseTimeout; }
            set { this._startToCloseTimeout = value; }
        }

        // Check to see if StartToCloseTimeout property is set
        internal bool IsSetStartToCloseTimeout()
        {
            return this._startToCloseTimeout != null;
        }

    }
}