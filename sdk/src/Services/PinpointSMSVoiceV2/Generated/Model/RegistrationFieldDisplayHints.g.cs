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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Provides help information on the registration field.
    /// </summary>
    public partial class RegistrationFieldDisplayHints
    {
        /// <summary>
        /// Gets and sets the property DocumentationLink. 
        /// <para>
        /// The link to the document the display hint is associated with.
        /// </para>
        /// </summary>
        public string DocumentationLink { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationLink property is set.
        /// </summary>
        internal bool IsSetDocumentationLink() => this.DocumentationLink != null;

        /// <summary>
        /// Gets and sets the property DocumentationTitle. 
        /// <para>
        /// The title of the document the display hint is associated with.
        /// </para>
        /// </summary>
        public string DocumentationTitle { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationTitle property is set.
        /// </summary>
        internal bool IsSetDocumentationTitle() => this.DocumentationTitle != null;

        /// <summary>
        /// Gets and sets the property ExampleTextValue. 
        /// <para>
        /// Example text of what the value of a field should contain.
        /// </para>
        /// </summary>
        public string ExampleTextValue { get; set; }

        /// <summary>
        /// Checks to see if the ExampleTextValue property is set.
        /// </summary>
        internal bool IsSetExampleTextValue() => this.ExampleTextValue != null;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// A full description of the display hint.
        /// </para>
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// Checks to see if the LongDescription property is set.
        /// </summary>
        internal bool IsSetLongDescription() => this.LongDescription != null;

        /// <summary>
        /// Gets and sets the property SelectOptionDescriptions. 
        /// <para>
        /// An array of SelectOptionDescription objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SelectOptionDescription> SelectOptionDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<SelectOptionDescription>() : null;

        /// <summary>
        /// Checks to see if the SelectOptionDescriptions property is set.
        /// </summary>
        internal bool IsSetSelectOptionDescriptions() => this.SelectOptionDescriptions != null && (this.SelectOptionDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A short description of the display hint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;

        /// <summary>
        /// Gets and sets the property TextValidationDescription. 
        /// <para>
        /// The validation rules for the text field.
        /// </para>
        /// </summary>
        public string TextValidationDescription { get; set; }

        /// <summary>
        /// Checks to see if the TextValidationDescription property is set.
        /// </summary>
        internal bool IsSetTextValidationDescription() => this.TextValidationDescription != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the display hint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
