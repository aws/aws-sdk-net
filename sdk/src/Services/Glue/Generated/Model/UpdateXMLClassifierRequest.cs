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
    /// Specifies an XML classifier to be updated.
    /// </summary>
    public partial class UpdateXMLClassifierRequest
    {
        private string _classification;
        private string _name;
        private string _rowTag;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// An identifier of the data format that the classifier matches.
        /// </para>
        /// </summary>
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RowTag. 
        /// <para>
        /// The XML tag designating the element that contains each record in an XML document being
        /// parsed. This cannot identify a self-closing element (closed by <c>/&gt;</c>). An empty
        /// row element that contains only attributes can be parsed as long as it ends with a
        /// closing tag (for example, <c>&lt;row item_a="A" item_b="B"&gt;&lt;/row&gt;</c> is
        /// okay, but <c>&lt;row item_a="A" item_b="B" /&gt;</c> is not).
        /// </para>
        /// </summary>
        public string RowTag
        {
            get { return this._rowTag; }
            set { this._rowTag = value; }
        }

        // Check to see if RowTag property is set
        internal bool IsSetRowTag()
        {
            return this._rowTag != null;
        }

    }
}