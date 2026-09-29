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
    /// The contextual accent palette.
    /// </summary>
    public partial class ContextualAccentPalette
    {
        /// <summary>
        /// Gets and sets the property Automation.
        /// </summary>
        public Palette Automation { get; set; }

        /// <summary>
        /// Checks to see if the Automation property is set.
        /// </summary>
        internal bool IsSetAutomation() => this.Automation != null;

        /// <summary>
        /// Gets and sets the property Connection.
        /// </summary>
        public Palette Connection { get; set; }

        /// <summary>
        /// Checks to see if the Connection property is set.
        /// </summary>
        internal bool IsSetConnection() => this.Connection != null;

        /// <summary>
        /// Gets and sets the property Insight.
        /// </summary>
        public Palette Insight { get; set; }

        /// <summary>
        /// Checks to see if the Insight property is set.
        /// </summary>
        internal bool IsSetInsight() => this.Insight != null;

        /// <summary>
        /// Gets and sets the property Visualization.
        /// </summary>
        public Palette Visualization { get; set; }

        /// <summary>
        /// Checks to see if the Visualization property is set.
        /// </summary>
        internal bool IsSetVisualization() => this.Visualization != null;
    }
}
