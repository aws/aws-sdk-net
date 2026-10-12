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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Represents a member of the complex data structure. The data type of the property can
    /// be either primitive or another <c>struct</c>.
    /// </summary>
    public partial class CustomProperty
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment in addition to the description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property DataEncoding. 
        /// <para>
        /// Indicates whether the property is binary data.
        /// </para>
        /// </summary>
        public NodeDataEncoding DataEncoding { get; set; }

        /// <summary>
        /// Checks to see if the DataEncoding property is set.
        /// </summary>
        internal bool IsSetDataEncoding() => this.DataEncoding != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type for the custom property. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DeprecationMessage. 
        /// <para>
        /// The deprecation message for the node or the branch that was moved or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DeprecationMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationMessage property is set.
        /// </summary>
        internal bool IsSetDeprecationMessage() => this.DeprecationMessage != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the custom property.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the custom property. For example, the fully qualified
        /// name of a custom property might be <c>ComplexDataTypes.VehicleDataTypes.SVMCamera.FPS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// Checks to see if the FullyQualifiedName property is set.
        /// </summary>
        internal bool IsSetFullyQualifiedName() => this.FullyQualifiedName != null;

        /// <summary>
        /// Gets and sets the property StructFullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the struct node for the custom property if the data type
        /// of the custom property is <c>Struct</c> or <c>StructArray</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public string StructFullyQualifiedName { get; set; }

        /// <summary>
        /// Checks to see if the StructFullyQualifiedName property is set.
        /// </summary>
        internal bool IsSetStructFullyQualifiedName() => this.StructFullyQualifiedName != null;
    }
}
