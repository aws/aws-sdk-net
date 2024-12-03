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
    /// The field that CloudFormation will change, such as the name of a resource's property,
    /// and whether the resource will be recreated.
    /// </summary>
    public partial class ResourceTargetDefinition
    {
        private string _afterValue;
        private ResourceAttribute _attribute;
        private AttributeChangeType _attributeChangeType;
        private string _beforeValue;
        private string _name;
        private string _path;
        private RequiresRecreation _requiresRecreation;

        /// <summary>
        /// Gets and sets the property AfterValue. 
        /// <para>
        /// The value of the property after the change is executed. Large values can be truncated.
        /// </para>
        /// </summary>
        public string AfterValue
        {
            get { return this._afterValue; }
            set { this._afterValue = value; }
        }

        // Check to see if AfterValue property is set
        internal bool IsSetAfterValue()
        {
            return this._afterValue != null;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// Indicates which resource attribute is triggering this update, such as a change in
        /// the resource attribute's <c>Metadata</c>, <c>Properties</c>, or <c>Tags</c>.
        /// </para>
        /// </summary>
        public ResourceAttribute Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

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
        ///  </li> </ul>
        /// </summary>
        public AttributeChangeType AttributeChangeType
        {
            get { return this._attributeChangeType; }
            set { this._attributeChangeType = value; }
        }

        // Check to see if AttributeChangeType property is set
        internal bool IsSetAttributeChangeType()
        {
            return this._attributeChangeType != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeValue. 
        /// <para>
        /// The value of the property before the change is executed. Large values can be truncated.
        /// </para>
        /// </summary>
        public string BeforeValue
        {
            get { return this._beforeValue; }
            set { this._beforeValue = value; }
        }

        // Check to see if BeforeValue property is set
        internal bool IsSetBeforeValue()
        {
            return this._beforeValue != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// If the <c>Attribute</c> value is <c>Properties</c>, the name of the property. For
        /// all other attributes, the value is null.
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The property path of the property.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

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
        public RequiresRecreation RequiresRecreation
        {
            get { return this._requiresRecreation; }
            set { this._requiresRecreation = value; }
        }

        // Check to see if RequiresRecreation property is set
        internal bool IsSetRequiresRecreation()
        {
            return this._requiresRecreation != null;
        }

    }
}