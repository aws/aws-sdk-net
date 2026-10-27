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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// A card representing a component or step in an Amazon Q App's flow.
    /// </summary>
    public partial class Card
    {
        /// <summary>
        /// Gets and sets the property FileUpload. 
        /// <para>
        /// A container for the properties of the file upload card.
        /// </para>
        /// </summary>
        public FileUploadCard FileUpload { get; set; }

        /// <summary>
        /// Checks to see if the FileUpload property is set.
        /// </summary>
        internal bool IsSetFileUpload() => this.FileUpload != null;

        /// <summary>
        /// Gets and sets the property FormInput. 
        /// <para>
        /// A container for the properties of the form input card.
        /// </para>
        /// </summary>
        public FormInputCard FormInput { get; set; }

        /// <summary>
        /// Checks to see if the FormInput property is set.
        /// </summary>
        internal bool IsSetFormInput() => this.FormInput != null;

        /// <summary>
        /// Gets and sets the property QPlugin. 
        /// <para>
        /// A container for the properties of the plugin card.
        /// </para>
        /// </summary>
        public QPluginCard QPlugin { get; set; }

        /// <summary>
        /// Checks to see if the QPlugin property is set.
        /// </summary>
        internal bool IsSetQPlugin() => this.QPlugin != null;

        /// <summary>
        /// Gets and sets the property QQuery. 
        /// <para>
        /// A container for the properties of the query card.
        /// </para>
        /// </summary>
        public QQueryCard QQuery { get; set; }

        /// <summary>
        /// Checks to see if the QQuery property is set.
        /// </summary>
        internal bool IsSetQQuery() => this.QQuery != null;

        /// <summary>
        /// Gets and sets the property TextInput. 
        /// <para>
        /// A container for the properties of the text input card.
        /// </para>
        /// </summary>
        public TextInputCard TextInput { get; set; }

        /// <summary>
        /// Checks to see if the TextInput property is set.
        /// </summary>
        internal bool IsSetTextInput() => this.TextInput != null;
    }
}
