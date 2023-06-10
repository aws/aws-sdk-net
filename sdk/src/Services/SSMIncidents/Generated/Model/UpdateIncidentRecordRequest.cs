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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIncidentRecord operation.
    /// Update the details of an incident record. You can use this operation to update an
    /// incident record from the defined chat channel. For more information about using actions
    /// in chat channels, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/chat.html#chat-interact">Interacting
    /// through chat</a>.
    /// </summary>
    public partial class UpdateIncidentRecordRequest : AmazonSSMIncidentsRequest
    {
        private string _arn;
        private ChatChannel _chatChannel;
        private string _clientToken;
        private int? _impact;
        private List<NotificationTargetItem> _notificationTargets = new List<NotificationTargetItem>();
        private IncidentRecordStatus _status;
        private string _summary;
        private string _title;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident record you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ChatChannel. 
        /// <para>
        /// The Chatbot chat channel where responders can collaborate.
        /// </para>
        /// </summary>
        public ChatChannel ChatChannel
        {
            get { return this._chatChannel; }
            set { this._chatChannel = value; }
        }

        // Check to see if ChatChannel property is set
        internal bool IsSetChatChannel()
        {
            return this._chatChannel != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures that a client calls the operation only once with the specified
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// Defines the impact of the incident to customers and applications. If you provide an
        /// impact for an incident, it overwrites the impact provided by the response plan.
        /// </para>
        ///  <p class="title"> <b>Possible impacts:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>1</code> - Critical impact, full application failure that impacts many to all
        /// customers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>2</code> - High impact, partial application failure with impact to many customers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>3</code> - Medium impact, the application is providing reduced service to customers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>4</code> - Low impact, customer aren't impacted by the problem yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>5</code> - No impact, customers aren't currently impacted but urgent action
        /// is needed to avoid impact.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int Impact
        {
            get { return this._impact.GetValueOrDefault(); }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationTargets. 
        /// <para>
        /// The Amazon SNS targets that Incident Manager notifies when a client updates an incident.
        /// </para>
        ///  
        /// <para>
        /// Using multiple SNS topics creates redundancy in the event that a Region is down during
        /// the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<NotificationTargetItem> NotificationTargets
        {
            get { return this._notificationTargets; }
            set { this._notificationTargets = value; }
        }

        // Check to see if NotificationTargets property is set
        internal bool IsSetNotificationTargets()
        {
            return this._notificationTargets != null && this._notificationTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the incident. Possible statuses are <code>Open</code> or <code>Resolved</code>.
        /// </para>
        /// </summary>
        public IncidentRecordStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A longer description of what occurred during the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8000)]
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A brief description of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}