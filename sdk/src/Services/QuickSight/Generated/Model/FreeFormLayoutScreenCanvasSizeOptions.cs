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
    /// The options that determine the sizing of the canvas used in a free-form layout.
    /// </summary>
    public partial class FreeFormLayoutScreenCanvasSizeOptions
    {
        private string _optimizedViewPortWidth;

        /// <summary>
        /// Gets and sets the property OptimizedViewPortWidth. 
        /// <para>
        /// The width that the view port will be optimized for when the layout renders.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OptimizedViewPortWidth
        {
            get { return this._optimizedViewPortWidth; }
            set { this._optimizedViewPortWidth = value; }
        }

        // Check to see if OptimizedViewPortWidth property is set
        internal bool IsSetOptimizedViewPortWidth()
        {
            return this._optimizedViewPortWidth != null;
        }

    }
}