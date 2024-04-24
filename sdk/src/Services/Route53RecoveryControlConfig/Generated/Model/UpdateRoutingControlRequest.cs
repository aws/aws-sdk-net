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
    /// Container for the parameters to the UpdateRoutingControl operation.
    /// Updates a routing control. You can only update the name of the routing control. To
    /// get or update the routing control state, see the Recovery Cluster (data plane) API
    /// actions for Amazon Route 53 Application Recovery Controller.
    /// </summary>
    public partial class UpdateRoutingControlRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        private string _routingControlArn;
        private string _routingControlName;

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The name of the routing control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}