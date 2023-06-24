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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the SwitchoverBlueGreenDeployment operation.
    /// Switches over a blue/green deployment.
    /// 
    ///  
    /// <para>
    /// Before you switch over, production traffic is routed to the databases in the blue
    /// environment. After you switch over, production traffic is routed to the databases
    /// in the green environment.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
    /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
    /// Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SwitchoverBlueGreenDeploymentRequest : AmazonRDSRequest
    {
        private string _blueGreenDeploymentIdentifier;
        private int? _switchoverTimeout;

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentIdentifier. 
        /// <para>
        /// The blue/green deployment identifier.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match an existing blue/green deployment identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BlueGreenDeploymentIdentifier
        {
            get { return this._blueGreenDeploymentIdentifier; }
            set { this._blueGreenDeploymentIdentifier = value; }
        }

        // Check to see if BlueGreenDeploymentIdentifier property is set
        internal bool IsSetBlueGreenDeploymentIdentifier()
        {
            return this._blueGreenDeploymentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SwitchoverTimeout. 
        /// <para>
        /// The amount of time, in seconds, for the switchover to complete. The default is 300.
        /// </para>
        ///  
        /// <para>
        /// If the switchover takes longer than the specified duration, then any changes are rolled
        /// back, and no changes are made to the environments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30)]
        public int SwitchoverTimeout
        {
            get { return this._switchoverTimeout.GetValueOrDefault(); }
            set { this._switchoverTimeout = value; }
        }

        // Check to see if SwitchoverTimeout property is set
        internal bool IsSetSwitchoverTimeout()
        {
            return this._switchoverTimeout.HasValue; 
        }

    }
}