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
    /// A text box.
    /// </summary>
    public partial class SheetTextBox
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content that is displayed in the text box.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 150000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Interactions. 
        /// <para>
        /// The general textbox interactions setup for a textbox.
        /// </para>
        /// </summary>
        public TextBoxInteractionOptions Interactions { get; set; }

        /// <summary>
        /// Checks to see if the Interactions property is set.
        /// </summary>
        internal bool IsSetInteractions() => this.Interactions != null;

        /// <summary>
        /// Gets and sets the property SheetTextBoxId. 
        /// <para>
        /// The unique identifier for a text box. This identifier must be unique within the context
        /// of a dashboard, template, or analysis. Two dashboards, analyses, or templates can
        /// have text boxes that share identifiers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SheetTextBoxId { get; set; }

        /// <summary>
        /// Checks to see if the SheetTextBoxId property is set.
        /// </summary>
        internal bool IsSetSheetTextBoxId() => this.SheetTextBoxId != null;
    }
}
