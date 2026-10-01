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
    /// The options that determine the sizing of the canvas used in a grid layout.
    /// </summary>
    public partial class GridLayoutScreenCanvasSizeOptions
    {
        /// <summary>
        /// Gets and sets the property OptimizedViewPortWidth. 
        /// <para>
        /// The width that the view port will be optimized for when the layout renders.
        /// </para>
        /// </summary>
        public string OptimizedViewPortWidth { get; set; }

        /// <summary>
        /// Checks to see if the OptimizedViewPortWidth property is set.
        /// </summary>
        internal bool IsSetOptimizedViewPortWidth() => this.OptimizedViewPortWidth != null;

        /// <summary>
        /// Gets and sets the property ResizeOption. 
        /// <para>
        /// This value determines the layout behavior when the viewport is resized.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FIXED</c>: A fixed width will be used when optimizing the layout. In the Quick
        /// Sight console, this option is called <c>Classic</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESPONSIVE</c>: The width of the canvas will be responsive and optimized to the
        /// view port. In the Quick Sight console, this option is called <c>Tiled</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResizeOption ResizeOption { get; set; }

        /// <summary>
        /// Checks to see if the ResizeOption property is set.
        /// </summary>
        internal bool IsSetResizeOption() => this.ResizeOption != null;
    }
}
