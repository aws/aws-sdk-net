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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListEventsFilters
    {
        private EventDataSource _dataSource;
        private EventClass _eventClass;
        private string _eventSource;
        private EventTimeRange _eventTimeRange;
        private string _insightId;
        private ResourceCollection _resourceCollection;

        /// <summary>
        /// Gets and sets the property DataSource.
        /// </summary>
        public EventDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property EventClass.
        /// </summary>
        public EventClass EventClass
        {
            get { return this._eventClass; }
            set { this._eventClass = value; }
        }

        // Check to see if EventClass property is set
        internal bool IsSetEventClass()
        {
            return this._eventClass != null;
        }

        /// <summary>
        /// Gets and sets the property EventSource.
        /// </summary>
        [AWSProperty(Min=10, Max=50)]
        public string EventSource
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
        /// Gets and sets the property EventTimeRange.
        /// </summary>
        public EventTimeRange EventTimeRange
        {
            get { return this._eventTimeRange; }
            set { this._eventTimeRange = value; }
        }

        // Check to see if EventTimeRange property is set
        internal bool IsSetEventTimeRange()
        {
            return this._eventTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property InsightId.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string InsightId
        {
            get { return this._insightId; }
            set { this._insightId = value; }
        }

        // Check to see if InsightId property is set
        internal bool IsSetInsightId()
        {
            return this._insightId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

    }
}