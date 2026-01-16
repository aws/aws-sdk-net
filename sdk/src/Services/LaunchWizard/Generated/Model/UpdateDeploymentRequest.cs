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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
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
namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeployment operation.
    /// Updates a deployment.
    /// </summary>
    public partial class UpdateDeploymentRequest : AmazonLaunchWizardRequest
    {
        private string _deploymentId;
        private string _deploymentPatternVersionName;
        private bool? _dryRun;
        private bool? _force;
        private Dictionary<string, string> _specifications = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workloadVersionName;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=128)]
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

        /// <summary>
        /// Gets and sets the property DeploymentPatternVersionName. 
        /// <para>
        /// The name of the deployment pattern version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=30)]
        public string DeploymentPatternVersionName
        {
            get { return this._deploymentPatternVersionName; }
            set { this._deploymentPatternVersionName = value; }
        }

        // Check to see if DeploymentPatternVersionName property is set
        internal bool IsSetDeploymentPatternVersionName()
        {
            return this._deploymentPatternVersionName != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the update even if validation warnings are present.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Specifications. 
        /// <para>
        /// The settings specified for the deployment. These settings define how to deploy and
        /// configure your resources created by the deployment. For more information about the
        /// specifications required for creating a deployment for a SAP workload, see <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/launch-wizard-specifications-sap.html">SAP
        /// deployment specifications</a>. To retrieve the specifications required to create a
        /// deployment for other workloads, use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_GetWorkloadDeploymentPattern.html">
        /// <c>GetWorkloadDeploymentPattern</c> </a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
        public Dictionary<string, string> Specifications
        {
            get { return this._specifications; }
            set { this._specifications = value; }
        }

        // Check to see if Specifications property is set
        internal bool IsSetSpecifications()
        {
            return this._specifications != null && (this._specifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadVersionName. 
        /// <para>
        /// The name of the workload version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=30)]
        public string WorkloadVersionName
        {
            get { return this._workloadVersionName; }
            set { this._workloadVersionName = value; }
        }

        // Check to see if WorkloadVersionName property is set
        internal bool IsSetWorkloadVersionName()
        {
            return this._workloadVersionName != null;
        }

    }
}