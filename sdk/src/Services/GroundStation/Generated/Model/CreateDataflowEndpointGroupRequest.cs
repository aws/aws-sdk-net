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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataflowEndpointGroup operation.
    /// Creates a <code>DataflowEndpoint</code> group containing the specified list of <code>DataflowEndpoint</code>
    /// objects.
    /// 
    ///  
    /// <para>
    /// The <code>name</code> field in each endpoint is used in your mission profile <code>DataflowEndpointConfig</code>
    /// to specify which endpoints to use during a contact.
    /// </para>
    ///  
    /// <para>
    /// When a contact uses multiple <code>DataflowEndpointConfig</code> objects, each <code>Config</code>
    /// must match a <code>DataflowEndpoint</code> in the same group.
    /// </para>
    /// </summary>
    public partial class CreateDataflowEndpointGroupRequest : AmazonGroundStationRequest
    {
        private List<EndpointDetails> _endpointDetails = new List<EndpointDetails>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// Endpoint details of each endpoint in the dataflow endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EndpointDetails> EndpointDetails
        {
            get { return this._endpointDetails; }
            set { this._endpointDetails = value; }
        }

        // Check to see if EndpointDetails property is set
        internal bool IsSetEndpointDetails()
        {
            return this._endpointDetails != null && this._endpointDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags of a dataflow endpoint group.
        /// </para>
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