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
    /// Conditional formatting options of a <code>FilledMapVisual</code>.
    /// </summary>
    public partial class FilledMapConditionalFormattingOption
    {
        private FilledMapShapeConditionalFormatting _shape;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The conditional formatting that determines the shape of the filled map.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilledMapShapeConditionalFormatting Shape
        {
            get { return this._shape; }
            set { this._shape = value; }
        }

        // Check to see if Shape property is set
        internal bool IsSetShape()
        {
            return this._shape != null;
        }

    }
}