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
    /// An AWS resource event. AWS resource events and metrics are analyzed by DevOps Guru
    /// to find anomalous behavior and provide recommendations to improve your operational
    /// solutions.
    /// </summary>
    public partial class Event
    {
        private EventDataSource _dataSource;
        private EventClass _eventClass;
        private string _eventSource;
        private string _id;
        private string _name;
        private ResourceCollection _resourceCollection;
        private List<EventResource> _resources = new List<EventResource>();
        private DateTime? _time;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The source, <code>AWS_CLOUD_TRAIL</code> or <code>AWS_CODE_DEPLOY</code>, where DevOps
        /// Guru analysis found the event. 
        /// </para>
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
        /// <para>
        ///  The class of the event. The class specifies what the event is related to, such as
        /// an infrastructure change, a deployment, or a schema change. 
        /// </para>
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
        /// <para>
        ///  The AWS source that emitted the event. 
        /// </para>
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
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the event. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        ///  An <code>EventResource</code> object that contains information about the resource
        /// that emitted the event. 
        /// </para>
        /// </summary>
        public List<EventResource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        ///  A <code>Timestamp</code> that specifies the time the event occurred. 
        /// </para>
        /// </summary>
        public DateTime Time
        {
            get { return this._time.GetValueOrDefault(); }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}