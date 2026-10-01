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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The text format for the title.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class ShortFormatText
    {
        /// <summary>
        /// Gets and sets the property PlainText. 
        /// <para>
        /// Plain text format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string PlainText { get; set; }

        /// <summary>
        /// Checks to see if the PlainText property is set.
        /// </summary>
        internal bool IsSetPlainText() => this.PlainText != null;

        /// <summary>
        /// Gets and sets the property RichText. 
        /// <para>
        /// Rich text. Examples of rich text include bold, underline, and italics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RichText { get; set; }

        /// <summary>
        /// Checks to see if the RichText property is set.
        /// </summary>
        internal bool IsSetRichText() => this.RichText != null;
    }
}
