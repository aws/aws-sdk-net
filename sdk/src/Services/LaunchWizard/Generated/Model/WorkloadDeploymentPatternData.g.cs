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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The data that details a workload deployment pattern.
    /// </summary>
    public partial class WorkloadDeploymentPatternData
    {
        /// <summary>
        /// Gets and sets the property AccountConstraints. Optional list of constraints describing
        /// what kind of AWS account is allowed to deploy this workload or deployment pattern.
        /// Within a single list the semantics are OR: an account satisfies the list if it satisfies
        /// any entry. Workload-level and pattern-level lists combine with AND at deployment time.
        /// An absent or empty list at this level means no constraint at this level.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<AccountConstraint> AccountConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountConstraint>() : null;

        /// <summary>
        /// Checks to see if the AccountConstraints property is set.
        /// </summary>
        internal bool IsSetAccountConstraints() => this.AccountConstraints != null && (this.AccountConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeploymentPatternName. 
        /// <para>
        /// The name of the deployment pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DeploymentPatternName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentPatternName property is set.
        /// </summary>
        internal bool IsSetDeploymentPatternName() => this.DeploymentPatternName != null;

        /// <summary>
        /// Gets and sets the property DeploymentPatternVersionName. 
        /// <para>
        /// The version name of the deployment pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 30)]
        public string DeploymentPatternVersionName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentPatternVersionName property is set.
        /// </summary>
        internal bool IsSetDeploymentPatternVersionName() => this.DeploymentPatternVersionName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the deployment pattern.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the deployment pattern.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DeploymentSpecificationsField> Specifications { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentSpecificationsField>() : null;

        /// <summary>
        /// Checks to see if the Specifications property is set.
        /// </summary>
        internal bool IsSetSpecifications() => this.Specifications != null && (this.Specifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployment pattern.
        /// </para>
        /// </summary>
        public WorkloadDeploymentPatternStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the deployment pattern.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The workload name of the deployment pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;

        /// <summary>
        /// Gets and sets the property WorkloadVersionName. 
        /// <para>
        /// The workload version name of the deployment pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 30)]
        public string WorkloadVersionName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadVersionName property is set.
        /// </summary>
        internal bool IsSetWorkloadVersionName() => this.WorkloadVersionName != null;
    }
}
