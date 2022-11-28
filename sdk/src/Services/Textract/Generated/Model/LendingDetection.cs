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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// The results extracted for a lending document.
    /// </summary>
    public partial class LendingDetection
    {
        private float? _confidence;
        private Geometry _geometry;
        private SelectionStatus _selectionStatus;
        private string _text;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level for the text of a detected value in a lending document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Geometry.
        /// </summary>
        public Geometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property SelectionStatus. 
        /// <para>
        /// The selection status of a selection element, such as an option button or check box.
        /// </para>
        /// </summary>
        public SelectionStatus SelectionStatus
        {
            get { return this._selectionStatus; }
            set { this._selectionStatus = value; }
        }

        // Check to see if SelectionStatus property is set
        internal bool IsSetSelectionStatus()
        {
            return this._selectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text extracted for a detected value in a lending document.
        /// </para>
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}