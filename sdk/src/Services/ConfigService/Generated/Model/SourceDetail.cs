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
    /// Provides the source and the message types that trigger AWS Config to evaluate your
    /// AWS resources against a rule. It also provides the frequency with which you want AWS
    /// Config to run evaluations for the rule if the trigger type is periodic. You can specify
    /// the parameter values for <code>SourceDetail</code> only for custom rules.
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
        /// The frequency that you want AWS Config to run evaluations for a rule that is triggered
        /// periodically. If you specify a value for <code>MaximumExecutionFrequency</code>, then
        /// <code>MessageType</code> must use the <code>ScheduledNotification</code> value.
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
        /// The type of notification that triggers AWS Config to run an evaluation. You can specify
        /// the following notification types:
        /// </para>
        ///  
        /// <para>
        ///  <code>ConfigurationItemChangeNotification</code> - Triggers an evaluation when AWS
        /// Config delivers a configuration item change notification.
        /// </para>
        ///  
        /// <para>
        ///  <code>ScheduledNotification</code> - Triggers a periodic evaluation at the frequency
        /// specified for <code>MaximumExecutionFrequency</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>ConfigurationSnapshotDeliveryCompleted</code> - Triggers a periodic evaluation
        /// when AWS Config delivers a configuration snapshot.
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