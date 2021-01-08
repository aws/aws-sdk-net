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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMultiplex operation.
    /// Create a new multiplex.
    /// </summary>
    public partial class CreateMultiplexRequest : AmazonMediaLiveRequest
    {
        private List<string> _availabilityZones = new List<string>();
        private MultiplexSettings _multiplexSettings;
        private string _name;
        private string _requestId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. A list of availability zones for the
        /// multiplex. You must specify exactly two.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MultiplexSettings. Configuration for a multiplex event.
        /// </summary>
        [AWSProperty(Required=true)]
        public MultiplexSettings MultiplexSettings
        {
            get { return this._multiplexSettings; }
            set { this._multiplexSettings = value; }
        }

        // Check to see if MultiplexSettings property is set
        internal bool IsSetMultiplexSettings()
        {
            return this._multiplexSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Name of multiplex.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RequestId. Unique request ID. This prevents retries from
        /// creating multipleresources.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}