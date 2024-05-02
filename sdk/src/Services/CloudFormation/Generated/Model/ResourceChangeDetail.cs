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
    /// For a resource with <c>Modify</c> as the action, the <c>ResourceChange</c> structure
    /// describes the changes CloudFormation will make to that resource.
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
        /// the group that's specified by the <c>ChangeSource</c> field. For example, if you modified
        /// the value of the <c>KeyPairName</c> parameter, the <c>CausingEntity</c> is the name
        /// of the parameter (<c>KeyPairName</c>).
        /// </para>
        ///  
        /// <para>
        /// If the <c>ChangeSource</c> value is <c>DirectModification</c>, no value is given for
        /// <c>CausingEntity</c>.
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
        /// The group to which the <c>CausingEntity</c> value belongs. There are five entity groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ResourceReference</c> entities are <c>Ref</c> intrinsic functions that refer to
        /// resources in the template, such as <c>{ "Ref" : "MyEC2InstanceResource" }</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ParameterReference</c> entities are <c>Ref</c> intrinsic functions that get template
        /// parameter values, such as <c>{ "Ref" : "MyPasswordParameter" }</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceAttribute</c> entities are <c>Fn::GetAtt</c> intrinsic functions that
        /// get resource attribute values, such as <c>{ "Fn::GetAtt" : [ "MyEC2InstanceResource",
        /// "PublicDnsName" ] }</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DirectModification</c> entities are changes that are made directly to the template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Automatic</c> entities are <c>AWS::CloudFormation::Stack</c> resource types, which
        /// are also known as nested stacks. If you made no changes to the <c>AWS::CloudFormation::Stack</c>
        /// resource, CloudFormation sets the <c>ChangeSource</c> to <c>Automatic</c> because
        /// the nested stack's template might have changed. Changes to a nested stack's template
        /// aren't visible to CloudFormation until you run an update on the parent stack.
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
        /// Indicates whether CloudFormation can determine the target value, and whether the target
        /// value will change before you execute a change set.
        /// </para>
        ///  
        /// <para>
        /// For <c>Static</c> evaluations, CloudFormation can determine that the target value
        /// will change, and its value. For example, if you directly modify the <c>InstanceType</c>
        /// property of an EC2 instance, CloudFormation knows that this property value will change,
        /// and its value, so this is a <c>Static</c> evaluation.
        /// </para>
        ///  
        /// <para>
        /// For <c>Dynamic</c> evaluations, can't determine the target value because it depends
        /// on the result of an intrinsic function, such as a <c>Ref</c> or <c>Fn::GetAtt</c>
        /// intrinsic function, when the stack is updated. For example, if your template includes
        /// a reference to a resource that's conditionally recreated, the value of the reference
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
        /// A <c>ResourceTargetDefinition</c> structure that describes the field that CloudFormation
        /// will change and whether the resource will be recreated.
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