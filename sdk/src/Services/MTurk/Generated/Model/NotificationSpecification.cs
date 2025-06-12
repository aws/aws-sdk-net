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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// The NotificationSpecification data structure describes a HIT event notification for
    /// a HIT type.
    /// </summary>
    public partial class NotificationSpecification
    {
        private string _destination;
        private List<string> _eventTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NotificationTransport _transport;
        private string _version;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        ///  The target for notification messages. The Destination’s format is determined by the
        /// specified Transport: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When Transport is Email, the Destination is your email address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When Transport is SQS, the Destination is your queue URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When Transport is SNS, the Destination is the ARN of your topic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypes. 
        /// <para>
        ///  The list of events that should cause notifications to be sent. Valid Values: AssignmentAccepted
        /// | AssignmentAbandoned | AssignmentReturned | AssignmentSubmitted | AssignmentRejected
        /// | AssignmentApproved | HITCreated | HITExtended | HITDisposed | HITReviewable | HITExpired
        /// | Ping. The Ping event is only valid for the SendTestEventNotification operation.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> EventTypes
        {
            get { return this._eventTypes; }
            set { this._eventTypes = value; }
        }

        // Check to see if EventTypes property is set
        internal bool IsSetEventTypes()
        {
            return this._eventTypes != null && (this._eventTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Transport. 
        /// <para>
        ///  The method Amazon Mechanical Turk uses to send the notification. Valid Values: Email
        /// | SQS | SNS. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationTransport Transport
        {
            get { return this._transport; }
            set { this._transport = value; }
        }

        // Check to see if Transport property is set
        internal bool IsSetTransport()
        {
            return this._transport != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the Notification API to use. Valid value is 2006-05-05.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}