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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Configures the properties of a chart's axes that are used by small multiples panels.
    /// </summary>
    public partial class SmallMultiplesAxisProperties
    {
        private SmallMultiplesAxisPlacement _placement;
        private SmallMultiplesAxisScale _scale;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// Defines the placement of the axis. By default, axes are rendered <c>OUTSIDE</c> of
        /// the panels. Axes with <c>INDEPENDENT</c> scale are rendered <c>INSIDE</c> the panels.
        /// </para>
        /// </summary>
        public SmallMultiplesAxisPlacement Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// Determines whether scale of the axes are shared or independent. The default value
        /// is <c>SHARED</c>.
        /// </para>
        /// </summary>
        public SmallMultiplesAxisScale Scale
        {
            get { return this._scale; }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale != null;
        }

    }
}