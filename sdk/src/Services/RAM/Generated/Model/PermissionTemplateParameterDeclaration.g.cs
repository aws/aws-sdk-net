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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes a template parameter declaration for a customer managed permission. Each
    /// declaration defines a named placeholder that can be used in the permission's policy
    /// template.
    /// </summary>
    public partial class PermissionTemplateParameterDeclaration
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the template parameter that helps consumers understand what value
        /// to provide.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the template parameter. This name is used as the placeholder in the policy
        /// template using the syntax <c>@{parameterName}</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the template parameter. This can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STRING</c> – A single string value that is substituted directly into the template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STRING_LIST</c> – One or more string values that expand to an array in the rendered
        /// policy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionTemplateParameterType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
