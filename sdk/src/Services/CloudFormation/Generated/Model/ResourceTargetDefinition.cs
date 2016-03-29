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
    /// The field that AWS CloudFormation will change, such as the name of a resource's property,
    /// and whether the resource will be recreated.
    /// </summary>
    public partial class ResourceTargetDefinition
    {
        private ResourceAttribute _attribute;
        private string _name;
        private RequiresRecreation _requiresRecreation;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// Indicates which resource attribute is triggering this update, such as a change in
        /// the resource attribute's <code>Metadata</code>, <code>Properties</code>, or <code>Tags</code>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// If the <code>Attribute</code> value is <code>Properties</code>, the name of the property.
        /// For all other attributes, the value is null.
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
        /// Gets and sets the property RequiresRecreation. 
        /// <para>
        /// If the <code>Attribute</code> value is <code>Properties</code>, indicates whether
        /// a change to this property causes the resource to be recreated. The value can be <code>Never</code>,
        /// <code>Always</code>, or <code>Conditionally</code>. To determine the conditions for
        /// a <code>Conditionally</code> recreation, see the update behavior for that <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">property</a>
        /// in the AWS CloudFormation User Guide.
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