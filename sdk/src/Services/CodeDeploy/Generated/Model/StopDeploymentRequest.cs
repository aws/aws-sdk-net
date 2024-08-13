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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the StopDeployment operation.
    /// Attempts to stop an ongoing deployment.
    /// </summary>
    public partial class StopDeploymentRequest : AmazonCodeDeployRequest
    {
        private bool? _autoRollbackEnabled;
        private string _deploymentId;

        /// <summary>
        /// Gets and sets the property AutoRollbackEnabled. 
        /// <para>
        ///  Indicates, when a deployment is stopped, whether instances that have been updated
        /// should be rolled back to the previous version of the application revision. 
        /// </para>
        /// </summary>
        public bool? AutoRollbackEnabled
        {
            get { return this._autoRollbackEnabled; }
            set { this._autoRollbackEnabled = value; }
        }

        // Check to see if AutoRollbackEnabled property is set
        internal bool IsSetAutoRollbackEnabled()
        {
            return this._autoRollbackEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

    }
}