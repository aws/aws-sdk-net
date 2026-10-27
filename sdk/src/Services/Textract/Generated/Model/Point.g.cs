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
    /// The X and Y coordinates of a point on a document page. The X and Y values that are
    /// returned are ratios of the overall document page size. For example, if the input document
    /// is 700 x 200 and the operation returns X=0.5 and Y=0.25, then the point is at the
    /// (350,50) pixel coordinate on the document page.
    /// 
    ///  
    /// <para>
    /// An array of <c>Point</c> objects, <c>Polygon</c>, is returned by <a>DetectDocumentText</a>.
    /// <c>Polygon</c> represents a fine-grained polygon around detected text. For more information,
    /// see Geometry in the Amazon Textract Developer Guide. 
    /// </para>
    /// </summary>
    public partial class Point
    {
        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The value of the X coordinate for a point on a <c>Polygon</c>.
        /// </para>
        /// </summary>
        public float? X { get; set; }

        /// <summary>
        /// Checks to see if the X property is set.
        /// </summary>
        internal bool IsSetX() => this.X.HasValue;

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The value of the Y coordinate for a point on a <c>Polygon</c>.
        /// </para>
        /// </summary>
        public float? Y { get; set; }

        /// <summary>
        /// Checks to see if the Y property is set.
        /// </summary>
        internal bool IsSetY() => this.Y.HasValue;
    }
}
