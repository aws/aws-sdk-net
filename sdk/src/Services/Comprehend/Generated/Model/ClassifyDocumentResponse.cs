/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the ClassifyDocument operation.
    /// </summary>
    public partial class ClassifyDocumentResponse : AmazonWebServiceResponse
    {
        private List<DocumentClass> _classes = new List<DocumentClass>();

        /// <summary>
        /// Gets and sets the property Classes. 
        /// <para>
        /// The classes used by the document being analyzed. These are used for multi-class trained
        /// models. Individual classes are mutually exclusive and each document is expected to
        /// have only a single class assigned to it. For example, an animal can be a dog or a
        /// cat, but not both at the same time. 
        /// </para>
        /// </summary>
        public List<DocumentClass> Classes
        {
            get { return this._classes; }
            set { this._classes = value; }
        }

        // Check to see if Classes property is set
        internal bool IsSetClasses()
        {
            return this._classes != null && this._classes.Count > 0; 
        }

    }
}