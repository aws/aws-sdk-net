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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// A card representing a component or step in an Amazon Q App's flow.
    /// </summary>
    public partial class Card
    {
        private FileUploadCard _fileUpload;
        private FormInputCard _formInput;
        private QPluginCard _qPlugin;
        private QQueryCard _qQuery;
        private TextInputCard _textInput;

        /// <summary>
        /// Gets and sets the property FileUpload. 
        /// <para>
        /// A container for the properties of the file upload card.
        /// </para>
        /// </summary>
        public FileUploadCard FileUpload
        {
            get { return this._fileUpload; }
            set { this._fileUpload = value; }
        }

        // Check to see if FileUpload property is set
        internal bool IsSetFileUpload()
        {
            return this._fileUpload != null;
        }

        /// <summary>
        /// Gets and sets the property FormInput. 
        /// <para>
        /// A container for the properties of the form input card.
        /// </para>
        /// </summary>
        public FormInputCard FormInput
        {
            get { return this._formInput; }
            set { this._formInput = value; }
        }

        // Check to see if FormInput property is set
        internal bool IsSetFormInput()
        {
            return this._formInput != null;
        }

        /// <summary>
        /// Gets and sets the property QPlugin. 
        /// <para>
        /// A container for the properties of the plugin card.
        /// </para>
        /// </summary>
        public QPluginCard QPlugin
        {
            get { return this._qPlugin; }
            set { this._qPlugin = value; }
        }

        // Check to see if QPlugin property is set
        internal bool IsSetQPlugin()
        {
            return this._qPlugin != null;
        }

        /// <summary>
        /// Gets and sets the property QQuery. 
        /// <para>
        /// A container for the properties of the query card.
        /// </para>
        /// </summary>
        public QQueryCard QQuery
        {
            get { return this._qQuery; }
            set { this._qQuery = value; }
        }

        // Check to see if QQuery property is set
        internal bool IsSetQQuery()
        {
            return this._qQuery != null;
        }

        /// <summary>
        /// Gets and sets the property TextInput. 
        /// <para>
        /// A container for the properties of the text input card.
        /// </para>
        /// </summary>
        public TextInputCard TextInput
        {
            get { return this._textInput; }
            set { this._textInput = value; }
        }

        // Check to see if TextInput property is set
        internal bool IsSetTextInput()
        {
            return this._textInput != null;
        }

    }
}