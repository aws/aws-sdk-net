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
    /// The field that CloudFormation will change, such as the name of a resource's property,
    /// and whether the resource will be recreated.
    /// </summary>
    public partial class ResourceTargetDefinition
    {
        /// <summary>
        /// Gets and sets the property AfterValue. 
        /// <para>
        /// The value of the property after the change is executed. Large values can be truncated.
        /// </para>
        /// </summary>
        public string AfterValue { get; set; }

        /// <summary>
        /// Checks to see if the AfterValue property is set.
        /// </summary>
        internal bool IsSetAfterValue() => this.AfterValue != null;

        /// <summary>
        /// Gets and sets the property AfterValueFrom. 
        /// <para>
        /// Indicates the source of the after value. Valid value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TEMPLATE</c> – The after value comes from the new template.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only present for drift-aware change sets.
        /// </para>
        /// </summary>
        public AfterValueFrom AfterValueFrom { get; set; }

        /// <summary>
        /// Checks to see if the AfterValueFrom property is set.
        /// </summary>
        internal bool IsSetAfterValueFrom() => this.AfterValueFrom != null;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// Indicates which resource attribute is triggering this update, such as a change in
        /// the resource attribute's <c>Metadata</c>, <c>Properties</c>, or <c>Tags</c>.
        /// </para>
        /// </summary>
        public ResourceAttribute Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property AttributeChangeType. 
        /// <para>
        /// The type of change to be made to the property if the change is executed.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Add</c> The item will be added.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Remove</c> The item will be removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Modify</c> The item will be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SyncWithActual</c> The drift status of this item will be reset but the item will
        /// not be modified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AttributeChangeType AttributeChangeType { get; set; }

        /// <summary>
        /// Checks to see if the AttributeChangeType property is set.
        /// </summary>
        internal bool IsSetAttributeChangeType() => this.AttributeChangeType != null;

        /// <summary>
        /// Gets and sets the property BeforeValue. 
        /// <para>
        /// The value of the property before the change is executed. Large values can be truncated.
        /// </para>
        /// </summary>
        public string BeforeValue { get; set; }

        /// <summary>
        /// Checks to see if the BeforeValue property is set.
        /// </summary>
        internal bool IsSetBeforeValue() => this.BeforeValue != null;

        /// <summary>
        /// Gets and sets the property BeforeValueFrom. 
        /// <para>
        /// Indicates the source of the before value. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTUAL_STATE</c> – The before value represents current actual state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PREVIOUS_DEPLOYMENT_STATE</c> – The before value represents the previous CloudFormation
        /// deployment state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only present for drift-aware change sets.
        /// </para>
        /// </summary>
        public BeforeValueFrom BeforeValueFrom { get; set; }

        /// <summary>
        /// Checks to see if the BeforeValueFrom property is set.
        /// </summary>
        internal bool IsSetBeforeValueFrom() => this.BeforeValueFrom != null;

        /// <summary>
        /// Gets and sets the property Drift. 
        /// <para>
        /// Detailed drift information for the resource property, including actual values, previous
        /// deployment values, and drift detection timestamps.
        /// </para>
        /// </summary>
        public LiveResourceDrift Drift { get; set; }

        /// <summary>
        /// Checks to see if the Drift property is set.
        /// </summary>
        internal bool IsSetDrift() => this.Drift != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// If the <c>Attribute</c> value is <c>Properties</c>, the name of the property. For
        /// all other attributes, the value is null.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The property path of the property.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property RequiresRecreation. 
        /// <para>
        /// If the <c>Attribute</c> value is <c>Properties</c>, indicates whether a change to
        /// this property causes the resource to be recreated. The value can be <c>Never</c>,
        /// <c>Always</c>, or <c>Conditionally</c>. To determine the conditions for a <c>Conditionally</c>
        /// recreation, see the update behavior for that property in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public RequiresRecreation RequiresRecreation { get; set; }

        /// <summary>
        /// Checks to see if the RequiresRecreation property is set.
        /// </summary>
        internal bool IsSetRequiresRecreation() => this.RequiresRecreation != null;
    }
}
