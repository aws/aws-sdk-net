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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Notification medium for users to get alerted for events that occur in application
    /// profile. We support SNS topic as a notification channel.
    /// </summary>
    public partial class Channel
    {
        private List<string> _eventPublishers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private string _uri;

        /// <summary>
        /// Gets and sets the property EventPublishers. 
        /// <para>
        /// List of publishers for different type of events that may be detected in an application
        /// from the profile. Anomaly detection is the only event publisher in Profiler.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> EventPublishers
        {
            get { return this._eventPublishers; }
            set { this._eventPublishers = value; }
        }

        // Check to see if EventPublishers property is set
        internal bool IsSetEventPublishers()
        {
            return this._eventPublishers != null && (this._eventPublishers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier for each <c>Channel</c> in the notification configuration of a Profiling
        /// Group. A random UUID for channelId is used when adding a channel to the notification
        /// configuration if not specified in the request.
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
        /// Gets and sets the property Uri. 
        /// <para>
        /// Unique arn of the resource to be used for notifications. We support a valid SNS topic
        /// arn as a channel uri.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}