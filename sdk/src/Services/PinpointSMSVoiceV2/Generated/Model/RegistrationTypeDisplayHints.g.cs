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
    /// Provides help information on the registration type.
    /// </summary>
    public partial class RegistrationTypeDisplayHints
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
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A short description of the display hint.
        /// </para>
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;

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
