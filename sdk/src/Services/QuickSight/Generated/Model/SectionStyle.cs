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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The options that style a section.
    /// </summary>
    public partial class SectionStyle
    {
        private string _height;
        private Spacing _padding;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of a section.
        /// </para>
        ///  
        /// <para>
        /// Heights can only be defined for header and footer sections. The default height margin
        /// is 0.5 inches. 
        /// </para>
        /// </summary>
        public string Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height != null;
        }

        /// <summary>
        /// Gets and sets the property Padding. 
        /// <para>
        /// The spacing between section content and its top, bottom, left, and right edges.
        /// </para>
        ///  
        /// <para>
        /// There is no padding by default.
        /// </para>
        /// </summary>
        public Spacing Padding
        {
            get { return this._padding; }
            set { this._padding = value; }
        }

        // Check to see if Padding property is set
        internal bool IsSetPadding()
        {
            return this._padding != null;
        }

    }
}