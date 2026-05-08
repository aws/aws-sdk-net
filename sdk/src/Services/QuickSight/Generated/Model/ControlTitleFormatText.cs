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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The title format text configuration for a sheet control. This is a tagged union type.
    /// Specify either <c>PlainText</c> or <c>RichText</c>, but not both.
    /// </summary>
    public partial class ControlTitleFormatText
    {
        private string _plainText;
        private string _richText;

        /// <summary>
        /// Gets and sets the property PlainText. 
        /// <para>
        /// The plain text format of the title text.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PlainText
        {
            get { return this._plainText; }
            set { this._plainText = value; }
        }

        // Check to see if PlainText property is set
        internal bool IsSetPlainText()
        {
            return this._plainText != null;
        }

        /// <summary>
        /// Gets and sets the property RichText. 
        /// <para>
        /// The rich text format of the title text.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string RichText
        {
            get { return this._richText; }
            set { this._richText = value; }
        }

        // Check to see if RichText property is set
        internal bool IsSetRichText()
        {
            return this._richText != null;
        }

    }
}