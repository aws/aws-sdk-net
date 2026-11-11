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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// A structure that contains information about a StackSet. With StackSets, you can provision
    /// stacks across Amazon Web Services accounts and Regions from a single CloudFormation
    /// template. Each stack is based on the same CloudFormation template, but you can customize
    /// individual stacks using parameters.
    /// </summary>
    public partial class StackSet
    {
        /// <summary>
        /// Gets and sets the property AdministrationRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to create or update the stack
        /// set.
        /// </para>
        ///  
        /// <para>
        /// Use customized administrator roles to control which users or groups can manage specific
        /// StackSets within the same administrator account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs.html">Prerequisites
        /// for using CloudFormation StackSets</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AdministrationRoleARN { get; set; }

        /// <summary>
        /// Checks to see if the AdministrationRoleARN property is set.
        /// </summary>
        internal bool IsSetAdministrationRoleARN() => this.AdministrationRoleARN != null;

        /// <summary>
        /// Gets and sets the property AutoDeployment. 
        /// <para>
        /// Describes whether StackSets automatically deploys to Organizations accounts that are
        /// added to a target organization or organizational unit (OU). Valid only if the StackSet
        /// uses service-managed permissions.
        /// </para>
        /// </summary>
        public AutoDeployment AutoDeployment { get; set; }

        /// <summary>
        /// Checks to see if the AutoDeployment property is set.
        /// </summary>
        internal bool IsSetAutoDeployment() => this.AutoDeployment != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities that are allowed in the StackSet. Some StackSet templates might include
        /// resources that can affect permissions in your Amazon Web Services account—for example,
        /// by creating new Identity and Access Management (IAM) users. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/control-access-with-iam.html#using-iam-capabilities">Acknowledging
        /// IAM resources in CloudFormation templates</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the StackSet that you specify when the StackSet is created or updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// The name of the IAM execution role used to create or update the StackSet.
        /// </para>
        ///  
        /// <para>
        /// Use customized execution roles to control which stack resources users and groups can
        /// include in their StackSets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleName property is set.
        /// </summary>
        internal bool IsSetExecutionRoleName() => this.ExecutionRoleName != null;

        /// <summary>
        /// Gets and sets the property ManagedExecution. 
        /// <para>
        /// Describes whether StackSets performs non-conflicting operations concurrently and queues
        /// conflicting operations.
        /// </para>
        /// </summary>
        public ManagedExecution ManagedExecution { get; set; }

        /// <summary>
        /// Checks to see if the ManagedExecution property is set.
        /// </summary>
        internal bool IsSetManagedExecution() => this.ManagedExecution != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// [Service-managed permissions] The organization root ID or organizational unit (OU)
        /// IDs that you specified for <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DeploymentTargets.html">DeploymentTargets</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationalUnitIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitIds property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitIds() => this.OrganizationalUnitIds != null && (this.OrganizationalUnitIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of input parameters for a StackSet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Describes how the IAM roles required for StackSet operations are created.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <c>self-managed</c> permissions, you must create the administrator and execution
        /// roles required to deploy to target accounts. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-self-managed.html">Grant
        /// self-managed permissions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <c>service-managed</c> permissions, StackSets automatically creates the IAM roles
        /// required to deploy to accounts managed by Organizations. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-activate-trusted-access.html">Activate
        /// trusted access for StackSets with Organizations</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionModels PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Returns a list of all Amazon Web Services Regions the given StackSet has stack instances
        /// deployed in. The Amazon Web Services Regions list output is in no particular order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StackSetARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the StackSet.
        /// </para>
        /// </summary>
        public string StackSetARN { get; set; }

        /// <summary>
        /// Checks to see if the StackSetARN property is set.
        /// </summary>
        internal bool IsSetStackSetARN() => this.StackSetARN != null;

        /// <summary>
        /// Gets and sets the property StackSetDriftDetectionDetails. 
        /// <para>
        /// Detailed information about the drift status of the StackSet.
        /// </para>
        ///  
        /// <para>
        /// For StackSets, contains information about the last <i>completed</i> drift operation
        /// performed on the StackSet. Information about drift operations currently in progress
        /// isn't included.
        /// </para>
        /// </summary>
        public StackSetDriftDetectionDetails StackSetDriftDetectionDetails { get; set; }

        /// <summary>
        /// Checks to see if the StackSetDriftDetectionDetails property is set.
        /// </summary>
        internal bool IsSetStackSetDriftDetectionDetails() => this.StackSetDriftDetectionDetails != null;

        /// <summary>
        /// Gets and sets the property StackSetId. 
        /// <para>
        /// The ID of the StackSet.
        /// </para>
        /// </summary>
        public string StackSetId { get; set; }

        /// <summary>
        /// Checks to see if the StackSetId property is set.
        /// </summary>
        internal bool IsSetStackSetId() => this.StackSetId != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name that's associated with the StackSet.
        /// </para>
        /// </summary>
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the StackSet.
        /// </para>
        /// </summary>
        public StackSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that specify information about the StackSet. A maximum number of 50
        /// tags can be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The structure that contains the body of the template that was used to create or update
        /// the StackSet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;
    }
}
