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

namespace Amazon.Route53RecoveryCluster.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoutingControlStates operation.
    /// Set multiple routing control states. You can set the value for each state to be On
    /// or Off. When the state is On, traffic flows to a cell. When it's off, traffic does
    /// not flow.
    /// 
    ///  
    /// <para>
    /// For more information about working with routing controls, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Routing
    /// control</a> in the Route 53 Application Recovery Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class UpdateRoutingControlStatesRequest : AmazonRoute53RecoveryClusterRequest
    {
        private List<UpdateRoutingControlStateEntry> _updateRoutingControlStateEntries = new List<UpdateRoutingControlStateEntry>();

        /// <summary>
        /// Gets and sets the property UpdateRoutingControlStateEntries. 
        /// <para>
        /// A set of routing control entries that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UpdateRoutingControlStateEntry> UpdateRoutingControlStateEntries
        {
            get { return this._updateRoutingControlStateEntries; }
            set { this._updateRoutingControlStateEntries = value; }
        }

        // Check to see if UpdateRoutingControlStateEntries property is set
        internal bool IsSetUpdateRoutingControlStateEntries()
        {
            return this._updateRoutingControlStateEntries != null && this._updateRoutingControlStateEntries.Count > 0; 
        }

    }
}