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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
        private ChangeAction _action;
        private string _afterContext;
        private string _beforeContext;
        private string _changeSetId;
        private List<ResourceChangeDetail> _details = AWSConfigs.InitializeCollections ? new List<ResourceChangeDetail>() : null;
        private string _logicalResourceId;
        private ModuleInfo _moduleInfo;
        private string _physicalResourceId;
        private PolicyAction _policyAction;
        private Replacement _replacement;
        private string _resourceType;
        private List<string> _scope = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that CloudFormation takes on the resource, such as <c>Add</c> (adds a new
        /// resource), <c>Modify</c> (changes a resource), <c>Remove</c> (deletes a resource),
        /// <c>Import</c> (imports a resource), or <c>Dynamic</c> (exact action for the resource
        /// can't be determined).
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AfterContext. 
        /// <para>
        /// An encoded JSON string that contains the context of the resource after the change
        /// is executed.
        /// </para>
        /// </summary>
        public string AfterContext
        {
            get { return this._afterContext; }
            set { this._afterContext = value; }
        }

        // Check to see if AfterContext property is set
        internal bool IsSetAfterContext()
        {
            return this._afterContext != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeContext. 
        /// <para>
        /// An encoded JSON string that contains the context of the resource before the change
        /// is executed.
        /// </para>
        /// </summary>
        public string BeforeContext
        {
            get { return this._beforeContext; }
            set { this._beforeContext = value; }
        }

        // Check to see if BeforeContext property is set
        internal bool IsSetBeforeContext()
        {
            return this._beforeContext != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The change set ID of the nested change set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ChangeSetId
        {
            get { return this._changeSetId; }
            set { this._changeSetId = value; }
        }

        // Check to see if ChangeSetId property is set
        internal bool IsSetChangeSetId()
        {
            return this._changeSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// For the <c>Modify</c> action, a list of <c>ResourceChangeDetail</c> structures that
        /// describes the changes that CloudFormation will make to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceChangeDetail> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The resource's logical ID, which is defined in the stack's template.
        /// </para>
        /// </summary>
        public string LogicalResourceId
        {
            get { return this._logicalResourceId; }
            set { this._logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this._logicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ModuleInfo. 
        /// <para>
        /// Contains information about the module from which the resource was created, if the
        /// resource was created from a module included in the stack template.
        /// </para>
        /// </summary>
        public ModuleInfo ModuleInfo
        {
            get { return this._moduleInfo; }
            set { this._moduleInfo = value; }
        }

        // Check to see if ModuleInfo property is set
        internal bool IsSetModuleInfo()
        {
            return this._moduleInfo != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The resource's physical ID (resource name). Resources that you are adding don't have
        /// physical IDs because they haven't been created.
        /// </para>
        /// </summary>
        public string PhysicalResourceId
        {
            get { return this._physicalResourceId; }
            set { this._physicalResourceId = value; }
        }

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this._physicalResourceId != null;
        }

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
        public PolicyAction PolicyAction
        {
            get { return this._policyAction; }
            set { this._policyAction = value; }
        }

        // Check to see if PolicyAction property is set
        internal bool IsSetPolicyAction()
        {
            return this._policyAction != null;
        }

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
        public Replacement Replacement
        {
            get { return this._replacement; }
            set { this._replacement = value; }
        }

        // Check to see if Replacement property is set
        internal bool IsSetReplacement()
        {
            return this._replacement != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of CloudFormation resource, such as <c>AWS::S3::Bucket</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// For the <c>Modify</c> action, indicates which resource attribute is triggering this
        /// update, such as a change in the resource attribute's <c>Metadata</c>, <c>Properties</c>,
        /// or <c>Tags</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null && (this._scope.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}