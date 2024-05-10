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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides the source and the message types that trigger Config to evaluate your Amazon
    /// Web Services resources against a rule. It also provides the frequency with which you
    /// want Config to run evaluations for the rule if the trigger type is periodic. You can
    /// specify the parameter values for <c>SourceDetail</c> only for custom rules.
    /// </summary>
    public partial class SourceDetail
    {
        private EventSource _eventSource;
        private MaximumExecutionFrequency _maximumExecutionFrequency;
        private MessageType _messageType;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The source of the event, such as an Amazon Web Services service, that triggers Config
        /// to evaluate your Amazon Web Services resources.
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
        /// The frequency at which you want Config to run evaluations for a custom rule with a
        /// periodic trigger. If you specify a value for <c>MaximumExecutionFrequency</c>, then
        /// <c>MessageType</c> must use the <c>ScheduledNotification</c> value.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, rules with a periodic trigger are evaluated every 24 hours. To change
        /// the frequency, specify a valid value for the <c>MaximumExecutionFrequency</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Based on the valid value you choose, Config runs evaluations once for each valid value.
        /// For example, if you choose <c>Three_Hours</c>, Config runs evaluations once every
        /// three hours. In this case, <c>Three_Hours</c> is the frequency of this rule. 
        /// </para>
        ///  </note>
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
        /// The type of notification that triggers Config to run an evaluation for a rule. You
        /// can specify the following notification types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ConfigurationItemChangeNotification</c> - Triggers an evaluation when Config delivers
        /// a configuration item as a result of a resource change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OversizedConfigurationItemChangeNotification</c> - Triggers an evaluation when
        /// Config delivers an oversized configuration item. Config may generate this notification
        /// type when a resource changes and the notification exceeds the maximum size allowed
        /// by Amazon SNS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ScheduledNotification</c> - Triggers a periodic evaluation at the frequency specified
        /// for <c>MaximumExecutionFrequency</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfigurationSnapshotDeliveryCompleted</c> - Triggers a periodic evaluation when
        /// Config delivers a configuration snapshot.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want your custom rule to be triggered by configuration changes, specify two
        /// SourceDetail objects, one for <c>ConfigurationItemChangeNotification</c> and one for
        /// <c>OversizedConfigurationItemChangeNotification</c>.
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