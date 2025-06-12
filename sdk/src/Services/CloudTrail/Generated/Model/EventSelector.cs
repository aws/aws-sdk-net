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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
    ///  
    /// <para>
    /// You cannot apply both event selectors and advanced event selectors to a trail.
    /// </para>
    /// </summary>
    public partial class EventSelector
    {
        private List<DataResource> _dataResources = AWSConfigs.InitializeCollections ? new List<DataResource>() : null;
        private List<string> _excludeManagementEventSources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _includeManagementEvents;
        private ReadWriteType _readWriteType;

        /// <summary>
        /// Gets and sets the property DataResources. 
        /// <para>
        /// CloudTrail supports data event logging for Amazon S3 objects in standard S3 buckets,
        /// Lambda functions, and Amazon DynamoDB tables with basic event selectors. You can specify
        /// up to 250 resources for an individual event selector, but the total number of data
        /// resources cannot exceed 250 across all event selectors in a trail. This limit does
        /// not apply if you configure resource logging for all data events.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Data
        /// Events</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Limits
        /// in CloudTrail</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To log data events for all other resource types including objects stored in <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">directory
        /// buckets</a>, you must use <a href="https://docs.aws.amazon.com/awscloudtrail/latest/APIReference/API_AdvancedEventSelector.html">AdvancedEventSelectors</a>.
        /// You must also use <c>AdvancedEventSelectors</c> if you want to filter on the <c>eventName</c>
        /// field.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataResource> DataResources
        {
            get { return this._dataResources; }
            set { this._dataResources = value; }
        }

        // Check to see if DataResources property is set
        internal bool IsSetDataResources()
        {
            return this._dataResources != null && (this._dataResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeManagementEventSources. 
        /// <para>
        /// An optional list of service event sources from which you do not want management events
        /// to be logged on your trail. In this release, the list can be empty (disables the filter),
        /// or it can filter out Key Management Service or Amazon RDS Data API events by containing
        /// <c>kms.amazonaws.com</c> or <c>rdsdata.amazonaws.com</c>. By default, <c>ExcludeManagementEventSources</c>
        /// is empty, and KMS and Amazon RDS Data API events are logged to your trail. You can
        /// exclude management event sources only in Regions that support the event source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludeManagementEventSources
        {
            get { return this._excludeManagementEventSources; }
            set { this._excludeManagementEventSources = value; }
        }

        // Check to see if ExcludeManagementEventSources property is set
        internal bool IsSetExcludeManagementEventSources()
        {
            return this._excludeManagementEventSources != null && (this._excludeManagementEventSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeManagementEvents. 
        /// <para>
        /// Specify if you want your event selector to include management events for your trail.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Management
        /// Events</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, the value is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// The first copy of management events is free. You are charged for additional copies
        /// of management events that you are logging on any subsequent trail in the same Region.
        /// For more information about CloudTrail pricing, see <a href="http://aws.amazon.com/cloudtrail/pricing/">CloudTrail
        /// Pricing</a>.
        /// </para>
        /// </summary>
        public bool? IncludeManagementEvents
        {
            get { return this._includeManagementEvents; }
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
        /// For example, the EC2 <c>GetConsoleOutput</c> is a read-only API operation and <c>RunInstances</c>
        /// is a write-only API operation.
        /// </para>
        ///  
        /// <para>
        ///  By default, the value is <c>All</c>.
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