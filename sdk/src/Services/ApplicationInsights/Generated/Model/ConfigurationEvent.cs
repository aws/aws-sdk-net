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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// The event information.
    /// </summary>
    public partial class ConfigurationEvent
    {
        private string _eventDetail;
        private string _eventResourceName;
        private ConfigurationEventResourceType _eventResourceType;
        private ConfigurationEventStatus _eventStatus;
        private DateTime? _eventTime;
        private string _monitoredResourceARN;

        /// <summary>
        /// Gets and sets the property EventDetail. 
        /// <para>
        ///  The details of the event in plain text. 
        /// </para>
        /// </summary>
        public string EventDetail
        {
            get { return this._eventDetail; }
            set { this._eventDetail = value; }
        }

        // Check to see if EventDetail property is set
        internal bool IsSetEventDetail()
        {
            return this._eventDetail != null;
        }

        /// <summary>
        /// Gets and sets the property EventResourceName. 
        /// <para>
        ///  The name of the resource Application Insights attempted to configure. 
        /// </para>
        /// </summary>
        public string EventResourceName
        {
            get { return this._eventResourceName; }
            set { this._eventResourceName = value; }
        }

        // Check to see if EventResourceName property is set
        internal bool IsSetEventResourceName()
        {
            return this._eventResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property EventResourceType. 
        /// <para>
        ///  The resource type that Application Insights attempted to configure, for example,
        /// CLOUDWATCH_ALARM. 
        /// </para>
        /// </summary>
        public ConfigurationEventResourceType EventResourceType
        {
            get { return this._eventResourceType; }
            set { this._eventResourceType = value; }
        }

        // Check to see if EventResourceType property is set
        internal bool IsSetEventResourceType()
        {
            return this._eventResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        ///  The status of the configuration update event. Possible values include INFO, WARN,
        /// and ERROR. 
        /// </para>
        /// </summary>
        public ConfigurationEventStatus EventStatus
        {
            get { return this._eventStatus; }
            set { this._eventStatus = value; }
        }

        // Check to see if EventStatus property is set
        internal bool IsSetEventStatus()
        {
            return this._eventStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        ///  The timestamp of the event. 
        /// </para>
        /// </summary>
        public DateTime EventTime
        {
            get { return this._eventTime.GetValueOrDefault(); }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoredResourceARN. 
        /// <para>
        ///  The resource monitored by Application Insights. 
        /// </para>
        /// </summary>
        public string MonitoredResourceARN
        {
            get { return this._monitoredResourceARN; }
            set { this._monitoredResourceARN = value; }
        }

        // Check to see if MonitoredResourceARN property is set
        internal bool IsSetMonitoredResourceARN()
        {
            return this._monitoredResourceARN != null;
        }

    }
}