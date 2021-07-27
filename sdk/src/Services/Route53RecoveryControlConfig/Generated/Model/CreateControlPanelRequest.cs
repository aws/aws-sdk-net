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

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateControlPanel operation.
    /// Creates a new control panel. A control panel represents a group of routing controls
    /// that can be changed together in a single transaction. You can use a control panel
    /// to centrally view the operational status of applications across your organization,
    /// and trigger multi-app failovers in a single transaction, for example, to fail over
    /// an Availability Zone or AWS Region.
    /// </summary>
    public partial class CreateControlPanelRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        private string _clientToken;
        private string _clusterArn;
        private string _controlPanelName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique client idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster for the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ControlPanelName. 
        /// <para>
        /// The name of the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ControlPanelName
        {
            get { return this._controlPanelName; }
            set { this._controlPanelName = value; }
        }

        // Check to see if ControlPanelName property is set
        internal bool IsSetControlPanelName()
        {
            return this._controlPanelName != null;
        }

    }
}