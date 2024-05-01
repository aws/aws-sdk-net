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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateClassifier operation.
    /// Creates a classifier in the user's account. This can be a <c>GrokClassifier</c>, an
    /// <c>XMLClassifier</c>, a <c>JsonClassifier</c>, or a <c>CsvClassifier</c>, depending
    /// on which field of the request is present.
    /// </summary>
    public partial class CreateClassifierRequest : AmazonGlueRequest
    {
        private CreateCsvClassifierRequest _csvClassifier;
        private CreateGrokClassifierRequest _grokClassifier;
        private CreateJsonClassifierRequest _jsonClassifier;
        private CreateXMLClassifierRequest _xmlClassifier;

        /// <summary>
        /// Gets and sets the property CsvClassifier. 
        /// <para>
        /// A <c>CsvClassifier</c> object specifying the classifier to create.
        /// </para>
        /// </summary>
        public CreateCsvClassifierRequest CsvClassifier
        {
            get { return this._csvClassifier; }
            set { this._csvClassifier = value; }
        }

        // Check to see if CsvClassifier property is set
        internal bool IsSetCsvClassifier()
        {
            return this._csvClassifier != null;
        }

        /// <summary>
        /// Gets and sets the property GrokClassifier. 
        /// <para>
        /// A <c>GrokClassifier</c> object specifying the classifier to create.
        /// </para>
        /// </summary>
        public CreateGrokClassifierRequest GrokClassifier
        {
            get { return this._grokClassifier; }
            set { this._grokClassifier = value; }
        }

        // Check to see if GrokClassifier property is set
        internal bool IsSetGrokClassifier()
        {
            return this._grokClassifier != null;
        }

        /// <summary>
        /// Gets and sets the property JsonClassifier. 
        /// <para>
        /// A <c>JsonClassifier</c> object specifying the classifier to create.
        /// </para>
        /// </summary>
        public CreateJsonClassifierRequest JsonClassifier
        {
            get { return this._jsonClassifier; }
            set { this._jsonClassifier = value; }
        }

        // Check to see if JsonClassifier property is set
        internal bool IsSetJsonClassifier()
        {
            return this._jsonClassifier != null;
        }

        /// <summary>
        /// Gets and sets the property XMLClassifier. 
        /// <para>
        /// An <c>XMLClassifier</c> object specifying the classifier to create.
        /// </para>
        /// </summary>
        public CreateXMLClassifierRequest XMLClassifier
        {
            get { return this._xmlClassifier; }
            set { this._xmlClassifier = value; }
        }

        // Check to see if XMLClassifier property is set
        internal bool IsSetXMLClassifier()
        {
            return this._xmlClassifier != null;
        }

    }
}