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
    /// Holds the normalized key-value pairs returned by AnalyzeDocument, including the document
    /// type, detected text, and geometry.
    /// </summary>
    public partial class LendingField
    {
        private LendingDetection _keyDetection;
        private string _type;
        private List<LendingDetection> _valueDetections = new List<LendingDetection>();

        /// <summary>
        /// Gets and sets the property KeyDetection.
        /// </summary>
        public LendingDetection KeyDetection
        {
            get { return this._keyDetection; }
            set { this._keyDetection = value; }
        }

        // Check to see if KeyDetection property is set
        internal bool IsSetKeyDetection()
        {
            return this._keyDetection != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the lending document.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValueDetections. 
        /// <para>
        /// An array of LendingDetection objects.
        /// </para>
        /// </summary>
        public List<LendingDetection> ValueDetections
        {
            get { return this._valueDetections; }
            set { this._valueDetections = value; }
        }

        // Check to see if ValueDetections property is set
        internal bool IsSetValueDetections()
        {
            return this._valueDetections != null && this._valueDetections.Count > 0; 
        }

    }
}