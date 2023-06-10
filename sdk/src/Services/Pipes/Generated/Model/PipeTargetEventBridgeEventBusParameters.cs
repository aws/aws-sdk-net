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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using an EventBridge event bus as a target.
    /// </summary>
    public partial class PipeTargetEventBridgeEventBusParameters
    {
        private string _detailType;
        private string _endpointId;
        private List<string> _resources = new List<string>();
        private string _source;
        private string _time;

        /// <summary>
        /// Gets and sets the property DetailType. 
        /// <para>
        /// A free-form string, with a maximum of 128 characters, used to decide what fields to
        /// expect in the event detail.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The URL subdomain of the endpoint. For example, if the URL for Endpoint is https://abcde.veo.endpoints.event.amazonaws.com,
        /// then the EndpointId is <code>abcde.veo</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// When using Java, you must include <code>auth-crt</code> on the class path.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Amazon Web Services resources, identified by Amazon Resource Name (ARN), which the
        /// event primarily concerns. Any number, including zero, may be present.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Resources
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property Time. 
        /// <para>
        /// The time stamp of the event, per <a href="https://www.rfc-editor.org/rfc/rfc3339.txt">RFC3339</a>.
        /// If no time stamp is provided, the time stamp of the <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutEvents.html">PutEvents</a>
        /// call is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

    }
}