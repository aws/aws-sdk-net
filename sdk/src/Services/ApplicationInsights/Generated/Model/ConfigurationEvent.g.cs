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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// The event information.
    /// </summary>
    public partial class ConfigurationEvent
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the owner of the application to which the configuration
        /// event belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property EventDetail. 
        /// <para>
        ///  The details of the event in plain text. 
        /// </para>
        /// </summary>
        public string EventDetail { get; set; }

        /// <summary>
        /// Checks to see if the EventDetail property is set.
        /// </summary>
        internal bool IsSetEventDetail() => this.EventDetail != null;

        /// <summary>
        /// Gets and sets the property EventResourceName. 
        /// <para>
        ///  The name of the resource Application Insights attempted to configure. 
        /// </para>
        /// </summary>
        public string EventResourceName { get; set; }

        /// <summary>
        /// Checks to see if the EventResourceName property is set.
        /// </summary>
        internal bool IsSetEventResourceName() => this.EventResourceName != null;

        /// <summary>
        /// Gets and sets the property EventResourceType. 
        /// <para>
        ///  The resource type that Application Insights attempted to configure, for example,
        /// CLOUDWATCH_ALARM. 
        /// </para>
        /// </summary>
        public ConfigurationEventResourceType EventResourceType { get; set; }

        /// <summary>
        /// Checks to see if the EventResourceType property is set.
        /// </summary>
        internal bool IsSetEventResourceType() => this.EventResourceType != null;

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        ///  The status of the configuration update event. Possible values include INFO, WARN,
        /// and ERROR. 
        /// </para>
        /// </summary>
        public ConfigurationEventStatus EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        ///  The timestamp of the event. 
        /// </para>
        /// </summary>
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoredResourceARN. 
        /// <para>
        ///  The resource monitored by Application Insights. 
        /// </para>
        /// </summary>
        public string MonitoredResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the MonitoredResourceARN property is set.
        /// </summary>
        internal bool IsSetMonitoredResourceARN() => this.MonitoredResourceARN != null;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group of the application to which the configuration event
        /// belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;
    }
}
