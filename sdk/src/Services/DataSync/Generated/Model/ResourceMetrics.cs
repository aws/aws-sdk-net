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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Information, including performance data and capacity usage, provided by DataSync Discovery
    /// about a resource in your on-premises storage system.
    /// </summary>
    public partial class ResourceMetrics
    {
        private Capacity _capacity;
        private P95Metrics _p95Metrics;
        private string _resourceId;
        private DiscoveryResourceType _resourceType;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The storage capacity of the on-premises storage system resource.
        /// </para>
        /// </summary>
        public Capacity Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity != null;
        }

        /// <summary>
        /// Gets and sets the property P95Metrics. 
        /// <para>
        /// The types of performance data that DataSync Discovery collects about the on-premises
        /// storage system resource.
        /// </para>
        /// </summary>
        public P95Metrics P95Metrics
        {
            get { return this._p95Metrics; }
            set { this._p95Metrics = value; }
        }

        // Check to see if P95Metrics property is set
        internal bool IsSetP95Metrics()
        {
            return this._p95Metrics != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The universally unique identifier (UUID) of the on-premises storage system resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of on-premises storage system resource.
        /// </para>
        /// </summary>
        public DiscoveryResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time when DataSync Discovery collected this information from the resource.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}