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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The style configuration of the reference line.
    /// </summary>
    public partial class ReferenceLineStyleConfiguration
    {
        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The hex color of the reference line.
        /// </para>
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The pattern type of the line style. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SOLID</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DASHED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DOTTED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReferenceLinePatternType Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;
    }
}
