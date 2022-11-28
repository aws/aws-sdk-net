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
    /// Summary information about documents grouped by the same document type.
    /// </summary>
    public partial class DocumentGroup
    {
        private List<DetectedSignature> _detectedSignatures = new List<DetectedSignature>();
        private List<SplitDocument> _splitDocuments = new List<SplitDocument>();
        private string _type;
        private List<UndetectedSignature> _undetectedSignatures = new List<UndetectedSignature>();

        /// <summary>
        /// Gets and sets the property DetectedSignatures. 
        /// <para>
        /// A list of the detected signatures found in a document group.
        /// </para>
        /// </summary>
        public List<DetectedSignature> DetectedSignatures
        {
            get { return this._detectedSignatures; }
            set { this._detectedSignatures = value; }
        }

        // Check to see if DetectedSignatures property is set
        internal bool IsSetDetectedSignatures()
        {
            return this._detectedSignatures != null && this._detectedSignatures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SplitDocuments. 
        /// <para>
        /// An array that contains information about the pages of a document, defined by logical
        /// boundary.
        /// </para>
        /// </summary>
        public List<SplitDocument> SplitDocuments
        {
            get { return this._splitDocuments; }
            set { this._splitDocuments = value; }
        }

        // Check to see if SplitDocuments property is set
        internal bool IsSetSplitDocuments()
        {
            return this._splitDocuments != null && this._splitDocuments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of document that Amazon Textract has detected. See LINK for a list of all
        /// types returned by Textract.
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
        /// Gets and sets the property UndetectedSignatures. 
        /// <para>
        /// A list of any expected signatures not found in a document group.
        /// </para>
        /// </summary>
        public List<UndetectedSignature> UndetectedSignatures
        {
            get { return this._undetectedSignatures; }
            set { this._undetectedSignatures = value; }
        }

        // Check to see if UndetectedSignatures property is set
        internal bool IsSetUndetectedSignatures()
        {
            return this._undetectedSignatures != null && this._undetectedSignatures.Count > 0; 
        }

    }
}