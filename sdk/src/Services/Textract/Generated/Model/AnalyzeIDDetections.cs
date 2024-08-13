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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Used to contain the information detected by an AnalyzeID operation.
    /// </summary>
    public partial class AnalyzeIDDetections
    {
        private float? _confidence;
        private NormalizedValue _normalizedValue;
        private string _text;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence score of the detected text.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NormalizedValue. 
        /// <para>
        /// Only returned for dates, returns the type of value detected and the date written in
        /// a more machine readable way.
        /// </para>
        /// </summary>
        public NormalizedValue NormalizedValue
        {
            get { return this._normalizedValue; }
            set { this._normalizedValue = value; }
        }

        // Check to see if NormalizedValue property is set
        internal bool IsSetNormalizedValue()
        {
            return this._normalizedValue != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Text of either the normalized field or value associated with it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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