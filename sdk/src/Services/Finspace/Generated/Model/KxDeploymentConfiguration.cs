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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The configuration that allows you to choose how you want to update the databases
    /// on a cluster. Depending on the option you choose, you can reduce the time it takes
    /// to update the cluster.
    /// </summary>
    public partial class KxDeploymentConfiguration
    {
        private KxDeploymentStrategy _deploymentStrategy;

        /// <summary>
        /// Gets and sets the property DeploymentStrategy. 
        /// <para>
        ///  The type of deployment that you want on a cluster. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ROLLING – This options updates the cluster by stopping the exiting q process and starting
        /// a new q process with updated configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NO_RESTART – This option updates the cluster without stopping the running q process.
        /// It is only available for <c>HDB</c> type cluster. This option is quicker as it reduces
        /// the turn around time to update configuration on a cluster. 
        /// </para>
        ///  
        /// <para>
        /// With this deployment mode, you cannot update the <c>initializationScript</c> and <c>commandLineArguments</c>
        /// parameters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public KxDeploymentStrategy DeploymentStrategy
        {
            get { return this._deploymentStrategy; }
            set { this._deploymentStrategy = value; }
        }

        // Check to see if DeploymentStrategy property is set
        internal bool IsSetDeploymentStrategy()
        {
            return this._deploymentStrategy != null;
        }

    }
}