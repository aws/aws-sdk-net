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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object containing Message Insights filters.
    /// 
    ///  
    /// <para>
    /// If you specify multiple filters, the filters are joined by AND.
    /// </para>
    ///  
    /// <para>
    /// If you specify multiple values for a filter, the values are joined by OR. Filter values
    /// are case-sensitive.
    /// </para>
    ///  
    /// <para>
    ///  <code>FromEmailAddress</code>, <code>Destination</code>, and <code>Subject</code>
    /// filters support partial match. A partial match is performed by using the <code>*</code>
    /// wildcard character placed at the beginning (suffix match), the end (prefix match)
    /// or both ends of the string (contains match). In order to match the literal characters
    /// <code>*</code> or <code>\</code>, they must be escaped using the <code>\</code> character.
    /// If no wildcard character is present, an exact match is performed. 
    /// </para>
    /// </summary>
    public partial class MessageInsightsFilters
    {
        private List<string> _destination = new List<string>();
        private List<string> _fromEmailAddress = new List<string>();
        private List<string> _isp = new List<string>();
        private List<string> _lastDeliveryEvent = new List<string>();
        private List<string> _lastEngagementEvent = new List<string>();
        private List<string> _subject = new List<string>();

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The recipient's email address.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null && this._destination.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The from address used to send the message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> FromEmailAddress
        {
            get { return this._fromEmailAddress; }
            set { this._fromEmailAddress = value; }
        }

        // Check to see if FromEmailAddress property is set
        internal bool IsSetFromEmailAddress()
        {
            return this._fromEmailAddress != null && this._fromEmailAddress.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Isp. 
        /// <para>
        /// The recipient's ISP (e.g., <code>Gmail</code>, <code>Yahoo</code>, etc.).
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> Isp
        {
            get { return this._isp; }
            set { this._isp = value; }
        }

        // Check to see if Isp property is set
        internal bool IsSetIsp()
        {
            return this._isp != null && this._isp.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastDeliveryEvent. 
        /// <para>
        ///  The last delivery-related event for the email, where the ordering is as follows:
        /// <code>SEND</code> &lt; <code>BOUNCE</code> &lt; <code>DELIVERY</code> &lt; <code>COMPLAINT</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> LastDeliveryEvent
        {
            get { return this._lastDeliveryEvent; }
            set { this._lastDeliveryEvent = value; }
        }

        // Check to see if LastDeliveryEvent property is set
        internal bool IsSetLastDeliveryEvent()
        {
            return this._lastDeliveryEvent != null && this._lastDeliveryEvent.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastEngagementEvent. 
        /// <para>
        ///  The last engagement-related event for the email, where the ordering is as follows:
        /// <code>OPEN</code> &lt; <code>CLICK</code>. 
        /// </para>
        ///  
        /// <para>
        ///  Engagement events are only available if <a href="https://docs.aws.amazon.com/ses/latest/dg/vdm-settings.html">Engagement
        /// tracking</a> is enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> LastEngagementEvent
        {
            get { return this._lastEngagementEvent; }
            set { this._lastEngagementEvent = value; }
        }

        // Check to see if LastEngagementEvent property is set
        internal bool IsSetLastEngagementEvent()
        {
            return this._lastEngagementEvent != null && this._lastEngagementEvent.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null && this._subject.Count > 0; 
        }

    }
}