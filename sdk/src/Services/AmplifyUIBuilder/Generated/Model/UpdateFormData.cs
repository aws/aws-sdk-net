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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Updates and saves all of the information about a form, based on form ID.
    /// </summary>
    public partial class UpdateFormData
    {
        private FormCTA _cta;
        private FormDataTypeConfig _dataType;
        private Dictionary<string, FieldConfig> _fields = new Dictionary<string, FieldConfig>();
        private FormActionType _formActionType;
        private LabelDecorator _labelDecorator;
        private string _name;
        private string _schemaVersion;
        private Dictionary<string, SectionalElement> _sectionalElements = new Dictionary<string, SectionalElement>();
        private FormStyle _style;

        /// <summary>
        /// Gets and sets the property Cta. 
        /// <para>
        /// The <code>FormCTA</code> object that stores the call to action configuration for the
        /// form.
        /// </para>
        /// </summary>
        public FormCTA Cta
        {
            get { return this._cta; }
            set { this._cta = value; }
        }

        // Check to see if Cta property is set
        internal bool IsSetCta()
        {
            return this._cta != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The type of data source to use to create the form.
        /// </para>
        /// </summary>
        public FormDataTypeConfig DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The configuration information for the form's fields.
        /// </para>
        /// </summary>
        public Dictionary<string, FieldConfig> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && this._fields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FormActionType. 
        /// <para>
        /// Specifies whether to perform a create or update action on the form.
        /// </para>
        /// </summary>
        public FormActionType FormActionType
        {
            get { return this._formActionType; }
            set { this._formActionType = value; }
        }

        // Check to see if FormActionType property is set
        internal bool IsSetFormActionType()
        {
            return this._formActionType != null;
        }

        /// <summary>
        /// Gets and sets the property LabelDecorator. 
        /// <para>
        /// Specifies an icon or decoration to display on the form.
        /// </para>
        /// </summary>
        public LabelDecorator LabelDecorator
        {
            get { return this._labelDecorator; }
            set { this._labelDecorator = value; }
        }

        // Check to see if LabelDecorator property is set
        internal bool IsSetLabelDecorator()
        {
            return this._labelDecorator != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the form.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of the form.
        /// </para>
        /// </summary>
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SectionalElements. 
        /// <para>
        /// The configuration information for the visual helper elements for the form. These elements
        /// are not associated with any data.
        /// </para>
        /// </summary>
        public Dictionary<string, SectionalElement> SectionalElements
        {
            get { return this._sectionalElements; }
            set { this._sectionalElements = value; }
        }

        // Check to see if SectionalElements property is set
        internal bool IsSetSectionalElements()
        {
            return this._sectionalElements != null && this._sectionalElements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// The configuration for the form's style.
        /// </para>
        /// </summary>
        public FormStyle Style
        {
            get { return this._style; }
            set { this._style = value; }
        }

        // Check to see if Style property is set
        internal bool IsSetStyle()
        {
            return this._style != null;
        }

    }
}