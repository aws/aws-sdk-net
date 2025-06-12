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
    /// The data associated with a deployment.
    /// </summary>
    public partial class DeploymentData
    {
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private string _deploymentArn;
        private string _id;
        private string _name;
        private string _patternName;
        private string _resourceGroup;
        private Dictionary<string, string> _specifications = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DeploymentStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the deployment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The time the deployment was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt
        {
            get { return this._deletedAt; }
            set { this._deletedAt = value; }
        }

        // Check to see if DeletedAt property is set
        internal bool IsSetDeletedAt()
        {
            return this._deletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment.
        /// </para>
        /// </summary>
        public string DeploymentArn
        {
            get { return this._deploymentArn; }
            set { this._deploymentArn = value; }
        }

        // Check to see if DeploymentArn property is set
        internal bool IsSetDeploymentArn()
        {
            return this._deploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PatternName. 
        /// <para>
        /// The pattern name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PatternName
        {
            get { return this._patternName; }
            set { this._patternName = value; }
        }

        // Check to see if PatternName property is set
        internal bool IsSetPatternName()
        {
            return this._patternName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroup. 
        /// <para>
        /// The resource group of the deployment.
        /// </para>
        /// </summary>
        public string ResourceGroup
        {
            get { return this._resourceGroup; }
            set { this._resourceGroup = value; }
        }

        // Check to see if ResourceGroup property is set
        internal bool IsSetResourceGroup()
        {
            return this._resourceGroup != null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployment.
        /// </para>
        /// </summary>
        public DeploymentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about the tags attached to a deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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