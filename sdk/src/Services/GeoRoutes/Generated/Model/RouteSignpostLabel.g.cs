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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Labels presented on the sign post.
    /// </summary>
    public partial class RouteSignpostLabel
    {
        /// <summary>
        /// Gets and sets the property RouteNumber. 
        /// <para>
        /// Route number of the road.
        /// </para>
        /// </summary>
        public RouteNumber RouteNumber { get; set; }

        /// <summary>
        /// Checks to see if the RouteNumber property is set.
        /// </summary>
        internal bool IsSetRouteNumber() => this.RouteNumber != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The Signpost text.
        /// </para>
        /// </summary>
        public LocalizedString Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
