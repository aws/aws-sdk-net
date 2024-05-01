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
    /// Details about the source content text data.
    /// </summary>
    public partial class TextData
    {
        private DocumentText _excerpt;
        private DocumentText _title;

        /// <summary>
        /// Gets and sets the property Excerpt.
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