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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Controls how Amazon Textract extracts content from a document, including whether bounding
    /// boxes are returned, the granularity of extraction, and the output format.
    /// </summary>
    public partial class ExtractionConfiguration
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Controls whether bounding box geometry is included in the extraction output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BoundingBoxConfiguration BoundingBox { get; set; }

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null;

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// Controls the granularity levels at which content is extracted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtractionGranularity Granularity { get; set; }

        /// <summary>
        /// Checks to see if the Granularity property is set.
        /// </summary>
        internal bool IsSetGranularity() => this.Granularity != null;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// Controls the format of the extraction output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;
    }
}
