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
    /// Container for the parameters to the UpdateClassifier operation. Modifies an existing
    /// classifier (a <c>GrokClassifier</c>, an <c>XMLClassifier</c>, a <c>JsonClassifier</c>,
    /// or a <c>CsvClassifier</c>, depending on which field is present).
    /// </summary>
    public partial class UpdateClassifierRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CsvClassifier. 
        /// <para>
        /// A <c>CsvClassifier</c> object with updated fields.
        /// </para>
        /// </summary>
        public UpdateCsvClassifierRequest CsvClassifier { get; set; }

        /// <summary>
        /// Checks to see if the CsvClassifier property is set.
        /// </summary>
        internal bool IsSetCsvClassifier() => this.CsvClassifier != null;

        /// <summary>
        /// Gets and sets the property GrokClassifier. 
        /// <para>
        /// A <c>GrokClassifier</c> object with updated fields.
        /// </para>
        /// </summary>
        public UpdateGrokClassifierRequest GrokClassifier { get; set; }

        /// <summary>
        /// Checks to see if the GrokClassifier property is set.
        /// </summary>
        internal bool IsSetGrokClassifier() => this.GrokClassifier != null;

        /// <summary>
        /// Gets and sets the property JsonClassifier. 
        /// <para>
        /// A <c>JsonClassifier</c> object with updated fields.
        /// </para>
        /// </summary>
        public UpdateJsonClassifierRequest JsonClassifier { get; set; }

        /// <summary>
        /// Checks to see if the JsonClassifier property is set.
        /// </summary>
        internal bool IsSetJsonClassifier() => this.JsonClassifier != null;

        /// <summary>
        /// Gets and sets the property XMLClassifier. 
        /// <para>
        /// An <c>XMLClassifier</c> object with updated fields.
        /// </para>
        /// </summary>
        public UpdateXMLClassifierRequest XMLClassifier { get; set; }

        /// <summary>
        /// Checks to see if the XMLClassifier property is set.
        /// </summary>
        internal bool IsSetXMLClassifier() => this.XMLClassifier != null;
    }
}
