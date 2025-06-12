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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a connection endpoint.
    /// </summary>
    public partial class Endpoint
    {
        private string _address;
        private int? _port;
        private List<VpcEndpoint> _vpcEndpoints = AWSConfigs.InitializeCollections ? new List<VpcEndpoint>() : null;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The DNS address of the Cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the database engine is listening on.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpoints. 
        /// <para>
        /// Describes a connection endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcEndpoint> VpcEndpoints
        {
            get { return this._vpcEndpoints; }
            set { this._vpcEndpoints = value; }
        }

        // Check to see if VpcEndpoints property is set
        internal bool IsSetVpcEndpoints()
        {
            return this._vpcEndpoints != null && (this._vpcEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}