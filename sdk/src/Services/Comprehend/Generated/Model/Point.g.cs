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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The X and Y coordinates of a point on a document page.
    /// 
    ///  
    /// <para>
    /// For additional information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/API_Point.html">Point</a>
    /// in the Amazon Textract API reference.
    /// </para>
    /// </summary>
    public partial class Point
    {
        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The value of the X coordinate for a point on a polygon
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
        /// The value of the Y coordinate for a point on a polygon
        /// </para>
        /// </summary>
        public float? Y { get; set; }

        /// <summary>
        /// Checks to see if the Y property is set.
        /// </summary>
        internal bool IsSetY() => this.Y.HasValue;
    }
}
