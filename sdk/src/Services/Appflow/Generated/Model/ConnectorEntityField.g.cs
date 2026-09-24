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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Describes the data model of a connector field. For example, for an <i>account</i>
    /// entity, the fields would be <i>account name</i>, <i>account ID</i>, and so on.
    /// </summary>
    public partial class ConnectorEntityField
    {
        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// A map that has specific properties related to the ConnectorEntityField.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> CustomProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomProperties property is set.
        /// </summary>
        internal bool IsSetCustomProperties() => this.CustomProperties != null && (this.CustomProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// Default value that can be assigned to this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the connector entity field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationProperties. 
        /// <para>
        ///  The properties applied to a field when the connector is being used as a destination.
        /// 
        /// </para>
        /// </summary>
        public DestinationFieldProperties DestinationProperties { get; set; }

        /// <summary>
        /// Checks to see if the DestinationProperties property is set.
        /// </summary>
        internal bool IsSetDestinationProperties() => this.DestinationProperties != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  The unique identifier of the connector field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property IsDeprecated. 
        /// <para>
        /// Booelan value that indicates whether this field is deprecated or not.
        /// </para>
        /// </summary>
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// Checks to see if the IsDeprecated property is set.
        /// </summary>
        internal bool IsSetIsDeprecated() => this.IsDeprecated.HasValue;

        /// <summary>
        /// Gets and sets the property IsPrimaryKey. 
        /// <para>
        /// Booelan value that indicates whether this field can be used as a primary key.
        /// </para>
        /// </summary>
        public bool? IsPrimaryKey { get; set; }

        /// <summary>
        /// Checks to see if the IsPrimaryKey property is set.
        /// </summary>
        internal bool IsSetIsPrimaryKey() => this.IsPrimaryKey.HasValue;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  The label applied to a connector entity field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property ParentIdentifier. 
        /// <para>
        /// The parent identifier of the connector field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ParentIdentifier property is set.
        /// </summary>
        internal bool IsSetParentIdentifier() => this.ParentIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        ///  The properties that can be applied to a field when the connector is being used as
        /// a source. 
        /// </para>
        /// </summary>
        public SourceFieldProperties SourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the SourceProperties property is set.
        /// </summary>
        internal bool IsSetSourceProperties() => this.SourceProperties != null;

        /// <summary>
        /// Gets and sets the property SupportedFieldTypeDetails. 
        /// <para>
        ///  Contains details regarding the supported <c>FieldType</c>, including the corresponding
        /// <c>filterOperators</c> and <c>supportedValues</c>. 
        /// </para>
        /// </summary>
        public SupportedFieldTypeDetails SupportedFieldTypeDetails { get; set; }

        /// <summary>
        /// Checks to see if the SupportedFieldTypeDetails property is set.
        /// </summary>
        internal bool IsSetSupportedFieldTypeDetails() => this.SupportedFieldTypeDetails != null;
    }
}
