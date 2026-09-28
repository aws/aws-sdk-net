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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// A single event entry in a PutEvents request.
    /// </summary>
    public partial class PutEventsRequestEntry
    {
        private string _detail;
        private string _detailType;
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _source;
        private PutEventsSystemMetadata _systemMetadata;
        private DateTime? _time;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// The event payload, as a valid JSON string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }

        // Check to see if Detail property is set
        internal bool IsSetDetail()
        {
            return this._detail != null;
        }

        /// <summary>
        /// Gets and sets the property DetailType.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DetailType
        {
            get { return this._detailType; }
            set { this._detailType = value; }
        }

        // Check to see if DetailType property is set
        internal bool IsSetDetailType()
        {
            return this._detailType != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// ARNs of resources the event concerns. Included in the event delivered to subscribers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the event. The <c>aws.</c> value prefix is service-reserved and cannot
        /// be used as a value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SystemMetadata.
        /// </summary>
        public PutEventsSystemMetadata SystemMetadata
        {
            get { return this._systemMetadata; }
            set { this._systemMetadata = value; }
        }

        // Check to see if SystemMetadata property is set
        internal bool IsSetSystemMetadata()
        {
            return this._systemMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time the event occurred. Defaults to the time the service receives the event when
        /// omitted.
        /// </para>
        /// </summary>
        public DateTime? Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}