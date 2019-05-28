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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetDataflowEndpointGroupResponse : AmazonWebServiceResponse
    {
        private string _dataflowEndpointGroupArn;
        private string _dataflowEndpointGroupId;
        private List<EndpointDetails> _endpointsDetails = new List<EndpointDetails>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DataflowEndpointGroupArn. 
        /// <para>
        /// ARN of a dataflow endpoint group.
        /// </para>
        /// </summary>
        public string DataflowEndpointGroupArn
        {
            get { return this._dataflowEndpointGroupArn; }
            set { this._dataflowEndpointGroupArn = value; }
        }

        // Check to see if DataflowEndpointGroupArn property is set
        internal bool IsSetDataflowEndpointGroupArn()
        {
            return this._dataflowEndpointGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataflowEndpointGroupId. 
        /// <para>
        /// UUID of a dataflow endpoint group.
        /// </para>
        /// </summary>
        public string DataflowEndpointGroupId
        {
            get { return this._dataflowEndpointGroupId; }
            set { this._dataflowEndpointGroupId = value; }
        }

        // Check to see if DataflowEndpointGroupId property is set
        internal bool IsSetDataflowEndpointGroupId()
        {
            return this._dataflowEndpointGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointsDetails. 
        /// <para>
        /// Details of a dataflow endpoint.
        /// </para>
        /// </summary>
        public List<EndpointDetails> EndpointsDetails
        {
            get { return this._endpointsDetails; }
            set { this._endpointsDetails = value; }
        }

        // Check to see if EndpointsDetails property is set
        internal bool IsSetEndpointsDetails()
        {
            return this._endpointsDetails != null && this._endpointsDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to a dataflow endpoint group.
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