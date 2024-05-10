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
    /// Classifiers are triggered during a crawl task. A classifier checks whether a given
    /// file is in a format it can handle. If it is, the classifier creates a schema in the
    /// form of a <c>StructType</c> object that matches that data format.
    /// 
    ///  
    /// <para>
    /// You can use the standard classifiers that Glue provides, or you can write your own
    /// classifiers to best categorize your data sources and specify the appropriate schemas
    /// to use for them. A classifier can be a <c>grok</c> classifier, an <c>XML</c> classifier,
    /// a <c>JSON</c> classifier, or a custom <c>CSV</c> classifier, as specified in one of
    /// the fields in the <c>Classifier</c> object.
    /// </para>
    /// </summary>
    public partial class Classifier
    {
        private CsvClassifier _csvClassifier;
        private GrokClassifier _grokClassifier;
        private JsonClassifier _jsonClassifier;
        private XMLClassifier _xmlClassifier;

        /// <summary>
        /// Gets and sets the property CsvClassifier. 
        /// <para>
        /// A classifier for comma-separated values (CSV).
        /// </para>
        /// </summary>
        public CsvClassifier CsvClassifier
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
        /// A classifier that uses <c>grok</c>.
        /// </para>
        /// </summary>
        public GrokClassifier GrokClassifier
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
        /// A classifier for JSON content.
        /// </para>
        /// </summary>
        public JsonClassifier JsonClassifier
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
        /// A classifier for XML content.
        /// </para>
        /// </summary>
        public XMLClassifier XMLClassifier
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