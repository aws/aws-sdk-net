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
    /// The warnings generated for a specific resource for this generated template.
    /// </summary>
    public partial class WarningDetail
    {
        private List<WarningProperty> _properties = AWSConfigs.InitializeCollections ? new List<WarningProperty>() : null;
        private WarningType _type;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of the resource that are impacted by this warning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WarningProperty> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this warning. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/generate-IaC-write-only-properties.html">Resolve
        /// write-only properties</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MUTUALLY_EXCLUSIVE_PROPERTIES</c> - The resource requires mutually-exclusive write-only
        /// properties. The IaC generator selects one set of mutually exclusive properties and
        /// converts the included properties into parameters. The parameter names have a suffix
        /// <c>OneOf</c> and the parameter descriptions indicate that the corresponding property
        /// can be replaced with other exclusive properties.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNSUPPORTED_PROPERTIES</c> - Unsupported properties are present in the resource.
        /// One example of unsupported properties would be a required write-only property that
        /// is an array, because a parameter cannot be an array. Another example is an optional
        /// write-only property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MUTUALLY_EXCLUSIVE_TYPES</c> - One or more required write-only properties are
        /// found in the resource, and the type of that property can be any of several types.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Currently the resource and property reference documentation does not indicate if a
        /// property uses a type of <c>oneOf</c> or <c>anyOf</c>. You need to look at the resource
        /// provider schema.
        /// </para>
        ///  </note>
        /// </summary>
        public WarningType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}