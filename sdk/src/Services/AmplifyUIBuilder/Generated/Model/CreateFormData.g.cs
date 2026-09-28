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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Represents all of the information that is required to create a form.
    /// </summary>
    public partial class CreateFormData
    {
        /// <summary>
        /// Gets and sets the property Cta. 
        /// <para>
        /// The <c>FormCTA</c> object that stores the call to action configuration for the form.
        /// </para>
        /// </summary>
        public FormCTA Cta { get; set; }

        /// <summary>
        /// Checks to see if the Cta property is set.
        /// </summary>
        internal bool IsSetCta() => this.Cta != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The type of data source to use to create the form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FormDataTypeConfig DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The configuration information for the form's fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, FieldConfig> Fields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FieldConfig>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FormActionType. 
        /// <para>
        /// Specifies whether to perform a create or update action on the form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FormActionType FormActionType { get; set; }

        /// <summary>
        /// Checks to see if the FormActionType property is set.
        /// </summary>
        internal bool IsSetFormActionType() => this.FormActionType != null;

        /// <summary>
        /// Gets and sets the property LabelDecorator. 
        /// <para>
        /// Specifies an icon or decoration to display on the form.
        /// </para>
        /// </summary>
        public LabelDecorator LabelDecorator { get; set; }

        /// <summary>
        /// Checks to see if the LabelDecorator property is set.
        /// </summary>
        internal bool IsSetLabelDecorator() => this.LabelDecorator != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of the form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;

        /// <summary>
        /// Gets and sets the property SectionalElements. 
        /// <para>
        /// The configuration information for the visual helper elements for the form. These elements
        /// are not associated with any data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, SectionalElement> SectionalElements { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SectionalElement>() : null;

        /// <summary>
        /// Checks to see if the SectionalElements property is set.
        /// </summary>
        internal bool IsSetSectionalElements() => this.SectionalElements != null && (this.SectionalElements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// The configuration for the form's style.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FormStyle Style { get; set; }

        /// <summary>
        /// Checks to see if the Style property is set.
        /// </summary>
        internal bool IsSetStyle() => this.Style != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more key-value pairs to use when tagging the form data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
