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
    /// Holds the structured data returned by AnalyzeDocument for lending documents.
    /// </summary>
    public partial class LendingDocument
    {
        private List<LendingField> _lendingFields = new List<LendingField>();
        private List<SignatureDetection> _signatureDetections = new List<SignatureDetection>();

        /// <summary>
        /// Gets and sets the property LendingFields. 
        /// <para>
        /// An array of LendingField objects.
        /// </para>
        /// </summary>
        public List<LendingField> LendingFields
        {
            get { return this._lendingFields; }
            set { this._lendingFields = value; }
        }

        // Check to see if LendingFields property is set
        internal bool IsSetLendingFields()
        {
            return this._lendingFields != null && this._lendingFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SignatureDetections. 
        /// <para>
        /// A list of signatures detected in a lending document.
        /// </para>
        /// </summary>
        public List<SignatureDetection> SignatureDetections
        {
            get { return this._signatureDetections; }
            set { this._signatureDetections = value; }
        }

        // Check to see if SignatureDetections property is set
        internal bool IsSetSignatureDetections()
        {
            return this._signatureDetections != null && this._signatureDetections.Count > 0; 
        }

    }
}