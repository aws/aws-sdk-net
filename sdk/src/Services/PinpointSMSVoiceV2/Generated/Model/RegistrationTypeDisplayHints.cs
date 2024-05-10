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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
        private string _documentationLink;
        private string _documentationTitle;
        private string _longDescription;
        private string _shortDescription;
        private string _title;

        /// <summary>
        /// Gets and sets the property DocumentationLink. 
        /// <para>
        /// The link to the document the display hint is associated with.
        /// </para>
        /// </summary>
        public string DocumentationLink
        {
            get { return this._documentationLink; }
            set { this._documentationLink = value; }
        }

        // Check to see if DocumentationLink property is set
        internal bool IsSetDocumentationLink()
        {
            return this._documentationLink != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentationTitle. 
        /// <para>
        /// The title of the document the display hint is associated with.
        /// </para>
        /// </summary>
        public string DocumentationTitle
        {
            get { return this._documentationTitle; }
            set { this._documentationTitle = value; }
        }

        // Check to see if DocumentationTitle property is set
        internal bool IsSetDocumentationTitle()
        {
            return this._documentationTitle != null;
        }

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// A full description of the display hint.
        /// </para>
        /// </summary>
        public string LongDescription
        {
            get { return this._longDescription; }
            set { this._longDescription = value; }
        }

        // Check to see if LongDescription property is set
        internal bool IsSetLongDescription()
        {
            return this._longDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A short description of the display hint.
        /// </para>
        /// </summary>
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set { this._shortDescription = value; }
        }

        // Check to see if ShortDescription property is set
        internal bool IsSetShortDescription()
        {
            return this._shortDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the display hint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}