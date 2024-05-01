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
    /// Structure containing both the normalized type of the extracted information and the
    /// text associated with it. These are extracted as Type and Value respectively.
    /// </summary>
    public partial class IdentityDocumentField
    {
        private AnalyzeIDDetections _type;
        private AnalyzeIDDetections _valueDetection;

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public AnalyzeIDDetections Type
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
        /// Gets and sets the property ValueDetection.
        /// </summary>
        public AnalyzeIDDetections ValueDetection
        {
            get { return this._valueDetection; }
            set { this._valueDetection = value; }
        }

        // Check to see if ValueDetection property is set
        internal bool IsSetValueDetection()
        {
            return this._valueDetection != null;
        }

    }
}