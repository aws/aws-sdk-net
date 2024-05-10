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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Incident Manager engaging a contact's contact channel.
    /// </summary>
    public partial class Page
    {
        private string _contactArn;
        private DateTime? _deliveryTime;
        private string _engagementArn;
        private string _incidentId;
        private string _pageArn;
        private DateTime? _readTime;
        private string _sender;
        private DateTime? _sentTime;

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The ARN of the contact that Incident Manager is engaging.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ContactArn
        {
            get { return this._contactArn; }
            set { this._contactArn = value; }
        }

        // Check to see if ContactArn property is set
        internal bool IsSetContactArn()
        {
            return this._contactArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryTime. 
        /// <para>
        /// The time the message was delivered to the contact channel.
        /// </para>
        /// </summary>
        public DateTime? DeliveryTime
        {
            get { return this._deliveryTime; }
            set { this._deliveryTime = value; }
        }

        // Check to see if DeliveryTime property is set
        internal bool IsSetDeliveryTime()
        {
            return this._deliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngagementArn. 
        /// <para>
        /// The ARN of the engagement that this page is part of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string EngagementArn
        {
            get { return this._engagementArn; }
            set { this._engagementArn = value; }
        }

        // Check to see if EngagementArn property is set
        internal bool IsSetEngagementArn()
        {
            return this._engagementArn != null;
        }

        /// <summary>
        /// Gets and sets the property IncidentId. 
        /// <para>
        /// The ARN of the incident that's engaging the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string IncidentId
        {
            get { return this._incidentId; }
            set { this._incidentId = value; }
        }

        // Check to see if IncidentId property is set
        internal bool IsSetIncidentId()
        {
            return this._incidentId != null;
        }

        /// <summary>
        /// Gets and sets the property PageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the page to the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PageArn
        {
            get { return this._pageArn; }
            set { this._pageArn = value; }
        }

        // Check to see if PageArn property is set
        internal bool IsSetPageArn()
        {
            return this._pageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReadTime. 
        /// <para>
        /// The time that the contact channel acknowledged engagement.
        /// </para>
        /// </summary>
        public DateTime? ReadTime
        {
            get { return this._readTime; }
            set { this._readTime = value; }
        }

        // Check to see if ReadTime property is set
        internal bool IsSetReadTime()
        {
            return this._readTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The user that started the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string Sender
        {
            get { return this._sender; }
            set { this._sender = value; }
        }

        // Check to see if Sender property is set
        internal bool IsSetSender()
        {
            return this._sender != null;
        }

        /// <summary>
        /// Gets and sets the property SentTime. 
        /// <para>
        /// The time that Incident Manager engaged the contact channel.
        /// </para>
        /// </summary>
        public DateTime? SentTime
        {
            get { return this._sentTime; }
            set { this._sentTime = value; }
        }

        // Check to see if SentTime property is set
        internal bool IsSetSentTime()
        {
            return this._sentTime.HasValue; 
        }

    }
}