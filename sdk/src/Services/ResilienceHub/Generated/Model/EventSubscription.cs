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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates an event you would like to subscribe and get notification for. Currently,
    /// Resilience Hub supports notifications only for <b>Drift detected</b> and <b>Scheduled
    /// assessment failure</b> events.
    /// </summary>
    public partial class EventSubscription
    {
        private EventType _eventType;
        private string _name;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event you would like to subscribe and get notification for. Currently,
        /// Resilience Hub supports notifications only for <b>Drift detected</b> (<c>DriftDetected</c>)
        /// and <b>Scheduled assessment failure</b> (<c>ScheduledAssessmentFailure</c>) events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Unique name to identify an event subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon Simple Notification Service topic. The format
        /// for this ARN is: <c>arn:partition:sns:region:account:topic-name</c>. For more information
        /// about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}