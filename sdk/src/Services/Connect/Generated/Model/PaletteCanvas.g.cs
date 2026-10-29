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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains color configuration for canvas elements in a workspace theme.
    /// </summary>
    public partial class PaletteCanvas
    {
        /// <summary>
        /// Gets and sets the property ActiveBackground. 
        /// <para>
        /// The background color for active elements.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string ActiveBackground { get; set; }

        /// <summary>
        /// Checks to see if the ActiveBackground property is set.
        /// </summary>
        internal bool IsSetActiveBackground() => this.ActiveBackground != null;

        /// <summary>
        /// Gets and sets the property ContainerBackground. 
        /// <para>
        /// The background color for container elements.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string ContainerBackground { get; set; }

        /// <summary>
        /// Checks to see if the ContainerBackground property is set.
        /// </summary>
        internal bool IsSetContainerBackground() => this.ContainerBackground != null;

        /// <summary>
        /// Gets and sets the property PageBackground. 
        /// <para>
        /// The background color for page elements.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string PageBackground { get; set; }

        /// <summary>
        /// Checks to see if the PageBackground property is set.
        /// </summary>
        internal bool IsSetPageBackground() => this.PageBackground != null;
    }
}
