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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetDataflowEndpointGroupResponse : AmazonWebServiceResponse
    {
        private int? _contactPostPassDurationSeconds;
        private int? _contactPrePassDurationSeconds;
        private string _dataflowEndpointGroupArn;
        private string _dataflowEndpointGroupId;
        private List<EndpointDetails> _endpointsDetails = AWSConfigs.InitializeCollections ? new List<EndpointDetails>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ContactPostPassDurationSeconds. 
        /// <para>
        /// Amount of time, in seconds, after a contact ends that the Ground Station Dataflow
        /// Endpoint Group will be in a <c>POSTPASS</c> state. A Ground Station Dataflow Endpoint
        /// Group State Change event will be emitted when the Dataflow Endpoint Group enters and
        /// exits the <c>POSTPASS</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=120, Max=480)]
        public int? ContactPostPassDurationSeconds
        {
            get { return this._contactPostPassDurationSeconds; }
            set { this._contactPostPassDurationSeconds = value; }
        }

        // Check to see if ContactPostPassDurationSeconds property is set
        internal bool IsSetContactPostPassDurationSeconds()
        {
            return this._contactPostPassDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactPrePassDurationSeconds. 
        /// <para>
        /// Amount of time, in seconds, before a contact starts that the Ground Station Dataflow
        /// Endpoint Group will be in a <c>PREPASS</c> state. A Ground Station Dataflow Endpoint
        /// Group State Change event will be emitted when the Dataflow Endpoint Group enters and
        /// exits the <c>PREPASS</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=120, Max=480)]
        public int? ContactPrePassDurationSeconds
        {
            get { return this._contactPrePassDurationSeconds; }
            set { this._contactPrePassDurationSeconds = value; }
        }

        // Check to see if ContactPrePassDurationSeconds property is set
        internal bool IsSetContactPrePassDurationSeconds()
        {
            return this._contactPrePassDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataflowEndpointGroupArn. 
        /// <para>
        /// ARN of a dataflow endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=97, Max=146)]
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
        [AWSProperty(Min=36, Max=36)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<EndpointDetails> EndpointsDetails
        {
            get { return this._endpointsDetails; }
            set { this._endpointsDetails = value; }
        }

        // Check to see if EndpointsDetails property is set
        internal bool IsSetEndpointsDetails()
        {
            return this._endpointsDetails != null && (this._endpointsDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to a dataflow endpoint group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}