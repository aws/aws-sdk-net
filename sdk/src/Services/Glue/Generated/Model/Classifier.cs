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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Classifiers are written in Python and triggered during a crawl task. You can write
    /// your own classifiers to best categorize your data sources and specify the appropriate
    /// schemas to use for them. A classifier checks whether a given file is in a format it
    /// can handle, and if it is, the classifier creates a schema in the form of a <code>StructType</code>
    /// object that matches that data format.
    /// 
    ///  
    /// <para>
    /// A classifier can be a <code>grok</code> classifier, an XML classifier, or a JSON classifier,
    /// asspecified in one of the fields in the <code>Classifier</code> object.
    /// </para>
    /// </summary>
    public partial class Classifier
    {
        private GrokClassifier _grokClassifier;
        private JsonClassifier _jsonClassifier;
        private XMLClassifier _xmlClassifier;

        /// <summary>
        /// Gets and sets the property GrokClassifier. 
        /// <para>
        /// A <code>GrokClassifier</code> object.
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
        /// A <code>JsonClassifier</code> object.
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
        /// An <code>XMLClassifier</code> object.
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