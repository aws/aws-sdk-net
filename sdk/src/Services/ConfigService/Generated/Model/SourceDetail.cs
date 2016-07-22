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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides the source and the message type that trigger AWS Config to evaluate your
    /// AWS resources against a rule. It also provides the frequency with which you want AWS
    /// Config to run evaluations for the rule if the trigger type is periodic.
    /// </summary>
    public partial class SourceDetail
    {
        private EventSource _eventSource;
        private MaximumExecutionFrequency _maximumExecutionFrequency;
        private MessageType _messageType;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The source of the event, such as an AWS service, that triggers AWS Config to evaluate
        /// your AWS resources.
        /// </para>
        /// </summary>
        public EventSource EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumExecutionFrequency. 
        /// <para>
        /// If the trigger type for your rule includes periodic, AWS Config runs evaluations for
        /// the rule at a frequency that you choose. If you specify a value for <code>MaximumExecutionFrequency</code>,
        /// then <code>MessageType</code> must use the <code>ScheduledNotification</code> value.
        /// </para>
        /// </summary>
        public MaximumExecutionFrequency MaximumExecutionFrequency
        {
            get { return this._maximumExecutionFrequency; }
            set { this._maximumExecutionFrequency = value; }
        }

        // Check to see if MaximumExecutionFrequency property is set
        internal bool IsSetMaximumExecutionFrequency()
        {
            return this._maximumExecutionFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The type of SNS message that triggers AWS Config to run an evaluation.
        /// </para>
        ///  
        /// <para>
        /// For evaluations that are initiated when AWS Config delivers a configuration item change
        /// notification, you must use <code>ConfigurationItemChangeNotification</code>. 
        /// </para>
        ///  
        /// <para>
        /// For evaluations that are initiated at a frequency that you choose (for example, every
        /// 24 hours), you must use <code>ScheduledNotification</code>.
        /// </para>
        ///  
        /// <para>
        /// For evaluations that are initiated when AWS Config delivers a configuration snapshot,
        /// you must use <code>ConfigurationSnapshotDeliveryCompleted</code>.
        /// </para>
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

    }
}