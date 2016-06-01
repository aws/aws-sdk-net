/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <code>ResourceChange</code> structure describes the resource and the action that
    /// AWS CloudFormation will perform on it if you execute this change set.
    /// </summary>
    public partial class ResourceChange
    {
        private ChangeAction _action;
        private List<ResourceChangeDetail> _details = new List<ResourceChangeDetail>();
        private string _logicalResourceId;
        private string _physicalResourceId;
        private Replacement _replacement;
        private string _resourceType;
        private List<string> _scope = new List<string>();

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that AWS CloudFormation takes on the resource, such as <code>Add</code>
        /// (adds a new resource), <code>Modify</code> (changes a resource), or <code>Remove</code>
        /// (deletes a resource).
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
        /// Gets and sets the property Details. 
        /// <para>
        /// For the <code>Modify</code> action, a list of <code>ResourceChangeDetail</code> structures
        /// that describes the changes that AWS CloudFormation will make to the resource. 
        /// </para>
        /// </summary>
        public List<ResourceChangeDetail> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && this._details.Count > 0; 
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
        /// Gets and sets the property Replacement. 
        /// <para>
        /// For the <code>Modify</code> action, indicates whether AWS CloudFormation will replace
        /// the resource by creating a new one and deleting the old one. This value depends on
        /// the value of the <code>RequiresRecreation</code> property in the <code>ResourceTargetDefinition</code>
        /// structure. For example, if the <code>RequiresRecreation</code> field is <code>Always</code>
        /// and the <code>Evaluation</code> field is <code>Static</code>, <code>Replacement</code>
        /// is <code>True</code>. If the <code>RequiresRecreation</code> field is <code>Always</code>
        /// and the <code>Evaluation</code> field is <code>Dynamic</code>, <code>Replacement</code>
        /// is <code>Conditionally</code>.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple changes with different <code>RequiresRecreation</code> values,
        /// the <code>Replacement</code> value depends on the change with the most impact. A <code>RequiresRecreation</code>
        /// value of <code>Always</code> has the most impact, followed by <code>Conditionally</code>,
        /// and then <code>Never</code>.
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
        /// The type of AWS CloudFormation resource, such as <code>AWS::S3::Bucket</code>.
        /// </para>
        /// </summary>
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
        /// For the <code>Modify</code> action, indicates which resource attribute is triggering
        /// this update, such as a change in the resource attribute's <code>Metadata</code>, <code>Properties</code>,
        /// or <code>Tags</code>.
        /// </para>
        /// </summary>
        public List<string> Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null && this._scope.Count > 0; 
        }

    }
}