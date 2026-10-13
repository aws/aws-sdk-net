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
    /// A classifier for <c>XML</c> content.
    /// </summary>
    public partial class XMLClassifier
    {
        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// An identifier of the data format that the classifier matches.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Checks to see if the Classification property is set.
        /// </summary>
        internal bool IsSetClassification() => this.Classification != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that this classifier was registered.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time that this classifier was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RowTag. 
        /// <para>
        /// The XML tag designating the element that contains each record in an XML document being
        /// parsed. This can't identify a self-closing element (closed by <c>/></c>). An empty
        /// row element that contains only attributes can be parsed as long as it ends with a
        /// closing tag (for example, <c>&lt;row item_a="A" item_b="B"&gt;&lt;/row&gt;</c> is
        /// okay, but <c>&lt;row item_a="A" item_b="B" /&gt;</c> is not).
        /// </para>
        /// </summary>
        public string RowTag { get; set; }

        /// <summary>
        /// Checks to see if the RowTag property is set.
        /// </summary>
        internal bool IsSetRowTag() => this.RowTag != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of this classifier.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
