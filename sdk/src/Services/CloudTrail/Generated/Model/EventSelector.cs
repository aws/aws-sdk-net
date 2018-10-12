/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Use event selectors to further specify the management and data event settings for
    /// your trail. By default, trails created without specific event selectors will be configured
    /// to log all read and write management events, and no data events. When an event occurs
    /// in your account, CloudTrail evaluates the event selector for all trails. For each
    /// trail, if the event matches any event selector, the trail processes and logs the event.
    /// If the event doesn't match any event selector, the trail doesn't log the event.
    /// 
    ///  
    /// <para>
    /// You can configure up to five event selectors for a trail.
    /// </para>
    /// </summary>
    public partial class EventSelector
    {
        private List<DataResource> _dataResources = new List<DataResource>();
        private bool? _includeManagementEvents;
        private ReadWriteType _readWriteType;

        /// <summary>
        /// Gets and sets the property DataResources. 
        /// <para>
        /// CloudTrail supports data event logging for Amazon S3 objects and AWS Lambda functions.
        /// You can specify up to 250 resources for an individual event selector, but the total
        /// number of data resources cannot exceed 250 across all event selectors in a trail.
        /// This limit does not apply if you configure resource logging for all data events. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html#logging-data-events">Data
        /// Events</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Limits
        /// in AWS CloudTrail</a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        public List<DataResource> DataResources
        {
            get { return this._dataResources; }
            set { this._dataResources = value; }
        }

        // Check to see if DataResources property is set
        internal bool IsSetDataResources()
        {
            return this._dataResources != null && this._dataResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeManagementEvents. 
        /// <para>
        /// Specify if you want your event selector to include management events for your trail.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html#logging-management-events">Management
        /// Events</a> in the <i>AWS CloudTrail User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, the value is <code>true</code>.
        /// </para>
        /// </summary>
        public bool IncludeManagementEvents
        {
            get { return this._includeManagementEvents.GetValueOrDefault(); }
            set { this._includeManagementEvents = value; }
        }

        // Check to see if IncludeManagementEvents property is set
        internal bool IsSetIncludeManagementEvents()
        {
            return this._includeManagementEvents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadWriteType. 
        /// <para>
        /// Specify if you want your trail to log read-only events, write-only events, or all.
        /// For example, the EC2 <code>GetConsoleOutput</code> is a read-only API operation and
        /// <code>RunInstances</code> is a write-only API operation.
        /// </para>
        ///  
        /// <para>
        ///  By default, the value is <code>All</code>.
        /// </para>
        /// </summary>
        public ReadWriteType ReadWriteType
        {
            get { return this._readWriteType; }
            set { this._readWriteType = value; }
        }

        // Check to see if ReadWriteType property is set
        internal bool IsSetReadWriteType()
        {
            return this._readWriteType != null;
        }

    }
}