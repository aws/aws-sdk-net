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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
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
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// A cluster endpoint. Specify an endpoint when you want to set or retrieve a routing
    /// control state in the cluster.
    /// </summary>
    public partial class ClusterEndpoint
    {
        private string _endpoint;
        private string _region;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// A cluster endpoint. Specify an endpoint and Amazon Web Services Region when you want
        /// to set or retrieve a routing control state in the cluster.
        /// </para>
        ///  
        /// <para>
        /// To get or update the routing control state, see the Amazon Route 53 Application Recovery
        /// Controller Routing Control Actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region for a cluster endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}