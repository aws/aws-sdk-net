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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// The results extracted for a lending document.
    /// </summary>
    public partial class LendingDetection
    {
        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level for the text of a detected value in a lending document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Geometry.
        /// </summary>
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property SelectionStatus. 
        /// <para>
        /// The selection status of a selection element, such as an option button or check box.
        /// </para>
        /// </summary>
        public SelectionStatus SelectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SelectionStatus property is set.
        /// </summary>
        internal bool IsSetSelectionStatus() => this.SelectionStatus != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text extracted for a detected value in a lending document.
        /// </para>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
