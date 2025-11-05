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
    /// Definition for a downlink agent endpoint
    /// </summary>
    public partial class DownlinkAwsGroundStationAgentEndpoint
    {
        private DownlinkDataflowDetails _dataflowDetails;
        private string _name;

        /// <summary>
        /// Gets and sets the property DataflowDetails. 
        /// <para>
        /// Dataflow details for the downlink endpoint
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DownlinkDataflowDetails DataflowDetails
        {
            get { return this._dataflowDetails; }
            set { this._dataflowDetails = value; }
        }

        // Check to see if DataflowDetails property is set
        internal bool IsSetDataflowDetails()
        {
            return this._dataflowDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Downlink dataflow endpoint name
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}