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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A text box.
    /// </summary>
    public partial class SheetTextBox
    {
        private string _content;
        private string _sheetTextBoxId;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content that is displayed in the text box.
        /// </para>
        /// </summary>
        [AWSProperty(Max=150000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property SheetTextBoxId. 
        /// <para>
        /// The unique identifier for a text box. This identifier must be unique within the context
        /// of a dashboard, template, or analysis. Two dashboards, analyses, or templates can
        /// have text boxes that share identifiers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SheetTextBoxId
        {
            get { return this._sheetTextBoxId; }
            set { this._sheetTextBoxId = value; }
        }

        // Check to see if SheetTextBoxId property is set
        internal bool IsSetSheetTextBoxId()
        {
            return this._sheetTextBoxId != null;
        }

    }
}