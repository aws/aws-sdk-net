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
    /// Information about the dataflow endpoint <c>Config</c>.
    /// </summary>
    public partial class DataflowEndpointConfig
    {
        private string _dataflowEndpointName;
        private string _dataflowEndpointRegion;

        /// <summary>
        /// Gets and sets the property DataflowEndpointName. 
        /// <para>
        /// Name of a dataflow endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataflowEndpointName
        {
            get { return this._dataflowEndpointName; }
            set { this._dataflowEndpointName = value; }
        }

        // Check to see if DataflowEndpointName property is set
        internal bool IsSetDataflowEndpointName()
        {
            return this._dataflowEndpointName != null;
        }

        /// <summary>
        /// Gets and sets the property DataflowEndpointRegion. 
        /// <para>
        /// Region of a dataflow endpoint.
        /// </para>
        /// </summary>
        public string DataflowEndpointRegion
        {
            get { return this._dataflowEndpointRegion; }
            set { this._dataflowEndpointRegion = value; }
        }

        // Check to see if DataflowEndpointRegion property is set
        internal bool IsSetDataflowEndpointRegion()
        {
            return this._dataflowEndpointRegion != null;
        }

    }
}