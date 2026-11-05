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
    /// The <c>ResourceChange</c> structure describes the resource and the action that CloudFormation
    /// will perform on it if you execute this change set.
    /// </summary>
    public partial class ResourceChange
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that CloudFormation takes on the resource, such as <c>Add</c> (adds a new
        /// resource), <c>Modify</c> (changes a resource), <c>Remove</c> (deletes a resource),
        /// <c>Import</c> (imports a resource), <c>Dynamic</c> (exact action for the resource
        /// can't be determined), or <c>SyncWithActual</c> (resource will not be changed, only
        /// CloudFormation metadata will change).
        /// </para>
        /// </summary>
        public ChangeAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AfterContext. 
        /// <para>
        /// An encoded JSON string that contains the context of the resource after the change
        /// is executed.
        /// </para>
        /// </summary>
        public string AfterContext { get; set; }

        /// <summary>
        /// Checks to see if the AfterContext property is set.
        /// </summary>
        internal bool IsSetAfterContext() => this.AfterContext != null;

        /// <summary>
        /// Gets and sets the property BeforeContext. 
        /// <para>
        /// An encoded JSON string that contains the context of the resource before the change
        /// is executed.
        /// </para>
        /// </summary>
        public string BeforeContext { get; set; }

        /// <summary>
        /// Checks to see if the BeforeContext property is set.
        /// </summary>
        internal bool IsSetBeforeContext() => this.BeforeContext != null;

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The change set ID of the nested change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetId property is set.
        /// </summary>
        internal bool IsSetChangeSetId() => this.ChangeSetId != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// For the <c>Modify</c> action, a list of <c>ResourceChangeDetail</c> structures that
        /// describes the changes that CloudFormation will make to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceChangeDetail> Details { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceChangeDetail>() : null;

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null && (this.Details.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The resource's logical ID, which is defined in the stack's template.
        /// </para>
        /// </summary>
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the LogicalResourceId property is set.
        /// </summary>
        internal bool IsSetLogicalResourceId() => this.LogicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ModuleInfo. 
        /// <para>
        /// Contains information about the module from which the resource was created, if the
        /// resource was created from a module included in the stack template.
        /// </para>
        /// </summary>
        public ModuleInfo ModuleInfo { get; set; }

        /// <summary>
        /// Checks to see if the ModuleInfo property is set.
        /// </summary>
        internal bool IsSetModuleInfo() => this.ModuleInfo != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The resource's physical ID (resource name). Resources that you are adding don't have
        /// physical IDs because they haven't been created.
        /// </para>
        /// </summary>
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property PolicyAction. 
        /// <para>
        /// The action that will be taken on the physical resource when the change set is executed.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Delete</c> The resource will be deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Retain</c> The resource will be retained.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Snapshot</c> The resource will have a snapshot taken.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReplaceAndDelete</c> The resource will be replaced and then deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReplaceAndRetain</c> The resource will be replaced and then retained.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReplaceAndSnapshot</c> The resource will be replaced and then have a snapshot
        /// taken.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PolicyAction PolicyAction { get; set; }

        /// <summary>
        /// Checks to see if the PolicyAction property is set.
        /// </summary>
        internal bool IsSetPolicyAction() => this.PolicyAction != null;

        /// <summary>
        /// Gets and sets the property PreviousDeploymentContext. 
        /// <para>
        /// Information about the resource's state from the previous CloudFormation deployment.
        /// </para>
        /// </summary>
        public string PreviousDeploymentContext { get; set; }

        /// <summary>
        /// Checks to see if the PreviousDeploymentContext property is set.
        /// </summary>
        internal bool IsSetPreviousDeploymentContext() => this.PreviousDeploymentContext != null;

        /// <summary>
        /// Gets and sets the property Replacement. 
        /// <para>
        /// For the <c>Modify</c> action, indicates whether CloudFormation will replace the resource
        /// by creating a new one and deleting the old one. This value depends on the value of
        /// the <c>RequiresRecreation</c> property in the <c>ResourceTargetDefinition</c> structure.
        /// For example, if the <c>RequiresRecreation</c> field is <c>Always</c> and the <c>Evaluation</c>
        /// field is <c>Static</c>, <c>Replacement</c> is <c>True</c>. If the <c>RequiresRecreation</c>
        /// field is <c>Always</c> and the <c>Evaluation</c> field is <c>Dynamic</c>, <c>Replacement</c>
        /// is <c>Conditional</c>.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple changes with different <c>RequiresRecreation</c> values, the
        /// <c>Replacement</c> value depends on the change with the most impact. A <c>RequiresRecreation</c>
        /// value of <c>Always</c> has the most impact, followed by <c>Conditional</c>, and then
        /// <c>Never</c>.
        /// </para>
        /// </summary>
        public Replacement Replacement { get; set; }

        /// <summary>
        /// Checks to see if the Replacement property is set.
        /// </summary>
        internal bool IsSetReplacement() => this.Replacement != null;

        /// <summary>
        /// Gets and sets the property ResourceDriftIgnoredAttributes. 
        /// <para>
        /// List of resource attributes for which drift was ignored.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceDriftIgnoredAttribute> ResourceDriftIgnoredAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceDriftIgnoredAttribute>() : null;

        /// <summary>
        /// Checks to see if the ResourceDriftIgnoredAttributes property is set.
        /// </summary>
        internal bool IsSetResourceDriftIgnoredAttributes() => this.ResourceDriftIgnoredAttributes != null && (this.ResourceDriftIgnoredAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceDriftStatus. 
        /// <para>
        /// The drift status of the resource. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_SYNC</c> – The resource matches its template definition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFIED</c> – Resource properties were modified outside CloudFormation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> – The resource was deleted outside CloudFormation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c> – CloudFormation doesn’t currently return this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c> – Drift status could not be determined.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNSUPPORTED</c> – Resource type does not support actual state comparison.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only present for drift-aware change sets.
        /// </para>
        /// </summary>
        public StackResourceDriftStatus ResourceDriftStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDriftStatus property is set.
        /// </summary>
        internal bool IsSetResourceDriftStatus() => this.ResourceDriftStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of CloudFormation resource, such as <c>AWS::S3::Bucket</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// For the <c>Modify</c> action, indicates which resource attribute is triggering this
        /// update, such as a change in the resource attribute's <c>Metadata</c>, <c>Properties</c>,
        /// or <c>Tags</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scope { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null && (this.Scope.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
