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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an asset model property definition. This property definition is applied to
    /// all assets created from the asset model.
    /// </summary>
    public partial class AssetModelPropertyDefinition
    {
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the property definition.
        /// </para>
        ///  
        /// <para>
        /// The <c>VIDEO</c>, <c>ANNOTATION</c>, and <c>JSON</c> data types aren't supported for
        /// asset model properties. These types are used only by time series that store data for
        /// datasets in a workspace.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>STRUCT</c>, you must also specify <c>dataTypeSpec</c> to identify
        /// the type of the structure for this property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PropertyDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property DataTypeSpec. 
        /// <para>
        /// The data type of the structure for this property. This parameter is required on properties
        /// that have the <c>STRUCT</c> data type.
        /// </para>
        ///  
        /// <para>
        /// The options for this parameter depend on the type of the composite model in which
        /// you define this property. Use <c>AWS/ALARM_STATE</c> for alarm state in alarm composite
        /// models.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DataTypeSpec { get; set; }

        /// <summary>
        /// Checks to see if the DataTypeSpec property is set.
        /// </summary>
        internal bool IsSetDataTypeSpec() => this.DataTypeSpec != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// An external ID to assign to the property definition. The external ID must be unique
        /// among property definitions within this asset model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID to assign to the asset model property, if desired. IoT SiteWise automatically
        /// generates a unique ID for you, so this parameter is never required. However, if you
        /// prefer to supply your own ID instead, you can specify it here in UUID format. If you
        /// specify your own ID, it must be globally unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the property definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The property definition type (see <c>PropertyType</c>). You can only specify one type
        /// in a property definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PropertyType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the property definition, such as <c>Newtons</c> or <c>RPM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
