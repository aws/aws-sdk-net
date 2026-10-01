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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The content of the quick response stored in different media types.
    /// </summary>
    public partial class QuickResponseContents
    {
        /// <summary>
        /// Gets and sets the property Markdown.
        /// </summary>
        public QuickResponseContentProvider Markdown { get; set; }

        /// <summary>
        /// Checks to see if the Markdown property is set.
        /// </summary>
        internal bool IsSetMarkdown() => this.Markdown != null;

        /// <summary>
        /// Gets and sets the property PlainText.
        /// </summary>
        public QuickResponseContentProvider PlainText { get; set; }

        /// <summary>
        /// Checks to see if the PlainText property is set.
        /// </summary>
        internal bool IsSetPlainText() => this.PlainText != null;
    }
}
