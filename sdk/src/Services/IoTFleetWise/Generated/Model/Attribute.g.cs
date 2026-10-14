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
    /// A signal that represents static information about the vehicle, such as engine type
    /// or manufacturing date.
    /// </summary>
    public partial class Attribute
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of possible values an attribute can be assigned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null && (this.AllowedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssignedValue. 
        /// <para>
        /// A specified value for the attribute.
        /// </para>
        /// </summary>
        [Obsolete("assignedValue is no longer in use")]
        public string AssignedValue { get; set; }

        /// <summary>
        /// Checks to see if the AssignedValue property is set.
        /// </summary>
        internal bool IsSetAssignedValue() => this.AssignedValue != null;

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
        /// Gets and sets the property DataType. 
        /// <para>
        /// The specified data type of the attribute. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the attribute.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

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
        /// A brief description of the attribute.
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
        /// The fully qualified name of the attribute. For example, the fully qualified name of
        /// an attribute might be <c>Vehicle.Body.Engine.Type</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// Checks to see if the FullyQualifiedName property is set.
        /// </summary>
        internal bool IsSetFullyQualifiedName() => this.FullyQualifiedName != null;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The specified possible maximum value of the attribute.
        /// </para>
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The specified possible minimum value of the attribute.
        /// </para>
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The scientific unit for the attribute.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
