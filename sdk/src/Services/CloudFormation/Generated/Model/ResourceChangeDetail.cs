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
    /// For a resource with <code>Modify</code> as the action, the <code>ResourceChange</code>
    /// structure describes the changes AWS CloudFormation will make to that resource.
    /// </summary>
    public partial class ResourceChangeDetail
    {
        private string _causingEntity;
        private ChangeSource _changeSource;
        private EvaluationType _evaluation;
        private ResourceTargetDefinition _target;

        /// <summary>
        /// Gets and sets the property CausingEntity. 
        /// <para>
        /// The identity of the entity that triggered this change. This entity is a member of
        /// the group that is specified by the <code>ChangeSource</code> field. For example, if
        /// you modified the value of the <code>KeyPairName</code> parameter, the <code>CausingEntity</code>
        /// is the name of the parameter (<code>KeyPairName</code>).
        /// </para>
        ///  
        /// <para>
        /// If the <code>ChangeSource</code> value is <code>DirectModification</code>, no value
        /// is given for <code>CausingEntity</code>.
        /// </para>
        /// </summary>
        public string CausingEntity
        {
            get { return this._causingEntity; }
            set { this._causingEntity = value; }
        }

        // Check to see if CausingEntity property is set
        internal bool IsSetCausingEntity()
        {
            return this._causingEntity != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeSource. 
        /// <para>
        /// The group to which the <code>CausingEntity</code> value belongs. There are five entity
        /// groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ResourceReference</code> entities are <code>Ref</code> intrinsic functions
        /// that refer to resources in the template, such as <code>{ "Ref" : "MyEC2InstanceResource"
        /// }</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ParameterReference</code> entities are <code>Ref</code> intrinsic functions
        /// that get template parameter values, such as <code>{ "Ref" : "MyPasswordParameter"
        /// }</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceAttribute</code> entities are <code>Fn::GetAtt</code> intrinsic functions
        /// that get resource attribute values, such as <code>{ "Fn::GetAtt" : [ "MyEC2InstanceResource",
        /// "PublicDnsName" ] }</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DirectModification</code> entities are changes that are made directly to the
        /// template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Automatic</code> entities are <code>AWS::CloudFormation::Stack</code> resource
        /// types, which are also known as nested stacks. If you made no changes to the <code>AWS::CloudFormation::Stack</code>
        /// resource, AWS CloudFormation sets the <code>ChangeSource</code> to <code>Automatic</code>
        /// because the nested stack's template might have changed. Changes to a nested stack's
        /// template aren't visible to AWS CloudFormation until you run an update on the parent
        /// stack.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChangeSource ChangeSource
        {
            get { return this._changeSource; }
            set { this._changeSource = value; }
        }

        // Check to see if ChangeSource property is set
        internal bool IsSetChangeSource()
        {
            return this._changeSource != null;
        }

        /// <summary>
        /// Gets and sets the property Evaluation. 
        /// <para>
        /// Indicates whether AWS CloudFormation can determine the target value, and whether the
        /// target value will change before you execute a change set.
        /// </para>
        ///  
        /// <para>
        /// For <code>Static</code> evaluations, AWS CloudFormation can determine that the target
        /// value will change, and its value. For example, if you directly modify the <code>InstanceType</code>
        /// property of an EC2 instance, AWS CloudFormation knows that this property value will
        /// change, and its value, so this is a <code>Static</code> evaluation.
        /// </para>
        ///  
        /// <para>
        /// For <code>Dynamic</code> evaluations, cannot determine the target value because it
        /// depends on the result of an intrinsic function, such as a <code>Ref</code> or <code>Fn::GetAtt</code>
        /// intrinsic function, when the stack is updated. For example, if your template includes
        /// a reference to a resource that is conditionally recreated, the value of the reference
        /// (the physical ID of the resource) might change, depending on if the resource is recreated.
        /// If the resource is recreated, it will have a new physical ID, so all references to
        /// that resource will also be updated.
        /// </para>
        /// </summary>
        public EvaluationType Evaluation
        {
            get { return this._evaluation; }
            set { this._evaluation = value; }
        }

        // Check to see if Evaluation property is set
        internal bool IsSetEvaluation()
        {
            return this._evaluation != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// A <code>ResourceTargetDefinition</code> structure that describes the field that AWS
        /// CloudFormation will change and whether the resource will be recreated.
        /// </para>
        /// </summary>
        public ResourceTargetDefinition Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}