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
    /// The configuration of spacing (often a margin or padding).
    /// </summary>
    public partial class Spacing
    {
        /// <summary>
        /// Gets and sets the property Bottom. 
        /// <para>
        /// Define the bottom spacing.
        /// </para>
        /// </summary>
        public string Bottom { get; set; }

        /// <summary>
        /// Checks to see if the Bottom property is set.
        /// </summary>
        internal bool IsSetBottom() => this.Bottom != null;

        /// <summary>
        /// Gets and sets the property Left. 
        /// <para>
        /// Define the left spacing.
        /// </para>
        /// </summary>
        public string Left { get; set; }

        /// <summary>
        /// Checks to see if the Left property is set.
        /// </summary>
        internal bool IsSetLeft() => this.Left != null;

        /// <summary>
        /// Gets and sets the property Right. 
        /// <para>
        /// Define the right spacing.
        /// </para>
        /// </summary>
        public string Right { get; set; }

        /// <summary>
        /// Checks to see if the Right property is set.
        /// </summary>
        internal bool IsSetRight() => this.Right != null;

        /// <summary>
        /// Gets and sets the property Top. 
        /// <para>
        /// Define the top spacing.
        /// </para>
        /// </summary>
        public string Top { get; set; }

        /// <summary>
        /// Checks to see if the Top property is set.
        /// </summary>
        internal bool IsSetTop() => this.Top != null;
    }
}
