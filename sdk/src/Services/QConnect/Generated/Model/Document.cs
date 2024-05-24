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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The document.
    /// </summary>
    public partial class Document
    {
        private ContentReference _contentReference;
        private DocumentText _excerpt;
        private DocumentText _title;

        /// <summary>
        /// Gets and sets the property ContentReference. 
        /// <para>
        /// A reference to the content resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentReference ContentReference
        {
            get { return this._contentReference; }
            set { this._contentReference = value; }
        }

        // Check to see if ContentReference property is set
        internal bool IsSetContentReference()
        {
            return this._contentReference != null;
        }

        /// <summary>
        /// Gets and sets the property Excerpt. 
        /// <para>
        /// The excerpt from the document.
        /// </para>
        /// </summary>
        public DocumentText Excerpt
        {
            get { return this._excerpt; }
            set { this._excerpt = value; }
        }

        // Check to see if Excerpt property is set
        internal bool IsSetExcerpt()
        {
            return this._excerpt != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the document.
        /// </para>
        /// </summary>
        public DocumentText Title
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