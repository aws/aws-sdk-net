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
    /// Contains the configuration settings for a <code>Form</code> user interface (UI) element
    /// for an Amplify app. A form is a component you can add to your project by specifying
    /// a data source as the default configuration for the form.
    /// </summary>
    public partial class Form
    {
        private string _appId;
        private FormCTA _cta;
        private FormDataTypeConfig _dataType;
        private string _environmentName;
        private Dictionary<string, FieldConfig> _fields = new Dictionary<string, FieldConfig>();
        private FormActionType _formActionType;
        private string _id;
        private LabelDecorator _labelDecorator;
        private string _name;
        private string _schemaVersion;
        private Dictionary<string, SectionalElement> _sectionalElements = new Dictionary<string, SectionalElement>();
        private FormStyle _style;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID of the Amplify app associated with the form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property Cta. 
        /// <para>
        /// Stores the call to action configuration for the form.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the backend environment that is a part of the Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// Stores the information about the form's fields.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The operation to perform on the specified form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The schema version of the form when it was imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Stores the visual helper elements for the form that are not associated with any data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Stores the configuration for the form's style.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more key-value pairs to use when tagging the form.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}