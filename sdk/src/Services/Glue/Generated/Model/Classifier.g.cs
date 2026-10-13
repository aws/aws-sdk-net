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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CsvClassifier. 
        /// <para>
        /// A classifier for comma-separated values (CSV).
        /// </para>
        /// </summary>
        public CsvClassifier CsvClassifier { get; set; }

        /// <summary>
        /// Checks to see if the CsvClassifier property is set.
        /// </summary>
        internal bool IsSetCsvClassifier() => this.CsvClassifier != null;

        /// <summary>
        /// Gets and sets the property GrokClassifier. 
        /// <para>
        /// A classifier that uses <c>grok</c>.
        /// </para>
        /// </summary>
        public GrokClassifier GrokClassifier { get; set; }

        /// <summary>
        /// Checks to see if the GrokClassifier property is set.
        /// </summary>
        internal bool IsSetGrokClassifier() => this.GrokClassifier != null;

        /// <summary>
        /// Gets and sets the property JsonClassifier. 
        /// <para>
        /// A classifier for JSON content.
        /// </para>
        /// </summary>
        public JsonClassifier JsonClassifier { get; set; }

        /// <summary>
        /// Checks to see if the JsonClassifier property is set.
        /// </summary>
        internal bool IsSetJsonClassifier() => this.JsonClassifier != null;

        /// <summary>
        /// Gets and sets the property XMLClassifier. 
        /// <para>
        /// A classifier for XML content.
        /// </para>
        /// </summary>
        public XMLClassifier XMLClassifier { get; set; }

        /// <summary>
        /// Checks to see if the XMLClassifier property is set.
        /// </summary>
        internal bool IsSetXMLClassifier() => this.XMLClassifier != null;
    }
}
