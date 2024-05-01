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
 * Do not modify this file. This file is generated from the route53-recovery-cluster-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryCluster.Model
{
    /// <summary>
    /// This is the response object from the GetRoutingControlState operation.
    /// </summary>
    public partial class GetRoutingControlStateResponse : AmazonWebServiceResponse
    {
        private string _routingControlArn;
        private string _routingControlName;
        private RoutingControlState _routingControlState;

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RoutingControlArn
        {
            get { return this._routingControlArn; }
            set { this._routingControlArn = value; }
        }

        // Check to see if RoutingControlArn property is set
        internal bool IsSetRoutingControlArn()
        {
            return this._routingControlArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingControlName. 
        /// <para>
        /// The routing control name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RoutingControlName
        {
            get { return this._routingControlName; }
            set { this._routingControlName = value; }
        }

        // Check to see if RoutingControlName property is set
        internal bool IsSetRoutingControlName()
        {
            return this._routingControlName != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingControlState. 
        /// <para>
        /// The state of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingControlState RoutingControlState
        {
            get { return this._routingControlState; }
            set { this._routingControlState = value; }
        }

        // Check to see if RoutingControlState property is set
        internal bool IsSetRoutingControlState()
        {
            return this._routingControlState != null;
        }

    }
}