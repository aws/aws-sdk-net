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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// The values to use to filter results from the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventTypes.html">DescribeEventTypes</a>
    /// operation.
    /// </summary>
    public partial class EventTypeFilter
    {
        private List<string> _eventTypeCategories = new List<string>();
        private List<string> _eventTypeCodes = new List<string>();
        private List<string> _services = new List<string>();

        /// <summary>
        /// Gets and sets the property EventTypeCategories. 
        /// <para>
        /// A list of event type category codes. Possible values are <code>issue</code>, <code>accountNotification</code>,
        /// or <code>scheduledChange</code>. Currently, the <code>investigation</code> value isn't
        /// supported at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> EventTypeCategories
        {
            get { return this._eventTypeCategories; }
            set { this._eventTypeCategories = value; }
        }

        // Check to see if EventTypeCategories property is set
        internal bool IsSetEventTypeCategories()
        {
            return this._eventTypeCategories != null && this._eventTypeCategories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventTypeCodes. 
        /// <para>
        /// A list of event type codes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> EventTypeCodes
        {
            get { return this._eventTypeCodes; }
            set { this._eventTypeCodes = value; }
        }

        // Check to see if EventTypeCodes property is set
        internal bool IsSetEventTypeCodes()
        {
            return this._eventTypeCodes != null && this._eventTypeCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The Amazon Web Services associated with the event. For example, <code>EC2</code>,
        /// <code>RDS</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && this._services.Count > 0; 
        }

    }
}