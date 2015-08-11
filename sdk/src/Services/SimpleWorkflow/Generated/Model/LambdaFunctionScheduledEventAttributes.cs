/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides details for the <code>LambdaFunctionScheduled</code> event.
    /// </summary>
    public partial class LambdaFunctionScheduledEventAttributes
    {
        private long? _decisionTaskCompletedEventId;
        private string _id;
        private string _input;
        private string _name;
        private string _startToCloseTimeout;

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <code>DecisionTaskCompleted</code> event for the decision that resulted
        /// in the scheduling of this AWS Lambda function. This information can be useful for
        /// diagnosing problems by tracing back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId.GetValueOrDefault(); }
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
        /// The unique Amazon SWF ID for the AWS Lambda task.
        /// </para>
        /// </summary>
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
        /// Input provided to the AWS Lambda function.
        /// </para>
        /// </summary>
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
        /// The name of the scheduled AWS Lambda function.
        /// </para>
        /// </summary>
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
        /// The maximum time, in seconds, that the AWS Lambda function can take to execute from
        /// start to close before it is marked as failed.
        /// </para>
        /// </summary>
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