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
    /// Describes a deployment pattern version summary.
    /// </summary>
    public partial class DeploymentPatternVersionDataSummary
    {
        private string _deploymentPatternName;
        private string _deploymentPatternVersionName;
        private string _description;
        private string _documentationUrl;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property DeploymentPatternName. 
        /// <para>
        /// The name of the deployment pattern.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeploymentPatternVersionName. 
        /// <para>
        /// The name of the deployment pattern version.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the deployment pattern version.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentationUrl. 
        /// <para>
        /// The URL of the documentation for the deployment pattern version.
        /// </para>
        /// </summary>
        public string DocumentationUrl
        {
            get { return this._documentationUrl; }
            set { this._documentationUrl = value; }
        }

        // Check to see if DocumentationUrl property is set
        internal bool IsSetDocumentationUrl()
        {
            return this._documentationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload.
        /// </para>
        /// </summary>
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