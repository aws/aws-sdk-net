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

namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation.
    /// Creates a deployment for the given workload. Deployments created by this operation
    /// are not available in the Launch Wizard console to use the <c>Clone deployment</c>
    /// action on.
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonLaunchWizardRequest
    {
        private string _deploymentPatternName;
        private bool? _dryRun;
        private string _name;
        private Dictionary<string, string> _specifications = new Dictionary<string, string>();
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property DeploymentPatternName. 
        /// <para>
        /// The name of the deployment pattern supported by a given workload. You can use the
        /// <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">
        /// <c>ListWorkloadDeploymentPatterns</c> </a> operation to discover supported values
        /// for this parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DeploymentPatternName
        {
            get { return this._deploymentPatternName; }
            set { this._deploymentPatternName = value; }
        }

        // Check to see if DeploymentPatternName property is set
        internal bool IsSetDeploymentPatternName()
        {
            return this._deploymentPatternName != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Specifications. 
        /// <para>
        /// The settings specified for the deployment. For more information on the specifications
        /// required for creating a deployment, see <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/launch-wizard-specifications.html">Workload
        /// specifications</a>.
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
            return this._specifications != null && this._specifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload. You can use the <a href="https://docs.aws.amazon.com/launchwizard/latest/APIReference/API_ListWorkloadDeploymentPatterns.html">
        /// <c>ListWorkloadDeploymentPatterns</c> </a> operation to discover supported values
        /// for this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

    }
}