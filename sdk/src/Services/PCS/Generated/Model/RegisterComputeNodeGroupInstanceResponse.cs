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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// This is the response object from the RegisterComputeNodeGroupInstance operation.
    /// </summary>
    public partial class RegisterComputeNodeGroupInstanceResponse : AmazonWebServiceResponse
    {
        private List<Endpoint> _endpoints = AWSConfigs.InitializeCollections ? new List<Endpoint>() : null;
        private string _nodeid;
        private string _sharedSecret;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The list of endpoints available for interaction with the scheduler.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Endpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeID. 
        /// <para>
        /// The scheduler node ID for this instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeID
        {
            get { return this._nodeid; }
            set { this._nodeid = value; }
        }

        // Check to see if NodeID property is set
        internal bool IsSetNodeID()
        {
            return this._nodeid != null;
        }

        /// <summary>
        /// Gets and sets the property SharedSecret. 
        /// <para>
        /// For the Slurm scheduler, this is the shared Munge key the scheduler uses to authenticate
        /// compute node group instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string SharedSecret
        {
            get { return this._sharedSecret; }
            set { this._sharedSecret = value; }
        }

        // Check to see if SharedSecret property is set
        internal bool IsSetSharedSecret()
        {
            return this._sharedSecret != null;
        }

    }
}